using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;

namespace Lab12_2.Models
{
    public class DAL
    {
        public static MySqlConnection DB;

        public static List<movie> ReadAllMovies()
        {
            return DB.GetAll<movie>().ToList();
        }

        public static movie ReadOneMovie(string id)
        {
            return DB.Get<movie>(id);
        }

        public static List<movie> ReadAllbyCategory(string cat)
        {
            var mymovies = new { themovie = cat};
            string sql = "select * from movie where department = @themovie";

            List<movie> emps = DB.Query<movie>(sql, mymovies).ToList();
            return emps;
        }

        public static bool DeleteMovie(string id)
        {
            movie temp = new movie() { id = id };
            DB.Delete<movie>(temp);
            return true;
        }

        public static movie AddMovie(movie emp)
        {
            DB.Insert<movie>(emp);
            return emp;
        }

        public static movie Updatemovie(movie emp)
        {
            DB.Update<movie>(emp);
            return emp;
        }

    }
}
