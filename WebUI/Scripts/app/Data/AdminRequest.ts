module Data {
    export class AdminRequest extends BaseRequest {
        constructor() {
            super("Admin");
        }

        public GetByUsername(p_username: string): JQueryPromise<Models.Admin> {
            return this.Get({"Username" : p_username});
        }
    }
}