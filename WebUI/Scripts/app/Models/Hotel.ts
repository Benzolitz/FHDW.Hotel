module Models {
    export class Hotel {

        public ID: number;
        public Address: Address;
        public Name: string;

        public Rooms: Array<Room>;

    }
}