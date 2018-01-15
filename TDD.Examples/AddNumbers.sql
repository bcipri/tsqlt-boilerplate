CREATE PROCEDURE [dbo].[AddNumbers]
	@param1 int,
	@param2 int
AS
	RETURN @param1 + @param2
