/* ============================================================
   COMPANY DATABASE PROJECT
   Based on the classic COMPANY ER schema (Elmasri/Navathe)
   ============================================================ */


/* ============================================================
   PART 1 — DATABASE & TABLE CREATION
   ============================================================ */

-- Database creation script
CREATE DATABASE CompanyDB;
GO
USE CompanyDB;
GO

-- ------------------------------------------------------------
-- EMPLOYEE
-- Ssn, Fname, Minit, Lname, Address, Sex, Bdate, Salary,
-- department FK (Dno), supervisor FK (Super_ssn, recursive)
-- ------------------------------------------------------------
CREATE TABLE Employee (
    Ssn        CHAR(9)      NOT NULL,
    Fname      VARCHAR(15)  NOT NULL,
    Minit      CHAR(1)      NULL,
    Lname      VARCHAR(15)  NOT NULL,
    Bdate      DATE         NULL,
    Address    VARCHAR(50)  NULL,
    Sex        CHAR(1)      NULL CHECK (Sex IN ('M','F')),
    Salary     DECIMAL(10,2) NOT NULL DEFAULT 0 CHECK (Salary > 0),
    Super_ssn  CHAR(9)      NULL,
    Dno        INT          NOT NULL,   -- total participation: every employee belongs to a department
    CONSTRAINT PK_Employee PRIMARY KEY (Ssn),
    CONSTRAINT FK_Employee_Supervisor FOREIGN KEY (Super_ssn)
        REFERENCES Employee(Ssn)        -- recursive SUPERVISION relationship
);
GO

-- ------------------------------------------------------------
-- DEPARTMENT
-- Name/DeptNumber, Locations (separate table, multivalued),
-- NumberOfEmployees, manager FK + start date
-- ------------------------------------------------------------
CREATE TABLE Department (
    Dnumber           INT           NOT NULL,
    Dname             VARCHAR(25)   NOT NULL,
    Mgr_ssn           CHAR(9)       NOT NULL,   -- total participation: every dept has a manager
    Mgr_start_date    DATE          NULL,
    NumberOfEmployees INT           NOT NULL DEFAULT 0 CHECK (NumberOfEmployees >= 0),
    CONSTRAINT PK_Department PRIMARY KEY (Dnumber),
    CONSTRAINT UQ_Department_Name UNIQUE (Dname),
    CONSTRAINT FK_Department_Manager FOREIGN KEY (Mgr_ssn)
        REFERENCES Employee(Ssn)
);
GO

-- Now that both tables exist, add Employee -> Department FK
ALTER TABLE Employee
    ADD CONSTRAINT FK_Employee_Department FOREIGN KEY (Dno)
        REFERENCES Department(Dnumber);
GO

