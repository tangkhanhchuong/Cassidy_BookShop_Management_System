CREATE DATABASE QLNS
GO

USE QLNS
GO

--BOOK
--USER
--EXPENSE
--ORDER
--CUSTOMER

CREATE TABLE BOOKS
(
	ID INT IDENTITY PRIMARY KEY,
	BOOKTITLE VARCHAR(100),
	AUTHOR VARCHAR(100),
	STOCK INT,
	COST FLOAT NOT NULL,
	PRICE FLOAT NOT NULL,
)
GO

CREATE TABLE USERS
(
	ID INT IDENTITY PRIMARY KEY,
	FIRSTNAME VARCHAR(100),
	LASTNAME VARCHAR(100),
	PHONE VARCHAR(5),
	EMAIL VARCHAR(50),	
)
GO

CREATE TABLE ACCOUNT
(
	USERNAME VARCHAR(100) PRIMARY KEY,
	PASSWORD VARCHAR(100),
	USERSID INT FOREIGN KEY REFERENCES USERS(ID)
)
GO

CREATE TABLE CUSTOMERS
(
	ID INT IDENTITY PRIMARY KEY,
	FULLNAME VARCHAR(100),
	PHONE CHAR(12), 
	EMAIL VARCHAR(100),
	ADDRESS VARCHAR(100),
	CITY VARCHAR(100),
	COUNTRY VARCHAR(100)
)
GO

CREATE TABLE EXPENSES
(
	ID INT IDENTITY PRIMARY KEY,
	TITLE VARCHAR(100),
	AMOUNT FLOAT,
	DATE SMALLDATETIME NOT NULL,
	DESCRIPTION VARCHAR(200)
)
GO

CREATE TABLE ORDERS
(
	ID INT IDENTITY PRIMARY KEY,
	DATE SMALLDATETIME,
	CUSTOMERSID INT FOREIGN KEY REFERENCES CUSTOMERS(ID),
	DISCOUNT FLOAT DEFAULT 0,
	TOTAL FLOAT
)
GO

CREATE TABLE CART
(
	ORDERID INT FOREIGN KEY REFERENCES ORDERS,
	BOOKID INT FOREIGN KEY REFERENCES BOOKS,
	QUANTITY INT,
	PRICE FLOAT,
	TOTAL AS (QUANTITY * PRICE) PERSISTED

)
GO

--Login Procedure

CREATE PROC USP_Login
@username nvarchar(100), @password nvarchar(100)
AS
BEGIN
	SELECT * FROM ACCOUNT WHERE USERNAME = @username AND PASSWORD = @password
END 
GO

--Add Order Procedure

CREATE PROC USP_AddNewOrder
AS
BEGIN
	INSERT INTO ORDERS DEFAULT VALUES
END
GO

--Add To Cart Procedure

CREATE PROC USP_AddToCart
@orderID INT,@bookID INT, @quantity INT, @price FLOAT
AS
BEGIN

	DECLARE @isExistsItem INT
	DECLARE @itemQuantity INT = 1

	--Kiem tra ton tai bookID trong cart

	SELECT @isExistsItem = CART.ID, @itemQuantity = QUANTITY
	FROM CART
	WHERE ORDERID = @orderID AND BOOKID = @bookID

	IF(@isExistsItem > 0)
	BEGIN
		DECLARE @newQuantity INT = @itemQuantity + @quantity
		IF(@newQuantity > 0)
			UPDATE CART
			SET QUANTITY = @itemQuantity + @quantity
			WHERE BOOKID = @bookID
		ELSE
			DELETE CART WHERE ORDERID = @orderID AND BOOKID = @bookID
	END

	ELSE
	BEGIN
		INSERT INTO CART(ORDERID,BOOKID,QUANTITY,PRICE)
		VALUES(@orderID, @bookID, @quantity, @price)
	END
END
GO

--Update Storage Procedure

CREATE PROC USP_UpdateStorage
@bookID INT, @remain INT
AS
BEGIN
	UPDATE BOOKS
	SET STOCK = @remain
	WHERE ID = @bookID
END

