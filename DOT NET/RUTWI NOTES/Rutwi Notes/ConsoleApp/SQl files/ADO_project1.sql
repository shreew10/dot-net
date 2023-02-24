CREATE TABLE tbl_employee ( EmpId int NOT NULL, EmpName varchar(25), EmpSal decimal(18,2), EmpContact varchar(10) )

INSERT INTO tbl_employee(EmpId,  EmpName, EmpSal,EmpContact)
VALUES (1,'Rutwi',50000,'9845682748');

SELECT EmpId,  EmpName, EmpSal,EmpContact FROM tbl_employee 