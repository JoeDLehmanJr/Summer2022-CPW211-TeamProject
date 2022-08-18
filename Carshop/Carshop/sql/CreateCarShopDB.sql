USE master;
-- Delete existing Database if exists and needs removal.
DROP DATABASE IF EXISTS Carshop;
GO
--------------------------------------------------------

-- Initialize Carshop Database

CREATE DATABASE Carshop;
GO

USE Carshop;
GO

-- Create Table AutoShop

CREATE TABLE AutoShop
(
	autoShopId int PRIMARY KEY IDENTITY (1,1) NOT NULL
	,Make varchar(40) 
	,Model varchar(40) 
	,releaseYear datetime 
	,userStatus varchar(85)	
)

CREATE TABLE Customers(
	customersId int PRIMARY KEY IDENTITY (1,1) NOT NULL
	,firstName varchar(25)
	,lastName varchar(25)
	,payment float


);

CREATE TABLE PaymentType(
	PaymentId int PRIMARY KEY IDENTITY (1,1) NOT NULL
	,cardType varchar(25)
	,cardNumber int
	,dateOfExpiration datetime
	,cvs int
	,authorizationNumber int


);

CREATE TABLE Job(
	jobId int PRIMARY KEY IDENTITY (1,1) NOT NULL
	,jobCategory varchar(25)


);

CREATE TABLE JobItemization(
	jobItemizationId int PRIMARY KEY IDENTITY (1,1) NOT NULL
	,jobType varchar(40)
	,itemCost float
);

ALTER TABLE AutoShop
ADD customersId int NOT NULL REFERENCES Customers(customersId)
ALTER TABLE AutoShop
ADD jobId int NOT NULL REFERENCES Job(jobId);

ALTER TABLE Customers
ADD paymentId int NOT NULL REFERENCES PaymentType(paymentId);

ALTER TABLE Job
ADD jobItemizationId int NOT NULL REFERENCES JobItemization(jobItemizationId);