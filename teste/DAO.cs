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

    class DAO
    {
        string strConnect = "Server=127.0.0.1;User Id=postgres; Password=123456; Database=cadastro;";
        NpgsqlConnection connection;
        public DAO()
        {
            try
            {
                connection = new NpgsqlConnection(strConnect);
                connection.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("insert into cliente (cpf, cep) values (123456789, 88311230)", connection);

                cmd.ExecuteNonQuery();

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }

        }

    }
}
