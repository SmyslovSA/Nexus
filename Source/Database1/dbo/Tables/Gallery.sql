CREATE TABLE [dbo].[Gallery] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Image]     BINARY (200)  NOT NULL,
    [ImageName] NVARCHAR (50) NULL,
    [Saler_ID]  INT           NOT NULL,
    CONSTRAINT [PK_Gallery] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Gallery_Salers] FOREIGN KEY ([Saler_ID]) REFERENCES [dbo].[Salers] ([Id])
);

