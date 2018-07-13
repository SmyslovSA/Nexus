CREATE TABLE [dbo].[Orders] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [StartDate]   DATETIME NOT NULL,
    [EndDate]     DATETIME NOT NULL,
    [Count]       INT      NULL,
    [OrderNumber] INT      NOT NULL,
    [Customer_ID] INT      NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([Customer_ID]) REFERENCES [dbo].[Customers] ([Id])
);

