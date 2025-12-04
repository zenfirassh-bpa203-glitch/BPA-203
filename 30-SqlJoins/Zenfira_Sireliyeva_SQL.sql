use Company

CREATE TABLE Countries(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50)
);

INSERT INTO Countries (Name) VALUES
('Azerbaijan'),
('Turkey'),
('Germany');


CREATE TABLE Cities(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50),
    CountryId INT FOREIGN KEY REFERENCES Countries(Id)
);

INSERT INTO Cities (Name, CountryId) VALUES
('Baku', 1),
('Ganja', 1),
('Istanbul', 2),
('Ankara', 2),
('Berlin', 3),
('Munich', 3);


CREATE TABLE Employees2(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50),
    Surname NVARCHAR(50),
    Age INT,
    Salary DECIMAL(10,2),
    Position NVARCHAR(50),
    CityId INT FOREIGN KEY REFERENCES Cities(Id),
    IsDeleted BIT
);

INSERT INTO Employees2 (Name, Surname, Age, Salary, Position, CityId, IsDeleted) VALUES
('Ali', 'Aliyev', 25, 1800, 'Developer', 1, 0),
('Nigar', 'Huseynova', 30, 2500, 'Manager', 1, 0),
('Ramil', 'Mammadov', 28, 2200, 'Reseption', 2, 0),
('Elvin', 'Quliyev', 35, 1500, 'Reseption', 3, 0),
('Aysel', 'Ismayilova', 29, 3000, 'Developer', 4, 0),
('Tural', 'Suleymanov', 40, 1700, 'Driver', 5, 1),  
('Leyla', 'Rahimova', 32, 2100, 'Manager', 6, 1);    


SELECT 
    e.Name,
    e.Surname,
    c.Name AS City,
    co.Name AS Country
FROM Employees2 e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id;

SELECT 
    e.Name,
    e.Surname,
    co.Name AS Country,
    e.Salary
FROM Employees2 e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id
WHERE e.Salary > 2000;


SELECT 
    c.Name AS City,
    co.Name AS Country
FROM Cities c
JOIN Countries co ON c.CountryId = co.Id;


SELECT 
    e.Name,
    e.Surname,
    e.Age,
    e.Salary,
    e.Position,
    c.Name AS City,
    co.Name AS Country,
    e.IsDeleted
FROM Employees2 e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id
WHERE e.Position = 'Reseption';



SELECT
    e.Name,
    e.Surname,
    c.Name AS City,
    co.Name AS Country
FROM Employees2 e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id
WHERE e.IsDeleted = 1;

