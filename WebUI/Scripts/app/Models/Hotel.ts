module Models {
    export class Hotel {

        public ID: number;
        public Name: string;
        public Adress: string;
        public Postalcode: string;
        public City: string;

        public Rooms: Array<Room>;

    }
}