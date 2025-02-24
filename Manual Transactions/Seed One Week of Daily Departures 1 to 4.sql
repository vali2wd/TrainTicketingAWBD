BEGIN TRANSACTION;

DECLARE @TodaysDate DATE = GETDATE();
DECLARE @FutureDate DATE;
DECLARE @Day INT = 0;

WHILE @Day <= 7
BEGIN
    SET @FutureDate = DATEADD(DAY, @Day, @TodaysDate);
    
	INSERT INTO DailyDepartures VALUES(@FutureDate, 1, NULL, 0);
	INSERT INTO DailyDepartures VALUES(@FutureDate, 2, NULL, 0);
	INSERT INTO DailyDepartures VALUES(@FutureDate, 3, NULL, 0);
	INSERT INTO DailyDepartures VALUES(@FutureDate, 4, NULL, 0);

    SET @Day = @Day + 1;
END;

SELECT * FROM DailyDepartures;
ROLLBACK TRANSACTION;
--COMMIT TRANSACTION;