INSERT INTO BOOKS
VALUES ('Catcher In The Rye', 'J.D Sallinger', 1000, 15, 17)

INSERT INTO BOOKS
VALUES ('To Kill A Mocking Bird', 'Harper Lee', 500, 20, 25)

SELECT * FROM BOOKS
 

INSERT INTO USERS
VALUES ('Finn', 'Truong','0909123456','finn@gmail.com','Employee')

INSERT INTO USERS
VALUES ('Harry', 'Kewell','0909123433','hk@gmail.com','Employee')

SET IDENTITY_INSERT ACCOUNT ON

INSERT INTO ACCOUNT(USERNAME,PASSWORD,USERSID) 
VALUES('Finn', 'pass123',1)

INSERT INTO ACCOUNT(USERNAME,PASSWORD,USERSID) 
VALUES('HK', 'pass123',2)

SELECT * FROM ACCOUNT

SELECT * FROM ACCOUNT WHERE USERNAME = N'Finn' AND PASSWORD = N'pass123'

SELECT FIRSTNAME FROM ACCOUNT JOIN USERS ON USERSID = ID WHERE USERNAME = N'Finn' AND PASSWORD = N'pass123'

GO




SELECT * FROM ORDERS
SELECT * FROM BOOKS
SELECT * FROM CUSTOMERS

DBCC CHECKIDENT ('CUSTOMERS',RESEED,0)
DBCC CHECKIDENT ('ORDERS',RESEED,0)

INSERT INTO CUSTOMERS(FULLNAME,PHONE,EMAIL,ADDRESS,CITY,COUNTRY)
VALUES('Customer 1','0123456789','customer@gmail.com','101 Sans','Transylvania','Romania')

INSERT INTO CUSTOMERS(FULLNAME,PHONE,EMAIL,ADDRESS,CITY,COUNTRY)
VALUES('Customer 2','0123456189','customer2@gmail.com','102 Sans','Transylvania','Romania')





SELECT * FROM BOOKS WHERE ID = 3
SELECT * FROM ORDERS
SELECT * FROM CART

INSERT INTO CART(BOOKID, QUANTITY,PRICE)
VALUES (1, 2, 17)

SELECT BOOKTITLE, QUANTITY, B.PRICE, TOTAL
FROM BOOKS B JOIN CART C ON B.ID = C.BOOKID 

SELECT * FROM ORDERS
INSERT INTO ORDERS(DATE)
VALUES(GETDATE())

DELETE FROM CART
SELECT * FROM CART

SELECT MAX(id) FROM ORDERS

INSERT INTO ORDERS DEFAULT VALUES
SELECT * FROM ORDERS

EXEC USP_AddNewOrder

SELECT * FROM CART
SELECT * FROM ORDERS
GO

ALTER PROC USP_AddToCart
@orderID INT,@bookID INT, @quantity INT, @price FLOAT
AS
BEGIN

	DECLARE @isExistsItem INT
	DECLARE @itemQuantity INT = 1

	--Kiem tra ton tai bookID trong cart

	SELECT @isExistsItem = CART.ID, @itemQuantity = QUANTITY
	FROM CART
	WHERE ORDERID = @orderID AND BOOKID = @bookID

	IF(@isExistsItem > 0)
	BEGIN
		DECLARE @newQuantity INT = @itemQuantity + @quantity
		IF(@newQuantity > 0)
			UPDATE CART
			SET QUANTITY = @itemQuantity + @quantity
			WHERE BOOKID = @bookID
		ELSE
			DELETE CART WHERE ORDERID = @orderID AND BOOKID = @bookID
	END

	ELSE
	BEGIN
		INSERT INTO CART(ORDERID,BOOKID,QUANTITY,PRICE)
		VALUES(@orderID, @bookID, @quantity, @price)
	END
END
GO

ALTER TABLE CART
ADD ID INT IDENTITY PRIMARY KEY

SELECT *
FROM CART

SELECT * FROM ORDERS
DELETE FROM ORDERS

DELETE FROM CART

EXEC USP_AddNewOrder

SELECT MAX(ID) FROM ORDERS


SELECT * FROM CART

