USE [InventoryManagement]
GO

/****** Object:  UserDefinedFunction [dbo].[getInvoicebySupplier]    Script Date: 5/24/2019 7:10:10 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[getInvoicebySupplier](@suppliercode varchar(10), @invoiceDate datetime)
returns varchar(10)
as 
begin
declare @result nvarchar(10)  
set @result = (select invoiceNo from PurchaseOrder where  supplierCode = @suppliercode
 and invoiceDate = @invoiceDate)
return @result
end

GO


