CREATE DATABASE IF NOT EXISTS fhdwhotel;

USE fhdwhotel;

CREATE TABLE IF NOT EXISTS address (
	ID INT NOT NULL, 
	Street VARCHAR(35), 
	PostalCode VARCHAR(10), 
	City VARCHAR(20), 
	PRIMARY KEY(ID)
); 

CREATE TABLE IF NOT EXISTS hotel(
	ID INT NOT NULL, 
	Name VARCHAR(20), 
	AddressID INT NOT NULL, 
	PRIMARY KEY(ID), 
	FOREIGN KEY(AddressID) REFERENCES address(ID)
);

CREATE TABLE IF NOT EXISTS guest(
	ID INT NOT NULL, 
	Firstname VARCHAR(20) NOT NULL, 
	Nachname VARCHAR(20) NOT NULL, 
	Emailaddress VARCHAR(50) UNIQUE NOT NULL, 
	Birthplace VARCHAR(20), 
	Birthday DateTime, 
	Password VARCHAR(35) NOT NULL, 
	Phonenumber VARCHAR(30), 
	ContactAddressID INT NOT NULL, 
	BillingAddressID INT, 
	PRIMARY KEY(ID), 
	FOREIGN KEY(ContactAddressID) REFERENCES address(ID), 
	FOREIGN KEY(BillingAddressID) REFERENCES address(ID) 
);

CREATE TABLE IF NOT EXISTS booking(
	ID INT NOT NULL, 
	Arrival DateTime, 
	Depature DateTime, 
	HotelID INT NOT NULL, 
	GuestID INT NOT NULL, 
	PRIMARY KEY(ID),
	FOREIGN KEY(HotelID) REFERENCES hotel(ID), 
	FOREIGN KEY(GuestID) REFERENCES guest(ID)
);

CREATE TABLE IF NOT EXISTS roomcategory(
	ID INT NOT NULL, 
	Category VARCHAR(10), 
	PRIMARY KEY(ID)
);

CREATE TABLE IF NOT EXISTS roomtype(
	ID INT NOT NULL, 
	Type VARCHAR(10), 
	PersonCount INT(2), 
	PRIMARY KEY(ID)
);

CREATE TABLE IF NOT EXISTS room(
	ID INT NOT NULL, 
	Price Decimal(5,2), 
	HotelID INT NOT NULL, 
	TypeID INT NOT NULL,  
	CategoryID INT NOT NULL, 
	PRIMARY KEY(ID), 
	FOREIGN KEY(HotelID) REFERENCES hotel(ID), 
	FOREIGN KEY(TypeID) REFERENCES roomtype(ID),
	FOREIGN KEY(CategoryID) REFERENCES roomcategory(ID) 
);

CREATE TABLE IF NOT EXISTS bookingroom(
	ID INT NOT NULL,
	BookingID INT NOT NULL,
	RoomID INT NOT NULL,
	PRIMARY KEY(ID),
	FOREIGN KEY(BookingID) REFERENCES booking(ID), 
	FOREIGN KEY(RoomID) REFERENCES room(ID)
); 
 
CREATE TABLE IF NOT EXISTS admin(
	ID INT NOT NULL,
	Username VARCHAR(25),
	Passwort VARCHAR(25),
    PRIMARY KEY(ID)
);