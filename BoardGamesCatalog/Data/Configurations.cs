using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BoardGamesCatalog.Data
{
    public static class Configurations
    {
        public static string ConnectionString =
            "Data Source=PC\\SQLEXPRESS;Initial Catalog=Boardgames;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
    }
}
