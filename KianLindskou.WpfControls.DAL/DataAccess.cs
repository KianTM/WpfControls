using Dapper;
using KianLindskou.WpfControls.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KianLindskou.WpfControls.DAL
{
    public class DataAccess
    {
        public List<Film> GetAllFilms()
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FilmDB")))
            {
                var output = connection.Query<Film>("dbo.Film_GetAllFilms").ToList();
                return output;
            }
        }
    }
}
