module Services {
    export class RoomService {
        
        //#region Member
        private _roomRequest: Data.RoomRequest;
        //#endregion

        constructor() {
            this._roomRequest = new Data.RoomRequest();
        }

        public AddRoom(p_room: Models.Room): void {
            this._roomRequest.Post(p_room);
        }

        public UpdateRoom(p_room: Models.Room): void {
            this._roomRequest.Put(p_room);
        }

        public DeleteRoom(p_room: Models.Room): void {
            this._roomRequest.Delete(p_room);
        }

    }
}