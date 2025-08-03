 use FactoryManagementDB;
CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    CNIC NVARCHAR(15) NOT NULL UNIQUE,
    PhoneNumber NVARCHAR(15)
    
);
ALTER TABLE Orders 
DROP COLUMN TotalPrice;

ALTER TABLE Orders 
ADD TotalPrice AS ([Total SqFeet] * UnitPrice);



CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    OrderDate DATE NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    TotalPrice AS (Quantity * UnitPrice),
    Description NVARCHAR(MAX),
    Address NVARCHAR(255), -- Address for the order
    CustomerName NVARCHAR(255) NOT NULL, -- Name of the customer
    CustomerCNIC NVARCHAR(15) NOT NULL, -- CNIC of the customer
    CustomerPhone NVARCHAR(15), -- Phone number of the customer
);
CREATE TABLE Ledger (
    LedgerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    Date DATE NOT NULL,
   
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE
);
ALTER TABLE Orders
ADD LedgerID INT NOT NULL DEFAULT 0;

ALTER TABLE Orders
ADD CONSTRAINT FK_Ledger FOREIGN KEY (LedgerID) REFERENCES Ledger(LedgerID) ON DELETE SET DEFAULT;

CREATE TABLE [FactoryManagementDB].[dbo].[Providers] (
    ProviderID INT PRIMARY KEY IDENTITY(1,1),
    ProviderName NVARCHAR(255) NOT NULL,
    Contact NVARCHAR(50),
    CNIC NVARCHAR(20),
    Address NVARCHAR(255)
);

CREATE TABLE [FactoryManagementDB].[dbo].[ProviderLedger] (
    LedgerID INT PRIMARY KEY IDENTITY(1,1),
    ProviderID INT FOREIGN KEY REFERENCES Providers(ProviderID),
    Amount DECIMAL(18,2) NOT NULL,
    LedgerDate DATETIME DEFAULT GETDATE()
    
);

CREATE TABLE RawMaterials (
    RawMaterialID INT IDENTITY(1,1) PRIMARY KEY,
    MaterialName NVARCHAR(255) NOT NULL,
    Quantity INT NOT NULL,
    PricePerUnit DECIMAL(18,2) NOT NULL,  -- Price per unit of raw material
    TotalPrice AS (Quantity * PricePerUnit),  -- Total price for the raw material based on quantity and price per unit
    DateAdded DATE NOT NULL,
    Description NVARCHAR(MAX) -- Manual entry of raw material details
);

ALTER TABLE [FactoryManagementDB].[dbo].[RawMaterials]
ADD ProviderName NVARCHAR(255) NOT NULL DEFAULT 'Unknown',
    ProviderContact NVARCHAR(50) NOT NULL DEFAULT 'N/A',
    ProviderCNIC NVARCHAR(20) NOT NULL DEFAULT 'N/A',
    LedgerID INT NULL FOREIGN KEY REFERENCES ProviderLedger(LedgerID);


CREATE TABLE [FactoryManagementDB].[dbo].[ProviderLedgerClearanceLog] (
    ClearanceID INT PRIMARY KEY IDENTITY(1,1),
    LedgerID INT FOREIGN KEY REFERENCES ProviderLedger(LedgerID),
    AmountPaid DECIMAL(18,2) NOT NULL,
    ClearanceDate DATETIME DEFAULT GETDATE(),
    RemainingBalance DECIMAL(18,2)
);


CREATE TABLE Production (
    ProductionID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(255) NOT NULL,
    Quantity INT NOT NULL,
    PricePerUnit DECIMAL(18,2) NOT NULL,  -- Price per unit of produced product
    TotalPrice AS (Quantity * PricePerUnit),  -- Total price for the produced product
    DateProduced DATE NOT NULL,
    Description NVARCHAR(MAX) -- Manual entry of production details
);


CREATE TABLE CashFlow (
    CashFlowID INT IDENTITY(1,1) PRIMARY KEY,
    CashFlowDate DATE NOT NULL, -- The date of the cash flow event
    Amount DECIMAL(18,2) NOT NULL, -- The amount of money (positive for inflow, negative for outflow)
    Type NVARCHAR(50) CHECK (Type IN ('Inflow', 'Outflow')), -- Type of cash flow, either inflow or outflow
    Reason NVARCHAR(255), -- The reason for the cash flow (e.g., payment received, purchase, etc.)
    Description NVARCHAR(MAX) -- A detailed description or notes about the cash flow
);
CREATE PROCEDURE AddRawMaterialWithCashFlow
    @MaterialName NVARCHAR(255),
    @Quantity INT,
    @PricePerUnit DECIMAL(18,2),
    @DateAdded DATE,
    @Description NVARCHAR(MAX)
AS
BEGIN
    DECLARE @TotalPrice DECIMAL(18,2);

    -- Calculate the total price for the raw material
    SET @TotalPrice = @Quantity * @PricePerUnit;

    -- Insert the raw material into the RawMaterials table
    INSERT INTO RawMaterials (MaterialName, Quantity, PricePerUnit, DateAdded, Description)
    VALUES (@MaterialName, @Quantity, @PricePerUnit, @DateAdded, @Description);

    -- Insert the corresponding cash flow record into the CashFlow table
    INSERT INTO CashFlow (CashFlowDate, Amount, Type, Reason, Description)
    VALUES (@DateAdded, @TotalPrice, 'Outflow', 'Raw Material Purchase', @Description);
END;

EXEC AddRawMaterialWithCashFlow
    @MaterialName = 'Cement',
    @Quantity = 100,
    @PricePerUnit = 500.00,
    @DateAdded = '2025-01-30',
    @Description = 'Bulk purchase of cement for factory production';


