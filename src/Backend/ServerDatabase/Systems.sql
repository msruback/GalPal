CREATE TABLE [dbo].[Systems]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [EDDBId] INT NULL, 
    [Name] NVARCHAR(100) NULL, 
    [X] DECIMAL(18, 4) NULL, 
    [Y] DECIMAL(18, 4) NULL, 
    [Z] DECIMAL(18, 4) NULL, 
    [Population] INT NULL, 
    [GovernmentId] INT NULL, 
    [AllegianceId] INT NULL, 
    [StateId] INT NULL, 
    [SecurityId] INT NULL, 
    [EconomyId] INT NULL, 
    [ReserveId] INT NULL, 
    [PowerStateId] INT NULL, 
    [PowerId] INT NULL, 
    [IsPermitLocked] BIT NULL, 
    [IsPopulated] BIT NULL, 
    [Updated] DECIMAL NULL
)
