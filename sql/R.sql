
CREATE PROCEDURE Client_Read_Licenseno
    @Driver_License_Number INT = NULL
AS
BEGIN
    if @Driver_License_Number is null
        select * from Client;
    else
        select * from Client where Driver_License_Number = @Driver_License_Number;
END;

CREATE PROCEDURE Branch_Read_BranchID
    @Branch_ID INT = NULL
AS
BEGIN
    if @Branch_ID is null
        select * from Branch;
    else
        select * from Branch where Branch_ID = @Branch_ID;
END;

CREATE PROCEDURE Car_Category_Read_CategoryID
    @Category_ID INT = NULL
AS
BEGIN
    if @Category_ID is null
        select * from Car_Category;
    else
        select * from Car_Category where Category_ID = @Category_ID;
END;

CREATE PROCEDURE Car_Read_LicensePlate
    @License_Plate VARCHAR(200) = NULL
AS
BEGIN
    if @License_Plate is null
        select * from Car;
    else
        select * from Car where License_Plate = @License_Plate;
END;

CREATE PROCEDURE Employee_Read_EmpID
    @Emp_ID INT = NULL
AS
BEGIN
    if @Emp_ID is null
        select * from Employee;
    else
        select * from Employee where Emp_ID = @Emp_ID;
END;

CREATE PROCEDURE Employee_Read_Email
    @Email VARCHAR(200) = NULL
AS
BEGIN
    if @Email is null
        select * from Employee;
    else
        select * from Employee where Email = @Email;
END;

CREATE PROCEDURE Payment_Read_PaymentID
    @Payment_ID INT = NULL
AS
BEGIN
    if @Payment_ID is null
        select * from Payment;
    else
        select * from Payment where Payment_ID = @Payment_ID;
END;

CREATE PROCEDURE Reservation_Read_ReservationID
    @Reservation_ID INT = NULL
AS
BEGIN
    if @Reservation_ID is null
        select * from Reservation;
    else
        select * from Reservation where Reservation_ID = @Reservation_ID;
END;

CREATE PROCEDURE Cars_Read_ByCategoryID
    @Category_ID INT
AS
BEGIN
    select * from Car where Category_ID = @Category_ID;
END;

CREATE PROCEDURE Cars_Read_ByBranchID
    @Branch_ID INT
AS
BEGIN
    select * from Car where Branch_ID = @Branch_ID;
END;

CREATE PROCEDURE Employee_Read_ByBranchID
    @Branch_ID INT
AS
BEGIN
    select * from Employee where Branch_ID = @Branch_ID;
END;

CREATE PROCEDURE Employee_Read_BySupervisorID
    @SuperEmpID INT
AS
BEGIN
    select * from Employee where SuperEmpID = @SuperEmpID;
END;

CREATE PROCEDURE Payment_Read_ByEmpID
    @Emp_ID INT
AS
BEGIN
    select * from Payment where Emp_ID = @Emp_ID;
END;

CREATE PROCEDURE Payment_Read_ByClientID
    @Client_ID INT
AS
BEGIN
    select * from Payment where Client_ID = @Client_ID;
END;

CREATE PROCEDURE Reservation_Read_ByClientID
    @LicenseNo INT
AS
BEGIN
    select * from Reservation where LicenseNo = @LicenseNo;
END;

CREATE PROCEDURE Reservation_Read_ByCarLicensePlate
    @License_Plate VARCHAR(200)
AS
BEGIN
    select * from Reservation where License_Plate = @License_Plate;
END;

CREATE PROCEDURE Reservation_Read_ByPickupBranchID
    @Pickup_Branch_ID INT
AS
BEGIN
    select * from Reservation where Pickup_Branch_ID = @Pickup_Branch_ID;
END;

CREATE PROCEDURE Reservation_Read_ByReturnBranchID
    @Return_Branch_ID INT
AS
BEGIN
    select * from Reservation where Return_Branch_ID = @Return_Branch_ID;
END;

-- Special retrieval procedures

CREATE PROCEDURE Get_Recent_Reservations
AS
BEGIN
    SELECT *
    FROM Reservation r
    WHERE r.Reservation_Date >= DATEADD(DAY, -7, CAST(GETDATE() AS DATE));
END;

CREATE PROCEDURE Get_Reservation_details
    @Reservation_ID INT
AS
BEGIN
    SELECT *
    FROM Reservation r
    LEFT JOIN Client cl ON r.LicenseNo = cl.Driver_License_Number
    LEFT JOIN Car c ON r.License_Plate = c.License_Plate
    LEFT JOIN Car_Category cat ON c.Category_ID = cat.Category_ID
    LEFT JOIN Payment p ON r.LicenseNo = p.Client_ID
    WHERE r.Reservation_ID = @Reservation_ID;
END;


CREATE PROCEDURE Get_Todays_Returns
AS
BEGIN
    SELECT *
    FROM Reservation
    WHERE Reservation_Status = 'Returned'
      AND Return_Date = CAST(GETDATE() AS DATE);
END;

CREATE PROCEDURE Get_Total_Cars_In_Branch
    @Branch_ID INT = NULL
AS
BEGIN
    IF @Branch_ID IS NULL
        SELECT COUNT(*) AS Total_Cars FROM Car;
    ELSE
        SELECT COUNT(*) AS Total_Cars FROM Car WHERE Branch_ID = @Branch_ID;
END;

CREATE PROCEDURE Get_Available_Cars_In_Branch
    @Branch_ID INT = NULL
AS
BEGIN
    IF @Branch_ID IS NULL
        SELECT * FROM Car WHERE Condition = 'Free';
    ELSE
        SELECT * FROM Car WHERE Condition = 'Free' AND Branch_ID = @Branch_ID;
END;

CREATE PROCEDURE Get_Todays_Planned_Returns
    @Branch_ID INT = NULL
AS
BEGIN
    IF @Branch_ID IS NULL
        SELECT * FROM Reservation WHERE Deadline = CAST(GETDATE() AS DATE);
    ELSE
        SELECT * FROM Reservation
        WHERE Deadline = CAST(GETDATE() AS DATE)
          AND Return_Branch_ID = @Branch_ID
          AND Reservation_Status != 'Returned';
END;

CREATE PROCEDURE Get_Branch_By_Employee_Email
    @Email VARCHAR(200)
AS
BEGIN
   SELECT Branch.*
    FROM Branch
    INNER JOIN Employee ON Branch.Branch_ID = Employee.Branch_ID
    WHERE Employee.Email = @Email;
END;

CREATE PROCEDURE Reservation_filter (
    @Day   DATE = NULL,
    @Week  INT  = NULL,
    @Month INT  = NULL,
    @Year  INT  = NULL 
)
AS 
BEGIN
    --toot    
END;

CREATE PROCEDURE Deadline_filter (
    @Day   DATE = NULL,
    @Week  INT  = NULL,
    @Month INT  = NULL,
    @Year  INT  = NULL 
)
AS 
BEGIN
    --toot
END;