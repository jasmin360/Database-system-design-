
EXEC Client_Create 10001, 'Ahmed',   'Hassan',   'ahmed.hassan@gmail.com',    '201012345678';
EXEC Client_Create 10002, 'Sara',    'Mahmoud',  'sara.mahmoud@yahoo.com',    '201123456789';
EXEC Client_Create 10003, 'Omar',    'Ali',      'omar.ali@hotmail.com',      '201234567890';
EXEC Client_Create 10004, 'Nour',    'Ibrahim',  'nour.ibrahim@outlook.com',  '201345678901';
EXEC Client_Create 10005, 'Khaled',  'Mostafa',  'khaled.mostafa@gmail.com',  '201456789012';


EXEC Branch_Create 'Cairo',          12,  3,  '202345678901';
EXEC Branch_Create 'Alexandria',     7,   1,  '203456789012';
EXEC Branch_Create 'Giza',           45,  2,  '202567890123';
EXEC Branch_Create 'Mansoura',       88,  5,  '205678901234';
EXEC Branch_Create 'Aswan',          3,   9,  '297890123456';


EXEC CarCategory_Create 'Sedan',     'Toyota',  'Camry',    2022, 'Automatic', 350.00;
EXEC CarCategory_Create 'SUV',       'Hyundai', 'Tucson',   2023, 'Automatic', 500.00;
EXEC CarCategory_Create 'Hatchback', 'Kia',     'Rio',      2021, 'Manual',    250.00;
EXEC CarCategory_Create 'Coupe',     'BMW',     '430i',     2023, 'DCT',       800.00;
EXEC CarCategory_Create 'Picanto',   'Kia',     'Picanto',  2020, 'Manual',    180.00;


EXEC Car_Create 'ABC-1234', 'Free',     5, 12000, 'White',  1, 1;
EXEC Car_Create 'DEF-5678', 'Free',     5, 30500, 'Black',  1, 2;
EXEC Car_Create 'GHI-9012', 'Reserved', 7, 45000, 'Silver', 2, 1;
EXEC Car_Create 'JKL-3456', 'Free',     5, 8200,  'Red',    3, 3;
EXEC Car_Create 'MNO-7890', 'Free',     5, 62000, 'Blue',   4, 2;
EXEC Car_Create 'PQR-1122', 'Reserved', 4, 15000, 'White',  5, 4;
EXEC Car_Create 'STU-3344', 'Free',     5, 27000, 'Gray',   2, 3;
EXEC Car_Create 'VWX-5566', 'Free',     7, 51000, 'Black',  2, 5;



EXEC Employee_Create 'pass$Cairo1',  'mgr.cairo@rental.com',     'Supervisor', 'Tarek',   'Sami',    1, NULL;
EXEC Employee_Create 'pass$Alex1',   'mgr.alex@rental.com',      'Supervisor', 'Dina',    'Fouad',   2, NULL;
EXEC Employee_Create 'pass$Giza1',   'mgr.giza@rental.com',      'Supervisor', 'Youssef', 'Nabil',   3, NULL;



EXEC Employee_Create 'pass$emp01',   'ali.kamal@rental.com',     'Employee',   'Ali',     'Kamal',   1, 1;
EXEC Employee_Create 'pass$emp02',   'mona.riad@rental.com',     'Employee',   'Mona',    'Riad',    1, 1;
EXEC Employee_Create 'pass$emp03',   'hassan.omar@rental.com',   'Employee',   'Hassan',  'Omar',    2, 2;
EXEC Employee_Create 'pass$emp04',   'nadia.samir@rental.com',   'Employee',   'Nadia',   'Samir',   3, 3;
EXEC Employee_Create 'pass$emp05',   'walid.fathy@rental.com',   'Employee',   'Walid',   'Fathy',   4, 1;



EXEC Payment_Create 'Cash',  '2025-01-05', 4, 10001;
EXEC Payment_Create 'Card',  '2025-01-10', 5, 10002;
EXEC Payment_Create 'Cash',  '2025-02-14', 6, 10003;
EXEC Payment_Create 'Card',  '2025-02-20', 7, 10004;
EXEC Payment_Create 'Cash',  '2025-03-01', 4, 10005;
EXEC Payment_Create 'Card',  '2025-03-15', 5, 10001;
EXEC Payment_Create 'Cash',  '2025-04-02', 6, 10002;



