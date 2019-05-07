USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteCompany]    Script Date: 5/7/2019 6:40:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spDeleteCompany]
@companyid int
as
begin
delete tblCompany where CompanyId = @companyid
end
GO


