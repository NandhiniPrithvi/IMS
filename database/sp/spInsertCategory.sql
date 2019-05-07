USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spInsertCategory]    Script Date: 5/7/2019 6:40:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[spInsertCategory]
@categoryname nvarchar(100),
@categorydesc nvarchar(100) =null
as
begin
insert into Category values(@categoryname,@categorydesc, getdate())
end
GO


