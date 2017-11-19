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
    public class OblikService
    {
        private IDbConnection _db = new SqlConnection(DbConnection.ConnectionString());

        public IEnumerable<Oblik> GetAll()
        {
            return _db.GetAll<Oblik>();
        }

        public Oblik GetByID(int Id)
        {
            return _db.Get<Oblik>(Id);
        }

        public List<Oblik> GetLookup()
        {
            return _db.Query<Oblik>("SELECT ID, Naziv FROM [dbo].[Oblik]").ToList();
        }

        public void CreateOrUpdate(Oblik oblik)
        {
            if (GetByID(oblik.ID) is null)
            {
                _db.Insert<Oblik>(oblik);
            }
            else
            {
                _db.Update<Oblik>(oblik);
            }
        }

        public void Create(Oblik oblik)
        {
            _db.Insert<Oblik>(oblik);
        }

        public void Update(Oblik oblik)
        {
            _db.Update<Oblik>(oblik);
        }

        public void Delete(Oblik oblik)
        {
            _db.Delete<Oblik>(oblik);
        }

        public void Delete(int id)
        {
            _db.Execute(@"DELETE FROM [Oblik] WHERE ID = @ID", new { ID = id });
        }
    }
}
