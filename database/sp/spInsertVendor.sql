USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spInsertVendor]    Script Date: 5/7/2019 6:40:47 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[spInsertVendor] 
@organme nvarchar(50),
@vendorname  nvarchar(50),
@vendorCode varchar(10),
@address nvarchar(50),
@city varchar(20),
@state varchar(20),
@pin varchar(10),
@contactno varchar(11),
@mail varchar(50)
as
begin
Insert into Vendor values(@organme,@vendorCode,@vendorname,@address,@city,@state,@pin,@contactno,@mail)
end

GO


