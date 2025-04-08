---- Create Pro-category table first
--CREATE TABLE Pro_category (
--    Category_ID INT PRIMARY KEY,
--    Name NVARCHAR(255) NOT NULL
--);

---- Create Product table after Pro-category table
--CREATE TABLE Product (
--    P_ID INT PRIMARY KEY,
--    Name NVARCHAR(255) NOT NULL,
--    Price DECIMAL(10, 2) NOT NULL,
--    Description NVARCHAR(MAX),
--    Category_ID INT,
--    FOREIGN KEY (Category_ID) REFERENCES Pro_category(Category_ID)
--);

---- Create User table
--CREATE TABLE [User] (
--    User_ID INT PRIMARY KEY,
--    Name NVARCHAR(255) NOT NULL,
--    Email NVARCHAR(255) NOT NULL
--);

---- Create Address table
--CREATE TABLE Address (
--    Address_ID INT PRIMARY KEY,
--    Country NVARCHAR(255) NOT NULL,
--    State NVARCHAR(255) NOT NULL,
--    City NVARCHAR(255) NOT NULL,
--    Pin_code NVARCHAR(10) NOT NULL,
--    User_ID INT,
--    FOREIGN KEY (User_ID) REFERENCES [User](User_ID)
--);

---- Create Order table
--CREATE TABLE [Order] (
--    Order_No INT PRIMARY KEY,
--    Order_Amount DECIMAL(10, 2) NOT NULL,
--    Order_Date DATE NOT NULL,
--    User_ID INT,
--    Address_ID INT,
--    FOREIGN KEY (User_ID) REFERENCES [User](User_ID),
--    FOREIGN KEY (Address_ID) REFERENCES Address(Address_ID)
--);

---- Create Payment table
--CREATE TABLE Payment (
--    Payment_ID INT PRIMARY KEY,
--    Method NVARCHAR(50) NOT NULL,
--    Amount DECIMAL(10, 2) NOT NULL,
--    Order_No INT,
--    FOREIGN KEY (Order_No) REFERENCES [Order](Order_No)
--);

---- Create Tracking Detail table
--CREATE TABLE Tracking_Detail (
--    Tracking_ID INT PRIMARY KEY,
--    Status NVARCHAR(50) NOT NULL,
--    Order_No INT,
--    FOREIGN KEY (Order_No) REFERENCES [Order](Order_No)
--);

---- Create Cart table
--CREATE TABLE Cart (
--    Cart_ID INT PRIMARY KEY,
--    User_ID INT,
--    FOREIGN KEY (User_ID) REFERENCES [User](User_ID)
--);

---- Create CartItem table
--CREATE TABLE CartItem (
--    CartItem_ID INT PRIMARY KEY,
--    Cart_ID INT,
--    P_ID INT,
--    Quantity INT NOT NULL,
--    FOREIGN KEY (Cart_ID) REFERENCES Cart(Cart_ID),
--    FOREIGN KEY (P_ID) REFERENCES Product(P_ID)
--);

---- Insert data into Pro-category table
--INSERT INTO Pro_category (Category_ID, Name)
--VALUES
--(1, 'Electronics'),
--(2, 'Books'),
--(3, 'Clothing'),
--(4, 'Home & Kitchen'),
--(5, 'Sports'),
--(6, 'Toys'),
--(7, 'Beauty'),
--(8, 'Automotive'),
--(9, 'Health'),
--(10, 'Grocery');

---- Insert data into Product table
--INSERT INTO Product (P_ID, Name, Price, Description, Category_ID)
--VALUES
--(1, 'Smartphone', 69999.99, 'Latest model smartphone with advanced features', 1),
--(2, 'Laptop', 99999.99, 'High performance laptop for professionals', 1),
--(3, 'Books', 499.99, 'Bestselling fiction book', 2),
--(4, 'Jeans', 1999.99, 'Comfortable and stylish jeans', 3),
--(5, 'Blender', 2999.99, 'High-speed blender for smoothies', 4),
--(6, 'Football', 999.99, 'Official size football', 5),
--(7, 'Action Figure', 599.99, 'Popular action figure toy', 6),
--(8, 'Lipstick', 999.99, 'Long-lasting matte lipstick', 7),
--(9, 'Car Wax', 799.99, 'Premium car wax for shine', 8),
--(10, 'Vitamins', 1499.99, 'Daily multivitamin supplement', 9);

---- Insert data into User table
--INSERT INTO [User] (User_ID, Name, Email)
--VALUES
--(1, 'Praisy', 'praisy@example.com'),
--(2, 'Kavya', 'kavya@example.com'),
--(3, 'Sandeep', 'sandeep@example.com'),
--(4, 'Vishal', 'vishal@example.com'),
--(5, 'Naina', 'naina@example.com'),
--(6, 'Harshitha', 'harshitha@example.com'),
--(7, 'Omkar', 'omkar@example.com'),
--(8, 'Tanvi', 'tanvi@example.com'),
--(9, 'Nandhini', 'nandhina@example.com'),
--(10, 'Ramya', 'ramya@example.com');

