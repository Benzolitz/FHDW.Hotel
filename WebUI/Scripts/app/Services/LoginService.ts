module Services {
    export class LoginService {

        //#region Observable
        public Username = ko.observable("");
        public Password = ko.observable("");
        //#endregion

        //#region Member
        private _cookieService: CookieService;
        private _adminRequest : Data.AdminRequest;
        //#endregion

        constructor() {
            this._cookieService = new CookieService();
            this._adminRequest = new Data.AdminRequest();

            this.checkCookie();
        }

        private checkCookie(): void {
            var cookie = this._cookieService.GetCookie("FHDW.Hotel.Admin");
            if (cookie) {
                window.location.href = "Administration.html";
            }
        }

        public Login(): void {
            // TODO: Check Logindata!
            
            // createCookie is a global function created in CookieService.js.
            // TypeScript can't find the function, but it works nontheless.
            this._cookieService.CreateCookie(this.Username());

            window.location.href = "Administration.html";
        }
    }
}