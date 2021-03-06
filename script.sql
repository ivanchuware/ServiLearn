USE [ServiLearn]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 14/12/2020 17:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin](
	[id_Admin] [int] NOT NULL,
	[email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[id_Admin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 14/12/2020 17:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alumno](
	[id_Alumno] [int] NOT NULL,
	[email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[id_Alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cuenta]    Script Date: 14/12/2020 17:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cuenta](
	[id_Cuenta] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[clave] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Cuenta] PRIMARY KEY CLUSTERED 
(
	[id_Cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cuenta_Curso]    Script Date: 14/12/2020 17:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuenta_Curso](
	[id_Cuenta] [int] NOT NULL,
	[id_Curso] [int] NOT NULL,
 CONSTRAINT [PK_Cuenta_Curso] PRIMARY KEY CLUSTERED 
(
	[id_Cuenta] ASC,
	[id_Curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cuenta_Evento]    Script Date: 14/12/2020 17:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuenta_Evento](
	[id_Cuenta] [int] NOT NULL,
	[id_Evento] [int] NOT NULL,
 CONSTRAINT [PK_Cuenta_Evento] PRIMARY KEY CLUSTERED 
(
	[id_Cuenta] ASC,
	[id_Evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Curso]    Script Date: 14/12/2020 17:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[id_Curso] [int] IDENTITY(1,1) NOT NULL,
	[id_Owner] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](600) NULL,
	[post] [nvarchar](4000) NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[id_Curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Docente]    Script Date: 14/12/2020 17:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Docente](
	[id_Docente] [int] NOT NULL,
	[email] [varchar](100) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Docente] PRIMARY KEY CLUSTERED 
(
	[id_Docente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Evento]    Script Date: 14/12/2020 17:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento](
	[id_Evento] [int] IDENTITY(1,1) NOT NULL,
	[id_Owner] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](600) NULL,
	[post] [nvarchar](4000) NULL,
	[fecha] [date] NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[id_Evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Invitado]    Script Date: 14/12/2020 17:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invitado](
	[id_Invitado] [int] NOT NULL,
 CONSTRAINT [PK_Invitado] PRIMARY KEY CLUSTERED 
(
	[id_Invitado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ong]    Script Date: 14/12/2020 17:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ong](
	[id_Ong] [int] NOT NULL,
	[email] [varchar](100) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Ong] PRIMARY KEY CLUSTERED 
(
	[id_Ong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK_Admin_Cuenta] FOREIGN KEY([id_Admin])
REFERENCES [dbo].[Cuenta] ([id_Cuenta])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_Cuenta]
GO
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Cuenta] FOREIGN KEY([id_Alumno])
REFERENCES [dbo].[Cuenta] ([id_Cuenta])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_Cuenta]
GO
ALTER TABLE [dbo].[Cuenta_Curso]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Curso_Cuenta] FOREIGN KEY([id_Cuenta])
REFERENCES [dbo].[Cuenta] ([id_Cuenta])
GO
ALTER TABLE [dbo].[Cuenta_Curso] CHECK CONSTRAINT [FK_Cuenta_Curso_Cuenta]
GO
ALTER TABLE [dbo].[Cuenta_Curso]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Curso_Curso] FOREIGN KEY([id_Curso])
REFERENCES [dbo].[Curso] ([id_Curso])
GO
ALTER TABLE [dbo].[Cuenta_Curso] CHECK CONSTRAINT [FK_Cuenta_Curso_Curso]
GO
ALTER TABLE [dbo].[Cuenta_Evento]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Evento_Cuenta] FOREIGN KEY([id_Cuenta])
REFERENCES [dbo].[Cuenta] ([id_Cuenta])
GO
ALTER TABLE [dbo].[Cuenta_Evento] CHECK CONSTRAINT [FK_Cuenta_Evento_Cuenta]
GO
ALTER TABLE [dbo].[Cuenta_Evento]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Evento_Evento] FOREIGN KEY([id_Evento])
REFERENCES [dbo].[Evento] ([id_Evento])
GO
ALTER TABLE [dbo].[Cuenta_Evento] CHECK CONSTRAINT [FK_Cuenta_Evento_Evento]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Cuenta] FOREIGN KEY([id_Owner])
REFERENCES [dbo].[Cuenta] ([id_Cuenta])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Cuenta]
GO
ALTER TABLE [dbo].[Docente]  WITH CHECK ADD  CONSTRAINT [FK_Docente_Cuenta] FOREIGN KEY([id_Docente])
REFERENCES [dbo].[Cuenta] ([id_Cuenta])
GO
ALTER TABLE [dbo].[Docente] CHECK CONSTRAINT [FK_Docente_Cuenta]
GO
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Cuenta] FOREIGN KEY([id_Owner])
REFERENCES [dbo].[Cuenta] ([id_Cuenta])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Cuenta]
GO
ALTER TABLE [dbo].[Invitado]  WITH CHECK ADD  CONSTRAINT [FK_Invitado_Cuenta] FOREIGN KEY([id_Invitado])
REFERENCES [dbo].[Cuenta] ([id_Cuenta])
GO
ALTER TABLE [dbo].[Invitado] CHECK CONSTRAINT [FK_Invitado_Cuenta]
GO
ALTER TABLE [dbo].[Ong]  WITH CHECK ADD  CONSTRAINT [FK_Ong_Cuenta] FOREIGN KEY([id_Ong])
REFERENCES [dbo].[Cuenta] ([id_Cuenta])
GO
ALTER TABLE [dbo].[Ong] CHECK CONSTRAINT [FK_Ong_Cuenta]
GO
