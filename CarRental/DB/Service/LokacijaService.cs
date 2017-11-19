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
    public class LokacijaService
    {
        private IDbConnection _db = new SqlConnection(DbConnection.ConnectionString());

        public IEnumerable<Lokacija> GetAll()
        {
            return _db.GetAll<Lokacija>();
        }

        public Lokacija GetByID(int Id)
        {
            return _db.Get<Lokacija>(Id);
        }

        public Lokacija GetByMjestoID(int mjestoId)
        {
            return _db.Query<Lokacija>("SELECT [ID],[MjestoID],[Adresa],[Naziv] FROM [Lokacija] WHERE [MjestoID] = @mjesto", new { mjesto = mjestoId }).SingleOrDefault();
        }

        public void CreateOrUpdate(Lokacija lokacija)
        {
            if (GetByID(lokacija.ID) is null)
            {
                _db.Insert<Lokacija>(lokacija);
            }
            else
            {
                _db.Update<Lokacija>(lokacija);
            }
        }

        public void Create(Lokacija lokacija)
        {
            _db.Insert<Lokacija>(lokacija);
        }

        public void Update(Lokacija lokacija)
        {
            _db.Update<Lokacija>(lokacija);
        }

        public void Delete(Lokacija lokacija)
        {
            _db.Delete<Lokacija>(lokacija);
        }

        public void Delete(int id)
        {
            _db.Execute(@"DELETE FROM [Lokacija] WHERE ID = @ID", new { ID = id });
        }
    }
}
