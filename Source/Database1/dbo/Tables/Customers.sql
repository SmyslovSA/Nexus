CREATE TABLE [dbo].[Customers] (
    [Id]      INT      IDENTITY (1, 1) NOT NULL,
    [DoB]     DATETIME NOT NULL,
    [User_ID] INT      NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Customers_Users] FOREIGN KEY ([User_ID]) REFERENCES [dbo].[Users] ([Id])
);

