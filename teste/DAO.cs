using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace teste
{
    /**
    Server - specifies the server location
    User Id - the database user
    Port - default is 5432
    Password - the password for the database user
    Database - the database name
     * */

    public sealed class DAO
    {
        private static DAO staticDao = null;

        private string strConnect = "Server=127.0.0.1;User Id=postgres; Password=123456; Database=cadastro;";

        public NpgsqlConnection connection;

        public static DAO getInstance()
        {
            /*Exclusão Mutua*/
            lock (typeof(DAO))
            {
                if (staticDao == null)
                {
                    DAO.staticDao = new DAO();
                }
                return DAO.staticDao;
            }           
        }
        

        public DAO()
        {
            try
            {
                connection = new NpgsqlConnection(strConnect);
                connection.Open();

               
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        ~DAO()
        {
            connection.Close();
        }

    }
}
