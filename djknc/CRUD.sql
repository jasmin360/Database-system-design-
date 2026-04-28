







-- branch


CREATE PROCEDURE Branch_Read
    @Branch_ID int = NULL
AS
BEGIN
    if @Branch_ID is null
        select * from Branch;
    else
        select * from Branch where Branch_ID = @Branch_ID;
END;







-- car category




CREATE PROCEDURE sp_CarCategory_Read
    @Category_ID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF @Category_ID IS NULL
        SELECT * FROM Car_Category;
    ELSE
        SELECT * FROM Car_Category WHERE Category_ID = @Category_ID;
END;









-- car




CREATE PROCEDURE sp_Car_Read
    @Licesne_Plate VARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF @Licesne_Plate IS NULL
        SELECT * FROM Car;
    ELSE
        SELECT * FROM Car WHERE Licesne_Plate = @Licesne_Plate;
END;







-- employee



CREATE PROCEDURE sp_Employee_Read
    @Emp_ID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF @Emp_ID IS NULL
        SELECT * FROM Employee;
    ELSE
        SELECT * FROM Employee WHERE Emp_ID = @Emp_ID;
END;








-- payment




CREATE PROCEDURE sp_Payment_Read
    @Payment_ID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF @Payment_ID IS NULL
        SELECT * FROM Payment;
    ELSE
        SELECT * FROM Payment WHERE Payment_ID = @Payment_ID;
END;






-- reservation



CREATE PROCEDURE sp_Reservation_Read
    @Reservation_ID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF @Reservation_ID IS NULL
        SELECT * FROM Reservation;
    ELSE
        SELECT * FROM Reservation WHERE Reservation_ID = @Reservation_ID;
END;



