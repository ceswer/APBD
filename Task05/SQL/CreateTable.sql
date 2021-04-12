CREATE TABLE "Order" (
    IdOrder int  NOT NULL IDENTITY,
    IdProduct int  NOT NULL,
    Amount int  NOT NULL,
    CreatedAt datetime  NOT NULL,
    FulfilledAt datetime  NULL,
    CONSTRAINT Order_pk PRIMARY KEY  (IdOrder)
);

-- Table: Product
CREATE TABLE Product (
    IdProduct int  NOT NULL IDENTITY,
    Name nvarchar(200)  NOT NULL,
    Description nvarchar(200)  NOT NULL,
    Price numeric(25,2)  NOT NULL,
    CONSTRAINT Product_pk PRIMARY KEY  (IdProduct)
);

-- Table: Product_Warehouse
CREATE TABLE Product_Warehouse (
    IdProductWarehouse int  NOT NULL IDENTITY,
    IdWarehouse int  NOT NULL,
    IdProduct int  NOT NULL,
    IdOrder int  NOT NULL,
    Amount int  NOT NULL,
    Price numeric(25,2)  NOT NULL,
    CreatedAt datetime  NOT NULL,
    CONSTRAINT Product_Warehouse_pk PRIMARY KEY  (IdProductWarehouse)
);

-- Table: Warehouse
CREATE TABLE Warehouse (
    IdWarehouse int  NOT NULL IDENTITY,
    Name nvarchar(200)  NOT NULL,
    Address nvarchar(200)  NOT NULL,
    CONSTRAINT Warehouse_pk PRIMARY KEY  (IdWarehouse)
);

-- foreign keys
-- Reference: Product_Warehouse_Order (table: Product_Warehouse)
ALTER TABLE Product_Warehouse ADD CONSTRAINT Product_Warehouse_Order
    FOREIGN KEY (IdOrder)
    REFERENCES "Order" (IdOrder);

-- Reference: Receipt_Product (table: Order)
ALTER TABLE "Order" ADD CONSTRAINT Receipt_Product
    FOREIGN KEY (IdProduct)
    REFERENCES Product (IdProduct);

-- Reference: _Product (table: Product_Warehouse)
ALTER TABLE Product_Warehouse ADD CONSTRAINT _Product
    FOREIGN KEY (IdProduct)
    REFERENCES Product (IdProduct);

-- Reference: _Warehouse (table: Product_Warehouse)
ALTER TABLE Product_Warehouse ADD CONSTRAINT _Warehouse
    FOREIGN KEY (IdWarehouse)
    REFERENCES Warehouse (IdWarehouse);

-- End of file.

GO

INSERT INTO Warehouse(Name, Address)
VALUES('Warsaw', 'Kwiatowa 12');

GO

INSERT INTO Product(Name, Description, Price)
VALUES ('Abacavir', '', 25.5),
('Acyclovir', '', 45.0),
('Allopurinol', '', 30.8);

INSERT INTO "Order"(IdProduct, Amount, CreatedAt)
VALUES((SELECT IdProduct FROM Product WHERE Name='Abacavir'), 125, GETDATE());