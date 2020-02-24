using KianLindskou.WpfControls.DAL;
using KianLindskou.WpfControls.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KianLindskou.WpfControls.BIZ
{
    public class BIZZ
    {
        private DataAccess da = new DataAccess();

        public List<Film> GetAllFilms()
        {
            return da.GetAllFilms();
        }
    }
}
