USE [ControlEdificios]
GO
/****** Object:  Table [dbo].[Accesos]    Script Date: 19/05/2025 11:25:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accesos](
	[AccesoID] [int] IDENTITY(1,1) NOT NULL,
	[EmpleadoID] [int] NULL,
	[VisitanteID] [int] NULL,
	[ZonaID] [int] NULL,
	[FechaHoraEntrada] [datetime] NOT NULL,
	[FechaHoraSalida] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[AccesoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlertaSeguridad]    Script Date: 19/05/2025 11:25:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlertaSeguridad](
	[AlertaID] [int] IDENTITY(1,1) NOT NULL,
	[EmpleadoID] [int] NOT NULL,
	[FechaHora] [datetime] NULL,
	[TipoAlerta] [nvarchar](100) NULL,
	[Descripcion] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[AlertaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 19/05/2025 11:25:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[EmpleadoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Rol] [nvarchar](50) NOT NULL,
	[ZonaAcceso] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 19/05/2025 11:25:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Usuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Rol] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visitantes]    Script Date: 19/05/2025 11:25:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visitantes](
	[VisitanteID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Telefono] [nvarchar](50) NULL,
	[MotivoVisita] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[VisitanteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zonas]    Script Date: 19/05/2025 11:25:05 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zonas](
	[ZonasID] [int] IDENTITY(1,1) NOT NULL,
	[NombreZona] [nvarchar](50) NOT NULL,
	[AccesoRestringido] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ZonasID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Accesos]  WITH CHECK ADD FOREIGN KEY([EmpleadoID])
REFERENCES [dbo].[Empleados] ([EmpleadoID])
GO
ALTER TABLE [dbo].[Accesos]  WITH CHECK ADD FOREIGN KEY([VisitanteID])
REFERENCES [dbo].[Visitantes] ([VisitanteID])
GO
ALTER TABLE [dbo].[Accesos]  WITH CHECK ADD FOREIGN KEY([ZonaID])
REFERENCES [dbo].[Zonas] ([ZonasID])
GO
ALTER TABLE [dbo].[AlertaSeguridad]  WITH CHECK ADD FOREIGN KEY([EmpleadoID])
REFERENCES [dbo].[Empleados] ([EmpleadoID])
GO
/****** Object:  StoredProcedure [dbo].[SP_GenerarAlerta]    Script Date: 19/05/2025 11:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GenerarAlerta]
	@EmpleadoID INT,
	@TipoAlerta NVARCHAR(100),
	@Descripcion NVARCHAR(200)
AS
BEGIN
	INSERT INTO [ControlEdificios].[dbo].[AlertaSeguridad] (EmpleadoID, FechaHora, TipoAlerta, Descripcion)
	VALUES (@EmpleadoID, GETDATE(), @TipoAlerta, @Descripcion);
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarAccesoEmpleado]    Script Date: 19/05/2025 11:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistrarAccesoEmpleado]
	@EmpleadoID INT,
	@ZonaID INT,
	@FechaEntrada DATETIME
AS
BEGIN
	INSERT INTO	[ControlEdificios].[dbo].[Accesos](EmpleadoID, ZonaID, FechaHoraEntrada, VisitanteID)
	VALUES (@EmpleadoID, @ZonaID, @FechaEntrada, NULL);
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarAccesoVisitante]    Script Date: 19/05/2025 11:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistrarAccesoVisitante]
	@VisitanteID INT,
	@ZonaID INT,
	@FechaEntrada DATETIME
AS
BEGIN
	 INSERT INTO [ControlEdificios].[dbo].[Accesos] (VisitanteID, ZonaID, FechaHoraEntrada, EmpleadoID)
	 VALUES (@VisitanteID, @ZonaID, @FechaEntrada, NULL);
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ValidarLogin]    Script Date: 19/05/2025 11:25:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ValidarLogin]
	@Usuario NVARCHAR(50),
	@Contraseña NVARCHAR(50)
AS
BEGIN
	SELECT Usuario, Contraseña, Rol
	FROM [ControlEdificios].[dbo].[Usuarios]
	WHERE Usuario = @Usuario AND Contraseña = @Contraseña;
END
GO
