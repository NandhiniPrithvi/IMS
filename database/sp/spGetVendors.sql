USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spGetVendors]    Script Date: 5/7/2019 6:40:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spGetVendors]
as
begin
select * from Vendor
end
GO


