module Services {
    export class AdministrationService {
        
        //#region Observable
        public Admin = ko.observable(new Models.Admin());
        public Hotels = ko.observableArray(new Array<Models.Hotel>());
        public Room = ko.observable(new Models.Room());

        public RoomManagementHotelName: KnockoutComputed<string>;
        //#endregion

        //#region Member
        private _cookieService: CookieService;

        private _hotelRequest: Data.HotelRequest;
        private _roomRequest: Data.RoomRequest;
        //#endregion

        constructor() {
            this._cookieService = new CookieService();
            this.checkCookie();

            this._roomRequest = new Data.RoomRequest();
            this._hotelRequest = new Data.HotelRequest();
            this.getHotelData();

            this.RoomManagementHotelName = ko.pureComputed(() => {
                return this.Room().Hotel.Name + " TEST ";
            }, this);
        }

        private checkCookie(): void {
            var cookie = this._cookieService.GetCookie("FHDW.Hotel.Admin");
            if (!cookie) {
                window.location.href = "Login.html";
            } else {
                var admin = JSON.parse(cookie);

                if (!admin) {
                    window.location.href = "Login.html";
                } else {
                    this.Admin(admin);
                }
            }
        }

        public Logout(): void {
            this._cookieService.DeleteCookie();
            window.location.href = "Login.html";
        }

        private getHotelData(): void {
            this._hotelRequest.Get().then((p_hotels: Array<Models.Hotel>) => {
                // Request every room for each hotel
                for (var i = 0; i < p_hotels.length; i++) {
                    var currentHotel: Models.Hotel = p_hotels[i];
                    this.getRoomDataForHotel(currentHotel);
                }

                $("#sliHotels > div:gt(0)").hide();
                $("#sliHotels div:first-child").show();
                $("#sliHotels div fieldset div").show(); // Workaround: div with the table would be set to display:none for no reason
            });
        }

        private getRoomDataForHotel(p_currentHotel: Models.Hotel): void {
            var self = this;
            this._roomRequest.GetCollectionByHotel(p_currentHotel).then((p_rooms: Array<Models.Room>) => {
                //// add Rooms to the Hotel
                p_currentHotel.Rooms = ko.observableArray(new Array<Models.Room>());
                p_currentHotel.Rooms(p_rooms);
                self.Hotels.push(p_currentHotel);
            });
        }


        //#region RoomHelper
        public GetRoomTypeName(p_roomType: Enums.RoomType): string {
            return Enums.RoomType[p_roomType];
        }

        public GetRoomCategoryName(p_roomType: Enums.RoomCategory): string {
            return Enums.RoomCategory[p_roomType];
        }

        public AddRoom(p_hotel: Models.Hotel): void {
            var newRoom = new Models.Room();
            newRoom.Hotel = p_hotel;

            this.Room = ko.observable(newRoom);

            ko.renderTemplate("", ModalRoomService, {
                afterRender() {
                    console.log("Render Test!");
                }
            });


            // (<any>$("#modalRoom")).modal("show"); 
        }

        public EditRoom(p_room: Models.Room, p_hotelId: number): void {
            this.Room = ko.observable(p_room);
            (<any>$("#modalRoom")).modal("show"); 
        }

        public SaveRoom(): void {
            console.log(this.Room());
        }

        public DeleteRoom(p_room: Models.Room, p_hotelId: number): void {
            if (confirm("Sind Sie sicher, dass Sie den Raum " + p_room.RoomNumber + " löschen möchten?")) {
                this._roomRequest.Delete(p_room).then((p_room: Models.Room) => {
                    alert("Der Raum wurde erfolgreich gelöscht!");
                });
            } 
        }
        //#endregion

        public NextHotel(): void {
            $("#sliHotels > div:first")
                .fadeOut(100)
                .next()
                .fadeIn(1000)
                .end()
                .appendTo("#sliHotels");
        }

        public ModalTest(): void {
            console.log("Hallo Modal");
        }
    }
}