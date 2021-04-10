CREATE TABLE Animal (
    IdAnimal int  NOT NULL IDENTITY,
    Name nvarchar(100)  NOT NULL,
    Type nvarchar(100)  NOT NULL,
    AdmissionDate date  NOT NULL,
    IdOwner int  NOT NULL,
    CONSTRAINT Animal_pk PRIMARY KEY  (IdAnimal)
);

-- Table: Owner
CREATE TABLE Owner (
    IdOwner int  NOT NULL IDENTITY,
    FirstName nvarchar(100)  NOT NULL,
    LastName nvarchar(100)  NOT NULL,
    CONSTRAINT Owner_pk PRIMARY KEY  (IdOwner)
);

-- Table: Procedure
CREATE TABLE [Procedure] (
    IdProcedure int  NOT NULL IDENTITY,
    Name nvarchar(100)  NOT NULL,
    Description nvarchar(100)  NOT NULL,
    CONSTRAINT Procedure_pk PRIMARY KEY  (IdProcedure)
);

-- Table: Procedure_Animal
CREATE TABLE Procedure_Animal (
    Procedure_IdProcedure int  NOT NULL,
    Animal_IdAnimal int  NOT NULL,
    Date date  NOT NULL,
    CONSTRAINT Procedure_Animal_pk PRIMARY KEY  (Procedure_IdProcedure,Animal_IdAnimal,Date)
);

-- foreign keys
-- Reference: Animal_Owner (table: Animal)
ALTER TABLE Animal ADD CONSTRAINT Animal_Owner
    FOREIGN KEY (IdOwner)
    REFERENCES Owner (IdOwner);

-- Reference: Table_3_Animal (table: Procedure_Animal)
ALTER TABLE Procedure_Animal ADD CONSTRAINT Table_3_Animal
    FOREIGN KEY (Animal_IdAnimal)
    REFERENCES Animal (IdAnimal);

-- Reference: Table_3_Procedure (table: Procedure_Animal)
ALTER TABLE Procedure_Animal ADD CONSTRAINT Table_3_Procedure
    FOREIGN KEY (Procedure_IdProcedure)
    REFERENCES "Procedure" (IdProcedure);