if not exists (Select * From sys.databases Where name ='CinemaTicket')
Create database CinemaTicket
go
use CinemaTicket
go



if not exists(Select * From INFORMATION_SCHEMA.TABLES WHERE table_name='Genders')
Create Table Genders
(
    GenderId int IDENTITY primary key,
    GenderName nvarchar(10)
)
Go


if not exists(Select * From INFORMATION_SCHEMA.TABLES WHERE table_name='Genres')
Create Table Genres
(
    GenreId int IDENTITY primary key,
    GenreName nvarchar(10)
)
Go



if not exists(Select * From INFORMATION_SCHEMA.TABLES WHERE table_name='Emplooyes')
Create Table Emplooyes
(

    EmplooyeId int IDENTITY primary key,
	UserName nvarchar(100),
	[Password] nvarchar(100),
	EmplooyeTC nvarchar(11),
	EmplooyeName nvarchar(max),
	EmplooyeSurname nvarchar(max),
	DateOfBirth nvarchar(max),
	GenderId nvarchar(10),
	StartDate nvarchar(max),
	FinishDate nvarchar(max),

	
)
Go

if not exists(Select * From INFORMATION_SCHEMA.TABLES WHERE table_name='Movies')
Create Table Movies
(
    MovieId int IDENTITY primary key,
	MovieName nvarchar(max),
	DirectorName nvarchar(max),
	GenreId int,
	VisionStartD nvarchar(max),
	VisionFinishD nvarchar(max),

	constraint FK_Movies_GenderId  foreign key (GenreId) references Genres(GenreId)

)
Go

if not exists(Select * From INFORMATION_SCHEMA.TABLES WHERE table_name='Customers')
Create Table Customers
(
    CustomerId int IDENTITY primary key,	
	UserName nvarchar(10),
	[Password] nvarchar(100),
	CustomerName nvarchar(100),
	CustomerSurname nvarchar(100),
	Phone nvarchar(11),
	[Address] nvarchar(max)
    

	
)
Go

if not exists(Select * From INFORMATION_SCHEMA.TABLES WHERE table_name='TicketSales')
Create Table TicketSales
(
    SaleId int IDENTITY primary key,	
	CustomerPhone nvarchar(100),
	TotalTicket int,
    MovieId nvarchar(100),
    DateOfPurchase nvarchar(max),

	
)
Go




