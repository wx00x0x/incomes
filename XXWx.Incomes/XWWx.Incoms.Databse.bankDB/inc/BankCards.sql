﻿CREATE TABLE [inc].[BankCards]
(
	[Id] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID()
	, [BankId] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES [inc].[Banks]([Id])
	, [Description] NVARCHAR(120) NOT NULL
	, [ExpiryDate] NVARCHAR NOT NULL
)
