CREATE TABLE [dbo].[Cards] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Description] NVARCHAR (64)    DEFAULT (N'') NOT NULL,
    [BankId]      INT              NOT NULL,
    [ExparyDate]  DATETIME         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([BankId]) REFERENCES [dbo].[Banks] ([Id])
);