EXEC Reservation_Create '2025-01-05', '2025-01-12', 'Pending',  10001, 'ABC-1234', 1, 2, NULL,         NULL;
EXEC Reservation_Create '2025-02-14', '2025-02-20', 'Pending',  10003, 'JKL-3456', 3, 3, NULL,         NULL;


EXEC Reservation_Create '2025-01-10', '2025-01-17', 'Pickedup', 10002, 'DEF-5678', 2, 1, NULL,         '2025-01-10';
EXEC Reservation_Create '2025-03-01', '2025-03-08', 'Pickedup', 10005, 'PQR-1122', 4, 4, NULL,         '2025-03-01';


EXEC Reservation_Create '2025-02-20', '2025-02-27', 'Returned', 10004, 'STU-3344', 3, 2, '2025-02-26', '2025-02-20';
EXEC Reservation_Create '2025-03-15', '2025-03-22', 'Returned', 10001, 'VWX-5566', 2, 5, '2025-03-21', '2025-03-15';
EXEC Reservation_Create '2025-04-02', '2025-04-09', 'Returned', 10002, 'ABC-1234', 1, 3, '2025-04-08', '2025-04-02';











-- ============================================================
-- DUMMY DATA INSERTIONS
-- All reservation/payment dates between 2026-04-27 and 2026-05-02
-- Run in FK dependency order
-- ============================================================


-- ============================================================
-- 1. CLIENT
-- ============================================================
INSERT INTO Client VALUES (10001, 'Ahmed',   'Hassan',   'ahmed.hassan@gmail.com',    '201012345678');
INSERT INTO Client VALUES (10002, 'Sara',    'Mahmoud',  'sara.mahmoud@yahoo.com',    '201123456789');
INSERT INTO Client VALUES (10003, 'Omar',    'Ali',      'omar.ali@hotmail.com',      '201234567890');
INSERT INTO Client VALUES (10004, 'Nour',    'Ibrahim',  'nour.ibrahim@outlook.com',  '201345678901');
INSERT INTO Client VALUES (10005, 'Khaled',  'Mostafa',  'khaled.mostafa@gmail.com',  '201456789012');


-- ============================================================
-- 2. BRANCH
-- ============================================================
EXEC Branch_Create 'Cairo',       12,  3,  '202345678901';
EXEC Branch_Create 'Alexandria',  7,   1,  '203456789012';
EXEC Branch_Create 'Giza',        45,  2,  '202567890123';
EXEC Branch_Create 'Mansoura',    88,  5,  '205678901234';
EXEC Branch_Create 'Aswan',       3,   9,  '297890123456';
-- Branch_IDs: 1..5


-- ============================================================
-- 3. CAR CATEGORY
-- ============================================================
EXEC CarCategory_Create 'Sedan',     'Toyota',  'Camry',   2022, 'Automatic', 350.00;
EXEC CarCategory_Create 'SUV',       'Hyundai', 'Tucson',  2023, 'Automatic', 500.00;
EXEC CarCategory_Create 'Hatchback', 'Kia',     'Rio',     2021, 'Manual',    250.00;
EXEC CarCategory_Create 'Coupe',     'BMW',     '430i',    2023, 'DCT',       800.00;
EXEC CarCategory_Create 'Picanto',   'Kia',     'Picanto', 2020, 'Manual',    180.00;
-- Category_IDs: 1..5


-- ============================================================
-- 4. CAR
-- ============================================================
EXEC Car_Create 'ABC-1234', 'Free',     5, 12000, 'White',  1, 1;
EXEC Car_Create 'DEF-5678', 'Reserved', 5, 30500, 'Black',  1, 2;
EXEC Car_Create 'GHI-9012', 'Reserved', 7, 45000, 'Silver', 2, 1;
EXEC Car_Create 'JKL-3456', 'Free',     5, 8200,  'Red',    3, 3;
EXEC Car_Create 'MNO-7890', 'Free',     5, 62000, 'Blue',   4, 2;
EXEC Car_Create 'PQR-1122', 'Reserved', 4, 15000, 'White',  5, 4;
EXEC Car_Create 'STU-3344', 'Free',     5, 27000, 'Gray',   2, 3;
EXEC Car_Create 'VWX-5566', 'Free',     7, 51000, 'Black',  2, 5;


-- ============================================================
-- 5. EMPLOYEE
--    Supervisors first so their Emp_IDs exist for subordinates
-- ============================================================
EXEC Employee_Create 'pass$Cairo1', 'mgr.cairo@rental.com',   'Supervisor', 'Tarek',   'Sami',   1, NULL;
EXEC Employee_Create 'pass$Alex1',  'mgr.alex@rental.com',    'Supervisor', 'Dina',    'Fouad',  2, NULL;
EXEC Employee_Create 'pass$Giza1',  'mgr.giza@rental.com',    'Supervisor', 'Youssef', 'Nabil',  3, NULL;
-- Emp_IDs: 1 (Tarek/Cairo), 2 (Dina/Alex), 3 (Youssef/Giza)

