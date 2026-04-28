
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
    @Licesne_Plate VARCHAR(200) = NULL
AS
BEGIN
    if @Licesne_Plate is null
        select * from Car;
    else
        select * from Car where Licesne_Plate = @Licesne_Plate;
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
    @emp_ID INT
AS
BEGIN
    select * from Payment where emp_ID = @emp_ID;
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
    @Licesne_Plate VARCHAR(200)
AS
BEGIN
    select * from Reservation where Licesne_Plate = @Licesne_Plate;
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
