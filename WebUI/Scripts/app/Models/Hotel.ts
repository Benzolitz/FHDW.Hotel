module Models {
    export class Hotel {

        public ID: number;
        public Address: Address;
        public Name: string;

        public Rooms = ko.observableArray(new Array<Room>());

    }
}