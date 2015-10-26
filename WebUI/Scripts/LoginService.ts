module Main {
    export class LoginService {

        //#region Observable
        public Username = ko.observable("");
        public Password = ko.observable("");
        //#endregion

        constructor() {
            
        }

        public Login(): void {
            // TODO: Check Logindata!
            
            // createCookie is a global function created in CookieService.js.
            // TypeScript can't find the function, but it works nontheless.
            //createCookie(this.Username());

            window.location.href = "Administration.html";
        }
    }
}