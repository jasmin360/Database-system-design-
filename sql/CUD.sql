
--client 
CREATE PROCEDURE Client_Create (
    @Driver_License_Number int,
    @First_Name varchar(200),
    @Last_Name varchar(200),
     @Email varchar(200),
     @Phone varchar(20)
)
AS
BEGIN 
    insert into Client 
    values (@Driver_License_Number, @First_Name, @Last_Name, @Email, @Phone)
END;

GO

CREATE PROCEDURE Client_Update(
     @Driver_License_Number int,
     @First_Name varchar(200) = null,
     @Last_Name varchar(200) = null,
     @Email varchar(200) = null,
     @Phone varchar(20) = null)
AS
BEGIN
    update Client
    set First_Name = ISNULL(@First_Name, First_Name),
        Last_Name = ISNULL(@Last_Name, Last_Name),
        Email = ISNULL(@Email, Email),
        Phone = ISNULL(@Phone, Phone)
    where Driver_License_Number = @Driver_License_Number;
END;

GO
CREATE PROCEDURE Client_Delete
     @Driver_License_Number int
AS
BEGIN
    delete from Client where Driver_License_Number = @Driver_License_Number;
END;

GO

--branch 
CREATE PROCEDURE Branch_Create
     @City varchar(200),
     @Street_Number int,
     @Building_Number int,
     @Contact_Number varchar(20)
AS
BEGIN
    insert into  Branch (City, Street_Number, Building_Number, Contact_Number)
    values (@City, @Street_Number, @Building_Number, @Contact_Number);
END;

GO
CREATE PROCEDURE Branch_Update
     @Branch_ID int,
     @City varchar(200) = null,
     @Street_Number int = null,
     @Building_Number int = null,
     @Contact_Number varchar(20) = null
AS
BEGIN
    update Branch
    set City            = ISNULL(@City, City),
        Street_Number   = ISNULL(@Street_Number, Street_Number),
        Building_Number = ISNULL(@Building_Number, Building_Number),
        Contact_Number  = ISNULL(@Contact_Number, Contact_Number)
    where Branch_ID = @Branch_ID;
END;

GO
CREATE PROCEDURE Branch_Delete
     @Branch_ID int
AS
BEGIN
    delete from Branch where Branch_ID = @Branch_ID;
END;

GO
--car category 
CREATE PROCEDURE CarCategory_Create
     @Car_Type varchar(20),
     @Make varchar(200),
     @Model varchar(200),
     @Model_Year int,
     @Transmission varchar(20),
     @Daily_Rental_Rate money
AS
BEGIN

    if NOT EXISTS (select 1 from Car_Category where Car_Type=@Car_Type and Make = @Make and Model = @Model 
        and Model_Year = @Model_Year and Transmission = @Transmission and Daily_Rental_Rate = @Daily_Rental_Rate)
    BEGIN
        insert into Car_Category (Car_Type, Make, Model, Model_Year, Transmission, Daily_Rental_Rate)
        values (@Car_Type, @Make, @Model, @Model_Year, @Transmission, @Daily_Rental_Rate);
    END;

END;

GO
CREATE PROCEDURE CarCategory_Update
     @Category_ID int,
     @Car_Type varchar(20) = null,
     @Make varchar(200) = null,
     @Model varchar(200) = null,
     @Model_Year int = null,
     @Transmission varchar(20) = null,
     @Daily_Rental_Rate money = null
AS
BEGIN;
    update Car_Category
    set Car_Type          = ISNULL(@Car_Type, Car_Type),
        Make              = ISNULL(@Make, Make),
        Model             = ISNULL(@Model, Model),
        Model_Year        = ISNULL(@Model_Year, Model_Year),
        Transmission      = ISNULL(@Transmission, Transmission),
        Daily_Rental_Rate = ISNULL(@Daily_Rental_Rate, Daily_Rental_Rate)
    where Category_ID = @Category_ID;
END;

GO
CREATE PROCEDURE CarCategory_Delete
     @Category_ID int
AS
BEGIN
    delete from Car_Category where Category_ID = @Category_ID;
END;

GO
-- car
CREATE PROCEDURE Car_Create
     @License_Plate varchar(200),
     @Condition varchar(20),
     @No_seats int,
     @Mileage int,
     @Colour varchar(200),
     @Category_ID int,
     @Branch_ID int
AS
BEGIN
    insert into Car (License_Plate, Condition, No_seats, Mileage, Colour, Category_ID, Branch_ID)
    values (@License_Plate, @Condition, @No_seats, @Mileage, @Colour, @Category_ID, @Branch_ID);
END;

GO
CREATE PROCEDURE Car_Update
     @License_Plate varchar(200),
     @Condition varchar(20) = null,
     @No_seats int = null,
     @Mileage int = null,
     @Colour varchar(200) = null,
     @Category_ID int = null,
     @Branch_ID int = null
AS
BEGIN
    update Car
    SET Condition   = ISNULL(@Condition,Condition), 
        No_seats    = ISNULL(@No_seats, No_seats),
        Mileage     = ISNULL(@Mileage,Mileage),
        Colour      = ISNULL(@Colour,Colour),
        Category_ID = ISNULL(@Category_ID, Category_ID),
        Branch_ID   = ISNULL(@Branch_ID, Branch_ID)
    WHERE License_Plate = @License_Plate;
END;

