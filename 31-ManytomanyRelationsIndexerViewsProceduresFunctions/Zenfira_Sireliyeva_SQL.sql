---------------------------------------------------------+
-- DATABASE
---------------------------------------------------------
CREATE DATABASE CompanyMM;
USE CompanyMM;

---------------------------------------------------------
-- TABLES
---------------------------------------------------------

-- Employees
CREATE TABLE Employees (
    EmployeeID INT identity PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName  VARCHAR(50) NOT NULL,
    BirthDate DATE NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    CHECK (BirthDate < '2010-01-01')
);

-- Projects
CREATE TABLE Projects (
    ProjectID INT identity PRIMARY KEY,
    ProjectName VARCHAR(100) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate   DATE,
    CHECK (EndDate IS NULL OR EndDate >= StartDate)
);

-- EmployeeProjects (Many-to-Many)
CREATE TABLE EmployeeProjects (
    EmployeeID INT NOT NULL,
    ProjectID  INT NOT NULL,
    AssignedDate DATE NOT NULL,

    PRIMARY KEY (EmployeeID, ProjectID),

    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
        ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID)
        ON DELETE CASCADE ON UPDATE CASCADE
);

---------------------------------------------------------
-- INSERT DATA 
---------------------------------------------------------

INSERT INTO Employees (FirstName, LastName, BirthDate, Email) VALUES
('Zema',   'Aliyeva',  '1992-03-15', 'zema@example.com'),
('Elyana', 'Huseynli', '1994-06-21', 'elyana@example.com'),
('Aytac',  'Mammadova','1991-01-10', 'aytac@example.com'),
('S',      'Quliyev',  '1990-09-19', 's@example.com'),
('Murad',  'Mehdiyev', '1987-04-14', 'murad@example.com');

INSERT INTO Projects (ProjectName, StartDate, EndDate) VALUES
('CRM Development',  '2024-01-01', NULL),
('Mobile App',       '2024-02-15', '2024-12-31'),
('Data Migration',   '2024-03-10', NULL);

INSERT INTO EmployeeProjects (EmployeeID, ProjectID, AssignedDate) VALUES
(1, 1, '2024-04-01'),
(1, 2, '2024-04-10'),
(2, 1, '2024-04-03'),
(3, 3, '2024-04-05'),
(4, 1, '2024-04-08'),
(5, 2, '2024-05-01');

---------------------------------------------------------
-- SELECT QUERIES
---------------------------------------------------------

-- 1. All employees
SELECT * FROM Employees;

-- 2. All projects
SELECT * FROM Projects;

-- 3. Employees with projects
SELECT e.EmployeeID, e.FirstName, e.LastName, p.ProjectName, ep.AssignedDate
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON p.ProjectID = ep.ProjectID;

-- 4. Project employee counts
SELECT p.ProjectName, COUNT(ep.EmployeeID) AS EmployeeCount
FROM Projects p
LEFT JOIN EmployeeProjects ep ON p.ProjectID = ep.ProjectID
GROUP BY p.ProjectID, p.ProjectName;

-- 5. Employees working in more than 2 projects
SELECT e.EmployeeID, e.FirstName, e.LastName, COUNT(ep.ProjectID) AS ProjectCount
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(ep.ProjectID) > 2;

---------------------------------------------------------
-- VIEW
---------------------------------------------------------

CREATE  VIEW EmployeeProjectView AS
SELECT 
    e.EmployeeID,
    CONCAT(e.FirstName, ' ', e.LastName) AS FullName,
    p.ProjectID,
    p.ProjectName,
    ep.AssignedDate
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON p.ProjectID = ep.ProjectID;

-- View for EmployeeID = 1
SELECT * FROM EmployeeProjectView WHERE EmployeeID = 1;

---------------------------------------------------------
-- STORED PROCEDURE
CREATE PROCEDURE sp_AssignEmployeeToProject(
    IN empId INT,
    IN projId INT
)
BEGIN
    DECLARE existingCount INT;

    SELECT COUNT(*)
    INTO existingCount
    FROM EmployeeProjects
    WHERE EmployeeID = empId
      AND ProjectID = projId;

    IF existingCount = 0 THEN
        INSERT INTO EmployeeProjects(EmployeeID, ProjectID, AssignedDate)
        VALUES (empId, projId, CURDATE());
    END IF;
END //
---------------------------------------------------------
-- FUNCTION
---------------------------------------------------------



CREATE FUNCTION fn_GetProjectCount(empId INT)
RETURNS INT
DETERMINISTIC
BEGIN
    DECLARE projCount INT;
    SELECT COUNT(*) INTO projCount
    FROM EmployeeProjects
    WHERE EmployeeID = empId;
    RETURN projCount;
END 



-- Call function
SELECT fn_GetProjectCount(1) AS ProjectsForEmp1;

---------------------------------------------------------


-- New assignment via procedure
CALL sp_AssignEmployeeToProject(3, 1);

-- Check result
SELECT * FROM EmployeeProjects WHERE EmployeeID = 3;

-- Delete all projects of an employee
DELETE FROM EmployeeProjects WHERE EmployeeID = 3;
