Create Proc SP_GetMovieByGender
@GenreName nvarchar(max)
As
Declare @id int=(Select GenreId From Genres  Where GenreName=@GenreName)
Select M.MovieId,M.MovieName,M.DirectorName,M.VisionStartD,M.VisionFinishD From Movies M Where M.GenreId=@id

