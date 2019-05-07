USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spInsertItem]    Script Date: 5/7/2019 6:40:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spInsertItem] 
@itemname nvarchar(50),
@category  int,
@company int ,
@code nvarchar(50),
@description nvarchar(50),
@price decimal
as
begin
Insert into Item values(@category,@itemname,@code,@description,@price,@company)
end
GO


