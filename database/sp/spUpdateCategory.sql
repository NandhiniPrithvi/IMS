USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateCategory]    Script Date: 5/7/2019 6:40:59 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spUpdateCategory]
@categoryid int,
@categoryname nvarchar(100),
@remarks nvarchar(100) = null
as
begin
update Category set name = @categoryname , [description]  =  @remarks where categoryId = @categoryid
end
GO


