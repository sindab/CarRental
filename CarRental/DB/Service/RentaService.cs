using CarRental.DB.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DB.Service
{
    public class RentaService
    {
        private IDbConnection _db = new SqlConnection(DbConnection.ConnectionString());

        public IEnumerable<Renta> GetAll()
        {
            return _db.GetAll<Renta>();
        }

        public Renta GetByID(int Id)
        {
            return _db.Get<Renta>(Id);
        }

        public Renta VratiNovuRentu()
        {
            Renta newR = new Renta()
            {
                Broj = NextBroj(),
                Datum = DateTime.Today,
                DatumOd = DateTime.Today,
                DatumDo = DateTime.Today,
                StanjeBrojilaStart = 0,
                StanjeBrojilaKraj = 0,
                StanjeGorivoStart = 0,
                StanjeGorivoKraj = 0,
                Cijena = 0,
                DanaZaRacun = 0,
                Depozit = 0,
                IsProduzen = false,
                IsRazduzen = false,
                IsZaduzen = false,
                Iznos = 0,
                Naplata = 0,
                OpisRazduzen = string.Empty,
                OpisZaduzen = string.Empty,
                PDV = 0,
                Rabat = 0
            };
            return newR;
        }

        public int NextBroj()
        {
            int result = 1;
            result = (int)_db.ExecuteScalar("SELECT MAX([Broj]) + 1 FROM (SELECT 0 Broj UNION ALL SELECT [Broj] FROM [Renta]) R");
            return result;
        }

        public int StanjeBrojilaMax(int voziloId)
        {
            int result = 0;
            result = (int)_db.ExecuteScalar("SELECT MAX([Broj]) FROM (SELECT 0 Broj UNION ALL SELECT StanjeBrojilaKraj FROM [Renta] WHERE VoziloID = @vId) R", new { vId = voziloId });
            return result;
        }

        public int StanjeGorivaMax(int voziloId)
        {
            int result = 0;
            result = (int)_db.ExecuteScalar("SELECT MAX([Broj]) FROM (SELECT 0 Broj UNION ALL SELECT StanjeGorivoKraj FROM [Renta] WHERE VoziloID = @vId) R", new { vId = voziloId });
            return result;
        }

        //public void CreateOrUpdate(Renta Renta)
        //{
        //    if (GetByID(Renta.ID) is null)
        //    {
        //        _db.Insert<Renta>(Renta);
        //    }
        //    else
        //    {
        //        _db.Update<Renta>(Renta);
        //    }
        //}

        public int CreateOrUpdate(Renta renta)
        {
            int result = renta.ID;
            if (!(string.IsNullOrEmpty(renta.OsobaID.ToString())) && !(string.IsNullOrEmpty(renta.VoziloID.ToString())))
            {
                if (renta.ID == 0 || GetByID(renta.ID) is null)
                {
                    result = Create(renta);
                }
                else
                {
                    Update(renta);
                }
            }
            return result;
        }

        public int Create(Renta renta)
        {
            return (int)_db.Insert<Renta>(renta);
        }

        //public void Create(Renta Renta)
        //{
        //    _db.Insert<Renta>(Renta);
        //}

        public void Update(Renta Renta)
        {
            _db.Update<Renta>(Renta);
        }

        public void Delete(Renta Renta)
        {
            _db.Delete<Renta>(Renta);
        }

        public void Delete(int id)
        {
            _db.Execute(@"DELETE FROM [Renta] WHERE ID = @ID", new { ID = id });
        }

        //***************vRenta*******************

        public IEnumerable<vRenta> GetAllV()
        {
            return _db.GetAll<vRenta>();
        }

        public vRenta GetVByID(int Id)
        {
            return _db.Get<vRenta>(Id);
        }

        public IEnumerable<vRenta> GetAllByVozilo(int voziloId)
        {
            return _db.Query<vRenta>(string.Format("SELECT * FROM [dbo].[vRenta] WHERE [VoziloID] = {0} ORDER BY Datum DESC",voziloId));
        }
        public IEnumerable<vRenta> GetAllByVozac(int vozacId)
        {
            return _db.Query<vRenta>(string.Format("SELECT * FROM [dbo].[vRenta] WHERE [OsobaID] = {0} ORDER BY Datum DESC", vozacId));
        }

        //***************vUgovor*******************

        public vUgovor GetUgovor(int Id)
        {
            return _db.Get<vUgovor>(Id);
        }
    }
}
