CREATE PROCEDURE [DummyTests].[testDummyFunction]
AS
BEGIN
  DECLARE @result INT;
  EXEC @result = dbo.DummyFunction 2 ,2;
  PRINT @result;
  EXEC tSQLt.AssertEquals 5, @result;
END

