using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppScreenSplash
{
    public static class Banco
    {
        public static SqlConnection Abrir()
        {
            string strCon = @"Data Source=DESKTOP-QEOUED8\SQLEXPRESS;Initial Catalog=db_Papelaria;Integrated Security=True";
            SqlConnection cn = new SqlConnection(strCon);
            cn.Open();
            return cn;
        }
    }
}
