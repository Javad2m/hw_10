using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git10;

public static class Configuration
{
    public static string ConnectionString { get; set; }

     static Configuration()
    {
        ConnectionString = "Data Source=WKK13\\SQLEXPRESS;Initial Catalog=hw10;User ID=sa;Password=111222333aA;TrustServerCertificate=True;Encrypt=True";
    }
}