CREATE PROCEDURE UpdateRawMaterialByID
    @MaterialID INT,
    @NewMaterialName NVARCHAR(255),
    @NewQuantity INT,
    @NewPricePerUnit DECIMAL(18,2),
    @NewDateAdded DATE,
    @NewDescription NVARCHAR(Max),
    @OldDescription NVARCHAR(Max),
    @OldTotalAmount DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;

    -- Calculate New Total Price inside SQL
    DECLARE @NewTotalAmount DECIMAL(18,2);
    SET @NewTotalAmount = @NewQuantity * @NewPricePerUnit;

    -- Step 1: Update Raw Material Table
    UPDATE RawMaterials
    SET MaterialName = @NewMaterialName,
        Quantity = @NewQuantity,
        PricePerUnit = @NewPricePerUnit,
        
        DateAdded = @NewDateAdded,
        Description = @NewDescription
    WHERE RawMaterialID = @MaterialID;

    -- Step 2: Update Cash Flow Table
    UPDATE CashFlow
    SET Amount = @NewTotalAmount,  -- Using Calculated Amount
        CashFlowDate = @NewDateAdded,
        Description = @NewDescription
    WHERE Amount = @OldTotalAmount
      AND Description = @OldDescription; -- Ensuring we update only the correct record
END;



EXEC UpdateRawMaterialByID
    @MaterialID = 8, -- Use the actual ID from RawMaterials
    @NewMaterialName = 'Steel Rod',
    @NewQuantity = 100,
    @NewPricePerUnit = 250.00,
    @NewDateAdded = '2024-01-20',
    @NewDescription = 'Steel rods for new construction',
    @OldDescription = 'bulk purchase of cement again',
    @OldTotalAmount = 40000.00;


	CREATE PROCEDURE GetAllRecords
    @TableName NVARCHAR(255)  -- Table ka naam as parameter
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SQLQuery NVARCHAR(MAX);

    -- Dynamic SQL query to select all data from the given table name
    SET @SQLQuery = 'SELECT * FROM ' + QUOTENAME(@TableName);

    -- Execute the query
    EXEC sp_executesql @SQLQuery;
END;


ALTER PROCEDURE UpdateRawMaterialByID
    @MaterialID INT,
    @NewMaterialName NVARCHAR(255),
    @NewQuantity INT,
    @NewPricePerUnit DECIMAL(18,2),
    @NewDateAdded DATE,
    @NewDescription NVARCHAR(Max),
    @OldDescription NVARCHAR(Max),
    @OldTotalAmount DECIMAL(18,2),
    @AffectedRows INT OUTPUT -- OUTPUT parameter to return affected rows count
AS
BEGIN
    SET NOCOUNT ON;

    -- Calculate New Total Price inside SQL
    DECLARE @NewTotalAmount DECIMAL(18,2);
    SET @NewTotalAmount = @NewQuantity * @NewPricePerUnit;

    -- Step 1: Update Cash Flow Table
    UPDATE CashFlow
    SET Amount = @NewTotalAmount,  -- Using Calculated Amount
        CashFlowDate = @NewDateAdded,
        Description = @NewDescription
    WHERE Amount = @OldTotalAmount
      AND Description = @OldDescription;

    -- Capture the number of affected rows from CashFlow update
    SET @AffectedRows = @@ROWCOUNT;

    -- Step 2: Update Raw Material Table
    UPDATE RawMaterials
    SET MaterialName = @NewMaterialName,
        Quantity = @NewQuantity,
        PricePerUnit = @NewPricePerUnit,
        DateAdded = @NewDateAdded,
        Description = @NewDescription
    WHERE RawMaterialID = @MaterialID;

    -- Add rows affected in RawMaterials table to the existing affected rows count
    SET @AffectedRows = @AffectedRows + @@ROWCOUNT;
END;


CREATE PROCEDURE DeleteRawMaterialByID
    @MaterialID INT,
    @MaterialName NVARCHAR(255),
    @OldDescription NVARCHAR(MAX),
    @OldTotalAmount DECIMAL(18,2),
    @AffectedRows INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @RowsDeleted INT = 0;

    BEGIN TRANSACTION;

    -- Step 1: Delete from RawMaterials table
    DELETE FROM [FactoryManagementDB].[dbo].[RawMaterials]
    WHERE RawMaterialID = @MaterialID AND MaterialName = @MaterialName;

    -- Count deleted rows from RawMaterials
    SET @RowsDeleted = @@ROWCOUNT;

    -- Step 2: Delete from CashFlow table
    DELETE FROM [FactoryManagementDB].[dbo].[CashFlow]
    WHERE Description = @OldDescription AND Amount = @OldTotalAmount;

    -- Add affected rows from CashFlow deletion
    SET @RowsDeleted = @RowsDeleted + @@ROWCOUNT;

    -- Return affected rows count
    SET @AffectedRows = @RowsDeleted;

    -- Commit or rollback transaction
    IF @RowsDeleted > 0
        COMMIT TRANSACTION;
    ELSE
        ROLLBACK TRANSACTION;
END;

DECLARE @AffectedRows INT;

EXEC DeleteRawMaterialByID 
    @MaterialID = 11,  
    @MaterialName = 'Cement',  
    @OldDescription = 'Bulk Purchase For Production Of Bricks',  
    @OldTotalAmount = 25000.00,  
    @AffectedRows = @AffectedRows OUTPUT;  

SELECT @AffectedRows AS 'Rows Deleted';


DBCC CHECKIDENT ('CashFlow', RESEED, 0);


-- Stored Procedure: AddCashFlow
CREATE PROCEDURE AddCashFlow
    @CashFlowDate DATE,
    @Amount DECIMAL(18, 2),
    @Type VARCHAR(50),
    @Reason VARCHAR(255),
    @Description TEXT
AS
BEGIN
    INSERT INTO dbo.CashFlow (CashFlowDate, Amount, Type, Reason, Description)
    VALUES (@CashFlowDate, @Amount, @Type, @Reason, @Description);

    -- Return the number of rows affected
    SELECT @@ROWCOUNT AS AffectedRows;
