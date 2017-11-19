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
    public class VoziloService
    {
        private IDbConnection _db = new SqlConnection(DbConnection.ConnectionString());

        public IEnumerable<Vozilo> GetAll()
        {
            return _db.GetAll<Vozilo>();
        }

        //public List<Vozilo> GetUsers()
        //{
        //    return _db.Query<Vozilo>("SELECT * FROM [dbo].[Vozilo] WHERE ISNULL(Lozinka,'') <> '' ").ToList();
        //}

        public List<Vozilo> GetLookup()
        {
            return _db.Query<Vozilo>("SELECT ID, RegBr as Naziv FROM [dbo].[Vozilo]").ToList();
        }

        public Vozilo GetByID(int Id)
        {
            try
            {
                return _db.Get<Vozilo>(Id);

            }
            catch (Exception)
            {
                Vozilo er = new Vozilo() { ID = 0 };
                return er;
            }
        }

        public int Create(Vozilo Vozilo)
        {
            return (int)_db.Insert<Vozilo>(Vozilo);
        }

        public void Update(Vozilo Vozilo)
        {
            _db.Update<Vozilo>(Vozilo);
        }

        public int CreateOrUpdate(Vozilo Vozilo)
        {
            int result = Vozilo.ID;
            if (!(string.IsNullOrEmpty(Vozilo.RegBr)))
            {
                if (Vozilo.ID == 0 || GetByID(Vozilo.ID) is null)
                {
                    result = Create(Vozilo);
                }
                else
                {
                    Update(Vozilo);
                }
            }
            return result;
        }

        public void Delete(int id)
        {
            _db.Execute(@"DELETE FROM [Vozilo] WHERE ID = @Id", new { Id = id });
        }
    }
}