EXEC Employee_Create 'pass$emp01',  'ali.kamal@rental.com',   'Employee',   'Ali',     'Kamal',  1, 1;
EXEC Employee_Create 'pass$emp02',  'mona.riad@rental.com',   'Employee',   'Mona',    'Riad',   1, 1;
EXEC Employee_Create 'pass$emp03',  'hassan.omar@rental.com', 'Employee',   'Hassan',  'Omar',   2, 2;
EXEC Employee_Create 'pass$emp04',  'nadia.samir@rental.com', 'Employee',   'Nadia',   'Samir',  3, 3;
EXEC Employee_Create 'pass$emp05',  'walid.fathy@rental.com', 'Employee',   'Walid',   'Fathy',  4, 1;
-- Emp_IDs: 4..8


-- ============================================================
-- 6. PAYMENT  (all dated 2026-04-27 to 2026-05-02)
-- ============================================================
EXEC Payment_Create 'Cash', '2026-04-27', 4, 10001;   -- Payment_ID 1
EXEC Payment_Create 'Card', '2026-04-27', 5, 10002;   -- Payment_ID 2
EXEC Payment_Create 'Cash', '2026-04-28', 6, 10003;   -- Payment_ID 3
EXEC Payment_Create 'Card', '2026-04-28', 7, 10004;   -- Payment_ID 4
EXEC Payment_Create 'Cash', '2026-04-29', 4, 10005;   -- Payment_ID 5
EXEC Payment_Create 'Card', '2026-04-30', 5, 10001;   -- Payment_ID 6
EXEC Payment_Create 'Cash', '2026-05-01', 6, 10002;   -- Payment_ID 7
EXEC Payment_Create 'Card', '2026-05-01', 7, 10003;   -- Payment_ID 8
EXEC Payment_Create 'Cash', '2026-05-02', 4, 10004;   -- Payment_ID 9
EXEC Payment_Create 'Card', '2026-05-02', 5, 10005;   -- Payment_ID 10


-- ============================================================
-- 7. RESERVATION  (Reservation_Date and Deadline within window)
--
--   'Pending'  -> Pickup_Date = NULL,        Return_Date = NULL
--   'Pickedup' -> Pickup_Date = pickup date, Return_Date = NULL
--   'Returned' -> Pickup_Date NOT NULL,       Return_Date >= Pickup_Date
-- ============================================================

-- Pending (booked but not yet picked up)
EXEC Reservation_Create '2026-04-27', '2026-05-04', 'Pending',  10001, 'ABC-1234', 1, 2, NULL,         NULL;
EXEC Reservation_Create '2026-04-28', '2026-05-05', 'Pending',  10003, 'JKL-3456', 3, 3, NULL,         NULL;
EXEC Reservation_Create '2026-04-30', '2026-05-07', 'Pending',  10004, 'MNO-7890', 2, 4, NULL,         NULL;
EXEC Reservation_Create '2026-05-01', '2026-05-08', 'Pending',  10005, 'STU-3344', 3, 1, NULL,         NULL;

-- Picked up (car is out, not yet returned)
EXEC Reservation_Create '2026-04-27', '2026-05-03', 'Pickedup', 10002, 'DEF-5678', 2, 1, NULL,         '2026-04-27';
EXEC Reservation_Create '2026-04-28', '2026-05-04', 'Pickedup', 10005, 'PQR-1122', 4, 4, NULL,         '2026-04-28';
EXEC Reservation_Create '2026-04-29', '2026-05-06', 'Pickedup', 10001, 'GHI-9012', 1, 3, NULL,         '2026-04-29';

-- Returned (completed rentals within the window)
EXEC Reservation_Create '2026-04-27', '2026-04-30', 'Returned', 10002, 'VWX-5566', 5, 2, '2026-04-30', '2026-04-27';
EXEC Reservation_Create '2026-04-28', '2026-05-01', 'Returned', 10003, 'STU-3344', 3, 1, '2026-05-01', '2026-04-28';
EXEC Reservation_Create '2026-04-29', '2026-05-02', 'Returned', 10004, 'ABC-1234', 1, 2, '2026-05-02', '2026-04-29';