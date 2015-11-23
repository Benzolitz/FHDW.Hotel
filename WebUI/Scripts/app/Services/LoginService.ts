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
            this._adminRequest.GetAdminData(this.Username(), this.Password()).then((p_admin : Models.Admin) => {
                if (p_admin) {
                    this._cookieService.CreateCookie(p_admin);
                    window.location.href = "Administration.html";
                } else {
                    $("#divLoginNotifier").val("Benutzername, oder Passwort falsch!");
                }
            });
        }
    }
}