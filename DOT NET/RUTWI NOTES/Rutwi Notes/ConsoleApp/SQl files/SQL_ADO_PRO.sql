

CREATE TABLE tbl_emp
( emp_id int PRIMARY KEY NOT NULL,
  emp_name varchar (50)NOT NULL,
  emp_gender char NOT NULL,
  emp_contact double PRECISION (10) NOT NULL,
  emp_sal decimal(13,2) NOT NULL,
  emp_job_status bit NOT NULL,
  emp_joining_date date NOT NULL,
  emp_email varchar(50),
  dept_no int foreign key references tbl_dept(dept_id)
  )

  CREATE TABLE tbl_dept
  ( dept_id int primary key NOT NULL,
    dept_name varchar(20)
	)

	ALTER TABLE tbl_dept
	ADD primary key(dept_id)

DROP TABLE tbl_dept
  SELECT dept_id, dept_name
  FROM tbl_dept