-- ------------------------------------------------------------
-- DEPT_LOCATIONS (handles Department's multivalued Locations attribute)
-- ------------------------------------------------------------
CREATE TABLE Dept_Locations (
    Dnumber   INT          NOT NULL,
    Dlocation VARCHAR(30)  NOT NULL,
    CONSTRAINT PK_Dept_Locations PRIMARY KEY (Dnumber, Dlocation),
    CONSTRAINT FK_DeptLoc_Department FOREIGN KEY (Dnumber)
        REFERENCES Department(Dnumber)
);
GO

-- ------------------------------------------------------------
-- PROJECT
-- Name, Number, Location, controlling department FK
-- ------------------------------------------------------------
CREATE TABLE Project (
    Pnumber   INT          NOT NULL,
    Pname     VARCHAR(25)  NOT NULL,
    Plocation VARCHAR(30)  NULL,
    Dnum      INT          NOT NULL,   -- total participation: every project is controlled by a dept
    CONSTRAINT PK_Project PRIMARY KEY (Pnumber),
    CONSTRAINT UQ_Project_Name UNIQUE (Pname),
    CONSTRAINT FK_Project_Department FOREIGN KEY (Dnum)
        REFERENCES Department(Dnumber)
);
GO

-- ------------------------------------------------------------
-- WORKS_ON (junction table: Employee + Project FK + Hours)
-- ------------------------------------------------------------
CREATE TABLE Works_On (
    Essn  CHAR(9)       NOT NULL,
    Pno   INT           NOT NULL,
    Hours DECIMAL(4,1)  NOT NULL CHECK (Hours > 0),
    CONSTRAINT PK_Works_On PRIMARY KEY (Essn, Pno),
    CONSTRAINT FK_WorksOn_Employee FOREIGN KEY (Essn) REFERENCES Employee(Ssn),
    CONSTRAINT FK_WorksOn_Project  FOREIGN KEY (Pno)  REFERENCES Project(Pnumber)
);
GO

-- ------------------------------------------------------------
-- DEPENDENT (weak entity: owning Employee's Ssn as FK + partial key Name)
-- ------------------------------------------------------------
CREATE TABLE Dependent (
    Essn            CHAR(9)      NOT NULL,
    Dependent_name  VARCHAR(15)  NOT NULL,   -- partial key
    Sex             CHAR(1)      NULL CHECK (Sex IN ('M','F')),
    Bdate           DATE         NULL,
    Relationship    VARCHAR(15)  NULL,
    CONSTRAINT PK_Dependent PRIMARY KEY (Essn, Dependent_name),  -- composite key
    CONSTRAINT FK_Dependent_Employee FOREIGN KEY (Essn)
        REFERENCES Employee(Ssn)
);
GO

/* ============================================================
   PART 3 — CRUD OPERATIONS
   ============================================================ */

-- Employee and Department reference each other (circular FK).
-- We briefly disable FK checking to load the first consistent
-- batch of data, then re-enable and validate immediately after.
ALTER TABLE Employee   NOCHECK CONSTRAINT FK_Employee_Department;
ALTER TABLE Department NOCHECK CONSTRAINT FK_Department_Manager;
GO

-- INSERT 1: Departments (includes managers who don't exist as
-- Employee rows yet — resolved once Employee rows are inserted below)
INSERT INTO Department (Dnumber, Dname, Mgr_ssn, Mgr_start_date, NumberOfEmployees) VALUES
(1, 'Headquarters',   '888665555', '1981-06-19', 1),
(4, 'Administration', '987654321', '1995-01-01', 2),
(5, 'Research',       '333445555', '1988-05-22', 2);
GO

-- INSERT 2: Employees
-- James Borg is a manager (Headquarters) with no supervisor (top of hierarchy)
-- Franklin Wong is both a manager (Research) AND a supervisor of John Smith
INSERT INTO Employee (Ssn, Fname, Minit, Lname, Bdate, Address, Sex, Salary, Super_ssn, Dno) VALUES
('888665555', 'James',    'E', 'Borg',    '1937-11-10', '450 Stone, Houston, TX',   'M', 55000, NULL,        1),
('333445555', 'Franklin', 'T', 'Wong',    '1955-12-08', '638 Voss, Houston, TX',    'M', 40000, '888665555', 5),
('987654321', 'Jennifer', 'S', 'Wallace', '1941-06-20', '291 Berry, Bellaire, TX',  'F', 43000, '888665555', 4),
('123456789', 'John',     'B', 'Smith',   '1965-01-09', '731 Fondren, Houston, TX', 'M', 30000, '333445555', 5),
('999887777', 'Alicia',   'J', 'Zelaya',  '1968-01-19', '3321 Castle, Spring, TX',  'F', 25000, '987654321', 4);
GO

-- Re-enable and re-validate the circular FKs now that data is consistent
ALTER TABLE Employee   WITH CHECK CHECK CONSTRAINT FK_Employee_Department;
ALTER TABLE Department WITH CHECK CHECK CONSTRAINT FK_Department_Manager;
GO

-- INSERT 3: Projects
INSERT INTO Project (Pnumber, Pname, Plocation, Dnum) VALUES
(1, 'ProductX',    'Bellaire',  5),
(2, 'ProductY',    'Sugarland', 5),
(3, 'NewBenefits', 'Stafford',  4);
GO

-- INSERT 4: Works_On (at least one record required)
INSERT INTO Works_On (Essn, Pno, Hours) VALUES
('123456789', 1, 32.5),
('123456789', 2, 7.5),
('333445555', 2, 10.0),
('333445555', 3, 10.0),
('999887777', 3, 30.0);
GO

-- INSERT 5: Dependents (at least one record required)
INSERT INTO Dependent (Essn, Dependent_name, Sex, Bdate, Relationship) VALUES
('333445555', 'Alice',     'F', '1986-04-05', 'Daughter'),
('333445555', 'Theodore',  'M', '1983-10-25', 'Child'),      -- intentionally vague; corrected in UPDATE 5
('987654321', 'Abner',     'M', '1942-02-28', 'Spouse'),
('123456789', 'Michael',   'M', '2010-05-15', 'Son');
GO


-- ------------------------------------------------------------
-- UPDATE statements (5 total, each a different table/change type)
-- ------------------------------------------------------------

-- UPDATE 1: Give an employee a raise
UPDATE Employee
SET Salary = Salary * 1.10
WHERE Ssn = '123456789';
GO

-- UPDATE 2: Reassign an employee to a new department
UPDATE Employee
SET Dno = 1
WHERE Ssn = '999887777';
GO

-- UPDATE 3: Change a project's location
UPDATE Project
SET Plocation = 'Houston'
WHERE Pnumber = 3;
GO

-- UPDATE 4: Update hours worked on a project
UPDATE Works_On
SET Hours = 20.0
WHERE Essn = '123456789' AND Pno = 2;
GO

-- UPDATE 5: Correct a dependent's relationship
UPDATE Dependent
SET Relationship = 'Son'
WHERE Essn = '333445555' AND Dependent_name = 'Theodore';
GO


-- DELETE DEMO 1: Remove an employee who has both Dependent and
-- Works_On records. Child rows must be deleted first.
DELETE FROM Dependent WHERE Essn = '123456789';
DELETE FROM Works_On  WHERE Essn = '123456789';
DELETE FROM Employee  WHERE Ssn  = '123456789';
GO

-- DELETE DEMO 2: Remove a project that still has Works_On records
-- pointing to it. Child rows must be deleted first.
DELETE FROM Works_On WHERE Pno = 3;
DELETE FROM Project  WHERE Pnumber = 3;
GO
