module Services {
    export class AdministrationService {
        
        //#region Observable
        public Admin = ko.observable(new Models.Admin());
        public Hotels = ko.observableArray(new Array<Models.Hotel>());
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
                p_currentHotel.Rooms = ko.observableArray(new Array<Models.Room>());
                p_currentHotel.Rooms(p_rooms);
                self.Hotels.push(p_currentHotel);
            });
        }


        //#region GUI-Methods
        public NextHotel(): void {
            $("#sliHotels > div:first")
                .fadeOut(100)
                .next()
                .fadeIn(1000)
                .end()
                .appendTo("#sliHotels");
        }
        public PreviousHotel(): void {
            // TODO: Add previous logic
        }

        public GetRoomTypeName(p_roomType: Enums.RoomType): string {
            return Enums.RoomType[p_roomType];
        }

        public GetRoomCategoryName(p_roomType: Enums.RoomCategory): string {
            return Enums.RoomCategory[p_roomType];
        }

        public AddRoom(p_hotel: Models.Hotel): void {
            var newRoom = new Models.Room();
            newRoom.Hotel = p_hotel;


            localStorage.setItem("RoomModal", JSON.stringify(newRoom));
            var roomModal = window.open("RoomModal.html", "Zimmerverwaltung", "toolbar=0,status=0,menubar=0,fullscreen=no,width=520,height=400");

            roomModal.onunload = () => {
                this.SaveRoom();
            }
        }

        public EditRoom(p_room: Models.Room, p_hotelId: number): void {
            p_room.Hotel = new Models.Hotel();
            p_room.Hotel.ID = p_hotelId;

            localStorage.setItem("RoomModal", JSON.stringify(p_room));
            var roomModal = window.open("RoomModal.html", "Zimmerverwaltung", "toolbar=0,status=0,menubar=0,fullscreen=no,width=520,height=400");

            roomModal.onunload = () => {
                this.SaveRoom();
            }
        }

        public SaveRoom(): void {
            var room = localStorage.getItem("RoomModal");
            if (room) {
                console.log(JSON.parse(room));
                this._roomRequest.Put(JSON.parse(room)).then((p_room: Models.Room) => {
                    
                });
            }
            localStorage.setItem("RoomModal", "");
        }

        public DeleteRoom(p_room: Models.Room, p_hotelId: number): void {
            if (confirm("Sind Sie sicher, dass Sie den Raum " + p_room.RoomNumber + " löschen möchten?")) {
                this._roomRequest.Delete(p_room).then((p_room: Models.Room) => {
                    alert("Der Raum wurde erfolgreich gelöscht!");
                });
            }
        }
        //#endregion
    }
}