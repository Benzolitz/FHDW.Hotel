module Services {
    export class AdministrationService {

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
            }
        }

        public Logout(): void {
            this._cookieService.DeleteCookie();
            window.location.href = "Login.html";
        }
    }
}