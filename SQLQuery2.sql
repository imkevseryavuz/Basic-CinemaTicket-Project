USE [CinemaTicket]
GO
SET IDENTITY_INSERT [dbo].[Genres] ON 

INSERT [dbo].[Genres] ([GenreId], [GenreName]) VALUES (1, N'Aþk')
INSERT [dbo].[Genres] ([GenreId], [GenreName]) VALUES (2, N'Dram')
INSERT [dbo].[Genres] ([GenreId], [GenreName]) VALUES (3, N'Komedi')
INSERT [dbo].[Genres] ([GenreId], [GenreName]) VALUES (4, N'Aksiyon')
INSERT [dbo].[Genres] ([GenreId], [GenreName]) VALUES (5, N'Korku')
INSERT [dbo].[Genres] ([GenreId], [GenreName]) VALUES (6, N'BilimKurgu')
SET IDENTITY_INSERT [dbo].[Genres] OFF
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieId], [MovieName], [DirectorName], [GenreId], [VisionStartD], [VisionFinishD]) VALUES (1, N'Maze Runner', N'deneme', 4, N'12.02.2016', N'20.02.2016')
INSERT [dbo].[Movies] ([MovieId], [MovieName], [DirectorName], [GenreId], [VisionStartD], [VisionFinishD]) VALUES (2, N'Who Am I', N'deneme', 6, N'13.02.2016', N'21.02.2016')
SET IDENTITY_INSERT [dbo].[Movies] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [UserName], [Password], [CustomerName], [CustomerSurname], [Phone], [Address]) VALUES (1, N'kevser', N'1', N'kevser', N'YAVUZ', N'123456', N'deneme')
INSERT [dbo].[Customers] ([CustomerId], [UserName], [Password], [CustomerName], [CustomerSurname], [Phone], [Address]) VALUES (2, N'ilker', N'2', N'ilker', N'yýldýz', N'123456', N'deneme2')
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Emplooyes] ON 

INSERT [dbo].[Emplooyes] ([EmplooyeId], [UserName], [Password], [EmplooyeTC], [EmplooyeName], [EmplooyeSurname], [DateOfBirth], [GenderId], [StartDate], [FinishDate]) VALUES (1, N'gokhan', N'1', N'123456', N'gökhan', N'atmaca', N'24 aralýk 1995', N'Erkek', N'12.02.2016', N'12.02.2017')
SET IDENTITY_INSERT [dbo].[Emplooyes] OFF
SET IDENTITY_INSERT [dbo].[Genders] ON 

INSERT [dbo].[Genders] ([GenderId], [GenderName]) VALUES (1, N'Bay')
INSERT [dbo].[Genders] ([GenderId], [GenderName]) VALUES (2, N'Bayan')
SET IDENTITY_INSERT [dbo].[Genders] OFF
SET IDENTITY_INSERT [dbo].[TicketSales] ON 

INSERT [dbo].[TicketSales] ([SaleId], [CustomerPhone], [TotalTicket], [MovieId], [DateOfPurchase]) VALUES (1, N'123456', 2, N'Maze Runner', N'11.12.2016')
INSERT [dbo].[TicketSales] ([SaleId], [CustomerPhone], [TotalTicket], [MovieId], [DateOfPurchase]) VALUES (2, N'123456', 3, N'Maze Runner', N'11.12.2016')
SET IDENTITY_INSERT [dbo].[TicketSales] OFF
