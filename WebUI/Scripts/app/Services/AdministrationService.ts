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
            (<any>$("#selRoomCategory")).select2();

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
            });
        }


        //#region RoomHelper
        public GetRoomTypeName(p_roomType: Enums.RoomType): string {
            return Enums.RoomType[p_roomType];
        }

        public GetRoomCategoryName(p_roomType: Enums.RoomCategory): string {
            return Enums.RoomCategory[p_roomType];
        }

        public AddRoom(p_hotelId: number): void {
            var currentHotel = $.grep(this.Hotels(), e => e.ID === p_hotelId)[0];

            var newRoom = new Models.Room();
            newRoom.Hotel = currentHotel;

            this.Room(newRoom);
            (<any>$("#modalRoom")).modal("show"); 
        }

        public EditRoom(p_room: Models.Room): void {

        }

        public DeleteRoom(p_room: Models.Room): void {

        }
        //#endregion
    }
}