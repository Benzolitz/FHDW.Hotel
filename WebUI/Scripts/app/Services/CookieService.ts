module Services {
    export class CookieService {

        constructor() { }

        /// <summary>
        /// 
        /// </summary>
        public GetCookie(p_cookieName: string): string {
            var name = p_cookieName + "=";
            var cookieArray = document.cookie.split(";");
            for (var i = 0; i < cookieArray.length; i++) {
                var c = cookieArray[i];
                while (c.charAt(0) === " ") c = c.substring(1);
                if (c.indexOf(name) === 0) return c.substring(name.length, c.length);
            }
            return "";
        }
        
        /// <summary>
        /// 
        /// </summary>
        public CreateCookie(p_admin: Models.Admin): void {
            var d = new Date();
            d.setTime(d.getTime() + (7200000)); // Keep Admin login for two hours.
            
            document.cookie = "FHDW.Hotel.Admin=" + JSON.stringify(p_admin) + ";expires=" + d.toUTCString();
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeleteCookie(): void {
            document.cookie = "FHDW.Hotel.Admin=; expires=Thu, 01 Jan 1970 00:00:00 UTC";
        }
    }
}