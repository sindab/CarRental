USE [CarRental]
GO
/****** Object:  Table [dbo].[Boja]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boja](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NULL,
 CONSTRAINT [PK_Boja] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Drzava]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drzava](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Drzava] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Firma]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Firma](
	[ID] [int] NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[PuniNaziv] [nvarchar](200) NULL,
	[Mjesto] [int] NULL,
	[Adresa] [nvarchar](50) NULL,
	[Telefon] [varchar](50) NULL,
	[Fax] [varchar](50) NULL,
	[Mobilni] [varchar](50) NULL,
	[Maticni] [varchar](50) NULL,
	[PIB] [varchar](50) NULL,
	[JIB] [varchar](50) NULL,
	[Ziro] [varchar](50) NULL,
	[Web] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
 CONSTRAINT [PK_Firma] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lokacija]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lokacija](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](100) NOT NULL,
	[Adresa] [nvarchar](100) NULL,
	[MjestoID] [int] NOT NULL,
 CONSTRAINT [PK_Lokacija] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Marka]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marka](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NULL,
	[DrzavaID] [int] NULL,
 CONSTRAINT [PK_Marka] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mjesto]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mjesto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OpstinaID] [int] NULL,
	[PostBr] [int] NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Mjesto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oblik]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oblik](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NULL,
 CONSTRAINT [PK_Oblik] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Opstina]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opstina](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Sifra] [nvarchar](5) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[DrzavaID] [int] NULL,
 CONSTRAINT [PK_Opstina] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Osoba]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Osoba](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[JMBG] [varchar](13) NOT NULL CONSTRAINT [DF_Osoba_JMBG]  DEFAULT (''),
	[Prezime] [nvarchar](50) NOT NULL CONSTRAINT [DF_Osoba_Prezime]  DEFAULT (''),
	[Ime] [nvarchar](50) NOT NULL CONSTRAINT [DF_Osoba_Ime]  DEFAULT (''),
	[MjestoStanID] [int] NULL,
	[AdresaStan] [nvarchar](50) NULL CONSTRAINT [DF_Osoba_AdresaStan]  DEFAULT (''),
	[TelefonStan] [nvarchar](50) NULL CONSTRAINT [DF_Osoba_TelefonStan]  DEFAULT (''),
	[TelefonMob] [nvarchar](50) NULL CONSTRAINT [DF_Osoba_TelefonMob]  DEFAULT (''),
	[BrLK] [nvarchar](50) NULL CONSTRAINT [DF_Osoba_BrLK]  DEFAULT (''),
	[BrPasos] [nvarchar](50) NULL,
	[BrVozacka] [nvarchar](50) NULL,
	[DatumRodjenja] [smalldatetime] NULL,
	[eMail] [nvarchar](50) NULL,
	[Pol] [nvarchar](10) NULL,
	[Slika] [varbinary](max) NULL,
	[Rating] [numeric](8, 2) NULL,
	[UserName] [nvarchar](50) NULL,
	[Lozinka] [nvarchar](50) NULL,
	[Napomena] [nvarchar](4000) NULL CONSTRAINT [DF_Osoba_Napomena]  DEFAULT (''),
 CONSTRAINT [PK_Osoba] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Renta]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Renta](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Datum] [datetime] NOT NULL,
	[Broj] [int] NOT NULL,
	[OsobaID] [int] NOT NULL,
	[DrugaOsobaID] [int] NULL,
	[VoziloID] [int] NOT NULL,
	[StanjeBrojilaStart] [int] NOT NULL,
	[StanjeBrojilaKraj] [int] NULL,
	[StanjeGorivoStart] [int] NOT NULL,
	[StanjeGorivoKraj] [int] NULL,
	[DatumOd] [datetime] NOT NULL,
	[DatumDo] [datetime] NOT NULL,
	[DatumRazduzen] [datetime] NULL,
	[IsZaduzen] [bit] NOT NULL,
	[IsRazduzen] [bit] NOT NULL,
	[IsProduzen] [bit] NOT NULL,
	[DatumProduzenDo] [datetime] NULL,
	[OpisZaduzen] [nvarchar](500) NULL,
	[OpisRazduzen] [nvarchar](500) NULL,
	[LokacijaPreuzimanje] [int] NULL,
	[LokacijaZaPovrat] [int] NULL,
	[LokacijaVraceno] [int] NULL,
	[DanaZaRacun] [int] NULL,
	[Depozit] [numeric](8, 2) NULL,
	[Cijena] [numeric](8, 2) NULL,
	[Rabat] [numeric](8, 4) NULL,
	[PDV] [numeric](8, 2) NULL,
	[Iznos] [numeric](8, 2) NULL,
	[Naplata] [numeric](8, 2) NOT NULL CONSTRAINT [DF_Renta_Naplata]  DEFAULT ((0)),
	[RatingKupca] [numeric](8, 2) NOT NULL CONSTRAINT [DF_Renta_RatingKupca]  DEFAULT ((0)),
	[IsPlaceno] [bit] NOT NULL,
 CONSTRAINT [PK_Renta] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vozilo]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vozilo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RegBr] [varchar](10) NOT NULL,
	[Sasija] [varchar](20) NULL,
	[MarkaID] [int] NULL,
	[Tip] [varchar](20) NULL,
	[BojaID] [int] NULL,
	[OblikID] [int] NULL,
	[Godina] [int] NULL,
	[BrMotora] [varchar](50) NULL,
	[Snaga] [int] NULL,
	[ZapreminaMotor] [int] NULL,
	[TipMotora] [varchar](20) NULL,
	[NetoTezina] [int] NULL,
	[BrojVrata] [int] NULL,
	[BrojSjedista] [int] NULL,
	[Nosivost] [int] NULL,
	[DatumReg] [datetime] NULL,
	[ZapreminaGorivo] [int] NULL,
	[ecBit] [int] NULL,
	[Napomena] [varchar](250) NULL,
	[Cijena] [numeric](8, 2) NULL,
	[Slika] [varbinary](max) NULL,
 CONSTRAINT [PK_Automobil] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vRenta]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vRenta]

AS

SELECT 
	R.[ID]
	,R.[Datum]
	,R.[Broj]
	,R.[OsobaID]
		,O.JMBG, O.Prezime, O.Ime, O.TelefonMob
		,(SELECT SUM([RatingKupca])/COUNT(ID) FROM [Renta] WHERE OsobaID = R.OsobaID) Rating
	,ISNULL(R.[DrugaOsobaID],0) DrugaOsobaID
		,ISNULL(O2.Prezime,'') Prezime2, ISNULL(O2.Ime,'') Ime2
	,R.[VoziloID]
		,V.RegBr, M.Naziv Marka, B.Naziv Boja
	,R.[StanjeBrojilaStart],R.[StanjeBrojilaKraj]
		,R.[StanjeBrojilaKraj]-R.[StanjeBrojilaStart] PredjeniKM
	,R.[StanjeGorivoStart],R.[StanjeGorivoKraj]
		,R.[StanjeGorivoKraj]-R.[StanjeGorivoStart] RazlikaGorivo
	,R.[DatumOd]
	,R.[DatumDo]
	,ISNULL(R.[DatumRazduzen],0) DatumRazduzen
	,R.[IsZaduzen]
	,R.[IsRazduzen]
	,R.[IsProduzen]
	,ISNULL(R.[DatumProduzenDo],0) DatumProduzenDo
	,R.[OpisZaduzen]
	,R.[OpisRazduzen]
	,ISNULL(R.[LokacijaPreuzimanje],0) LokacijaPreuzimanje,ISNULL(LokZ.Naziv,'NEDEFINISANO') LokacijaPreuzimanjeNaziv
	,ISNULL(R.[LokacijaZaPovrat],0) LokacijaZaPovrat,ISNULL(LokP.Naziv,'NEDEFINISANO') LokacijaZaPovratNaziv
	,ISNULL(R.[LokacijaVraceno],0) LokacijaVraceno,ISNULL(LokV.Naziv,'NEDEFINISANO') LokacijaVracenoNaziv
	,R.[DanaZaRacun]
	,R.[Depozit]
	,R.[Cijena]
	,R.[Rabat]
	,R.[PDV]
	,R.[Iznos]
	,R.[Naplata]
	,R.[RatingKupca]
	,R.[IsPlaceno]
FROM [dbo].[Renta] R
LEFT JOIN Osoba O ON R.OsobaID = O.ID
LEFT JOIN Osoba O2 ON R.DrugaOsobaID = O2.ID
LEFT JOIN Vozilo V ON R.VoziloID = V.ID
LEFT JOIN Marka M ON V.MarkaID = M.ID
LEFT JOIN Boja B ON V.BojaID = B.ID
LEFT JOIN Lokacija LokZ ON R.[LokacijaPreuzimanje] = LokZ.ID
LEFT JOIN Lokacija LokP ON R.[LokacijaZaPovrat] = LokP.ID
LEFT JOIN Lokacija LokV ON R.[LokacijaVraceno] = LokV.ID


GO
/****** Object:  View [dbo].[vUgovor]    Script Date: 12/19/17 8:03:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vUgovor]

AS

SELECT 
	R.[ID]
	,CAST(DATEPART(DAY,R.[Datum]) as varchar(2)) + '/' + CAST(DATEPART(MONTH,R.[Datum]) as varchar(2)) + '/' + CAST(DATEPART(YEAR,R.[Datum]) as varchar(4)) Datum
	,R.[Broj]
	--,R.[OsobaID]
		,O.JMBG, O.Prezime, O.Ime, O.TelefonMob, ISNULL(O.AdresaStan,'') Adresa
		,ISNULL(Mj.Naziv,'') as Grad, ISNULL(Dr.Naziv,'') as Drzava, O.BrLK, O.BrPasos, O.BrVozacka
		,ISNULL((SELECT SUM([RatingKupca])/COUNT(ID) FROM [Renta] WHERE OsobaID = R.OsobaID),0) Rating
	--,ISNULL(R.[DrugaOsobaID],0) DrugaOsobaID
		,ISNULL(O2.JMBG,'') JMBG2,ISNULL(O2.Prezime,'') Prezime2, ISNULL(O2.Ime,'') Ime2, ISNULL(O2.TelefonMob,'') TelefonMob2, ISNULL(O2.AdresaStan,'') Adresa2
		,ISNULL(Mj2.Naziv,'') as Grad2, ISNULL(Dr2.Naziv,'') as Drzava2, O2.BrLK BrLK2, O2.BrPasos BrPasos2, O2.BrVozacka BrVozacka2
	--,R.[VoziloID]
		,V.RegBr, M.Naziv Marka, ISNULL(V.Tip,'NEDEFINISANO') Tip, ISNULL(Ob.Naziv,'NEDEFINISANO') Oblik, B.Naziv Boja
		,ISNULL(V.BrMotora,'NEDEFINISANO') BrMotora, ISNULL(V.Sasija,'NEDEFINISANO') Sasija
		,ISNULL(V.Godina,0) Godiste, ISNULL(V.TipMotora,'NEDEFINISANO') TipMotora
		,CAST(DATEPART(DAY,V.DatumReg) as varchar(2)) + '/' + CAST(DATEPART(MONTH,V.DatumReg) as varchar(2)) + '/' + CAST(DATEPART(YEAR,V.DatumReg) as varchar(4)) DatumReg
		,ISNULL(V.BrojSjedista,0) BrojSjedista, ISNULL(V.BrojVrata,0) BrojVrata, ISNULL(V.Nosivost,0) Nosivost, ISNULL(V.Snaga,0) Snaga
	,ISNULL(R.[StanjeBrojilaStart],0) StanjeBrojilaStart,ISNULL(R.[StanjeBrojilaKraj],0) StanjeBrojilaKraj
		,ISNULL(R.[StanjeBrojilaKraj],0)-ISNULL(R.[StanjeBrojilaStart],0) PredjeniKM
	,ISNULL(R.[StanjeGorivoStart],0) StanjeGorivoStart,ISNULL(R.[StanjeGorivoKraj],0) StanjeGorivoKraj
		,ISNULL(R.[StanjeGorivoKraj],0)-ISNULL(R.[StanjeGorivoStart],0) RazlikaGorivo
	,CAST(DATEPART(DAY,R.[DatumOd]) as varchar(2)) + '/' + CAST(DATEPART(MONTH,R.[DatumOd]) as varchar(2)) + '/' + CAST(DATEPART(YEAR,R.[DatumOd]) as varchar(4)) DatumOd
	--,R.[DatumOd]
	,CAST(DATEPART(DAY,R.[DatumDo]) as varchar(2)) + '/' + CAST(DATEPART(MONTH,R.[DatumDo]) as varchar(2)) + '/' + CAST(DATEPART(YEAR,R.[DatumDo]) as varchar(4)) DatumDo
	--,R.[DatumDo]
	,CAST(DATEPART(DAY,R.[DatumRazduzen]) as varchar(2)) + '/' + CAST(DATEPART(MONTH,R.[DatumRazduzen]) as varchar(2)) + '/' + CAST(DATEPART(YEAR,R.[DatumRazduzen]) as varchar(4)) DatumRazduzen
	--,ISNULL(R.[DatumRazduzen],0) DatumRazduzen
	,CASE R.[IsZaduzen] WHEN 1 THEN 'DA' ELSE 'NE' END Zaduzen
	,CASE R.[IsRazduzen] WHEN 1 THEN 'DA' ELSE 'NE' END Razduzen
	,CASE R.[IsProduzen] WHEN 1 THEN 'DA' ELSE 'NE' END Produzen
	,CAST(DATEPART(DAY,R.[DatumProduzenDo]) as varchar(2)) + '/' + CAST(DATEPART(MONTH,R.[DatumProduzenDo]) as varchar(2)) + '/' + CAST(DATEPART(YEAR,R.[DatumProduzenDo]) as varchar(4)) DatumProduzenDo
	--,ISNULL(R.[DatumProduzenDo],0) DatumProduzenDo
	,ISNULL(R.[OpisZaduzen],'') OpisZaduzen
	,ISNULL(R.[OpisRazduzen],'') OpisRazduzen
	--,ISNULL(R.[LokacijaPreuzimanje],0) LokacijaPreuzimanje
	,ISNULL(LokZ.Naziv,'NEDEFINISANO') LokacijaPreuzimanje
	--,ISNULL(R.[LokacijaZaPovrat],0) LokacijaZaPovrat
	,ISNULL(LokP.Naziv,'NEDEFINISANO') LokacijaZaPovrat
	--,ISNULL(R.[LokacijaVraceno],0) LokacijaVraceno
	,ISNULL(LokV.Naziv,'NEDEFINISANO') LokacijaVraceno
	,ISNULL(R.[DanaZaRacun],0) Dana
	,ISNULL(R.[Depozit],0) Depozit
	,ISNULL(R.[Cijena],0) Cijena
	,ISNULL(R.[Rabat],0) Rabat
	,ISNULL(R.[PDV],0) PDV
	,ISNULL(R.[Iznos],0) Iznos
	,ISNULL(R.[Naplata],0) Naplata
	--,R.[RatingKupca]
	,CASE R.[IsPlaceno] WHEN 1 THEN 'DA' ELSE 'NE' END Placeno
FROM [dbo].[Renta] R
LEFT JOIN Osoba O ON R.OsobaID = O.ID
LEFT JOIN Mjesto Mj ON O.MjestoStanID = Mj.ID
LEFT JOIN Opstina Op ON Mj.OpstinaID = Op.ID
LEFT JOIN Drzava Dr ON Op.DrzavaID = Dr.ID
LEFT JOIN Osoba O2 ON R.DrugaOsobaID = O2.ID
LEFT JOIN Mjesto Mj2 ON O2.MjestoStanID = Mj2.ID
LEFT JOIN Opstina Op2 ON Mj2.OpstinaID = Op2.ID
LEFT JOIN Drzava Dr2 ON Op2.DrzavaID = Dr2.ID
LEFT JOIN Vozilo V ON R.VoziloID = V.ID
LEFT JOIN Marka M ON V.MarkaID = M.ID
LEFT JOIN Boja B ON V.BojaID = B.ID
LEFT JOIN Oblik Ob ON V.OblikID = Ob.ID
LEFT JOIN Lokacija LokZ ON R.[LokacijaPreuzimanje] = LokZ.ID
LEFT JOIN Lokacija LokP ON R.[LokacijaZaPovrat] = LokP.ID
LEFT JOIN Lokacija LokV ON R.[LokacijaVraceno] = LokV.ID




GO
ALTER TABLE [dbo].[Firma]  WITH CHECK ADD  CONSTRAINT [FK_Firma_Mjesto] FOREIGN KEY([Mjesto])
REFERENCES [dbo].[Mjesto] ([ID])
GO
ALTER TABLE [dbo].[Firma] CHECK CONSTRAINT [FK_Firma_Mjesto]
GO
ALTER TABLE [dbo].[Lokacija]  WITH CHECK ADD  CONSTRAINT [FK_Lokacija_Mjesto] FOREIGN KEY([MjestoID])
REFERENCES [dbo].[Mjesto] ([ID])
GO
ALTER TABLE [dbo].[Lokacija] CHECK CONSTRAINT [FK_Lokacija_Mjesto]
GO
ALTER TABLE [dbo].[Marka]  WITH CHECK ADD  CONSTRAINT [FK_Marka_Drzava] FOREIGN KEY([DrzavaID])
REFERENCES [dbo].[Drzava] ([ID])
GO
ALTER TABLE [dbo].[Marka] CHECK CONSTRAINT [FK_Marka_Drzava]
GO
ALTER TABLE [dbo].[Mjesto]  WITH CHECK ADD  CONSTRAINT [FK_Mjesto_Opstina] FOREIGN KEY([OpstinaID])
REFERENCES [dbo].[Opstina] ([ID])
GO
ALTER TABLE [dbo].[Mjesto] CHECK CONSTRAINT [FK_Mjesto_Opstina]
GO
ALTER TABLE [dbo].[Opstina]  WITH CHECK ADD  CONSTRAINT [FK_Opstina_Drzava] FOREIGN KEY([DrzavaID])
REFERENCES [dbo].[Drzava] ([ID])
GO
ALTER TABLE [dbo].[Opstina] CHECK CONSTRAINT [FK_Opstina_Drzava]
GO
ALTER TABLE [dbo].[Osoba]  WITH NOCHECK ADD  CONSTRAINT [FK_Osoba_Mjesto] FOREIGN KEY([MjestoStanID])
REFERENCES [dbo].[Mjesto] ([ID])
GO
ALTER TABLE [dbo].[Osoba] CHECK CONSTRAINT [FK_Osoba_Mjesto]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD  CONSTRAINT [FK_Renta_Lokacija] FOREIGN KEY([LokacijaPreuzimanje])
REFERENCES [dbo].[Lokacija] ([ID])
GO
ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Renta_Lokacija]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD  CONSTRAINT [FK_Renta_Lokacija1] FOREIGN KEY([LokacijaZaPovrat])
REFERENCES [dbo].[Lokacija] ([ID])
GO
ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Renta_Lokacija1]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD  CONSTRAINT [FK_Renta_Lokacija2] FOREIGN KEY([LokacijaVraceno])
REFERENCES [dbo].[Lokacija] ([ID])
GO
ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Renta_Lokacija2]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD  CONSTRAINT [FK_Renta_Osoba] FOREIGN KEY([OsobaID])
REFERENCES [dbo].[Osoba] ([ID])
GO
ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Renta_Osoba]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD  CONSTRAINT [FK_Renta_Osoba1] FOREIGN KEY([DrugaOsobaID])
REFERENCES [dbo].[Osoba] ([ID])
GO
ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Renta_Osoba1]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD  CONSTRAINT [FK_Renta_Vozilo] FOREIGN KEY([VoziloID])
REFERENCES [dbo].[Vozilo] ([ID])
GO
ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Renta_Vozilo]
GO
ALTER TABLE [dbo].[Vozilo]  WITH CHECK ADD  CONSTRAINT [FK_Automobil_Boja] FOREIGN KEY([BojaID])
REFERENCES [dbo].[Boja] ([ID])
GO
ALTER TABLE [dbo].[Vozilo] CHECK CONSTRAINT [FK_Automobil_Boja]
GO
ALTER TABLE [dbo].[Vozilo]  WITH CHECK ADD  CONSTRAINT [FK_Automobil_Marka] FOREIGN KEY([MarkaID])
REFERENCES [dbo].[Marka] ([ID])
GO
ALTER TABLE [dbo].[Vozilo] CHECK CONSTRAINT [FK_Automobil_Marka]
GO
ALTER TABLE [dbo].[Vozilo]  WITH CHECK ADD  CONSTRAINT [FK_Automobil_Oblik] FOREIGN KEY([OblikID])
REFERENCES [dbo].[Oblik] ([ID])
GO
ALTER TABLE [dbo].[Vozilo] CHECK CONSTRAINT [FK_Automobil_Oblik]
GO
