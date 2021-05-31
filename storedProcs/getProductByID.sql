-- =======================================================
-- Create Stored Procedure Template for Azure SQL Database
-- =======================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Barry Tarlton
-- Create Date: May 31, 2021
-- Description: returns a product based on passed in ID
-- =============================================
CREATE PROCEDURE GET_PRODUCT_BY_ID
(
    -- Add the parameters for the stored procedure here
     @PRODUCT_ID int
    
)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Insert statements for procedure here
    SELECT ProductID, SKU, Description, Price, Cost 
	FROM dbo.PRODUCT
	WHERE ProductID = @PRODUCT_ID
END
GO
