CREATE TABLE [dbo].[tbl_student_details](
	[stud_aadhar_card] [varchar](12) NOT NULL,
	[stud_name] [varchar](50) NOT NULL,
	[stud_gender] [char](1) NOT NULL,
	[stud_dob] [date] NOT NULL,
	[stud_address] [varchar](max) NOT NULL,
	[stud_area] [varchar](20) NOT NULL,
	[stud_city] [varchar](20) NOT NULL,
	[stud_pincode] [varchar](1) NOT NULL,
	[stud_pan_card] [varchar](10) NOT NULL,
	[stud_joining_date] [date] NOT NULL,
	[stud_contact] [varchar](10) NOT NULL,
	[vehicle_type] [varchar](15) NOT NULL,)

SELECT stud_aadhar_card[Aadhar Card No], stud_name[Name],stud_gender[Gender], stud_dob[DOB], stud_address[Address], stud_area[Area], stud_city[City], stud_pincode[Pin Code],stud_joining_date[Joining Date], stud_contact[Contact], vehicle_type[Vehicle type]
FROM tbl_student_details