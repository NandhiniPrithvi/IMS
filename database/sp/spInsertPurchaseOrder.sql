USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spInsertPurchaseOrder]    Script Date: 5/7/2019 6:40:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE proc [dbo].[spInsertPurchaseOrder]
@productCode varchar(10),
@productName varchar(50),
@purchasePrice decimal(18, 2),
@discount decimal(18, 2),
@quantity decimal(18, 2),
@quantityNeeded decimal(18, 2),
@totalAmount decimal(18, 2),
@supplierCode varchar(10),
@invoiceNo varchar(10),
@invoiceDate datetime
as 
begin
declare @orderdate datetime
set @orderdate = CONVERT(date, getdate())
insert into PurchaseOrder values(@productCode, @productName,@purchasePrice,@discount,@quantity,
@quantityNeeded,@totalAmount,@supplierCode,@invoiceNo,@invoiceDate,@orderdate)
end




GO


