CREATE TABLE [tbl_clinic_details](
	[clinic_name] [varchar](60) NULL,
	[clinic_addrs] [varchar](150) NULL,
	[clinic_area] [varchar](50) NULL,
	[clinic_city] [varchar](25) NULL,
	[clinic_pin] [int] NULL,
	[clinic_contact] [varchar](10) NULL,
	[clinic_website] [varchar](50) NULL,
	[clinic_email] [varchar](50) NULL,
	[start_time] [time](7) NULL,
	[end_time] [time](7) NULL,
	[am_pm_start] [varchar](2) NULL,
	[am_pm_end] [varchar](2) NULL,
	[clinic_id] [int] PRIMARY KEY NOT NULL)

CREATE TABLE [tbl_staff_details](
	[staff_id] [int] PRIMARY KEY NOT NULL,
	[staff_name] [varchar](40) NULL,
	[staff_addrs] [varchar](150) NULL,
	[staff_area] [varchar](50) NULL,
	[staff_city] [varchar](25) NULL,
	[staff_pin] [int] NULL,
	[staff_contact] [varchar](10) NULL,
	[staff_gender] [varchar](8) NULL,
	[staff_aadhar] [varchar](12) NULL,
	[staff_email] [varchar](40) NULL,
	[staff_dob] [date] NULL,
	[staff_doj] [date] NULL,
	[staff_qualification] [varchar](50) NULL,
	[staff_experience] [varchar](20) NULL,
	[staff_work_type] [varchar](20) NULL,
	[password] [varchar](50) NULL)

CREATE TABLE [tbl_patient_details](
	[patient_id] [int] PRIMARY KEY  NOT NULL,
	[patient_name] [varchar](40) NULL,
	[patient_addrs] [varchar](150) NULL,
	[patient_area] [varchar](50) NULL,
	[patient_city] [varchar](25) NULL,
	[patient_pin] [int] NULL,
	[patient_gender] [varchar](8) NULL,
	[patient_dob] [date] NULL,
	[patient_contact] [varchar](10) NULL,
	[patient_email] [varchar](40) NULL,
	[patient_ref] [varchar](50) NULL,
	[patient_blood_group] [varchar](5) NULL,
	[reg_dt] [date] NULL)



CREATE TABLE [tbl_appointment_details](
	[appt_no] [int] PRIMARY KEY NOT NULL,
	[staff_id] [int] NULL,
	[appt_reason] [varchar](90) NULL,
	[time_slot] [time](7) NULL,
	[appt_date] [date] NULL,
	[patient_id] [int] NULL,
	[doctor_id] [int] NULL)

CREATE TABLE [tbl_visit_details](
	[visit_no] [int] NOT NULL,
	[visit_type] [varchar](20) NULL,
	[visit_time] [time](7) NULL,
	[visit_date] [date] NULL,
	[doctor_id] [int] NULL,
	[staff_id] [int] NULL,
	[patient_id] [int] NULL,
	[symptoms] [varchar](525) NULL,
	[diagnosis] [varchar](525) NULL,
	[temperature] [int] NULL,
	[bp] [varchar](15) NULL,
	[oxy_level] [int] NULL,
	[weight] [varchar](5) NULL,
	[height] [varchar](5) NULL,
	[am_pm] [varchar](2) NULL)

CREATE TABLE [dbo].[tbl_cronic_disease](
	[cronic_disease_id] [int] PRIMARY KEY NOT NULL,
	[patient_id] [int] NULL,
	[cronic_disease] [varchar](80) NULL,
	[cronic_disease_start_dt] [date] NULL)
	
CREATE TABLE [dbo].[tbl_investigation_details](
	[visit_invst_id] [int] PRIMARY KEY NOT NULL,
	[visit_no] [int] NULL,
	[investigation] [varchar](250) NULL,
	[result] [varchar](250) NULL)


CREATE TABLE [dbo].[tbl_medication_details](
	[visit_med_id] [int] PRIMARY KEY NOT NULL,
	[visit_no] [int] NULL,
	[medicine] [varchar](70) NULL,
	[frequency] [varchar](50) NULL,
	[no_of_days] [int] NULL)

CREATE TABLE [dbo].[tbl_medication_history](
	[patient_med_id] [int] PRIMARY KEY NOT NULL,
	[patient_id] [int] NULL,
	[medicine] [varchar](60) NULL,
	[frequency] [varchar](50) NULL)

CREATE TABLE [dbo].[tbl_payment_collection](
	[payment_id] [int] PRIMARY KEY NOT NULL,
	[patient_id] [int] NULL,
	[mode_of_pay] [varchar](10) NULL,
	[type_of_pay] [varchar](30) NULL,
	[amount] [int] NULL,
	[payment_dt] [date] NULL)

CREATE TABLE [dbo].[tbl_pay_type](
	[category] [varchar](30) NULL,
	[value] [int] NULL,
	[unit] [varchar](5) NULL)

CREATE TABLE [dbo].[tbl_allergy_history](
	[allergy_id] [int] PRIMARY KEY NOT NULL,
	[patient_id] [int] NULL,
	[allergy] [varchar](70) NULL,
	[allergy_start_dt] [date] NULL)