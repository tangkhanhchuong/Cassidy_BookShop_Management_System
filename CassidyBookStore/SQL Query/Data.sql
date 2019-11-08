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
	QUANTITY INT,
	COST FLOAT NOT NULL,
	PRICE FLOAT NOT NULL,
)
GO

CREATE TABLE USERS
(
	ID INT IDENTITY PRIMARY KEY,
	FIRSTNAME VARCHAR(100),
	LASTNAME VARCHAR(100),
	PHONE CHAR(12),
	EMAIL VARCHAR(50),
	ROLE VARCHAR(50),
)
GO

CREATE TABLE ACCOUNT
(
	USERNAME VARCHAR(100) PRIMARY KEY,
	PASSWORD VARCHAR(100),
	USERSID INT IDENTITY FOREIGN KEY REFERENCES USERS(ID)
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
	BOOKID INT FOREIGN KEY REFERENCES BOOKS,
	QUANTITY INT,
	DISCOUNT FLOAT DEFAULT 0,
	TOTAL FLOAT
)
GO