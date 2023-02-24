CREATE TABLE [dbo].[tbl_daily_training](
	[training_id] [int] NOT NULL,
	[training_date] [datetime] NOT NULL,
	[student_daily_km] [int] NOT NULL,
	[stud_aadhar_card] [varchar](12) NULL,)

SELECT training_id[ID], training_date[Date], student_daily_km[Daily KM], stud_aadhar_card[Aadhar Card No.]
FROM tbl_daily_training