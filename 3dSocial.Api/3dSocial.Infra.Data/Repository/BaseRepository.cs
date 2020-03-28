using _3dSocial.Domain.Entities;
using _3dSocial.Domain.Interfaces;
using _3dSocial.Infra.Data.Mapping;
using Dapper;
using DapperExtensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace _3dSocial.Infra.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        public BaseRepository()
        {
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[] { typeof(CenterClassMapper).Assembly });
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[] { typeof(ProjectClassMapper).Assembly });
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[] { typeof(DemandClassMapper).Assembly });
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[] { typeof(UserClassMapper).Assembly });

            DapperExtensions.DapperExtensions.SqlDialect = new DapperExtensions.Sql.MySqlDialect();
        }

        private string GetConnectionString()
        {
            return "Server=50.116.86.24;Port=3306;Database=telef840_3dSocial;Uid=telef840_3dSocia;Pwd=ATpJ6ebNrLWkk8Rc8MVm969K9FPfnhuZ";
            //TODO:
            //return ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        }


        public void Insert(T obj)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Insert<T>(obj);
            }
        }

        public void Update(T obj)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Update<T>(obj);
            }
        }

        public void Delete(T obj)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Delete<T>(obj);
            }
        }

        public IList<T> Select()
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                return con.GetList<T>().AsList();
            }
        }

        public T Select(int id)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                return con.Get<T>(id);
            }
        }

        public void Remove<T1>(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
