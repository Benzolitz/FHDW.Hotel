module Services {
    export class AdministrationService {

        //#region Observable
        public Username = ko.observable("");
        //#endregion

        //#region Member
        private _cookieService: CookieService;
        //#endregion

        constructor() {
            this._cookieService = new CookieService();
            this.checkCookie();
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
    }
}