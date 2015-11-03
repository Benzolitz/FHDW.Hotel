module Data {
    export class AdminRequest extends BaseRequest {
        constructor() {
            super("Admin");
        }

        public GetAdminData(p_username: string, p_password: string): JQueryPromise<Models.Admin> {
            return this.Get({"Username" : p_username, "Password" : p_password});
        }
    }
}