END;
-- Stored Procedure: UpdateCashFlow
CREATE PROCEDURE UpdateCashFlow
    @CashFlowID INT,
    @CashFlowDate DATE,
    @Amount DECIMAL(18, 2),
    @Type VARCHAR(50),
    @Reason VARCHAR(255),
    @Description TEXT
AS
BEGIN
    UPDATE dbo.CashFlow
    SET CashFlowDate = @CashFlowDate,
        Amount = @Amount,
        Type = @Type,
        Reason = @Reason,
        Description = @Description
    WHERE CashFlowID = @CashFlowID;

    -- Return the number of rows affected
    SELECT @@ROWCOUNT AS AffectedRows;
END;
-- Stored Procedure: DeleteCashFlow
CREATE PROCEDURE DeleteCashFlow
    @CashFlowID INT
AS
BEGIN
    DELETE FROM dbo.CashFlow WHERE CashFlowID = @CashFlowID;

    -- Return the number of rows affected
    SELECT @@ROWCOUNT AS AffectedRows;
END;
EXEC UpdateCashFlow
    @CashFlowID = 1,
    @CashFlowDate = '2025-01-31',
    @Amount = 1000.00,
    @Type = 'Inflow',
    @Reason = 'Sale',
    @Description = 'Updated Description';
use FactoryManagementDB;

ALTER TABLE Production
ADD LabourCost DECIMAL(18,2) NOT NULL,
    RawMaterialUsed NVARCHAR(MAX);

	CREATE TABLE Stock (
    StockID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(255) NOT NULL UNIQUE,  -- Ensuring each product appears only once
    Quantity INT NOT NULL DEFAULT 0             -- Initial stock is 0, increases with production
);


Alter PROCEDURE AddProductionAndStock
    @ProductName NVARCHAR(100),
    @Quantity INT,
    @LabourCost DECIMAL(10,2),
    @RawMaterialUsed NVARCHAR(255),
    @DateProduced DATE,
    @Description NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert into Production table
    INSERT INTO Production (ProductName, Quantity, LabourCost, RawMaterialUsed, DateProduced, Description)
    VALUES (@ProductName, @Quantity, @LabourCost, @RawMaterialUsed, @DateProduced, @Description);

    -- Update or Insert into Stock table
    IF EXISTS (SELECT 1 FROM Stock WHERE UPPER(ProductName) = UPPER(@ProductName))
    BEGIN
        -- If product exists, update quantity
        UPDATE Stock 
        SET Quantity = Quantity + @Quantity
        WHERE UPPER(ProductName) = UPPER(@ProductName);
    END
    ELSE
    BEGIN
        -- If product does not exist, insert new entry
        INSERT INTO Stock (ProductName, Quantity)
        VALUES (UPPER(@ProductName), @Quantity);
    END
	    -- Insert into CashFlow table (recording outflow for labour cost)
    INSERT INTO CashFlow (CashFlowDate, Amount, Type, Reason, Description)
    VALUES 
    (
        @DateProduced,               -- CashFlowDate
        @LabourCost,                 -- Amount (outflow)
        'Outflow',                   -- Type
        'Payment To Labour For Production of ' + @ProductName ,  -- Reason
        @Description                 -- Description (same as in the Production table)
    );
END;

ALTER PROCEDURE UpdateProductionAndStock
    @ProductionID INT,
    @NewProductName NVARCHAR(100),
    @NewQuantity INT,
    @NewLabourCost DECIMAL(10,2),
    @NewRawMaterialUsed NVARCHAR(255),
    @NewDateProduced DATE,
    @NewDescription NVARCHAR(255),
    @OldProductName NVARCHAR(100),
	  @OldQuantity INT,
    @OldLabourCost DECIMAL(10,2),
    @OldDescription NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Start a transaction to ensure atomicity
        BEGIN TRANSACTION;

        -- Step 1: Update the Production table with new values
        UPDATE Production
        SET ProductName = @NewProductName,
            Quantity = @NewQuantity,
            LabourCost = @NewLabourCost,
            RawMaterialUsed = @NewRawMaterialUsed,
            DateProduced = @NewDateProduced,
            Description = @NewDescription
        WHERE ProductionID = @ProductionID;

        -- Check if the Production table was updated
        IF @@ROWCOUNT = 0
        BEGIN
            RAISERROR('No records updated in Production table.', 16, 1);
        END

        -- Step 2: Update the CashFlow table for the old values
        UPDATE CashFlow
        SET Amount = @NewLabourCost,
            Description = @NewDescription,
            CashFlowDate = @NewDateProduced,
            Reason = 'Payment To labour For Production of ' + @NewProductName
        WHERE Reason = 'Payment To Labour For Production of ' + @OldProductName
          AND Description = @OldDescription
          AND Amount = @OldLabourCost;

        -- Check if the CashFlow table was updated
        IF @@ROWCOUNT = 0
        BEGIN
            RAISERROR('No records updated in CashFlow table.', 16, 1);
        END

        -- Step 3: Update the Stock table
        -- Subtract the old quantity from the Stock
        UPDATE Stock
        SET Quantity = Quantity - @OldQuantity
        WHERE UPPER(ProductName) = UPPER(@OldProductName);

        -- Check if the Stock table was updated
        IF @@ROWCOUNT = 0
        BEGIN
            RAISERROR('No records updated in Stock table for old product.', 16, 1);
        END

        -- Add the new quantity to the Stock
        UPDATE Stock
        SET Quantity = Quantity + @NewQuantity
        WHERE UPPER(ProductName) = UPPER(@NewProductName);

        -- Check if the Stock table was updated
        IF @@ROWCOUNT = 0
        BEGIN
            RAISERROR('No records updated in Stock table for new product.', 16, 1);
        END

        -- If the product doesn't exist in the stock, insert it as a new record
        IF NOT EXISTS (SELECT 1 FROM Stock WHERE UPPER(ProductName) = UPPER(@NewProductName))
        BEGIN
            INSERT INTO Stock (ProductName, Quantity)
            VALUES (@NewProductName, @NewQuantity);
        END

        -- Commit the transaction if all steps succeed
        COMMIT TRANSACTION;
        RETURN 1; -- Indicate success
    END TRY
    BEGIN CATCH
        -- Rollback the transaction if any error occurs
        ROLLBACK TRANSACTION;
        -- Capture error message
        DECLARE @ErrorMessage NVARCHAR(4000);
        SET @ErrorMessage = ERROR_MESSAGE();
        RAISERROR('Error occurred: %s', 16, 1, @ErrorMessage);
        RETURN -1; -- Indicate failure
    END CATCH
