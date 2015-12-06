module Models {
    export class Room {
        public ID: number;
        public RoomNumber: string;
        public Category: Enums.RoomCategory;
        public Type: Enums.RoomType;
        public PersonCount: number;
        public Price: number;
        public Hotel: Hotel;
    }
}