DELETE FROM CART
WHERE BOOKID = 1

DELETE FROM CART
DELETE FROM ORDERS

SELECT SUM(TOTAL) FROM CART WHERE ORDERID = 2
SELECT * FROM BOOKS
SELECT * FROM EXPENSES

INSERT INTO EXPENSES(TITLE, AMOUNT, DATE, DESCRIPTION)
VALUES('Books',1000,GETDATE(),'50 book')

UPDATE EXPENSES
SET TITLE = 'Book', AMOUNT = 100, DATE = '11/09/2019' 
WHERE ID = 1

ALTER TABLE USERS
DROP COLUMN ROLE

SELECT * FROM BOOKS WHERE BOOKTITLE LIKE 'Catcher In The Rye'

SELECT TITLE,AMOUNT,DATE,DESCRIPTION FROM EXPENSES

SELECT * FROM ACCOUNT
SELECT * FROM USERS
INSERT INTO ACCOUNT(USERNAME,PASSWORD)
VALUES('Adam','1')

SELECT * FROM ACCOUNT WHERE USERNAME

SELECT MAX(ID) FROM USERS

SELECT * FROM USERS
INSERT INTO USERS(FIRSTNAME,LASTNAME,PHONE,EMAIL)
VALUES('Adam', 'Scott', '0909123456', 'scott@gmail.com')

SELECT MAX(ID) FROM USERS

SELECT * FROM ACCOUNT
SELECT * FROM USERS
INSERT INTO ACCOUNT VALUES('Stan','pass123',4)

ALTER TABLE ACCOUNT
ADD USERSID INT FOREIGN KEY REFERENCES USERS(ID)

SELECT * FROM ACCOUNT WHERE USERNAME = 'A'

SELECT CONCAT(FIRSTNAME,' ',LASTNAME)
FROM USERS

SELECT * FROM USERS WHERE CONCAT(FIRSTNAME,' ',LASTNAME) LIKE '%A%'

SELECT ID FROM BOOKS WHERE BOOKTITLE LIKE '%A%'

SELECT * FROM CART

SELECT SUM(TOTAL) AS TOTAL FROM CART WHERE ORDERID = 2

DELETE FROM CART
WHERE ORDERID = 2

SELECT SUM(TOTAL) FROM CART WHERE ORDERID = 2

SELECT * FROM CUSTOMERS

SELECT FIRSTNAME FROM ACCOUNT JOIN USERS ON USERSID = ID WHERE USERNAME = N'Finn' AND PASSWORD = N'pass123'

SELECT * FROM ACCOUNT JOIN USERS ON USERSID = ID

SELECT * FROM ACCOUNT

SELECT * FROM USERS

DELETE FROM USERS WHERE ID = 21

DELETE FROM ACCOUNT WHERE USERSID = 21

ALTER TABLE CUSTOMERS
DROP COLUMN COUNTRY

SELECT * FROM CUSTOMERS
WHERE ID LIKE '%0%' OR FULLNAME LIKE '%w%' OR PHONE LIKE 'a' OR EMAIL LIKE 'a' OR ADDRESS LIKE 'a' OR CITY LIKE 'a'

SELECT * FROM CUSTOMERS WHERE EMAIL = 'customer@gmail.com'
SELECT * FROM ORDERS
SELECT * FROM CART WHERE ORDERID = 2

SELECT * FROM ORDERS
ALTER TABLE ORDERS
ADD STATUS INT DEFAULT 0
Go
DELETE FROM ORDERS WHERE ID = 2
DELETE FROM CART WHERE ORDERID = 2

SELECT * FROM ORDERS O JOIN CUSTOMERS C ON O.CUSTOMERSID= C.ID 

ALTER TABLE CUSTOMERS
ALTER COLUMN PHONE VARCHAR(15)

SELECT * FROM CUSTOMERS

INSERT INTO CUSTOMERS(FULLNAME, PHONE, EMAIL, ADDRESS, CITY)
VALUES(N'Finn Truong', '0123456789', 'tmhieu00@gmail.com', '170 Charity Cross', 'London')

SELECT * FROM EXPENSES