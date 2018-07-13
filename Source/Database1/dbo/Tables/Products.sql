CREATE TABLE [dbo].[Products] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [PartNumber]  NVARCHAR (50)  NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Maker]       NVARCHAR (50)  NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Price]       MONEY          NOT NULL,
    [Image]       BINARY (200)   NULL,
    [Saler_ID]    INT            NOT NULL,
    [Order_ID]    INT            NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Products_Orders] FOREIGN KEY ([Order_ID]) REFERENCES [dbo].[Orders] ([Id]),
    CONSTRAINT [FK_Products_Salers] FOREIGN KEY ([Saler_ID]) REFERENCES [dbo].[Salers] ([Id])
);

