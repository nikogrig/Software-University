DROP DATABASE Employees

CREATE DATABASE Employees
COLLATE Cyrillic_General_100_CI_AI

USE Bank

CREATE TABLE Employees
(
	Id INT IDENTITY PRIMARY KEY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Salary DECIMAL(15, 2) CHECK (Salary > 0) NOT NULL,
	Email VARCHAR(50) UNIQUE NOT NULL,
	IsEmployed BIT DEFAULT 'True' NOT NULL,
	HireDate DATE DEFAULT GETDATE(),
)
	
DROP TABLE Employees

USE Employees

SELECT * FROM Employees

USE Bank

TRUNCATE TABLE Accounts

SELECT * FROM Accounts

ALTER TABLE Employees
ADD DEFAULT True
FOR IsEmployed
