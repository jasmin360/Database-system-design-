
--client 
CREATE PROCEDURE Client_Create (
    in @Driver_License_Number int,
    in @First_Name varchar(200),
    in @Last_Name varchar(200),
    in @Email varchar(200),
    in @Phone varchar(20)
)
AS
BEGIN 
    insert into Client 
    values (@Driver_License_Number, @First_Name, @Last_Name, @Email, @Phone)
END;

CREATE PROCEDURE Client_Update
    in @Driver_License_Number int,
    in @First_Name varchar(200) = null,
    in @Last_Name varchar(200) = null,
    in @Email varchar(200) = null,
    in @Phone varchar(20) = null
AS
BEGIN
    update Client
    set First_Name = ISNULL(@First_Name, First_Name),
        Last_Name = ISNULL(@Last_Name, Last_Name),
        Email = ISNULL(@Email, Email),
        Phone = ISNULL(@Phone, Phone)
    where Driver_License_Number = @Driver_License_Number;
END;


CREATE PROCEDURE Client_Delete
    in @Driver_License_Number int
AS
BEGIN
    delete from Client where Driver_License_Number = @Driver_License_Number;
END;


--branch 
CREATE PROCEDURE Branch_Create
    in @City varchar(200),
    in @Street_Number int,
    in @Building_Number int,
    in @Contact_Number varchar(20)
AS
BEGIN
    insert into  Branch (City, Street_Number, Building_Number, Contact_Number)
    values (@City, @Street_Number, @Building_Number, @Contact_Number);
END;

CREATE PROCEDURE Branch_Update
    in @Branch_ID int,
    in @City varchar(200) = null,
    in @Street_Number int = null,
    in @Building_Number int = null,
    in @Contact_Number varchar(20) = null
AS
BEGIN
    update Branch
    set City            = ISNULL(@City, City),
        Street_Number   = ISNULL(@Street_Number, Street_Number),
        Building_Number = ISNULL(@Building_Number, Building_Number),
        Contact_Number  = ISNULL(@Contact_number, Contact_Number)
    where Branch_ID = @Branch_ID;
END;

CREATE PROCEDURE Branch_Delete
    in @Branch_ID int
AS
BEGIN
    delete from Branch where Branch_ID = @Branch_ID;
END;


--car category 
CREATE PROCEDURE CarCategory_Create
    in @Car_Type varchar(20),
    in @Make varchar(200),
    in @Model varchar(200),
    in @Model_Year int,
    in @Transmission varchar(20),
    in @Daily_Rental_Rate money
AS
BEGIN
    insert into Car_Category (Car_Type, Make, Model, Model_Year, Transmission, Daily_Rental_Rate)
    values (@Car_Type, @Make, @Model, @Model_Year, @Transmission, @Daily_Rental_Rate);
END;


CREATE PROCEDURE CarCategory_Update
    in @Category_ID int,
    in @Car_Type varchar(20) = null,
    in @Make varchar(200) = null,
    in @Model varchar(200) = null,
    in @Model_Year int = null,
    in @Transmission varchar(20) = null,
    in @Daily_Rental_Rate money = null
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


CREATE PROCEDURE CarCategory_Delete
    in @Category_ID int
AS
BEGIN
    delete from Car_Category where Category_ID = @Category_ID;
END;


-- car
CREATE PROCEDURE Car_Create
    in @License_Plate varchar(200),
    in @Condition varchar(20),
    in @No_seats int,
    in @Mileage int,
    in @Colour varchar(200),
    in @Category_ID int,
    in @Branch_ID int
AS
BEGIN
    insert into Car 
    values (@License_Plate, @Condition, @No_seats, @Mileage, @Colour, @Category_ID, @Branch_ID);
END;


CREATE PROCEDURE Car_Update
    in @License_Plate varchar(200),
    in @Condition varchar(20) = null,
    in @No_seats int = null,
    in @Mileage int = null,
    in @Colour varchar(200) = null,
    in @Category_ID int = null,
    in @Branch_ID int = null
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


