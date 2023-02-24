/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [mst_id]
      ,[category]
      ,[vehicle_type]
      ,[fee_amount]
  FROM [db_drivingSchool].[dbo].[tbl_master]

 SELECT fee_amount FROM tbl_master WHERE category='Admission'