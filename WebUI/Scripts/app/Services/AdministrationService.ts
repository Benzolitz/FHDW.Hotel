module Services {
    export class AdministrationService {

        //#region Observable
        public Username = ko.observable("");
        public Hotels = ko.observableArray(new Array<Models.Hotel>());
        //#endregion

        //#region Member
        private _cookieService: CookieService;
        private _hotelRequest: Data.HotelRequest;
        //#endregion

        constructor() {
            this._cookieService = new CookieService();
            this.checkCookie();

            this._hotelRequest = new Data.HotelRequest();
            this.getHotelData();
        }

        private checkCookie(): void {
            var cookie = this._cookieService.GetCookie("FHDW.Hotel.Admin");
            if (!cookie) {
                window.location.href = "Login.html";
            } else {
                this.Username(this._cookieService.ReadCookieKey(cookie, "Username"));
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
    }
}