---- Insert data into Address table
--INSERT INTO Address (Address_ID, Country, State, City, Pin_code, User_ID)
--VALUES
--(1, 'India', 'Maharashtra', 'Mumbai', '400001', 1),
--(2, 'India', 'Delhi', 'New Delhi', '110001', 2),
--(3, 'India', 'Karnataka', 'Bangalore', '560001', 3),
--(4, 'India', 'Tamil Nadu', 'Chennai', '600001', 4),
--(5, 'India', 'Gujarat', 'Ahmedabad', '380001', 5),
--(6, 'India', 'Uttar Pradesh', 'Lucknow', '226001', 6),
--(7, 'India', 'Rajasthan', 'Jaipur', '302001', 7),
--(8, 'India', 'West Bengal', 'Kolkata', '700001', 8),
--(9, 'India', 'Telangana', 'Hyderabad', '500001', 9),
--(10, 'India', 'Kerala', 'Thiruvananthapuram', '695001', 10);

---- Insert data into Order table
--INSERT INTO [Order] (Order_No, Order_Amount, Order_Date, User_ID, Address_ID)
--VALUES
--(1, 74999.98, '2025-04-01', 1, 1),
--(2, 101999.98, '2025-04-02', 2, 2),
--(3, 999.98, '2025-04-03', 3, 3),
--(4, 2999.98, '2025-04-04', 4, 4),
--(5, 2999.98, '2025-04-05', 5, 5),
--(6, 1999.98, '2025-04-06', 6, 6),
--(7, 599.98, '2025-04-07', 7, 7),
--(8, 999.98, '2025-04-08', 8, 8),
--(9, 799.98, '2025-04-09', 9, 9),
--(10, 1499.98, '2025-04-10', 10, 10);

---- Insert data into Payment table
--INSERT INTO Payment (Payment_ID, Method, Amount, Order_No)
--VALUES
--(1, 'Credit Card', 74999.98, 1),
--(2, 'UPI', 101999.98, 2),
--(3, 'Credit Card', 999.98, 3),
--(4, 'UPI', 2999.98, 4),
--(5, 'Credit Card', 2999.98, 5),
--(6, 'UPI', 1999.98, 6),
--(7, 'Credit Card', 599.98, 7),
--(8, 'UPI', 999.98, 8),
--(9, 'Credit Card', 799.98, 9),
--(10, 'UPI', 1499.98, 10);

---- Insert data into Tracking Detail table
--INSERT INTO Tracking_Detail (Tracking_ID, Status, Order_No)
--VALUES
--(1, 'On the way', 1),
--(2, 'Delivered', 2),
--(3, 'On the way', 3),
--(4, 'Delivered', 4),
--(5, 'On the way', 5),
--(6, 'Delivered', 6),
--(7, 'On the way', 7),
--(8, 'Delivered', 8),
--(9, 'On the way', 9),
--(10, 'Delivered', 10);

---- Insert data into Cart table
--INSERT INTO Cart (Cart_ID, User_ID)
--VALUES
--(1, 1),
--(2, 2),
--(3, 3),
--(4, 4),
--(5, 5),
--(6, 6),
--(7, 7),
--(8, 8),
--(9, 9),
--(10, 10);

---- Insert data into CartItem table
--INSERT INTO CartItem (CartItem_ID, Cart_ID, P_ID, Quantity)
--VALUES
--(1, 1, 1, 1),
--(2, 1, 2, 1),
--(3, 2, 3, 1),
--(4, 2, 4, 2),
--(5, 3, 5, 1),
--(6, 3, 6, 1),
--(7, 4, 7, 1),
--(8, 4, 8, 1),
--(9, 5, 9, 1),
--(10, 5, 10, 1);


SELECT 
    P1.P_ID AS ProductID1,
    P1.Name AS ProductName1,
    P2.P_ID AS ProductID2,
    P2.Name AS ProductName2,
    P1.Price
FROM 
    Product P1
INNER JOIN 
    Product P2 ON P1.Category_ID = P2.Category_ID or P1.Price = P2.Price
WHERE 
    P1.P_ID <> P2.P_ID;

SELECT 
    Product.P_ID,
    Product.Name AS ProductName,
    Product.Price,
    Pro_category.Name AS CategoryName
FROM 
    Product
LEFT JOIN 
    Pro_category ON Product.Category_ID = Pro_category.Category_ID;

SELECT 
    Product.P_ID,
    Product.Name AS ProductName,
    Product.Price,
    Pro_category.Name AS CategoryName
FROM 
    Product
RIGHT JOIN 
    Pro_category ON Product.Category_ID = Pro_category.Category_ID;
