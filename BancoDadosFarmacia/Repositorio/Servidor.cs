using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Servidor
    {

        public string PegarServidor()
        {
            string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Seek3r_Home.mdf;Integrated Security=True;Connect Timeout=30";

            return CadeiaDeConexao;
        }

    }
}
