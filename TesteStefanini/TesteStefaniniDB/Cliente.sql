

CREATE TABLE [dbo].[Cliente](
	[Codigo] [int] NOT NULL,
	[Nome] [varchar](20) NOT NULL,
	[Sobrenome] [varchar](30) NOT NULL,
	[DataNascimento] [date] NOT NULL,
	[Sexo] [varchar](20) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