END;
ALTER PROCEDURE UpdateProductionAndStock
    @ProductionID INT,
    @NewProductName NVARCHAR(100),
    @NewQuantity INT,
    @NewLabourCost DECIMAL(10,2),
    @NewRawMaterialUsed NVARCHAR(255),
    @NewDateProduced DATE,
    @NewDescription NVARCHAR(255),
    @OldProductName NVARCHAR(100),
    @OldQuantity INT,
    @OldLabourCost DECIMAL(10,2),
    @OldDescription NVARCHAR(255),
    @AffectedRows INT OUTPUT  -- Output parameter added
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @RowsUpdated INT = 0;
	 DECLARE @CurrentStock INT;
    BEGIN TRY
        BEGIN TRANSACTION;
		        -- Step 1: Get current stock for the old product
        SELECT @CurrentStock = Quantity
        FROM Stock
        WHERE UPPER(ProductName) = UPPER(@OldProductName);

        -- Check if current stock is sufficient to reduce by old quantity
        IF @CurrentStock < @OldQuantity
        BEGIN
            RAISERROR('Insufficient stock to update production. Stock cannot go negative.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Step 1: Update Production Table
        UPDATE Production
        SET ProductName = @NewProductName,
            Quantity = @NewQuantity,
            LabourCost = @NewLabourCost,
            RawMaterialUsed = @NewRawMaterialUsed,
            DateProduced = @NewDateProduced,
            Description = @NewDescription
        WHERE ProductionID = @ProductionID;

        SET @RowsUpdated = @RowsUpdated + @@ROWCOUNT;

        -- Step 2: Update CashFlow Table
        UPDATE CashFlow
        SET Amount = @NewLabourCost,
            Description = @NewDescription,
            CashFlowDate = @NewDateProduced,
            Reason = 'Payment To labour For Production of ' + @NewProductName
        WHERE Reason = 'Payment To Labour For Production of ' + @OldProductName
          AND Description = @OldDescription
          AND Amount = @OldLabourCost;

        SET @RowsUpdated = @RowsUpdated + @@ROWCOUNT;

        -- Step 3: Update Stock Table
        UPDATE Stock
        SET Quantity = Quantity - @OldQuantity
        WHERE UPPER(ProductName) = UPPER(@OldProductName);

        SET @RowsUpdated = @RowsUpdated + @@ROWCOUNT;

        UPDATE Stock
        SET Quantity = Quantity + @NewQuantity
        WHERE UPPER(ProductName) = UPPER(@NewProductName);

        SET @RowsUpdated = @RowsUpdated + @@ROWCOUNT;

        IF NOT EXISTS (SELECT 1 FROM Stock WHERE UPPER(ProductName) = UPPER(@NewProductName))
        BEGIN
            INSERT INTO Stock (ProductName, Quantity)
            VALUES (@NewProductName, @NewQuantity);
            SET @RowsUpdated = @RowsUpdated + 1;
        END

        SET @AffectedRows = @RowsUpdated;

        COMMIT TRANSACTION;
        RETURN 1; -- Success
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        DECLARE @ErrorMessage NVARCHAR(4000);
        SET @ErrorMessage = ERROR_MESSAGE();
        RAISERROR('Error occurred: %s', 16, 1, @ErrorMessage);
        RETURN -1; -- Failure
    END CATCH
END;
Alter PROCEDURE DeleteProductionAndUpdateStock
    @ProductionID INT,
    @ProductName NVARCHAR(100),
    @Amount DECIMAL(10,2),
    @Description NVARCHAR(255),
    @AffectedRows INT OUTPUT  -- Output parameter to track affected rows
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @RowsDeleted INT = 0;
    DECLARE @DeletedQuantity INT;
	DECLARE @CurrentStock INT;
    BEGIN TRY
        BEGIN TRANSACTION;
		        -- Step 1: Get current stock for the old product
        SELECT @CurrentStock = Quantity
        FROM Stock
        WHERE UPPER(ProductName) = UPPER(@ProductName);


        -- Step 1: Get the quantity before deleting from Production
        SELECT @DeletedQuantity = Quantity 
        FROM Production 
        WHERE ProductionID = @ProductionID 
          AND ProductName = @ProductName;
		          -- Check if current stock is sufficient to reduce by old quantity
        IF @CurrentStock < @DeletedQuantity
        BEGIN
            RAISERROR('Insufficient stock to update production. Stock cannot go negative.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END
        -- Step 2: Delete from Production table
        DELETE FROM Production 
        WHERE ProductionID = @ProductionID 
          AND ProductName = @ProductName;

        SET @RowsDeleted = @RowsDeleted + @@ROWCOUNT;

        -- Step 3: Delete from CashFlow table
        DELETE FROM CashFlow 
        WHERE Amount = @Amount 
          AND Description = @Description 
          AND Reason = 'Payment To Labour For Production of ' + @ProductName;

        SET @RowsDeleted = @RowsDeleted + @@ROWCOUNT;

        -- Step 4: Update Stock table
        UPDATE Stock 
        SET Quantity = Quantity - @DeletedQuantity 
        WHERE UPPER(ProductName) = UPPER(@ProductName);

        SET @RowsDeleted = @RowsDeleted + @@ROWCOUNT;

        -- Set the output parameter
        SET @AffectedRows = @RowsDeleted;

        COMMIT TRANSACTION;
        RETURN 1; -- Success
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        DECLARE @ErrorMessage NVARCHAR(4000);
        SET @ErrorMessage = ERROR_MESSAGE();
        RAISERROR('Error occurred: %s', 16, 1, @ErrorMessage);
        RETURN -1; -- Failure
    END CATCH
END;
use FactoryManagementDB;
Alter PROCEDURE InsertCashOrder
    @OrderDate DATE,
    @Quantity INT,
    @UnitPrice DECIMAL(18,2),
    @Description NVARCHAR(MAX),
    @Address NVARCHAR(255),
    @CustomerName NVARCHAR(255),
    @CustomerCNIC NVARCHAR(15),
    @CustomerPhone NVARCHAR(15),
    @StockID INT,
	@RowsAffected INT OUTPUT 
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TotalPrice DECIMAL(18,2) = @Quantity * @UnitPrice;
    DECLARE @OrderID INT;
    

    BEGIN TRANSACTION;

    -- 1. Insert Order
    INSERT INTO Orders (OrderDate, Quantity, UnitPrice, Description, Address, CustomerName, CustomerCNIC, CustomerPhone, LedgerID)
    VALUES (@OrderDate, @Quantity, @UnitPrice, @Description, @Address, @CustomerName, @CustomerCNIC, @CustomerPhone, Null);

    SET @OrderID = SCOPE_IDENTITY(); -- Get the last inserted OrderID

    -- 2. Check if Order Inserted
    SET @RowsAffected = @@ROWCOUNT;
    IF @RowsAffected = 0
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR ('Order could not be inserted.', 16, 1);
        RETURN;
    END

    -- 3. Insert into CashFlow (Inflow Entry)
    INSERT INTO CashFlow (CashFlowDate, Amount, Type, Reason, Description)
    VALUES (@OrderDate, @TotalPrice, 'Inflow', CONCAT('Cash Sale For Cash Order ID: ', @OrderID),@Description );

    -- 4. Update Stock (Reduce Quantity)
    UPDATE Stock
    SET Quantity = Quantity - @Quantity
    WHERE StockID = @StockID;

    -- 5. Check if Stock Updated
    SET @RowsAffected = @@ROWCOUNT;
    IF @RowsAffected = 0
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR ('Stock update failed.', 16, 1);
        RETURN;
    END

    COMMIT TRANSACTION;
END;
Alter PROCEDURE InsertCreditOrder
    @CustomerName NVARCHAR(255),
    @CNIC NVARCHAR(15),
    @Phone NVARCHAR(15),
    @Quantity INT,
    @UnitPrice DECIMAL(18,2),
    @OrderDate DATE,
    @Address NVARCHAR(255),
    @Description NVARCHAR(MAX),
    @StockID INT       -- Product ID
    
AS
BEGIN
    DECLARE @CustomerID INT, @LedgerID INT, @TotalPrice DECIMAL(18,2), @AffectedRows INT
    SET @TotalPrice = @Quantity * @UnitPrice

    -- Step 1: Check if Customer Exists
    SELECT @CustomerID = CustomerID FROM Customer WHERE CNIC = @CNIC

    -- Step 2: Handle New Customer & Ledger
    IF @CustomerID IS NULL
    BEGIN
        -- Insert New Customer
        INSERT INTO Customer (Name, CNIC, PhoneNumber)
        VALUES (@CustomerName, @CNIC, @Phone)
        SET @CustomerID = SCOPE_IDENTITY()

        -- Create New Ledger for Customer
        INSERT INTO Ledger (CustomerID, Amount, Date)
        VALUES (@CustomerID, @TotalPrice, @OrderDate)
        SET @LedgerID = SCOPE_IDENTITY()
    END
    ELSE
    BEGIN
        -- Fetch Existing Ledger
        SELECT @LedgerID = LedgerID FROM Ledger WHERE CustomerID = @CustomerID

        -- Update Existing Ledger Balance
        UPDATE Ledger
        SET Amount = Amount + @TotalPrice
		SET Date = @OrderDate
        WHERE LedgerID = @LedgerID
    END

    -- Step 3: Insert Order
    INSERT INTO Orders (OrderDate, Quantity, UnitPrice, Description, Address, CustomerName, CustomerCNIC, CustomerPhone, LedgerID)
    VALUES (@OrderDate, @Quantity, @UnitPrice, @Description, @Address, @CustomerName, @CNIC, @Phone, @LedgerID)

    -- Get affected rows
    SET @AffectedRows = @@ROWCOUNT

    -- Step 4: Insert into CashFlow
    INSERT INTO CashFlow (CashFlowDate, Amount, Type, Reason, Description)
    VALUES (@OrderDate, @TotalPrice, 'Inflow', 'Order In ledger For Customer : '+@CustomerName, @Description)

    -- Step 5: Update Stock using ProductID
    UPDATE Stock
    SET Quantity = Quantity - @Quantity
    WHERE StockID = @StockID

    -- Return affected rows
    SELECT @AffectedRows AS RowsAffected
END


ALTER PROCEDURE [dbo].[GetAllRecords]
    @TableName NVARCHAR(255),  -- Table ka naam
    @Condition NVARCHAR(MAX) = NULL -- Optional condition
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SQLQuery NVARCHAR(MAX);

    -- Base query
    SET @SQLQuery = 'SELECT * FROM ' + QUOTENAME(@TableName);

    -- Agr condition di gayi ho, to WHERE clause add karo
    IF @Condition IS NOT NULL AND LTRIM(RTRIM(@Condition)) <> ''
        SET @SQLQuery = @SQLQuery + ' WHERE ' + @Condition;

    -- Execute the query
    EXEC sp_executesql @SQLQuery;
END;



Alter PROCEDURE DeleteOrder
    @OrderID INT
AS
BEGIN
    SET NOCOUNT OFF;

    -- Step 1: Fetch Order Details Before Deletion
    DECLARE @Quantity INT, @ProductName NVARCHAR(255), @TotalPrice DECIMAL(18,2), 
            @LedgerID INT, @CustomerName NVARCHAR(255), @Description NVARCHAR(MAX),
    @TotalAffectedRows INT = 0;
    SELECT @Quantity = Quantity, 
           @ProductName = Product, 
           @TotalPrice = TotalPrice, 
           @LedgerID = LedgerID,
           @Description = Description,
           @CustomerName = CustomerName
    FROM Orders
    WHERE OrderID = @OrderID;

    -- Step 2: Restore Stock Quantity (Ensure ProductName is unique)
    UPDATE Stock
    SET Quantity = Quantity + @Quantity
    WHERE ProductName = @ProductName;
	SET @TotalAffectedRows = @TotalAffectedRows + @@ROWCOUNT;
    -- Step 3: Handle Cash Flow & Ledger Adjustment
    IF @LedgerID IS NOT NULL
    BEGIN
        -- Update Ledger Balance
        UPDATE Ledger
        SET Amount = Amount - @TotalPrice
        WHERE LedgerID = @LedgerID;
		SET @TotalAffectedRows = @TotalAffectedRows + @@ROWCOUNT;
        -- Delete from CashFlow for Credit Order
        DELETE FROM CashFlow
        WHERE Amount = @TotalPrice 
          AND Reason = 'Order In Ledger For Customer : '+ @CustomerName;
		  SET @TotalAffectedRows = @TotalAffectedRows + @@ROWCOUNT;
    END
    ELSE
    BEGIN
        -- Delete from CashFlow for Cash Order
        DELETE FROM CashFlow
        WHERE Amount = @TotalPrice 
          AND Reason = 'Cash Sale For Cash Order ID: '+CAST(@OrderID AS NVARCHAR(50));
		  SET @TotalAffectedRows = @TotalAffectedRows + @@ROWCOUNT;
    END;

    -- Step 4: Delete Order
    DELETE FROM Orders WHERE OrderID = @OrderID;
	SET @TotalAffectedRows = @TotalAffectedRows + @@ROWCOUNT;

	  -- Step 5: Return Total Affected Rows
    SELECT @TotalAffectedRows AS TotalRowsAffected;
END;
USE FactoryManagementDB;



-- Temporarily disable foreign key constraints
EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL';

-- Delete all records and reset identity correctly
EXEC sp_MSforeachtable 'IF OBJECTPROPERTY(OBJECT_ID(''?''), ''TableHasIdentity'') = 1 
                        BEGIN 
                            DELETE FROM ?; 
                            DBCC CHECKIDENT (''?'', RESEED, 0);
                        END
                        ELSE
                        BEGIN
                            DELETE FROM ?;
                        END';

-- Re-enable foreign key constraints
EXEC sp_MSforeachtable 'ALTER TABLE ? CHECK CONSTRAINT ALL';

DBCC CHECKIDENT ('CashFlow', RESEED, 0);
DBCC CHECKIDENT ('Customer', RESEED, 0);
DBCC CHECKIDENT ('Ledger', RESEED, 0);
DBCC CHECKIDENT ('Orders', RESEED, 0);
DBCC CHECKIDENT ('Production', RESEED, 0);
DBCC CHECKIDENT ('RawMaterials', RESEED, 0);
DBCC CHECKIDENT ('Stock', RESEED, 0);

Alter PROCEDURE ClearLedger
    @LedgerID INT,
    @Amount DECIMAL(18,2) = NULL  -- Optional: If NULL, clear the full balance
AS
BEGIN
    SET NOCOUNT OFF;

    -- If @Amount is provided, subtract it; otherwise, reset to 0
    IF @Amount IS NOT NULL
    BEGIN
        UPDATE Ledger
        SET Amount = Amount - @Amount
        WHERE LedgerID = @LedgerID;
    END
    ELSE
    BEGIN
        UPDATE Ledger
        SET Amount = 0
        WHERE LedgerID = @LedgerID;
    END
END;
CREATE PROCEDURE GetDailySummary
    @Date DATE
AS
BEGIN
    -- Total Cash Inflow
    DECLARE @TotalInflow DECIMAL(18,2)
    SELECT @TotalInflow = ISNULL(SUM(Amount), 0)
    FROM CashFlow
    WHERE CashFlowDate = @Date AND Type = 'Inflow';

    -- Total Cash Outflow
    DECLARE @TotalOutflow DECIMAL(18,2)
    SELECT @TotalOutflow = ISNULL(SUM(Amount), 0)
    FROM CashFlow
    WHERE CashFlowDate = @Date AND Type = 'Outflow';

    -- Net Flow (Inflow - Outflow)
    DECLARE @NetFlow DECIMAL(18,2) = @TotalInflow - @TotalOutflow;

    -- Total Orders Count
    DECLARE @TotalOrders INT
    SELECT @TotalOrders = COUNT(*)
    FROM Orders
    WHERE OrderDate = @Date;

    -- Return results
    SELECT 
        @TotalInflow AS TotalInflow, 
        @TotalOutflow AS TotalOutflow, 
        @NetFlow AS NetFlow, 
        @TotalOrders AS TotalOrders;
END;




CREATE TABLE LedgerClearanceLog (
    ClearanceID INT IDENTITY(1,1) PRIMARY KEY,
    LedgerID INT,
    ClearedAmount DECIMAL(18,2),
    RemainingBalance DECIMAL(18,2),
    ClearanceDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (LedgerID) REFERENCES Ledger(LedgerID),
);


  ALTER PROCEDURE [dbo].[ClearLedger]
    @LedgerID INT,
    @Amount DECIMAL(18,2) = NULL  -- NULL ho to pura clear hoga
AS
BEGIN
    SET NOCOUNT Off;

    DECLARE @ClearedAmount DECIMAL(18,2);
    DECLARE @RemainingBalance DECIMAL(18,2);
    DECLARE @CustomerID INT;
    DECLARE @CustomerName NVARCHAR(255);
    DECLARE @DateNow DATETIME = GETDATE();

    -- Ledger se customer ID aur current amount nikal lo
    SELECT @CustomerID = CustomerID, @ClearedAmount = Amount 
    FROM Ledger WHERE LedgerID = @LedgerID;

    -- Customer ka naam nikal lo
    SELECT @CustomerName = Name FROM Customer WHERE CustomerID = @CustomerID;

    -- NULL ho to pura clear, warna jitna diya hai utna minus karo
    IF @Amount IS NOT NULL
    BEGIN
        SET @ClearedAmount = @Amount;
        UPDATE Ledger
        SET Amount = Amount - @Amount
        WHERE LedgerID = @LedgerID;
    END
    ELSE
    BEGIN
        UPDATE Ledger
        SET Amount = 0
        WHERE LedgerID = @LedgerID;
    END

    -- Updated remaining balance le lo
    SELECT @RemainingBalance = Amount FROM Ledger WHERE LedgerID = @LedgerID;

    -- **Ledger Clearance Log Entry**
    INSERT INTO LedgerClearanceLog (LedgerID, ClearedAmount, RemainingBalance, ClearanceDate)
    VALUES (@LedgerID, @ClearedAmount, @RemainingBalance, @DateNow);

    -- **CashFlow me entry dal do**
    INSERT INTO CashFlow (CashFlowDate, Amount, Type, Reason, Description)
    VALUES (
        @DateNow, 
        @ClearedAmount, 
        'Inflow', 
        'Clearance in Ledger for Customer: ' + @CustomerName, 
        'Amount Cleared in Ledger'
    );

    -- Done!
END;


Alter PROCEDURE AddRawMaterial_CashPurchase
    @MaterialName NVARCHAR(255),
    @Quantity INT,
    @PricePerUnit DECIMAL(18,2),
    @TotalPrice DECIMAL(18,2),
    @DateAdded DATE,
    @Description NVARCHAR(500),
    @ProviderName NVARCHAR(255),
    @ProviderContact NVARCHAR(50),
    @ProviderCNIC NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT OFF;

    -- Insert into RawMaterials Table
    INSERT INTO [FactoryManagementDB].[dbo].[RawMaterials] 
        (MaterialName, Quantity, PricePerUnit,  DateAdded, Description, 
         ProviderName, ProviderContact, ProviderCNIC, LedgerID)
    VALUES 
        (@MaterialName, @Quantity, @PricePerUnit,  @DateAdded, @Description, 
         @ProviderName, @ProviderContact, @ProviderCNIC, NULL);

    -- Insert into CashFlow Table
    INSERT INTO [FactoryManagementDB].[dbo].[CashFlow] 
        (CashFlowDate, Amount, Type, Reason, Description)
    VALUES 
        (@DateAdded, @TotalPrice, 'Outflow', 'Raw Material Purchase Name : '+@MaterialName, @Description);
    
  
END;

   

   USE [FactoryManagementDB]
GO

Create PROCEDURE [dbo].[InsertCreditRawMaterial]
    @ProviderID INT = NULL, 
    @ProviderName NVARCHAR(255),
    @ProviderCNIC NVARCHAR(15),
    @ProviderContact NVARCHAR(15),
    @MaterialName NVARCHAR(255),
    @Quantity INT,
    @PricePerUnit DECIMAL(18,2),
    @DateAdded DATE,
    @Description NVARCHAR(MAX)
AS
BEGIN
   SET NOCOUNT OFF;
    DECLARE @LedgerID INT, @TotalPrice DECIMAL(18,2), @AffectedRows INT
    SET @TotalPrice = @Quantity * @PricePerUnit

    -- Step 1: Handle New Provider & Ledger
    IF @ProviderID IS NULL
    BEGIN
        -- Insert New Provider
        INSERT INTO Providers (ProviderName, CNIC, Contact)
        VALUES (@ProviderName, @ProviderCNIC, @ProviderContact)
        SET @ProviderID = SCOPE_IDENTITY()

        -- Create New Ledger for Provider
        INSERT INTO ProviderLedger (ProviderID, Amount, LedgerDate)
        VALUES (@ProviderID, @TotalPrice, @DateAdded)
        SET @LedgerID = SCOPE_IDENTITY()
    END
    ELSE
    BEGIN
        -- Fetch Existing Ledger
        SELECT @LedgerID = LedgerID FROM ProviderLedger WHERE ProviderID = @ProviderID

        -- Update Existing Ledger Balance
        UPDATE ProviderLedger
        SET Amount = Amount + @TotalPrice,
            LedgerDate = @DateAdded
        WHERE LedgerID = @LedgerID
    END

    -- Step 2: Insert Raw Material Entry
    INSERT INTO RawMaterials (MaterialName, Quantity, PricePerUnit,  DateAdded, Description, ProviderName, ProviderContact, ProviderCNIC, LedgerID)
    VALUES (@MaterialName, @Quantity, @PricePerUnit,  @DateAdded, @Description, @ProviderName, @ProviderContact, @ProviderCNIC, @LedgerID)

    -- Get affected rows
    SET @AffectedRows = @@ROWCOUNT

    -- Return affected rows
    SELECT @AffectedRows AS RowsAffected
END
    


	-- Step 1: Disable All Foreign Key Constraints
EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'

-- Step 2: Delete All Data from Every Table
EXEC sp_MSforeachtable 'DELETE FROM ?'

-- Step 3: Reset Identity Columns to Start from 1
EXEC sp_MSforeachtable 'IF OBJECTPROPERTY(OBJECT_ID(''?''), ''TableHasIdentity'') = 1 DBCC CHECKIDENT (''?'', RESEED, 0)'

-- Step 4: Re-enable All Foreign Key Constraints
EXEC sp_MSforeachtable 'ALTER TABLE ? CHECK CONSTRAINT ALL'




USE [FactoryManagementDB]
GO

Create PROCEDURE [dbo].[ClearProviderLedger]
    @LedgerID INT,
    @Amount DECIMAL(18,2) = NULL  -- NULL ho to pura clear hoga
AS
BEGIN
    SET NOCOUNT OFF;

    DECLARE @ClearedAmount DECIMAL(18,2);
    DECLARE @RemainingBalance DECIMAL(18,2);
    DECLARE @ProviderID INT;
    DECLARE @ProviderName NVARCHAR(255);
    DECLARE @DateNow DATETIME = GETDATE();

    -- ProviderLedger se ProviderID aur current amount nikal lo
    SELECT @ProviderID = ProviderID, @ClearedAmount = Amount 
    FROM ProviderLedger WHERE LedgerID = @LedgerID;

    -- Provider ka naam nikal lo
    SELECT @ProviderName = ProviderName FROM Providers WHERE ProviderID = @ProviderID;

    -- NULL ho to pura clear, warna jitna diya hai utna minus karo
    IF @Amount IS NOT NULL
    BEGIN
        SET @ClearedAmount = @Amount;
        UPDATE ProviderLedger
        SET Amount = Amount - @Amount
        WHERE LedgerID = @LedgerID;
    END
    ELSE
    BEGIN
        UPDATE ProviderLedger
        SET Amount = 0
        WHERE LedgerID = @LedgerID;
    END

    -- Updated remaining balance le lo
    SELECT @RemainingBalance = Amount FROM ProviderLedger WHERE LedgerID = @LedgerID;

    -- **Provider Ledger Clearance Log Entry**
    INSERT INTO ProviderLedgerClearanceLog (LedgerID, AmountPaid, RemainingBalance, ClearanceDate)
    VALUES (@LedgerID, @ClearedAmount, @RemainingBalance, @DateNow);

    -- **CashFlow me entry dal do**
    INSERT INTO CashFlow (CashFlowDate, Amount, Type, Reason, Description)
    VALUES (
        @DateNow, 
        @ClearedAmount, 
        'Outflow', 
        'Clearance in Provider Ledger for Provider: ' + @ProviderName, 
        'Amount Cleared in Provider Ledger'
    );

    -- Done!
END;



USE [FactoryManagementDB]
GO

Alter PROCEDURE [dbo].[DeleteProviderLedgerClearance]
    @ClearanceID INT,
    @LedgerID INT,
    @ProviderName NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT OFF;

    DECLARE @Amount DECIMAL(18,2);
    DECLARE @RemainingBalance DECIMAL(18,2);
    DECLARE @ClearanceDate DATETIME;
    DECLARE @CashFlowID INT;

    -- **Step 1: Clearance Table se Amount, Remaining Balance, aur Date nikaal lo**
    SELECT @Amount = AmountPaid, 
           @RemainingBalance = RemainingBalance, 
           @ClearanceDate = ClearanceDate
    FROM ProviderLedgerClearanceLog
    WHERE ClearanceID = @ClearanceID;

    IF @Amount IS NULL
    BEGIN
        PRINT 'No matching clearance entry found!';
        RETURN;
    END

    -- **Step 2: ProviderLedger me amount restore karo**
    UPDATE ProviderLedger
    SET Amount = Amount - @Amount
    WHERE LedgerID = @LedgerID;

    -- **Step 3: Clearance Table se entry delete karo**
    DELETE FROM ProviderLedgerClearanceLog WHERE ClearanceID = @ClearanceID;

    -- **Step 4: CashFlow se matching entry delete karo**
    DELETE FROM CashFlow
    WHERE Amount = @Amount 
          AND Type = 'Outflow' 
          AND Reason = 'Clearance in Provider Ledger for Provider: ' + @ProviderName
          



    PRINT 'Clearance reversal successful!';
END;



Alter PROCEDURE [dbo].[DeleteClientLedgerClearance]
    @ClearanceID INT,
    @LedgerID INT,
    @ClientName NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT OFF;

    DECLARE @Amount DECIMAL(18,2);
    DECLARE @RemainingBalance DECIMAL(18,2);
    DECLARE @ClearanceDate DATETIME;

    -- **Step 1: Clearance Table se Amount, Remaining Balance, aur Date nikaal lo**
    SELECT @Amount = ClearedAmount, 
           @RemainingBalance = RemainingBalance, 
           @ClearanceDate = ClearanceDate
    FROM LedgerClearanceLog
    WHERE ClearanceID = @ClearanceID;

    IF @Amount IS NULL
    BEGIN
        PRINT 'No matching clearance entry found!';
        RETURN;
    END

    -- **Step 2: Client Ledger me amount restore karo**
    UPDATE Ledger
    SET Amount = Amount + @Amount
    WHERE LedgerID = @LedgerID;

    -- **Step 3: Clearance Table se entry delete karo**
    DELETE FROM LedgerClearanceLog WHERE ClearanceID = @ClearanceID;

    -- **Step 4: CashFlow se matching entry delete karo**
    DELETE FROM CashFlow
    WHERE Amount = @Amount 
          AND Type = 'Inflow' 
          AND Reason = 'Clearance in Ledger for Customer: ' + @ClientName;

    PRINT 'Clearance reversal successful!';
END;
