using Dapper;
using Dapper.Contrib.Extensions;
using CarRental.DB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CarRental.DB.Service
{
    public class OsobaService
    {
        private IDbConnection _db = new SqlConnection(DbConnection.ConnectionString());

        public IEnumerable<Osoba> GetAll()
        {
            //try
            //{
            return _db.GetAll<Osoba>();
            //}
            //catch (Exception)
            //{
            //    List<Osoba> er = new List<Osoba>();
            //    er.Add(new Osoba { ID = 0 });
            //    return er;
            //}
            ////return _db.Query<Osoba>("SELECT [ID],[JMBG],[Prezime],[DjevPrezime],[Ime],[ImeOca],[Bitovi],[Titula],[Funkcija]," +
            ////    "[MjestoRodjenja],[OpstinaRodjenja],[DatumRodjenja],[Drzava],[Nacionalnost],[PorodicnoStanje]," +
            ////    "[MjestoStan],[AdresaStan],[OpstinaStan],[TelefonStan],[TelefonMob],[TelefonPosao],[Zanimanje],[StrucnaSprema],[ZavrsenaSkola]," +
            ////    "[PoslovnaJedinica],[RadnoMjesto],[BrLK],[BrRadneKnj],[OpstinaIzdavanjaRK],[LicniBrOsiguranja],[NacinIsplate],[BrTekucegRn]," +
            ////    "[Banka],[DatumPrvogZapos],[PrethodniStazMj],[PrethodniStazDan],[PrethodniStazUFirmiMj],[PrethodniStazUFirmiDan],[DatumZapos]," +
            ////    "[TipRadnogOdnosa],[NacinPrestankaRO],[DatumPrestankaRO],[Napomena],[FindStr],[Lozinka],[Slika] FROM [dbo].[Osoba] ").ToList();
        }

        //public IEnumerable<vOsoba> GetAllV()
        //{


        //    return _db.GetAll<vOsoba>();
        //}

        public List<Osoba> GetUsers()
        {
            return _db.Query<Osoba>("SELECT * FROM [dbo].[Osoba] WHERE ISNULL(Lozinka,'') <> '' ").ToList();
        }

        public List<Lookups> GetLookup()
        {
            return _db.Query<Lookups>("SELECT ID, ISNULL(Prezime,'') + ' ' + ISNULL(Ime,'') as Naziv FROM [dbo].[Osoba]").ToList();
        }

        public Osoba GetByID(int Id)
        {
            try
            {
                return _db.Get<Osoba>(Id);

            }
            catch (Exception)
            {
                Osoba er = new Osoba() { ID = 0 };
                return er;
            }
            //return _db.Query<Osoba>("SELECT [ID],[JMBG],[Prezime],[DjevPrezime],[Ime],[ImeOca],Naziv,[Bitovi],[Titula],[Funkcija]," +
            //    "[MjestoRodjenja],[OpstinaRodjenja],[DatumRodjenja],[Drzava],[Nacionalnost],[PorodicnoStanje]," +
            //    "[MjestoStan],[AdresaStan],[OpstinaStan],[TelefonStan],[TelefonMob],[TelefonPosao],[Zanimanje],[StrucnaSprema],[ZavrsenaSkola]," +
            //    "[PoslovnaJedinica],[RadnoMjesto],[BrLK],[BrRadneKnj],[OpstinaIzdavanjaRK],[LicniBrOsiguranja],[NacinIsplate],[BrTekucegRn]," +
            //    "[Banka],[DatumPrvogZapos],[PrethodniStazMj],[PrethodniStazDan],[PrethodniStazUFirmiMj],[PrethodniStazUFirmiDan],[DatumZapos]," +
            //    "[TipRadnogOdnosa],[NacinPrestankaRO],[DatumPrestankaRO],[Napomena],[FindStr],[Lozinka],[Slika],eMail FROM [dbo].[Osoba] WHERE ID = @ID", new { ID = Id }).SingleOrDefault();
        }

        public decimal Rejting(int Id)
        {
            try
            {
                return (decimal)_db.ExecuteScalar(string.Format("SELECT SUM([RatingKupca])/COUNT(ID) FROM [Renta] WHERE /*IsRazduzen = 1 and*/ OsobaID = {0}", Id));
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //public OsobaStaz GetStaz(int Id)
        //{
        //    //return _db.Get<Osoba>(Id);
        //    return _db.Query<OsobaStaz>("SELECT * FROM [dbo].[OsobaStaz] WHERE RadID = @ID", new { ID = Id }).SingleOrDefault();
        //}

        ////public vPar GetByWhere(string where)
        ////{
        ////    try
        ////    {
        ////        return _db.QuerySingle<vPar>(string.Format("SELECT ParID, AutoID, Naziv, Adresa, PostBr, Grad, Drzava, DomaciStrani, Komercijalist, JIB, PIB, ecBit, " +
        ////            "Dobavljac, Kupac, Domaci, Strani, IsKomercijalist, IsProizvodac, IsDiler, IsVIP, IsPravno, IsNeaktivan, IsPDV, Valuta, Find, " +
        ////            "Telefon, Fax, Maticni, KontaktOsoba, RabatGrupa, Rabat, Mobilni, Ziro, Mail, Web, KnjSifra, Parent, GrupaID, Opis, Kredit, Sjediste, " +
        ////            "Kvadratura, MjeriloBR, MZ FROM vPar {0}", where));
        ////    }
        ////    catch (Exception)
        ////    {
        ////        return _db.QuerySingle<vPar>("SELECT ParID, AutoID, Naziv, Adresa, PostBr, Grad, Drzava, DomaciStrani, Komercijalist, JIB, PIB, ecBit, " +
        ////                        "Dobavljac, Kupac, Domaci, Strani, IsKomercijalist, IsProizvodac, IsDiler, IsVIP, IsPravno, IsNeaktivan, IsPDV, Valuta, Find, " +
        ////                        "Telefon, Fax, Maticni, KontaktOsoba, RabatGrupa, Rabat, Mobilni, Ziro, Mail, Web, KnjSifra, Parent, GrupaID, Opis, Kredit, Sjediste, " +
        ////                        "Kvadratura, MjeriloBR, MZ FROM vPar Where ParID = 0");
        ////    }
        ////}

        //public string GetNazivByParID(int parId)
        //{
        //    Par p = GetByID(parId);
        //    return p.Naziv;
        //}

        public int Create(Osoba Osoba)
        {
            return (int)_db.Insert<Osoba>(Osoba);
            //int rowsAffected = _db.Execute(@"INSERT INTO [dbo].[Osoba]([JMBG],[Prezime],[DjevPrezime],[Ime],[ImeOca],[Bitovi],[Titula],[Funkcija],[MjestoRodjenja],[OpstinaRodjenja],[DatumRodjenja],[Drzava],[Nacionalnost],[PorodicnoStanje],[MjestoStan],[AdresaStan],[OpstinaStan],[TelefonStan],[TelefonMob],[TelefonPosao],[Zanimanje],[StrucnaSprema],[ZavrsenaSkola],[PoslovnaJedinica],[RadnoMjesto],[BrLK],[BrRadneKnj],[OpstinaIzdavanjaRK],[LicniBrOsiguranja],[NacinIsplate],[BrTekucegRn],[Banka],[DatumPrvogZapos],[PrethodniStazMj],[PrethodniStazDan],[PrethodniStazUFirmiMj],[PrethodniStazUFirmiDan],[DatumZapos],[TipRadnogOdnosa],[NacinPrestankaRO],[DatumPrestankaRO],[Napomena],[Lozinka],[Slika]) " +
            //    "VALUES(@JMBG,@Prezime,@DjevPrezime,@Ime,@ImeOca,@Bitovi,@Titula,@Funkcija,@MjestoRodjenja,@OpstinaRodjenja,@DatumRodjenja,@Drzava,@Nacionalnost,@PorodicnoStanje,@MjestoStan,@AdresaStan,@OpstinaStan,@TelefonStan,@TelefonMob,@TelefonPosao,@Zanimanje,@StrucnaSprema,@ZavrsenaSkola,@PoslovnaJedinica,@RadnoMjesto,@BrLK,@BrRadneKnj,@OpstinaIzdavanjaRK,@LicniBrOsiguranja,@NacinIsplate,@BrTekucegRn,@Banka,@DatumPrvogZapos,@PrethodniStazMj,@PrethodniStazDan,@PrethodniStazUFirmiMj,@PrethodniStazUFirmiDan,@DatumZapos,@TipRadnogOdnosa,@NacinPrestankaRO,@DatumPrestankaRO,@Napomena,@Lozinka,@Slika)", 
            //    new
            //    {
            //        JMBG = Osoba.JMBG,
            //        Prezime = Osoba.Prezime,
            //        DjevPrezime = Osoba.DjevPrezime,
            //        Ime = Osoba.Ime,
            //        ImeOca = Osoba.ImeOca,
            //        Bitovi = Osoba.Bitovi,
            //        Titula = Osoba.Titula,
            //        Funkcija = Osoba.Funkcija, ...
            //    });
            //if (rowsAffected > 0)
            //{
            //    return true;
            //}
            //return false;
        }

        public void Update(Osoba Osoba)
        {
            //Osoba.FindStr
            //Osoba.Naziv
            _db.Update<Osoba>(Osoba);
            //int rowsAffected = _db.Execute("UPDATE [Par] SET [Naziv] = @Naziv ,[Adresa] = @Adresa, [PostBr] = @PostBr " +
            //    "WHERE ParID = " + par.ParID, par);
            //if (rowsAffected > 0)
            //{
            //    return true;
            //}
            //return false;
        }

        public int CreateOrUpdate(Osoba Osoba)
        {
            int result = Osoba.ID;
            if (!(string.IsNullOrEmpty(Osoba.Prezime)) && !(string.IsNullOrEmpty(Osoba.Ime)))
            {
                if (Osoba.ID == 0 || GetByID(Osoba.ID) is null)
                {
                    result = Create(Osoba);
                }
                else
                {
                    Update(Osoba);
                }
            }
            return result;
        }

        public void Delete(int radID)
        {
            //_db.Delete<Osoba>(Osoba);
            _db.Execute(@"DELETE FROM [Osoba] WHERE ID = @RadID", new { RadID = radID });
            //int rowsAffected = _db.Execute(@"DELETE FROM [Osoba] WHERE RadID = @RadID", new { ParID = Id });
            //if (rowsAffected > 0)
            //{
            //    return true;
            //}
            //return false;
        }
    }
}
