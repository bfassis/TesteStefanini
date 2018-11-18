CREATE TABLE [dbo].[VinculoClienteProduto](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[CodigoProduto] [int] NOT NULL,
	[CodigoCliente] [int] NOT NULL,
 CONSTRAINT [PK_VinculoClienteProduto] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[VinculoClienteProduto]  WITH CHECK ADD  CONSTRAINT [FK_VinculoClienteProduto_Cliente] FOREIGN KEY([CodigoCliente])
REFERENCES [dbo].[Cliente] ([Codigo])
GO

ALTER TABLE [dbo].[VinculoClienteProduto] CHECK CONSTRAINT [FK_VinculoClienteProduto_Cliente]
GO

ALTER TABLE [dbo].[VinculoClienteProduto]  WITH CHECK ADD  CONSTRAINT [FK_VinculoClienteProduto_Produto] FOREIGN KEY([CodigoProduto])
REFERENCES [dbo].[Produto] ([Codigo])
GO

ALTER TABLE [dbo].[VinculoClienteProduto] CHECK CONSTRAINT [FK_VinculoClienteProduto_Produto]
GO


