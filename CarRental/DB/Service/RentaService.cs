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

        public void CreateOrUpdate(Renta Renta)
        {
            if (GetByID(Renta.ID) is null)
            {
                _db.Insert<Renta>(Renta);
            }
            else
            {
                _db.Update<Renta>(Renta);
            }
        }

        public void Create(Renta Renta)
        {
            _db.Insert<Renta>(Renta);
        }

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
    }
}
