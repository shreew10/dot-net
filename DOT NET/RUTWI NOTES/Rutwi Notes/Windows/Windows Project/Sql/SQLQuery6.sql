/****** Script for SelectTopNRows command from SSMS  ******/


  DELETE tbl_staff_details 

  CREATE TABLE [dbo].[tbl_staff_details](
	[staff_aadhar_card] [varchar](12) NOT NULL,
	[staff_name] [varchar](25) NOT NULL,
	[staff_address] [varchar](100) NULL,
	[staff_city] [varchar](15) NULL,
	[staff_area] [varchar](20) NULL,
	[staff_contact] [varchar](13) NOT NULL,
	[staff_pan_card] [varchar](10) NOT NULL,
	[staff_gender] [char](1) NOT NULL,
	[staff_email] [varchar](15) NOT NULL,
	[staff_password] [varchar](10) NOT NULL,)

SELECT staff_aadhar_card[Aadhar Card No], staff_name[Name],staff_address[Address],staff_city[City],staff_area[Area],staff_contact[Contact],staff_pan_card[Pan Card No], staff_gender[Gender],staff_email[Email],staff_password[Password] FROM tbl_staff_details

INSERT INTO tbl_staff_details( staff_aadhar_card,staff_name,staff_address, staff_city,staff_area,staff_contact,staff_pan_card,staff_gender,staff_email,staff_password) Values()