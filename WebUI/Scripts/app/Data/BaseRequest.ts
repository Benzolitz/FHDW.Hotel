module Data {
    export class BaseRequest {
        private _controller: string;

        constructor(p_controller: string) {
            this._controller = p_controller;
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
            var options = this.RequestOptions(<any>RequestType.Get);
            options.data = $.param(p_params || {});

            return this.execute(options);
        }

        public GetById<T>(p_id: number): JQueryPromise<T> {
            var options = this.RequestOptions(<any>RequestType.Get);
            options.data = $.param({ "Id": p_id });

            return this.execute(options);
        }

        public Post<T>(p_data: Object): JQueryPromise<T> {
            var options = this.RequestOptions(<any>RequestType.Post);
            options.data = JSON.stringify(ko.toJS(p_data) || {});

            return this.execute(options);
        }

        public Put<T>(p_data: Object): JQueryPromise<T> {
            var options = this.RequestOptions(<any>RequestType.Put);
            options.data = JSON.stringify(ko.toJS(p_data) || {});

            return this.execute(options);
        }

        public Delete<T>(p_params: Object): JQueryPromise<T> {
            var options = this.RequestOptions(<any>RequestType.Delete);
            options.data = $.param(p_params);
            options.url = options.url + "?" + options.data;

            return this.execute(options);
        }

        public DeleteById<T>(p_id: number): JQueryPromise<T> {
            var options = this.RequestOptions(<any>RequestType.Delete);
            options.data = $.param({ "Id": p_id.toString() });
            options.url = options.url + "?" + options.data;

            return this.execute(options);
        }

        private execute(p_options: JQueryAjaxSettings): JQueryPromise<any> {
            var d = $.Deferred();
            $.ajax(p_options)
                .then((p_data) => {
                    d.resolve(p_data);
                }).fail((p_jqXhr: JQueryXHR, p_textStatus: string, p_errorThrow: string) => {
                    d.reject(p_jqXhr, p_textStatus, p_errorThrow);
                });

            return d.promise();
        }
    }

    enum RequestType {
        Get = <any>"GET",
        Put = <any>"PUT",
        Post = <any>"POST",
        Delete = <any>"DELETE"
    }
} 