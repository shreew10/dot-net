CREATE TABLE [dbo].[tbl_company](
	[comp_name] [varchar](30) NOT NULL,
	[comp_address] [varchar](200) NOT NULL,
	[comp_contact] [varchar](12) NOT NULL,
	[comp_email] [varchar](100) NOT NULL,
	[comp_website] [varchar](100) NOT NULL
)

SELECT comp_name[Name], comp_address[Address],comp_contact[Contact],comp_email[Email],comp_website[Website]
FROM tbl_company

