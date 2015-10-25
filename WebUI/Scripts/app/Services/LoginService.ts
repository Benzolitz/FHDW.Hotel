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
            this._adminRequest.GetByUsername(this.Username()).then((p_admin : Models.Admin) => {
                // Sha256 is not recognized by TypeScript, but is aviable nonetheless.
                // var hash = Sha256.hash(this.Password());

                if ("" === p_admin.PasswordHash) {
                    this._cookieService.CreateCookie(p_admin.ID, p_admin.Username, p_admin.LoginGuid);
                    window.location.href = "Administration.html";
                } else {
                    $("#divNotifier").val("Benutzername, oder Passwort falsch!");
                }
            });
        }
    }
}