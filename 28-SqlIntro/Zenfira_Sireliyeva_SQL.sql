create database Company
use Company
create table Employees(
EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
FirstName NVARCHAR(50),
LastName NVARCHAR(50),
Email NVARCHAR(100),
PhoneNumber NVARCHAR(20),
HireDate DATE,
JobTitle NVARCHAR(50),
Salary DECIMAL(10,2),
Department NVARCHAR(50)
);

INSERT INTO Employees (FirstName, LastName, Email, PhoneNumber, HireDate, JobTitle, Salary, Department)
VALUES
('Zema', 'Sireliyeva', 'zema@company.az', '0501234567', '2019-03-12', 'Developer', 2500, 'IT'),
('Aytac', 'Qeribova', 'aytac@company.az', '0519876543', '2021-06-20', 'HR Specialist', 1800, 'HR'),
('Elyana', 'Alizade', 'elyana@company.az', '0705558899', '2018-11-05', 'Accountant', 2200, 'Finance'),
('Fidan', 'Qasimova', 'fidan@company.az', '0557771122', '2022-01-10', 'HR Assistant', 1600, 'HR'),
('Nermin', 'Zeynalli', 'nermin@company.az', '0774443322', '2017-09-18', 'System Administrator', 2800, 'IT');

SELECT * FROM Employees;

SELECT * FROM Employees
WHERE Salary > 2000;

SELECT * FROM Employees
WHERE Department = 'IT';

SELECT * FROM Employees
ORDER BY Salary DESC;

SELECT FirstName, Salary FROM Employees;

SELECT * FROM Employees
WHERE HireDate > '2020-01-01';


SELECT * FROM Employees
WHERE Email LIKE '%company.az%';


SELECT MAX(Salary) AS HighestSalary FROM Employees;

SELECT MIN(Salary) AS LowestSalary FROM Employees;

SELECT AVG(Salary) AS AverageSalary FROM Employees;

SELECT SUM(Salary) AS TotalSalaries FROM Employees;


SELECT Department, COUNT(*) AS EmployeeCount
FROM Employees
GROUP BY Department;

SELECT Department, AVG(Salary) AS AvgSalary
FROM Employees
GROUP BY Department;

SELECT Department, MAX(Salary) AS MaxSalary
FROM Employees
GROUP BY Department;

UPDATE Employees
SET Salary = 2800
WHERE EmployeeID = 1;

UPDATE Employees
SET Salary = Salary * 1.10
WHERE Department = 'IT';

UPDATE Employees
SET JobTitle = 'HR Meneceri'
WHERE FirstName = 'Fidan' AND LastName = 'Qasimova';

DELETE FROM Employees
WHERE EmployeeID = 5;


INSERT INTO Employees (FirstName, LastName, Email, PhoneNumber, HireDate, JobTitle, Salary, Department)
VALUES ('Test', 'Worker', 'test@company.az', '0000000000', '2024-01-01', 'Intern', 1400, 'IT');

DELETE FROM Employees
WHERE Salary < 1500;

SELECT * FROM Employees
WHERE FirstName LIKE '%a%';

SELECT * FROM Employees
WHERE Salary BETWEEN 2000 AND 2500;

SELECT * FROM Employees
WHERE Department IN ('Finance', 'IT');