CREATE PROCEDURE Car_Delete
    in @License_Plate varchar(200)
AS
BEGIN
    delete from Car where License_Plate = @License_Plate;
END;



-- employee
CREATE PROCEDURE Employee_Create
    in @Passkey varchar(200),
    in @Email varchar(200),
    in @Position varchar(20),
    in @First_name varchar(200),
    in @Last_name varchar(200),
    in @Branch_ID int,
    in @SuperEmpID int = null
AS
BEGIN
    insert into Employee (Passkey, Email, Position, First_name, Last_name, Branch_ID, SuperEmpID)
    values (@Passkey, @Email, @Position, @First_name, @Last_name, @Branch_ID, @SuperEmpID);
END;

CREATE PROCEDURE Employee_Update
    in @Emp_ID int,
    in @Passkey varchar(200) = null,
    in @Email varchar(200) = null,
    in @Position varchar(20) = null,
    in @First_name varchar(200) = null,
    in @Last_name varchar(200)= null,
    in @Branch_ID int = null,
    in @SuperEmpID int = null
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


CREATE PROCEDURE Employee_Delete
    in @Emp_ID int
AS
BEGIN
    delete from Employee where Emp_ID = @Emp_ID;
END;


--payment 

CREATE PROCEDURE Payment_Create
    in @Payment_Method varchar(10),
    in @Payment_Date date,
    in @Emp_ID int,
    in @Client_ID int
AS
BEGIN
    insert into Payment (Payment_Method, Payment_Date, Emp_ID, Client_ID)
    values (@Payment_Method, @Payment_Date, @Emp_ID, @Client_ID);
END;


CREATE PROCEDURE Payment_Update
    in @Payment_ID int,
    in @Payment_Method varchar(10) = null,
    in @Payment_date date = null,
    in @Emp_ID int = null,
    in @Client_ID int = null
AS
BEGIN
    update Payment
    set Payment_Method = ISNULL(@Payment_Method,Payment_Method),
        Payment_Date   = ISNULL(@Payment_Date,Payment_Date),
        Emp_ID         = ISNULL(@Emp_ID,Emp_ID),
        Client_ID      = ISNULL(@Client_ID,Client_ID)
    where Payment_ID = @Payment_ID;
END;


CREATE PROCEDURE Payment_Delete
    in @Payment_ID int
AS
BEGIN
    delete from Payment where Payment_ID = @Payment_ID;
END;


--reservation 
CREATE PROCEDURE Reservation_Create
    in @Reservation_Date date,
    in @Deadline date,
    in @Reservation_Status varchar(20),
    in @LicenseNo int,
    in @License_Plate varchar(200),
    in @Pickup_Branch_ID int,
    in @Return_Branch_ID int,
    in @Return_Date date = null,
    in @Pickup_Date date = null
AS
BEGIN
    insert into Reservation (
        Reservation_Date, Deadline, Reservation_Status, LicenseNo, License_Plate, Pickup_Branch_ID, Return_Branch_ID,
        Return_Date, Pickup_Date
    )
    values (
        @Reservation_Date, @Deadline, @Reservation_Status, @LicenseNo, @License_Plate, @Pickup_Branch_ID, @Return_Branch_ID,
        @Return_Date, @Pickup_Date
    );
END;


CREATE PROCEDURE Reservation_Update
    in @Reservation_ID int,
    in @Deadline date = null,
    in @Reservation_Date date = null,
    in @Reservation_Status varchar(20) = null,
    in @LicenseNo int =null,
    in @License_Plate varchar(200)= null,
    in @Pickup_Branch_ID int = null,
    in @Return_Branch_ID int =null,
    in @Return_Date date = null,
    in @Pickup_Date date = null
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


CREATE PROCEDURE Reservation_Delete
    in @Reservation_ID int
AS
BEGIN
    delete from Reservation where Reservation_ID = @Reservation_ID;
END;