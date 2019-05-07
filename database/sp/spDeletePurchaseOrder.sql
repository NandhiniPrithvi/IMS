USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spDeletePurchaseOrder]    Script Date: 5/7/2019 6:40:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spDeletePurchaseOrder]
@porderid int
as
begin
delete from PurchaseOrder where porderid = @porderid
end

GO


