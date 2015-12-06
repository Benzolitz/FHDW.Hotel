module Services {
    export class RoomModalService {

        // region Observable
        public Room = ko.observable(new Models.Room());
        public HotelName: KnockoutComputed<string>;
        public RoomNumber = ko.observable("");

        public RoomType = ko.observable<Enums.RoomType>();
        public RoomCategory = ko.observable<Enums.RoomCategory>();
        // endregion

        constructor() {
            var roomString = localStorage.getItem("RoomModal");
            var room = JSON.parse(roomString);

            if (room) {
                this.Room(room);

                this.HotelName = ko.pureComputed(() => {
                    return "Hotel " + this.Room().Hotel.Name + " (" + this.Room().Hotel.Address.City + ")";
                }, this);
                

            } else {
                alert("Raumobjekt im localstorage erwartet!");
                window.close();
            }
        }

        public Save(): void {
            this.Room().RoomNumber = this.RoomNumber();
            this.Room().Type = this.RoomType();
            this.Room().Category = this.RoomCategory();

            localStorage.setItem("RoomModal", JSON.stringify(this.Room()));
            window.close();
        }

        public Close(): void {
            localStorage.setItem("RoomModal", "");
            window.close();
        }
    }
}