CREATE DATABASE FunHall
USE FunHall

create table Bookings
(
	BookingId nvarchar(100) PRIMARY KEY NOT NULL,
	Name nvarchar(100) NOT NULL,
	CusTel nvarchar(20) NOT NULL,
	CusTelAlt nvarchar(20),
	CusMail nvarchar(100),
	Date nvarchar(100),
	TotalPrice float,
	CusComment text,
	IntComment text	
);

create table Activities
(
	ActivityId INT PRIMARY KEY ,
	Name nvarchar(20) NOT NULL,
	Price float
);


create table BookedActivities
(
	Id INT PRIMARY KEY ,
	BookingId nvarchar(20) NOT NULL,
	ActivityId INT NOT NULL,
	Timedesc text,
	StartTime datetime,
	Endtime datetime,
	productAmount int
);

create table Guests
(
	GuestId INT PRIMARY KEY ,
	Name nvarchar(20) NOT NULL,
	Email nvarchar(100) NOT NULL,
	AgreeTerms bit,
	Subscription bit,
	ChekedInTime datetime
);



SELECT * FROM Bookings