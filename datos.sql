USE [CTH_INT]
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (1, N'Gabriel', N'Silva', N'gsilva', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (2, N'Lucas', N'Silva', N'lsilva', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (3, N'Administrador', N'Admin', N'Admin', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (4, N'solicitante', N'usuario', N'usolicitante', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (5, N'agente', N'test', N'agentetest', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (6, N'coordinador', N'test', N'coordinadortest', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[usuarios] ([id], [nombre], [apellido], [username], [pass]) VALUES (7, N'jefe', N'tecnico', N'jefetecnico', N'81dc9bdb52d04dc20036dbd8313ed055')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[permiso] ON 

INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Admin', 5, N'Administrador')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Admin_tecnico', 6, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Operador', 7, N'Tecnico')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'OperadorTecnico', 8, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'CoordinadorTec', 9, N'Coordinador')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Coordinador', 10, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Jefe Tecnico', 11, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'profesor', 12, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'permisoProfesor', 13, N'Administrador')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'nueva', 14, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Solicitante', 15, N'Solicitante')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'AgenteTecnico', 16, N'Agente')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Agente_tecnico', 17, NULL)
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Coordinador', 18, N'Coordinador')
INSERT [dbo].[permiso] ([nombre], [id], [permiso]) VALUES (N'Jefe', 19, N'JefeTecnico')
SET IDENTITY_INSERT [dbo].[permiso] OFF
GO
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (4, 15)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (2, 9)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (3, 6)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (3, 11)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (5, 17)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (6, 18)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (7, 19)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (3, 10)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (1, 7)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (1, 12)
GO
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (6, 5)
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (8, 7)
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (11, 5)
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (11, 7)
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (11, 9)
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (12, 13)
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (17, 16)
GO
SET IDENTITY_INSERT [dbo].[equipo] ON 

INSERT [dbo].[equipo] ([id], [nombre], [marca], [numSerie], [fechaAlta], [fechaBaja], [estado], [id_sector]) VALUES (1, N'Cobas', N'Cobas', N'asd123', CAST(N'1980-01-01' AS Date), NULL, 1, 1)
INSERT [dbo].[equipo] ([id], [nombre], [marca], [numSerie], [fechaAlta], [fechaBaja], [estado], [id_sector]) VALUES (2, N'Arco en C', N'Samsung', N'00012344a', CAST(N'2015-10-22' AS Date), NULL, 1, 2)
INSERT [dbo].[equipo] ([id], [nombre], [marca], [numSerie], [fechaAlta], [fechaBaja], [estado], [id_sector]) VALUES (3, N'Compresor Aire', N'Tausem', N'as123as', CAST(N'2019-10-10' AS Date), NULL, 1, 4)
INSERT [dbo].[equipo] ([id], [nombre], [marca], [numSerie], [fechaAlta], [fechaBaja], [estado], [id_sector]) VALUES (4, N'Bomba vacio', N'Pascal', N'78aa88', CAST(N'1901-02-01' AS Date), NULL, 1, 4)
SET IDENTITY_INSERT [dbo].[equipo] OFF
GO
SET IDENTITY_INSERT [dbo].[orden] ON 

INSERT [dbo].[orden] ([id], [fechaCreacion], [fechaFinalizado], [fechaCierre], [solicitante], [coordinador], [agente], [descripcion], [sector], [equipo], [terminada], [finalizada], [cierre], [urgencia], [id_solicitante]) VALUES (1, CAST(N'2021-11-19' AS Date), NULL, NULL, N'solicitante usuario', NULL, NULL, N'no anda', N'sala de gases', 4, NULL, NULL, NULL, N'Critica', 4)
INSERT [dbo].[orden] ([id], [fechaCreacion], [fechaFinalizado], [fechaCierre], [solicitante], [coordinador], [agente], [descripcion], [sector], [equipo], [terminada], [finalizada], [cierre], [urgencia], [id_solicitante]) VALUES (2, CAST(N'2021-11-19' AS Date), NULL, NULL, N'solicitante usuario', NULL, NULL, N'ver', N'laboratorio', 1, NULL, NULL, NULL, N'Baja', 4)
SET IDENTITY_INSERT [dbo].[orden] OFF
GO
SET IDENTITY_INSERT [dbo].[sector] ON 

INSERT [dbo].[sector] ([id], [nombre]) VALUES (1, N'laboratorio')
INSERT [dbo].[sector] ([id], [nombre]) VALUES (2, N'quirofano')
INSERT [dbo].[sector] ([id], [nombre]) VALUES (3, N'recepcion guardia')
INSERT [dbo].[sector] ([id], [nombre]) VALUES (4, N'sala de gases')
INSERT [dbo].[sector] ([id], [nombre]) VALUES (5, N'sala aire comprimido')
SET IDENTITY_INSERT [dbo].[sector] OFF
GO
