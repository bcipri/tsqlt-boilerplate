CREATE PROCEDURE [AddNumberTests].[test_AddNumberReturnsSumOfParameters]
AS
BEGIN
  DECLARE @result INT;
  EXEC @result = dbo.AddNumbers 2 ,2;
  PRINT @result;
  EXEC tSQLt.AssertEquals 4, @result;
END

