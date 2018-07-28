CREATE TABLE [dbo].[CardBalance] (
    [CardId]  UNIQUEIDENTIFIER NOT NULL,
    [Date]    DATETIME         DEFAULT (getdate()) NOT NULL,
    [Balance] MONEY            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([CardId] ASC, [Date] ASC),
    FOREIGN KEY ([CardId]) REFERENCES [dbo].[Cards] ([Id])
);

