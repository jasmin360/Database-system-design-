
--client 
CREATE PROCEDURE Client_Create (
    in @Driver_License_Number int,
    in @Fname varchar(200),
    in @Lname varchar(200),
    in @Email varchar(200),
    in @Phone varchar(20)
)
AS
BEGIN 
    insert into Client 
    values (@Driver_License_Number, @Fname, @Lname, @Email, @Phone)
END;

CREATE PROCEDURE Client_Update
    in @Driver_License_Number int,
    in @Fname varchar(200) = null,
    in @Lname varchar(200) = null,
    in @Email varchar(200) = null,
    in @Phone varchar(20) = null
AS
BEGIN
    update Client
    set Fname = ISNULL(@Fname, Fname),
        Lname = ISNULL(@Lname, Lname),
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
    in @Contact_number varchar(20)
AS
BEGIN
    insert into  Branch (City, Street_Number, Building_Number, Contact_number)
    values (@City, @Street_Number, @Building_Number, @Contact_number);
END;

CREATE PROCEDURE Branch_Update
    in @Branch_ID int,
    in @City varchar(200) = null,
    in @Street_Number int = null,
    in @Building_Number int = null,
    in @Contact_number varchar(20) = null
AS
BEGIN
    update Branch
    set City            = ISNULL(@City, City),
        Street_Number   = ISNULL(@Street_Number, Street_Number),
        Building_Number = ISNULL(@Building_Number, Building_Number),
        Contact_number  = ISNULL(@Contact_number, Contact_number)
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
    in @model_year varchar(200),
    in @Transmission varchar(20),
    in @Daily_rental_rate money
AS
BEGIN
    insert into Car_Category (Car_Type, Make, Model, model_year, Transmission, Daily_rental_rate)
    values (@Car_Type, @Make, @Model, @model_year, @Transmission, @Daily_rental_rate);
END;


CREATE PROCEDURE CarCategory_Update
    in @Category_ID int,
    in @Car_Type varchar(20) = null,
    in @Make varchar(200) = null,
    in @Model varchar(200) = null,
    in @model_year varchar(200) = null,
    in @Transmission varchar(20) = null,
    in @Daily_rental_rate money = null
AS
BEGIN;
    update Car_Category
    set Car_Type          = ISNULL(@Car_Type, Car_Type),
        Make              = ISNULL(@Make, Make),
        Model             = ISNULL(@Model, Model),
        model_year        = ISNULL(@model_year, model_year),
        Transmission      = ISNULL(@Transmission, Transmission),
        Daily_rental_rate = ISNULL(@Daily_rental_rate, Daily_rental_rate),
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
    in @Licesne_Plate varchar(200),
    in @Condition varchar(20),
    in @No_seats int,
    in @Mileage int,
    in @colour varchar(200),
    in @Category_ID int,
    in @Branch_ID int
AS
BEGIN
    insert into Car 
    values (@Licesne_Plate, @Condition, @No_seats, @Mileage, @colour, @Category_ID, @Branch_ID);
END;


CREATE PROCEDURE Car_Update
    in @Licesne_Plate varchar(200),
    in @Condition varchar(20) = null,
    in @No_seats int = null,
    in @Mileage int = null,
    in @colour varchar(200) = null,
    in @Category_ID int = null,
    in @Branch_ID int = null
AS
BEGIN
    update Car
    SET Condition   = ISNULL(@Condition,Condition), 
        No_seats    = ISNULL(@No_seats, No_seats),
        Mileage     = ISNULL(@Mileage,Mileage),
        colour      = ISNULL(@colour,colour),
        Category_ID = ISNULL(@Category_ID, Category_ID),
        Branch_ID   = ISNULL(@Branch_ID, Branch_ID),
    WHERE Licesne_Plate = @Licesne_Plate;
END;


CREATE PROCEDURE Car_Delete
    in @Licesne_Plate varchar(200)
AS
BEGIN
    delete from Car where Licesne_Plate = @Licesne_Plate;
END;