GO
CREATE PROCEDURE Car_Delete
     @License_Plate varchar(200)
AS
BEGIN
    delete from Car where License_Plate = @License_Plate;
END;

GO

-- employee
CREATE PROCEDURE Employee_Create
     @Passkey varchar(200),
     @Email varchar(200),
     @Position varchar(20),
     @First_name varchar(200),
     @Last_name varchar(200),
     @Branch_ID int,
     @SuperEmpID int = null
AS
BEGIN
    insert into Employee (Passkey, Email, Position, First_name, Last_name, Branch_ID, SuperEmpID)
    values (@Passkey, @Email, @Position, @First_name, @Last_name, @Branch_ID, @SuperEmpID);
END;

GO
CREATE PROCEDURE Employee_Update
     @Emp_ID int,
     @Passkey varchar(200) = null,
     @Email varchar(200) = null,
     @Position varchar(20) = null,
     @First_name varchar(200) = null,
     @Last_name varchar(200)= null,
     @Branch_ID int = null,
     @SuperEmpID int = null
AS
BEGIN
    update Employee
    set Passkey         = ISNULL(@Passkey,Passkey),
        Email           = ISNULL(@Email, Email),
        Position        = ISNULL(@Position,Position),
        First_name      = ISNULL(@First_name,First_name),
        Last_name       = ISNULL(@Last_name,Last_name),
        Branch_ID       = ISNULL(@Branch_ID,Branch_ID),
        SuperEmpID      = ISNULL(@SuperEmpID, SuperEmpID)
    where Emp_ID = @Emp_ID;
END;

GO
CREATE PROCEDURE Employee_Delete
     @Emp_ID int
AS
BEGIN
    delete from Employee where Emp_ID = @Emp_ID;
END;


--payment 
GO
CREATE PROCEDURE Payment_Create
     @Payment_Method varchar(10),
     @Payment_Date date,
     @Emp_ID int,
     @Client_ID int
AS
BEGIN
    SET @Payment_Date = GETDATE();
    INSERT INTO Payment (Payment_Method, Payment_Date, Emp_ID, Client_ID)
    VALUES (@Payment_Method, @Payment_Date, @Emp_ID, @Client_ID);

    SELECT SCOPE_IDENTITY() AS Payment_ID;
END;

GO
CREATE PROCEDURE Payment_Update
     @Payment_ID int,
     @Payment_Method varchar(10) = null,
     @Payment_Date date = null,
     @Emp_ID int = null,
     @Client_ID int = null
AS
BEGIN
    update Payment
    set Payment_Method = ISNULL(@Payment_Method,Payment_Method),
        Payment_Date   = ISNULL(@Payment_Date,Payment_Date),
        Emp_ID         = ISNULL(@Emp_ID,Emp_ID),
        Client_ID      = ISNULL(@Client_ID,Client_ID)
    where Payment_ID = @Payment_ID;
END;

GO
CREATE PROCEDURE Payment_Delete
     @Payment_ID int
AS
BEGIN
    delete from Payment where Payment_ID = @Payment_ID;
END;

GO
--reservation 
CREATE PROCEDURE Reservation_Create
     @Reservation_Date date,
     @Payment_ID int,
     @Deadline date,
     @Reservation_Status varchar(20),
     @LicenseNo int,
     @License_Plate varchar(200),
     @Pickup_Branch_ID int,
     @Return_Branch_ID int = null,
     @Return_Date date = null,
     @Pickup_Date date = null
AS
BEGIN
    insert into Reservation (
        Reservation_Date,Payment_ID, Deadline, Reservation_Status, LicenseNo, License_Plate, Pickup_Branch_ID, Return_Branch_ID,
        Return_Date, Pickup_Date
    )
    values (
        @Reservation_Date, @Payment_ID, @Deadline, @Reservation_Status, @LicenseNo, @License_Plate, @Pickup_Branch_ID, @Return_Branch_ID,
        @Return_Date, @Pickup_Date
    );
END;

GO
CREATE PROCEDURE Reservation_Update
     @Reservation_ID int,
     @Deadline date = null,
     @Reservation_Date date = null,
     @Reservation_Status varchar(20) = null,
     @LicenseNo int =null,
     @License_Plate varchar(200)= null,
     @Pickup_Branch_ID int = null,
     @Return_Branch_ID int =null,
     @Return_Date date = null,
     @Pickup_Date date = null
AS
BEGIN
    update Reservation
    set Reservation_Date  = ISNULL(@Reservation_Date,Reservation_Date), 
        Deadline          = ISNULL(@Deadline,Deadline),
        Reservation_Status= ISNULL(@Reservation_Status,Reservation_Status),
        LicenseNo         = ISNULL(@LicenseNo, LicenseNo),
        License_Plate     = ISNULL(@License_Plate,License_Plate),
        Pickup_Branch_ID  = ISNULL(@Pickup_Branch_ID, Pickup_Branch_ID),
        Return_Branch_ID  = ISNULL(@Return_Branch_ID,Return_Branch_ID),
        Return_Date       = ISNULL(@Return_Date, Return_Date),
        Pickup_Date       = ISNULL(@Pickup_Date, Pickup_Date)
    where Reservation_ID = @Reservation_ID;
END;

GO
CREATE PROCEDURE Reservation_Delete
     @Reservation_ID int
AS
BEGIN
    delete from Reservation where Reservation_ID = @Reservation_ID;
END;