-- DATABASE COMMANDS

-- Syntax: CREATE DATABASE database_name;
CREATE DATABASE Training;

-- Syntax: USE database_name;
USE Training;


-- DATA DEFINITION LANGUAGE (DDL)

-- Syntax: CREATE TABLE table_name (column datatype constraints);
CREATE TABLE Students (
    ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

-- Syntax: ALTER TABLE table_name ADD column datatype;
ALTER TABLE Students ADD Age INT;

-- Syntax: DROP TABLE table_name;
-- DROP TABLE Students;


-- DATA MANIPULATION LANGUAGE (DML)

-- Syntax: INSERT INTO table_name (columns) VALUES (values);
INSERT INTO Students (ID, Name, Age) VALUES (1, 'Arjun', 20);

-- Syntax: UPDATE table_name SET column = value WHERE condition;
UPDATE Students SET Age = 21 WHERE ID = 1;

-- Syntax: DELETE FROM table_name WHERE condition;
DELETE FROM Students WHERE ID = 1;


-- DATA QUERY LANGUAGE (DQL)

-- Syntax: INSERT INTO table_name (columns) VALUES (values);
INSERT INTO Students (ID, Name, Age) VALUES (1, 'Arjun', 20);
INSERT INTO Students (ID, Name, Age) VALUES (2, 'Priya', 21);
INSERT INTO Students (ID, Name, Age) VALUES (3, 'Rahul', 19);
INSERT INTO Students (ID, Name, Age) VALUES (4, 'Sneha', 22);
INSERT INTO Students (ID, Name, Age) VALUES (5, 'Karan', 20);

-- Syntax: SELECT * FROM table_name;
SELECT * FROM Students;

-- Syntax: SELECT columns FROM table_name WHERE condition;
SELECT Name, Age FROM Students WHERE Age > 18;


-- DATA CONTROL LANGUAGE (DCL)

-- Syntax: GRANT privilege ON object TO user;
GRANT SELECT ON Students TO user_name;

-- Syntax: REVOKE privilege ON object FROM user;
REVOKE SELECT ON Students FROM user_name;


-- TRANSACTION CONTROL LANGUAGE (TCL)

-- Syntax: BEGIN TRANSACTION;
BEGIN;

-- Syntax: UPDATE table_name SET column = value WHERE condition;
UPDATE Students SET Age = 25 WHERE ID = 2;

-- Syntax: SAVEPOINT savepoint_name;
SAVEPOINT sp1;

-- Syntax: UPDATE table_name SET column = value WHERE condition;
UPDATE Students SET Age = 30 WHERE ID = 3;

-- Syntax: ROLLBACK TO savepoint_name;
ROLLBACK TO sp1;

-- Syntax: COMMIT;
COMMIT;


-- TABLE FOR JOIN OPERATIONS

-- Syntax: CREATE TABLE table_name with FOREIGN KEY
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    StudentID INT,
    CourseName VARCHAR(50),
    Marks INT,
    FOREIGN KEY (StudentID) REFERENCES Students(ID)
);

-- Syntax: INSERT INTO table_name (columns) VALUES (values);
INSERT INTO Courses (CourseID, StudentID, CourseName, Marks)
VALUES (101, 1, 'Math', 85);

INSERT INTO Courses (CourseID, StudentID, CourseName, Marks)
VALUES (102, 2, 'Science', 90);

INSERT INTO Courses (CourseID, StudentID, CourseName, Marks)
VALUES (103, 3, 'English', 78);

INSERT INTO Courses (CourseID, StudentID, CourseName, Marks)
VALUES (104, 1, 'Computer', 95);

-- Syntax: SELECT * FROM table_name;
SELECT * FROM Courses;


-- JOINS

-- Syntax: INNER JOIN
SELECT S.Name, C.CourseName, C.Marks
FROM Students S
INNER JOIN Courses C
ON S.ID = C.StudentID;

-- Syntax: LEFT OUTER JOIN
SELECT S.Name, C.CourseName, C.Marks
FROM Students S
LEFT JOIN Courses C
ON S.ID = C.StudentID;

-- Syntax: RIGHT OUTER JOIN
SELECT S.Name, C.CourseName, C.Marks
FROM Students S
RIGHT JOIN Courses C
ON S.ID = C.StudentID;

-- Syntax: FULL OUTER JOIN
-- NOTE: Not supported directly in MySQL
SELECT S.Name, C.CourseName, C.Marks
FROM Students S
FULL OUTER JOIN Courses C
ON S.ID = C.StudentID;

-- Syntax: CROSS JOIN
SELECT S.Name, C.CourseName
FROM Students S
CROSS JOIN Courses C;

-- Syntax: SELF JOIN
SELECT A.Name AS Student1, B.Name AS Student2, A.Age
FROM Students A
JOIN Students B
ON A.Age = B.Age AND A.ID <> B.ID;