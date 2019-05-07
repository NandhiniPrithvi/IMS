USE [InventoryManagement]
GO

/****** Object:  UserDefinedFunction [dbo].[spGetInvoiceNo]    Script Date: 5/7/2019 6:43:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[spGetInvoiceNo]()
returns varchar(10)
as
begin
declare @invoiceno varchar(10)
declare @invoice varchar(10)
set @invoiceno = (select top 1 invoiceNo from PurchaseOrder order by orderDate)
if @invoiceno is null
  set @invoiceno = 'IN0001'
else
begin
  set @invoice = cast(SUBSTRING(@invoiceno,3,6) as int)
  set @invoice = @invoice+1
  if len(@invoice) < 4
   set @invoice = REPLICATE('0',4-LEN(@invoice)) + @invoice
  set @invoiceno = 'IN' + @invoice
end
return @invoiceno 
end
GO


