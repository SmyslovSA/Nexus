CREATE TABLE [dbo].[Salers] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Address]     NVARCHAR (100) NOT NULL,
    [CompanyName] NVARCHAR (50)  NULL,
    [Summary]     NVARCHAR (MAX) NULL,
    [User_ID]     INT            NOT NULL,
    CONSTRAINT [PK_Salers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Salers_Users] FOREIGN KEY ([User_ID]) REFERENCES [dbo].[Users] ([Id])
);

