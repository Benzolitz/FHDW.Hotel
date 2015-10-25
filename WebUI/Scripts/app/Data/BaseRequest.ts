module Data {
    export class BaseRequest {
        
        //#region Member
        private _controller: string;
        //#endregion

        constructor(p_controller: string) {
            this._controller = p_controller + "/";
        }

        public RequestOptions(p_verb: string, p_action?: string): JQueryAjaxSettings {
            var self = this;
            return {
                url: "http://localhost:35588/api/" + self._controller,
                cache: false,
                type: p_verb,
                contentType: "application/json; charset=utf-8",
                async: true
            }
        }

        public Get<T>(p_params?: Object): JQueryPromise<T> {
            var options = this.RequestOptions(<any>Verbs.Get);
            options.data = $.param(p_params || {});

            return this.execute(options);
        }

        public GetById<T>(p_id: number): JQueryPromise<T> {
            var options = this.RequestOptions(<any>Verbs.Get);
            options.data = $.param({ "Id": p_id });

            return this.execute(options);
        }

        public Post<T>(p_data: Object): JQueryPromise<T> {
            var options = this.RequestOptions(<any>Verbs.Post);
            options.data = JSON.stringify(ko.toJS(p_data) || {});

            return this.execute(options);
        }

        public Put<T>(p_data: Object): JQueryPromise<T> {
            var options = this.RequestOptions(<any>Verbs.Put);
            options.data = JSON.stringify(ko.toJS(p_data) || {});

            return this.execute(options);
        }

        public Delete<T>(p_params: Object): JQueryPromise<T> {
            var options = this.RequestOptions(<any>Verbs.Delete);
            options.data = $.param(p_params);
            options.url = options.url + "?" + options.data;

            return this.execute(options);
        }

        public DeleteById<T>(p_id: number): JQueryPromise<T> {
            var options = this.RequestOptions(<any>Verbs.Delete);
            options.data = $.param({ "Id": p_id.toString() });
            options.url = options.url + "?" + options.data;

            return this.execute(options);
        }

        private execute(p_options: JQueryAjaxSettings): JQueryPromise<any> {
            var d = $.Deferred();

            $.ajax(p_options)
                .then((p_data) => {
                    d.resolve(p_data.Result.Value);
                }).fail((p_jqXhr: JQueryXHR, p_textStatus: string, p_errorThrow: string) => {
                    var serverErrorMessage = this.deserializeXhr(p_jqXhr);

                    alert(serverErrorMessage);

                    d.reject(p_jqXhr, p_textStatus, p_errorThrow);
                });

            return d.promise();
        }

        private deserializeXhr(p_xhr: JQueryXHR): any {
            if (!p_xhr) return null;

            try {
                var retVal: any = $.parseJSON(p_xhr.responseText);
                if (retVal && retVal.Notification) {

                    if (p_xhr.status >= 400 && p_xhr.status < 600) {
                        retVal.Notification.IsError = true;
                    }

                    return retVal.Notification;
                }
                else {
                    return null;
                }
            } catch (e) {
                return null;
            }
        }
    }

    enum Verbs {
        Get     = <any>"GET",
        Put     = <any>"PUT",
        Post    = <any>"POST",
        Delete  = <any>"DELETE"
    }
} 