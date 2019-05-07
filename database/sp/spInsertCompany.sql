USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spInsertCompany]    Script Date: 5/7/2019 6:40:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spInsertCompany]
@companyname nvarchar(100)
as
begin
insert into tblCompany values(@companyname)
end
GO


