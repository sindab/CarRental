// This file was automatically generated by the Dapper.SimpleCRUD T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `data source=DESKTOP-L1OSIDV\SQLEXPRESS;initial catalog=CarRental;Trusted_Connection=false;User ID=sa; Password=test; Connection Timeout = 0;`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `data source=DESKTOP-L1OSIDV\SQLEXPRESS;initial catalog=CarRental;Trusted_Connection=false;User ID=sa; Password=******;`
//     Include Views:          `True`

using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace CarRental.DB.Models
{
    /// <summary>
    /// A class which represents the Firma table.
    /// </summary>
	[Table("Firma")]
	public partial class Firma
	{
		[Key]
			public virtual int ID { get; set; }
			public virtual string Naziv { get; set; }
			public virtual string PuniNaziv { get; set; }
			public virtual int? Mjesto { get; set; }
			public virtual string Adresa { get; set; }
			public virtual string Telefon { get; set; }
			public virtual string Fax { get; set; }
			public virtual string Mobilni { get; set; }
			public virtual string Maticni { get; set; }
			public virtual string PIB { get; set; }
			public virtual string JIB { get; set; }
			public virtual string Ziro { get; set; }
			public virtual string Web { get; set; }
			public virtual string Mail { get; set; }
	}

    /// <summary>
    /// A class which represents the Drzava table.
    /// </summary>
	[Table("Drzava")]
	public partial class Drzava
	{
		[Key]
			public virtual int ID { get; set; }
			public virtual string Naziv { get; set; }
	}

    /// <summary>
    /// A class which represents the Opstina table.
    /// </summary>
	[Table("Opstina")]
	public partial class Opstina
	{
		[Key]
			public virtual int ID { get; set; }
			public virtual string Sifra { get; set; }
			public virtual string Naziv { get; set; }
			public virtual int? DrzavaID { get; set; }
	}

    /// <summary>
    /// A class which represents the Mjesto table.
    /// </summary>
	[Table("Mjesto")]
	public partial class Mjesto
	{
		[Key]
			public virtual int ID { get; set; }
			public virtual int? OpstinaID { get; set; }
			public virtual int PostBr { get; set; }
			public virtual string Naziv { get; set; }
	}

    /// <summary>
    /// A class which represents the Lokacija table.
    /// </summary>
	[Table("Lokacija")]
	public partial class Lokacija
	{
		[Key]
			public virtual int ID { get; set; }
			public virtual string Naziv { get; set; }
			public virtual string Adresa { get; set; }
			public virtual int MjestoID { get; set; }
	}

    /// <summary>
    /// A class which represents the Vozilo table.
    /// </summary>
	[Table("Vozilo")]
	public partial class Vozilo
	{
		[Key]
			public virtual int ID { get; set; }
			public virtual string RegBr { get; set; }
			public virtual string Sasija { get; set; }
			public virtual int? MarkaID { get; set; }
			public virtual string Tip { get; set; }
			public virtual int? BojaID { get; set; }
			public virtual int? OblikID { get; set; }
			public virtual int? Godina { get; set; }
			public virtual string BrMotora { get; set; }
			public virtual int? Snaga { get; set; }
			public virtual int? ZapreminaMotor { get; set; }
			public virtual string TipMotora { get; set; }
			public virtual int? NetoTezina { get; set; }
			public virtual int? BrojVrata { get; set; }
			public virtual int? BrojSjedista { get; set; }
			public virtual int? Nosivost { get; set; }
			public virtual DateTime? DatumReg { get; set; }
			public virtual int? ZapreminaGorivo { get; set; }
			public virtual int? ecBit { get; set; }
			public virtual string Napomena { get; set; }
			public virtual decimal? Cijena { get; set; }
			public virtual byte[] Slika { get; set; }
	}

    /// <summary>
    /// A class which represents the Osoba table.
    /// </summary>
	[Table("Osoba")]
	public partial class Osoba
	{
		[Key]
			public virtual int ID { get; set; }
			public virtual string JMBG { get; set; }
			public virtual string Prezime { get; set; }
			public virtual string Ime { get; set; }
			public virtual int? MjestoStanID { get; set; }
			public virtual string AdresaStan { get; set; }
			public virtual string TelefonStan { get; set; }
			public virtual string TelefonMob { get; set; }
			public virtual string BrLK { get; set; }
			public virtual string BrPasos { get; set; }
			public virtual string BrVozacka { get; set; }
			public virtual DateTime? DatumRodjenja { get; set; }
			public virtual string eMail { get; set; }
			public virtual string Pol { get; set; }
			public virtual byte[] Slika { get; set; }
			public virtual decimal? Rating { get; set; }
			public virtual string UserName { get; set; }
			public virtual string Lozinka { get; set; }
			public virtual string Napomena { get; set; }
	}

    /// <summary>
    /// A class which represents the Oblik table.
    /// </summary>
	[Table("Oblik")]
	public partial class Oblik
	{
		[Key]
			public virtual int ID { get; set; }
			public virtual string Naziv { get; set; }
	}

    /// <summary>
    /// A class which represents the Boja table.
    /// </summary>
	[Table("Boja")]
	public partial class Boja
	{
		[Key]
			public virtual int ID { get; set; }
			public virtual string Naziv { get; set; }
	}

    /// <summary>
    /// A class which represents the Marka table.
    /// </summary>
	[Table("Marka")]
	public partial class Marka
	{
		[Key]
			public virtual int ID { get; set; }
			public virtual string Naziv { get; set; }
			public virtual int? DrzavaID { get; set; }
	}

    /// <summary>
    /// A class which represents the Renta table.
    /// </summary>
	[Table("Renta")]
	public partial class Renta
	{
		[Key]
			public virtual int ID { get; set; }
			public virtual DateTime Datum { get; set; }
			public virtual int Broj { get; set; }
			public virtual int OsobaID { get; set; }
			public virtual int? DrugaOsobaID { get; set; }
			public virtual int VoziloID { get; set; }
			public virtual int StanjeBrojilaStart { get; set; }
			public virtual int? StanjeBrojilaKraj { get; set; }
			public virtual int StanjeGorivoStart { get; set; }
			public virtual int? StanjeGorivoKraj { get; set; }
			public virtual DateTime DatumOd { get; set; }
			public virtual DateTime DatumDo { get; set; }
			public virtual DateTime? DatumRazduzen { get; set; }
			public virtual bool IsZaduzen { get; set; }
			public virtual bool IsRazduzen { get; set; }
			public virtual bool IsProduzen { get; set; }
			public virtual DateTime? DatumProduzenDo { get; set; }
			public virtual string OpisZaduzen { get; set; }
			public virtual string OpisRazduzen { get; set; }
			public virtual int? LokacijaPreuzimanje { get; set; }
			public virtual int? LokacijaZaPovrat { get; set; }
			public virtual int? LokacijaVraceno { get; set; }
			public virtual int? DanaZaRacun { get; set; }
			public virtual decimal? Depozit { get; set; }
			public virtual decimal? Cijena { get; set; }
			public virtual decimal? Rabat { get; set; }
			public virtual decimal? PDV { get; set; }
			public virtual decimal? Iznos { get; set; }
			public virtual decimal Naplata { get; set; }
			public virtual decimal RatingKupca { get; set; }
			public virtual bool IsPlaceno { get; set; }
	}

    /// <summary>
    /// A class which represents the vRenta view.
    /// </summary>
	[Table("vRenta")]
	public partial class vRenta
	{
			[ExplicitKey]
		public virtual int ID { get; set; }
			public virtual DateTime Datum { get; set; }
			public virtual int Broj { get; set; }
			public virtual int OsobaID { get; set; }
			public virtual string JMBG { get; set; }
			public virtual string Prezime { get; set; }
			public virtual string Ime { get; set; }
			public virtual string TelefonMob { get; set; }
			public virtual decimal? Rating { get; set; }
			public virtual int DrugaOsobaID { get; set; }
			public virtual string Prezime2 { get; set; }
			public virtual string Ime2 { get; set; }
			public virtual int VoziloID { get; set; }
			public virtual string RegBr { get; set; }
			public virtual string Marka { get; set; }
			public virtual string Boja { get; set; }
			public virtual int StanjeBrojilaStart { get; set; }
			public virtual int? StanjeBrojilaKraj { get; set; }
			public virtual int? PredjeniKM { get; set; }
			public virtual int StanjeGorivoStart { get; set; }
			public virtual int? StanjeGorivoKraj { get; set; }
			public virtual int? RazlikaGorivo { get; set; }
			public virtual DateTime DatumOd { get; set; }
			public virtual DateTime DatumDo { get; set; }
			public virtual DateTime DatumRazduzen { get; set; }
			public virtual bool IsZaduzen { get; set; }
			public virtual bool IsRazduzen { get; set; }
			public virtual bool IsProduzen { get; set; }
			public virtual DateTime DatumProduzenDo { get; set; }
			public virtual string OpisZaduzen { get; set; }
			public virtual string OpisRazduzen { get; set; }
			public virtual int LokacijaPreuzimanje { get; set; }
			public virtual string LokacijaPreuzimanjeNaziv { get; set; }
			public virtual int LokacijaZaPovrat { get; set; }
			public virtual string LokacijaZaPovratNaziv { get; set; }
			public virtual int LokacijaVraceno { get; set; }
			public virtual string LokacijaVracenoNaziv { get; set; }
			public virtual int? DanaZaRacun { get; set; }
			public virtual decimal? Depozit { get; set; }
			public virtual decimal? Cijena { get; set; }
			public virtual decimal? Rabat { get; set; }
			public virtual decimal? PDV { get; set; }
			public virtual decimal? Iznos { get; set; }
			public virtual decimal Naplata { get; set; }
			public virtual decimal RatingKupca { get; set; }
			public virtual bool IsPlaceno { get; set; }
	}

    /// <summary>
    /// A class which represents the vUgovor view.
    /// </summary>
	[Table("vUgovor")]
	public partial class vUgovor
	{
			public virtual int ID { get; set; }
			public virtual string Datum { get; set; }
			public virtual int Broj { get; set; }
			public virtual string JMBG { get; set; }
			public virtual string Prezime { get; set; }
			public virtual string Ime { get; set; }
			public virtual string TelefonMob { get; set; }
			public virtual string Adresa { get; set; }
			public virtual string Grad { get; set; }
			public virtual string Drzava { get; set; }
			public virtual string BrLK { get; set; }
			public virtual string BrPasos { get; set; }
			public virtual string BrVozacka { get; set; }
			public virtual decimal Rating { get; set; }
			public virtual string JMBG2 { get; set; }
			public virtual string Prezime2 { get; set; }
			public virtual string Ime2 { get; set; }
			public virtual string TelefonMob2 { get; set; }
			public virtual string Adresa2 { get; set; }
			public virtual string Grad2 { get; set; }
			public virtual string Drzava2 { get; set; }
			public virtual string BrLK2 { get; set; }
			public virtual string BrPasos2 { get; set; }
			public virtual string BrVozacka2 { get; set; }
			public virtual string RegBr { get; set; }
			public virtual string Marka { get; set; }
			public virtual string Tip { get; set; }
			public virtual string Oblik { get; set; }
			public virtual string Boja { get; set; }
			public virtual string BrMotora { get; set; }
			public virtual string Sasija { get; set; }
			public virtual int Godiste { get; set; }
			public virtual string TipMotora { get; set; }
			public virtual string DatumReg { get; set; }
			public virtual int BrojSjedista { get; set; }
			public virtual int BrojVrata { get; set; }
			public virtual int Nosivost { get; set; }
			public virtual int Snaga { get; set; }
			public virtual int StanjeBrojilaStart { get; set; }
			public virtual int StanjeBrojilaKraj { get; set; }
			public virtual int? PredjeniKM { get; set; }
			public virtual int StanjeGorivoStart { get; set; }
			public virtual int StanjeGorivoKraj { get; set; }
			public virtual int? RazlikaGorivo { get; set; }
			public virtual string DatumOd { get; set; }
			public virtual string DatumDo { get; set; }
			public virtual string DatumRazduzen { get; set; }
			public virtual string Zaduzen { get; set; }
			public virtual string Razduzen { get; set; }
			public virtual string Produzen { get; set; }
			public virtual string DatumProduzenDo { get; set; }
			public virtual string OpisZaduzen { get; set; }
			public virtual string OpisRazduzen { get; set; }
			public virtual string LokacijaPreuzimanje { get; set; }
			public virtual string LokacijaZaPovrat { get; set; }
			public virtual string LokacijaVraceno { get; set; }
			public virtual int Dana { get; set; }
			public virtual decimal Depozit { get; set; }
			public virtual decimal Cijena { get; set; }
			public virtual decimal Rabat { get; set; }
			public virtual decimal PDV { get; set; }
			public virtual decimal Iznos { get; set; }
			public virtual decimal Naplata { get; set; }
			public virtual string Placeno { get; set; }
	}

}
