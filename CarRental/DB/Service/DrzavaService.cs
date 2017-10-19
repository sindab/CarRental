using Dapper;
using Dapper.Contrib.Extensions;
using CarRental.DB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DB.Service
{
    public class DrzavaService
    {
        private IDbConnection _db = new SqlConnection(DbConnection.ConnectionString());

        public IEnumerable<Drzava> GetAll()
        {
            return _db.GetAll<Drzava>();
        }

        public Drzava GetByID(int Id)
        {
            return _db.Get<Drzava>(Id);
        }

        public void CreateOrUpdate(Drzava Drzava)
        {
            if (GetByID(Drzava.ID) is null)
            {
                _db.Insert<Drzava>(Drzava);
            }
            else
            {
                _db.Update<Drzava>(Drzava);
            }
        }

        public void Create(Drzava Drzava)
        {
            _db.Insert<Drzava>(Drzava);
        }

        public void Update(Drzava Drzava)
        {
            _db.Update<Drzava>(Drzava);
        }

        public void Delete(Drzava Drzava)
        {
            _db.Delete<Drzava>(Drzava);
        }

        public void Delete(int id)
        {
            _db.Execute(@"DELETE FROM [Drzava] WHERE ID = @ID", new { ID = id });
        }
    }
}
