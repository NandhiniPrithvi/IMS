USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spGetPurchaseOrder]    Script Date: 5/7/2019 6:40:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[spGetPurchaseOrder]
as
begin
select  po.porderid,po.productCode,po.productName,po.purchasePrice,po.discount,po.quantity,quantityNeeded,po.totalAmount,category,company,
sgst,cgst,hsnCode,po.supplierCode, v.vendorName as supplierName,invoiceNo,invoiceDate,orderDate

from PurchaseOrder po join Product p on po.productCode = p.productCode 
join Vendor v on po.supplierCode = v.vendorCode where orderDate = CONVERT(date, getdate()) 
order by po.porderid
end
GO


