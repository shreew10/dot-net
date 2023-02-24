/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [EmpId]
      ,[EmpName]
      ,[EmpSal]
      ,[EmpContact]
  FROM [ADOPro_R].[dbo].[tbl_employee]

  SELECT EmpId, EmpName,EmpSal, EmpContact FROM tbl_employee