-- employee
CREATE PROCEDURE Employee_Create
    in @Password_Hashed varchar(200),
    in @Email varchar(200),
    in @position varchar(20),
    in @First_name varchar(200),
    in @Last_name varchar(200),
    in @Branch_ID int,
    in @SuperEmpID int = null
AS
BEGIN
    insert into Employee (Password_Hashed, Email, position, First_name, Last_name, Branch_ID, SuperEmpID)
    values (@Password_Hashed, @Email, @position, @First_name, @Last_name, @Branch_ID, @SuperEmpID);
END;

CREATE PROCEDURE Employee_Update
    in @Emp_ID int,
    in @Password_Hashed varchar(200) = null,
    in @Email varchar(200) = null,
    in @position varchar(20) = null,
    in @First_name varchar(200) = null,
    in @Last_name varchar(200)= null,
    in @Branch_ID int = null,
    in @SuperEmpID int = null
AS
BEGIN
    update Employee
    set Password_Hashed = ISNULL(@Password_Hashed,Password_Hashed),
        Email           = ISNULL(@Email, Password_Hashed),
        position        = ISNULL(@position,position),
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
    in @Payment_method varchar(10),
    in @Payment_date date,
    in @base_price money,
    in @emp_ID int,
    in @Client_ID int
AS
BEGIN
    insert into Payment (Payment_method, Payment_date, base_price, emp_ID, Client_ID)
    values (@Payment_method, @Payment_date, @base_price, @emp_ID, @Client_ID);
END;


CREATE PROCEDURE Payment_Update
    in @Payment_ID int,
    in @Payment_method varchar(10) = null,
    in @Payment_date date = null,
    in @base_price money = null,
    in @emp_ID int = null,
    in @Client_ID int = null
AS
BEGIN
    update Payment
    set Payment_method = ISNULL(@Payment_method,Payment_method),
        Payment_date   = ISNULL(@Payment_date,Payment_date),
        base_price     = ISNULL(@base_price,base_price), 
        emp_ID         = ISNULL(@emp_ID,emp_ID),
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
    in @reservation varchar(20),
    in @LicenseNo int,
    in @Licesne_Plate varchar(200),
    in @Pickup_Branch_ID int,
    in @Return_Branch_ID int,
    in @return_Date date = null,
    in @Pickup_date date = null
AS
BEGIN
    insert into Reservation (
        Reservation_Date, Deadline, reservation, LicenseNo, Licesne_Plate, Pickup_Branch_ID, Return_Branch_ID,
        return_Date, Pickup_date
    )
    values (
        @Reservation_Date, @Deadline, @reservation, @LicenseNo, @Licesne_Plate, @Pickup_Branch_ID, @Return_Branch_ID,
        @return_Date, @Pickup_date
    );
END;


CREATE PROCEDURE Reservation_Update
    in @Reservation_ID int,
    in @Deadline date = null,
    in @reservation varchar(20) = null,
    in @LicenseNo int =null,
    in @Licesne_Plate varchar(200)= null,
    in @Pickup_Branch_ID int = null,
    in @Return_Branch_ID int =null,
    in @return_Date date = null,
    in @Pickup_date date = null
AS
BEGIN
    update Reservation
    set Reservation_Date  = ISNULL(@Reservation_Date,Reservation_Date), 
        Deadline          = ISNULL(@Deadline,Deadline),
        reservation       = ISNULL(@reservation,reservation),
        LicenseNo         = ISNULL(@LicenseNo, LicenseNo),
        Licesne_Plate     = ISNULL(@Licesne_Plate,Licesne_Plate),
        Pickup_Branch_ID  = ISNULL(@Pickup_Branch_ID, Pickup_Branch_ID),
        Return_Branch_ID  = ISNULL(@Return_Branch_ID,Return_Branch_ID),
        return_Date       = ISNULL(@return_Date, return_Date),
        Pickup_date       = ISNULL(@Pickup_date, Pickup_date)
    where Reservation_ID = @Reservation_ID;
END;


CREATE PROCEDURE Reservation_Delete
    in @Reservation_ID int
AS
BEGIN
    delete from Reservation where Reservation_ID = @Reservation_ID;
END;