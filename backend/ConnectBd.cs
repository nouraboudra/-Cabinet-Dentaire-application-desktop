using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connexion;

class ConnectBd
{
    private static SqlConnection conn;
    private static ConnectBd instance = null;

    private ConnectBd()
    {
        conn = new SqlConnection(@"Data Source=DESKTOP-UQVLEP1\SQLEXPRESS;Initial Catalog=cabinetDentaire;Persist Security Info=True;User ID=sa;Password=SABAS");

    }

    public  SqlConnection getConn()
    {
        return conn;
    }

    public static ConnectBd getInstance()
    {
        if (instance == null)
        {
            instance = new ConnectBd();
            return instance;
        }
        return instance;
    }
}

