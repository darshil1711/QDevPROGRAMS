CREATE DATABASE Employee

USE Employee
GO

create table Hobby(
Id int primary key,
Name Varchar(20)
)

create table Employee(
Id int primary key,
FirstName VARCHAR(10),
LastName VARCHAR(10),
Age int,
MobileNumber VARCHAR(15),
Address VARCHAR(50)
)

CREATE TABLE EmployeeSalary (
Id INT PRIMARY KEY,
EmployeeId INT,
Salary DECIMAL(10, 2),
Date DATE,
FOREIGN KEY (EmployeeId) REFERENCES Employee(Id)
)

CREATE TABLE EmployeeHobby (
Id INT PRIMARY KEY,
EmployeeId INT,
HobbyId INT,
FOREIGN KEY (EmployeeId) REFERENCES Employee(Id),
FOREIGN KEY (HobbyId) REFERENCES Hobby(Id)
);

INSERT INTO Hobby(ID,Name) VALUES ('1','Sports')
INSERT INTO Hobby(ID,Name) VALUES ('2','Reading')
INSERT INTO Hobby(ID,Name) VALUES ('3','Games')
INSERT INTO Hobby(ID,Name) VALUES ('4','Singing')
INSERT INTO Hobby(ID,Name) VALUES ('5','Travel')

Select * From Hobby

INSERT INTO Employee(Id,FirstName,LastName,Age,MobileNumber,Address) VALUES ('1','Darshil','Panchani','21','9104481102','Ahmedabad')
INSERT INTO Employee(Id,FirstName,LastName,Age,MobileNumber,Address) VALUES ('2','Keval','Vasoya','24','8141215163','Surat')
INSERT INTO Employee(Id,FirstName,LastName,Age,MobileNumber,Address) VALUES ('3','Smit','Jogani','22','8798562314','Raipur')
INSERT INTO Employee(Id,FirstName,LastName,Age,MobileNumber,Address) VALUES ('4','Harshil','Patel','30','7152634896','Kanpur')
INSERT INTO Employee(Id,FirstName,LastName,Age,MobileNumber,Address) VALUES ('5','Madhav','Patel','36','7698981918','Ahmedabad')

Select * From Employee

INSERT INTO EmployeeSalary(Id,EmployeeId,Salary,Date) VALUES ('1','1','25000','1/09/2023')
INSERT INTO EmployeeSalary(Id,EmployeeId,Salary,Date) VALUES ('2','2','24500','1/08/2022')
INSERT INTO EmployeeSalary(Id,EmployeeId,Salary,Date) VALUES ('3','3','18000','10/01/2023')
INSERT INTO EmployeeSalary(Id,EmployeeId,Salary,Date) VALUES ('4','4','35000','6/09/2023')
INSERT INTO EmployeeSalary(Id,EmployeeId,Salary,Date) VALUES ('5','5','20000','10/07/2023')

Select * From EmployeeSalary

INSERT INTO EmployeeHobby(Id, EmployeeId, HobbyId) VALUES ('1','1','1')
INSERT INTO EmployeeHobby(Id, EmployeeId, HobbyId) VALUES ('2','2','2')
INSERT INTO EmployeeHobby(Id, EmployeeId, HobbyId) VALUES ('3','3','3')
INSERT INTO EmployeeHobby(Id, EmployeeId, HobbyId) VALUES ('4','4','4')
INSERT INTO EmployeeHobby(Id, EmployeeId, HobbyId) VALUES ('5','5','5')

Select * From  EmployeeHobby

UPDATE Hobby SET Name = 'Singing' WHERE Id = 1;
UPDATE Hobby SET Name = 'Sports' WHERE Id = 4;

UPDATE Employee SET Address = 'Nikol'  WHERE Id = 1;
UPDATE Employee SET  LastName = 'Zala' WHERE Id = 4;

UPDATE EmployeeSalary SET Salary = '26000'  WHERE Id = 5;
UPDATE EmployeeSalary SET  Salary = '50000' WHERE Id = 1;

UPDATE EmployeeHobby SET HobbyId = '2'  WHERE Id = 3;
UPDATE EmployeeHobby SET  HobbyId = '3' WHERE Id = 1;

DELETE FROM Hobby WHERE ID = 4;
DELETE FROM Hobby WHERE ID = 5;

DELETE FROM Employee WHERE Id = 4;
DELETE FROM Employee WHERE Id = 5;

DELETE FROM EmployeeSalary WHERE Id = 4;
DELETE FROM EmployeeSalary WHERE Id = 5;

DELETE FROM EmployeeHobby WHERE Id = 4;
DELETE FROM EmployeeHobby WHERE Id = 5;

TRUNCATE TABLE Hobby
TRUNCATE TABLE Employee
TRUNCATE TABLE EmployeeSalary
TRUNCATE TABLE EmployeeHobby

SELECT * FROM Hobby WHERE Id = 1;
SELECT * FROM Employee WHERE Id = 1;
SELECT * FROM EmployeeSalary WHERE Id = 1;
SELECT * FROM EmployeeHobby WHERE Id = 1;

SELECT Id AS 'Id',FirstName AS 'Employee Name and Hobby Name' FROM Employee
UNION ALL
SELECT Id AS 'Id',Name  FROM Hobby;

SELECT e.FirstName AS 'Employee Name', es.Salary AS 'Employee Salary'
FROM Employee e
JOIN EmployeeSalary es ON e.Id = es.EmployeeId;

Select Employee.FirstName,EmployeeSalary.Salary,Hobby.NameFrom  Employee	JOIN EmployeeSalary     ON (EmployeeSalary.Id = Employee.Id)	JOIN Hobby    ON (Hobby.Id = Employee.Id)
   
