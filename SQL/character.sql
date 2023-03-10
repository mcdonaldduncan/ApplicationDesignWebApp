USE [PROG455SP23]
GO
/****** Object:  Table [dbo].[Character]    Script Date: 2/15/2023 2:23:15 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Character]') AND type in (N'U'))
DROP TABLE [dbo].[Character]
GO
/****** Object:  Table [dbo].[Character]    Script Date: 2/15/2023 2:23:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Character](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[Element_Type] [nchar](50) NOT NULL,
	[Job_Class] [nchar](50) NOT NULL,
	[ATK] [int] NOT NULL,
	[DEF] [int] NOT NULL,
	[Mana] [int] NOT NULL,
	[HP_Initial] [int] NOT NULL,
	[HP_Max] [int] NOT NULL,
	[NPC] [bit] NOT NULL,
 CONSTRAINT [PK_Character] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Character] ON 

INSERT [dbo].[Character] ([ID], [Name], [Element_Type], [Job_Class], [ATK], [DEF], [Mana], [HP_Initial], [HP_Max], [NPC]) VALUES (1, N'Tree Sentinel                                     ', N'Holy                                              ', N'Guard                                             ', 35, 57, 40, 1000, 1000, 1)
INSERT [dbo].[Character] ([ID], [Name], [Element_Type], [Job_Class], [ATK], [DEF], [Mana], [HP_Initial], [HP_Max], [NPC]) VALUES (2, N'Phalanx                                           ', N'Unknown                                           ', N'Player                                            ', 78, 113, 25, 1854, 2000, 0)
INSERT [dbo].[Character] ([ID], [Name], [Element_Type], [Job_Class], [ATK], [DEF], [Mana], [HP_Initial], [HP_Max], [NPC]) VALUES (3, N'Placidusax                                        ', N'Lightning                                         ', N'Ancient Dragon                                    ', 99, 99, 1200, 9000, 9000, 1)
INSERT [dbo].[Character] ([ID], [Name], [Element_Type], [Job_Class], [ATK], [DEF], [Mana], [HP_Initial], [HP_Max], [NPC]) VALUES (4, N'Maliketh                                          ', N'Death                                             ', N'Rune Bearer                                       ', 168, 54, 600, 3000, 6000, 1)
INSERT [dbo].[Character] ([ID], [Name], [Element_Type], [Job_Class], [ATK], [DEF], [Mana], [HP_Initial], [HP_Max], [NPC]) VALUES (5, N'Commander O''Neal                                  ', N'Rot                                               ', N'Fort Commander                                    ', 56, 85, 15, 1500, 1500, 1)
INSERT [dbo].[Character] ([ID], [Name], [Element_Type], [Job_Class], [ATK], [DEF], [Mana], [HP_Initial], [HP_Max], [NPC]) VALUES (7, N'Godrick The Grafted                               ', N'Holy                                              ', N'Demigod                                           ', 55, 55, 55, 1000, 1000, 1)
SET IDENTITY_INSERT [dbo].[Character] OFF
GO
