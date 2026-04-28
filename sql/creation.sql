CREATE TABLE Client (
Driver_License_Number int IDENTITY(1,1) PRIMARY KEY,
Fname varchar(200),
Lname varchar(200),
Email varchar(200) CHECK (Email LIKE '%_@__%.__%' AND PATINDEX('%[^a-zA-Z0-9@._-]%', Email) = 0),
Phone varchar(20) CHECK (LEN(Phone) = 12 AND Phone NOT LIKE '%[^0-9]%')
);

CREATE TABLE Branch (
Branch_ID int IDENTITY(1,1) PRIMARY KEY,
City varchar(200),
Street_Number int,
Building_Number int,
Contact_number  varchar(20) CHECK (LEN(Contact_number) = 12 AND Contact_number NOT LIKE '%[^0-9]%')
);

CREATE TABLE Car_Category (
Category_ID int IDENTITY(1,1) PRIMARY KEY,
Car_Type ENUM('Picanto', 'SUV', 'Coupe', 'Sedan', 'Hatchback'),
Make varchar(200),
Model varchar(200),
model_year varchar(200),
Transmission ENUM('Manual', 'Automatic', 'DCT', 'CVT', 'AMT'),
Daily_rental_rate money
);

CREATE TABLE Car (
Licesne_Plate varchar(200) PRIMARY KEY ,
Condition ENUM('Maintainance', 'Free','Reserved'),
No_seats int,
Mileage int,
colour varchar(200),
Category_ID int REFERENCES Car_Category(Category_ID),
Branch_ID int REFERENCES Branch(Branch_ID)
);

CREATE TABLE Employee (
Emp_ID int IDENTITY(1,1) PRIMARY KEY ,
Password_Hashed varchar(200),
Email varchar(200) CHECK (Email LIKE '%_@__%.__%' AND PATINDEX('%[^a-zA-Z0-9@._-]%', Email) = 0),
position ENUM('Supervisor','Employee'),
First_name varchar(200),
Last_name varchar(200),
Branch_ID int REFERENCES Branch(Branch_ID),
SuperEmpID int REFERENCES Employee(Emp_ID)
);

CREATE TABLE Payment (
Payment_ID int IDENTITY(1,1) PRIMARY KEY,
Payment_method ENUM('Cash', 'Card'),
Payment_date Date,
base_price money,
emp_ID int REFERENCES Employee(Emp_ID),
Client_ID int REFERENCES Client(Driver_License_Number)
);

CREATE TABLE Reservation (
Reservation_ID int IDENTITY(1,1) PRIMARY KEY,
Reservation_Date date,
Deadline Date, 
reservation ENUM('Pending', 'Pickedup', 'Rreturned'),
LicenseNo int REFERENCES Client(Driver_License_Number),
Licesne_Plate varchar(200) REFERENCES Car(Licesne_Plate), /*spelling ~yahia*/
Pickup_Branch_ID int REFERENCES Branch(Branch_ID),
Return_Branch_ID int REFERENCES Branch(Branch_ID),
return_Date date default null,
Pickup_date date default null
);



