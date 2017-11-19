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
    public class BojaService
    {
        private IDbConnection _db = new SqlConnection(DbConnection.ConnectionString());

        public IEnumerable<Boja> GetAll()
        {
            return _db.GetAll<Boja>();
        }

        public Boja GetByID(int Id)
        {
            return _db.Get<Boja>(Id);
        }

        public List<Boja> GetLookup()
        {
            return _db.Query<Boja>("SELECT ID, Naziv FROM [dbo].[Boja]").ToList();
        }

        public void CreateOrUpdate(Boja boja)
        {
            if (GetByID(boja.ID) is null)
            {
                _db.Insert<Boja>(boja);
            }
            else
            {
                _db.Update<Boja>(boja);
            }
        }

        public void Create(Boja boja)
        {
            _db.Insert<Boja>(boja);
        }

        public void Update(Boja boja)
        {
            _db.Update<Boja>(boja);
        }

        public void Delete(Boja boja)
        {
            _db.Delete<Boja>(boja);
        }

        public void Delete(int id)
        {
            _db.Execute(@"DELETE FROM [Boja] WHERE ID = @ID", new { ID = id });
        }
    }
}
