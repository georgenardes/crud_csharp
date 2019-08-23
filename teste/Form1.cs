using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/**
 * Buscar CPF é pago
 * https://www.cpfcnpj.com.br/dev/
 */


namespace teste
{
    public partial class frmCadastro : Form
    {
       
        string connectionString = @"Server=.\sqlexpress;Database=bdcadastro;Trusted_Connection=True;";
        private bool isAlterar = false;

        DAO dbHelper;

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            
        }

        /**
         * Inserção
         */
        private void onClickInserir(object sender, EventArgs e)
        {
            

            if (!this.isAlterar)
            {
                string sql = "INSERT INTO CLIENTE " +
                    "(cpf, nome, data_nasc, telefone, email, " +
                    "cep, logradouro, numero, complemento, bairro, localidade, uf," +
                    "observacoes) ";

                /*  Valores */
               sql += " VALUES (" +
                    "'" + mtxtCPF.Text + "'," +
                    "'" + txtNome.Text.Trim() + "'," +
                    "'" + dtp.Text + "'," +
                    "'" + mtxtNumeroContato.Text + "'," +
                    "'" + txtEmailContato.Text + "'," +
                    "'" + mtxtCEP.Text + "'," +
                    "'" + txtLogradouro.Text + "'," +
                    "'" + mtxtNumero.Text + "'," +
                    "'" + txtComplemento.Text + "'," +
                    "'" + txtBairro.Text + "'," +
                    "'" + txtLocalidade.Text + "'," +
                    "'" + txtUF.Text + "'," +
                    "'" + txtObservacoes.Text + "')";

                System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, connection);

                cmd.CommandType = CommandType.Text;

                connection.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {

            }
        }




    }
}
