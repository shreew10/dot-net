/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [EmpId]
      ,[EmpName]
      ,[EmpSal]
      ,[EmpContact]
  FROM [ADOPro_R].[dbo].[tbl_employee]

  --UPDATE tbl_employee SET EmpName= 'Shruti' , EmpSal=31000 WHERE EmpId= 4

  --DELETE FROM tbl_employee WHERE EmpId=4

  SELECT MAX(EmpId) FROM tbl_employee