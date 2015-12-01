module Services {
    export class AdministrationService {
        
        //#region Observable
        public Admin = ko.observable(new Models.Admin());
        public Hotels = ko.observableArray(new Array<Models.Hotel>());
        public Room = ko.observable(new Models.Room());
        //#endregion

        //#region Member
        private _cookieService: CookieService;
        private _roomService: RoomService;

        private _hotelRequest: Data.HotelRequest;
        //#endregion

        constructor() {
            this._cookieService = new CookieService();
            this.checkCookie();

            this._roomService = new RoomService();

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
                this.Hotels(p_hotels);

                $("#sliHotels div").hide();
                $("#sliHotels div:first-child").show();
                $("#sliHotels div fieldset div").show(); // Workaround: div with the table would be set to display:none for no reason
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

            this.Room(newRoom);
            (<any>$("#modalRoom")).modal("show"); 
        }

        public EditRoom(p_room: Models.Room): void {

        }

        public DeleteRoom(p_room: Models.Room): void {

        }
        //#endregion

        public NextHotel(): void {
            $(".slideshow div:first-child").fadeOut(500).appendTo(".slideshow");
            $(".slideshow div:nth-child(2)").fadeIn(1000);
        }
    }
}