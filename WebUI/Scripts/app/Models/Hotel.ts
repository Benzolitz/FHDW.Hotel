module Models {
    export class Hotel {

        public ID: number;
        public Name: string;
        public Adress: Address;

        public Rooms: Array<Room>;

    }
}