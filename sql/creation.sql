CREATE TABLE Client (
Driver_License_Number int PRIMARY KEY,
First_Name varchar(200) NOT NULL,
Last_Name varchar(200) NOT NULL,
Email varchar(200) unique CHECK (Email LIKE '%_@__%.__%' AND PATINDEX('%[^a-zA-Z0-9@._-]%', Email) = 0) NOT NULL,
Phone varchar(20) unique CHECK (LEN(Phone) = 12 AND Phone NOT LIKE '%[^0-9]%') NOT NULL
);

CREATE TABLE Branch (
Branch_ID int IDENTITY(1,1) PRIMARY KEY,
City varchar(200) NOT NULL,
Street_Number int NOT NULL,
Building_Number int NOT NULL,
Contact_Number  varchar(20) CHECK (LEN(Contact_Number) = 12 AND Contact_Number NOT LIKE '%[^0-9]%')
);

CREATE TABLE Car_Category (
Category_ID int IDENTITY(1,1) PRIMARY KEY,
Car_Type varchar(200) CHECK (Car_Type IN('Picanto', 'SUV', 'Coupe', 'Sedan', 'Hatchback')) NOT NULL,
Make varchar(200) NOT NULL,
Model varchar(200) NOT NULL,
Model_Year int NOT NULL,
Transmission varchar(200) CHECK (Transmission IN('Manual', 'Automatic', 'DCT', 'CVT', 'AMT')) NOT NULL,
Daily_Rental_Rate money NOT NULL
UNIQUE (Category_ID,Car_Type, Make,Model,Model_Year,Transmission, Daily_Rental_Rate)
);

CREATE TABLE Car (
License_Plate varchar(200) PRIMARY KEY ,
Condition varchar(200) CHECK (Condition IN('Free','Reserved', 'Retired')) NOT NULL,
No_seats int NOT NULL,
Mileage int NOT NULL,
Colour varchar(200) NOT NULL,
Category_ID int NOT NULL REFERENCES Car_Category(Category_ID),
Branch_ID int NOT NULL REFERENCES Branch(Branch_ID)
);

CREATE TABLE Employee (
Emp_ID int IDENTITY(1,1) PRIMARY KEY ,
Passkey varchar(200) NOT NULL,
Email varchar(200) unique CHECK (Email LIKE '%_@__%.__%' AND PATINDEX('%[^a-zA-Z0-9@._-]%', Email) = 0)  NOT NULL,
Position varchar(200) CHECK (Position IN ('Supervisor','Employee')) NOT NULL,
First_Name varchar(200) NOT NULL,
Last_Name varchar(200) NOT NULL,
Branch_ID int NOT NULL REFERENCES Branch(Branch_ID),
SuperEmpID int REFERENCES Employee(Emp_ID), 
Active bit NOT NULL, 

    CONSTRAINT noselfsupervisor 
        CHECK (SuperEmpID IS NULL OR SuperEmpID <> Emp_ID)
);

CREATE TABLE Payment (
Payment_ID int IDENTITY(1,1) PRIMARY KEY,
Payment_Method varchar(200) CHECK (Payment_Method IN('Cash', 'Card')) NOT NULL,
Payment_Date Date NOT NULL,
Emp_ID int REFERENCES Employee(Emp_ID) NOT NULL,
Client_ID int NOT NULL REFERENCES Client(Driver_License_Number)
);

CREATE TABLE Reservation (
Reservation_ID int IDENTITY(1,1) PRIMARY KEY,
Payment_ID int NOT NULL REFERENCES Payment(Payment_ID),
Reservation_Date date NOT NULL,
Deadline Date NOT NULL, 
Reservation_Status varchar(200)  NOT NULL,
LicenseNo int NOT NULL REFERENCES Client(Driver_License_Number),
License_Plate varchar(200) NOT NULL REFERENCES Car(License_Plate), 
Pickup_Branch_ID int REFERENCES Branch(Branch_ID) NOT NULL,
Return_Branch_ID int REFERENCES Branch(Branch_ID) default null,
Return_Date date default null,
Pickup_Date date default null ,

CHECK (Deadline >= Reservation_Date),
CHECK ((Reservation_Status = 'Pending' AND Pickup_Date IS NULL AND Return_Date IS NULL) OR(Reservation_Status = 'Pickedup' AND Pickup_Date IS NOT NULL) OR(Reservation_Status = 'Returned' AND Pickup_Date IS NOT NULL AND Return_Date IS NOT NULL)),
CHECK (Return_Date IS NULL OR Pickup_Date IS NULL OR Return_Date >= Pickup_Date)
);



