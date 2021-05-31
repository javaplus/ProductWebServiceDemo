-- =======================================================
-- Create Stored Procedure Template for Azure SQL Database
-- =======================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      <Author, , Name>
-- Create Date: <Create Date, , >
-- Description: <Description, , >
-- =============================================
CREATE PROCEDURE UPDATE_PRODUCT_PRICE
(
    -- Add the parameters for the stored procedure here
    @PRODUCT_ID int,
	@PRICE Money
    
)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Insert statements for procedure here
    UPDATE PRODUCT 
	SET Price = @PRICE
	WHERE ProductID = @PRODUCT_ID;

	SELECT * FROM PRODUCT WHERE ProductID=@PRODUCT_ID


END
GO
