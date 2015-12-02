module Data {
    export class RoomRequest extends BaseRequest {
        constructor() {
            super("Room");
        }

        public GetCollectionByHotel(p_currentHotel: Models.Hotel): JQueryPromise<any> {
            return this.Get({ "Hotel": p_currentHotel });
        }
    }
}