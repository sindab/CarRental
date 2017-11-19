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
    public class MarkaService
    {
        private IDbConnection _db = new SqlConnection(DbConnection.ConnectionString());

        public IEnumerable<Marka> GetAll()
        {
            return _db.GetAll<Marka>();
        }

        public Marka GetByID(int Id)
        {
            return _db.Get<Marka>(Id);
        }

        public List<Marka> GetLookup()
        {
            return _db.Query<Marka>("SELECT ID, Naziv FROM [dbo].[Marka]").ToList();
        }

        public void CreateOrUpdate(Marka marka)
        {
            if (GetByID(marka.ID) is null)
            {
                _db.Insert<Marka>(marka);
            }
            else
            {
                _db.Update<Marka>(marka);
            }
        }

        public void Create(Marka marka)
        {
            _db.Insert<Marka>(marka);
        }

        public void Update(Marka marka)
        {
            _db.Update<Marka>(marka);
        }

        public void Delete(Marka marka)
        {
            _db.Delete<Marka>(marka);
        }

        public void Delete(int id)
        {
            _db.Execute(@"DELETE FROM [Marka] WHERE ID = @ID", new { ID = id });
        }
    }
}
