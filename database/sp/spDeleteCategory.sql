USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteCategory]    Script Date: 5/7/2019 6:40:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spDeleteCategory]
@categoryid int
as
begin
delete Category where categoryId = @categoryid
end
GO


