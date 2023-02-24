CREATE TABLE [dbo].[tbl_master](
	[mst_id] [int] NOT NULL,
	[category] [varchar](15) NOT NULL,
	[vehicle_type] [varchar](15) NOT NULL,
	[fee_amount] [real] NOT NULL,)

SELECT mst_id[ID], category[Category], vehicle_type[Vehicle Type],fee_amount[Amount] FROM tbl_master