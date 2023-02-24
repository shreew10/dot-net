CREATE TABLE [dbo].[tbl_payment_details](
	[reciept_no] [int] NOT NULL,
	[mode_of_payment] [varchar](25) NOT NULL,
	[amount] [real] NOT NULL,
	[cheque_number] [varchar](15) NULL,
	[cheque_date] [date] NULL,
	[bank_name] [varchar](50) NULL,
	[branch_name] [varchar](50) NULL,
	[fee_type] [varchar](25) NOT NULL,
	[stud_aadhar_card] [varchar](12) NULL,)

SELECT reciept_no[Receipt no.],mode_of_payment[Payment Mode],amount[Amount],cheque_number[Cheque No.],cheque_date[Cheque Date], bank_name[Bank], branch_name[Branch], fee_type[Fee Type], stud_aadhar_card[Aadhar Card no]
FROM tbl_payment_details