using System;
using Npgsql;
using System.Data;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace teste
{
    
    class Cliente : Crud
    {
        private int id;
        private string cpf;
        private string nome;
        private DateTime data_nascimento;
        private string numero_contato;
        private string email_contato;
        private string cep;
        private string logradouro;
        private int numero_endereco;
        private string complemento;
        private string bairro;
        private string localidade;
        private string uf;
        private string observacoes;

        private DAO dao;

        public int Id { get => id; set => id = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public string Numero_contato { get => numero_contato; set => numero_contato = value; }
        public string Email_contato { get => email_contato; set => email_contato = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public int Numero_endereco { get => numero_endereco; set => numero_endereco = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Localidade { get => localidade; set => localidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Observacoes { get => observacoes; set => observacoes = value; }

        public Cliente()
        {
            this.dao = DAO.getInstance();

            Data_nascimento = new DateTime(2010,01,01);
            
        }


        public override bool alterar()
        {
            try
            {
                using (NpgsqlCommand cmdUpdate = dao.connection.CreateCommand())
                {
                    cmdUpdate.CommandText = "UPDATE CLIENTE SET " +
                        "cpf = @cpf, nome = @nome, data_nascimento = @data_nascimento," +
                        "numero_contato = @numero_contato, email_contato = @email_contato," +
                        "cep = @cep, logradouro = @logradouro, " +
                        "numero_endereco = @numero_endereco, complemento = @complemento," +
                        "bairro = @bairro, localidade = @localidade, uf = @uf, " +
                        "observacoes = @observacoes";

                    cmdUpdate.Parameters.AddWithValue("@cpf", retmask(cpf));
                    cmdUpdate.Parameters.AddWithValue("@nome", nome);
                    cmdUpdate.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                    cmdUpdate.Parameters.AddWithValue("@numero_contato", retmask(numero_contato));
                    cmdUpdate.Parameters.AddWithValue("@email_contato", email_contato);
                    cmdUpdate.Parameters.AddWithValue("@cep", retmask(cep));
                    cmdUpdate.Parameters.AddWithValue("@logradouro", logradouro);
                    cmdUpdate.Parameters.AddWithValue("@numero_endereco", numero_endereco);
                    cmdUpdate.Parameters.AddWithValue("@complemento", complemento);
                    cmdUpdate.Parameters.AddWithValue("@bairro", bairro);
                    cmdUpdate.Parameters.AddWithValue("@localidade", localidade);
                    cmdUpdate.Parameters.AddWithValue("@uf", uf);
                    cmdUpdate.Parameters.AddWithValue("@observacoes", observacoes);

                    cmdUpdate.ExecuteNonQuery();
                }

                this.limpar();
                return true;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
                return false;
            }

        }

        public override bool deletar()
        {
            string cmdDelete = "delete from cliente where _id = " + this.id;

            try
            {
                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDelete, this.dao.connection))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                return true;
            } catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
                return false;
            }                                  
        }

        public override bool gravar()
        {
            
            Cpf = retmask(Cpf);
            Numero_contato = retmask(Numero_contato);
            Cep = retmask(Cep);         
            
            string cmdInserir = String.Format("INSERT INTO cliente(" +
            "cpf, nome, data_nascimento, numero_contato, email_contato," +
            "cep, logradouro, numero_endereco, complemento, bairro, localidade," +
            "UF, observacoes) VALUES (" +
            "'" + Cpf + "'," +
            "'" + Nome +"'," +
            "'" + Data_nascimento.ToString("dd/MM/yyyy") + "'," +
            "'" + Numero_contato + "'," +
            "'" + Email_contato + "'," +
            "'" + Cep + "'," +
            "'" + Logradouro + "'," +
            "" + Numero_endereco + "," +
            "'" + Complemento + "'," +
            "'" + Bairro + "'," +
            "'" + Localidade +"'," +
            "'" + Uf + "'," +
            "'" + Observacoes + "')");;

            try
            {
                using (NpgsqlCommand cmdInsert = dao.connection.CreateCommand())
                {
                    cmdInsert.CommandText = cmdInserir;

                    cmdInsert.ExecuteNonQuery();
                }
                limpar();
                return true;
            }
            catch (NpgsqlException msg)
            {
                MessageBox.Show(msg.Message);
                return false;
            }finally
            {
                Id = 0;
            }
            
        }

        public override bool ler()
        {
            DataTable dt = new DataTable();

            string cmdSeleciona = "SELECT " +
                "_id, cpf, nome, data_nascimento, numero_contato, email_contato," +
                "cep, logradouro, numero_endereco, complemento, bairro, localidade," +
                "uf, observacoes " +
                "from cliente " +
                "where _id = " + Id;
                

            try
            {
                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, this.dao.connection))
                {
                    Adpt.Fill(dt);                 
                }
                cpf         =  dt.Rows[0]["cpf"].ToString();
                nome        =  dt.Rows[0]["nome"].ToString();
                data_nascimento =  Convert.ToDateTime(dt.Rows[0]["data_nascimento"].ToString());
                numero_contato =  dt.Rows[0]["numero_contato"].ToString();
                cep         =  dt.Rows[0]["cep"].ToString();
                logradouro  =  dt.Rows[0]["logradouro"].ToString();
                numero_endereco =  Convert.ToInt32(dt.Rows[0]["numero_endereco"].ToString());
                email_contato =  dt.Rows[0]["email_contato"].ToString();
                complemento =  dt.Rows[0]["complemento"].ToString();
                localidade  =  dt.Rows[0]["localidade"].ToString();
                bairro      =  dt.Rows[0]["bairro"].ToString();
                uf          =  dt.Rows[0]["uf"].ToString();
                observacoes =  dt.Rows[0]["observacoes"].ToString();
                
                               
                return true;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                return false;
            }
            
        }

        public void limpar()
        {
            id = 0;
            cpf = "";
            nome = "";
            data_nascimento = new DateTime(2010, 01, 01);
            numero_contato = "";
            cep = "";
            logradouro = "";
            numero_endereco = 0;
            email_contato = "";
            complemento = "";
            localidade = "";
            bairro = "";
            uf = "";
            observacoes = "";
        }


        public DataTable getAll()
        {
            DataTable dt= new DataTable();          

            string cmdSeleciona = "SELECT _id AS ID, nome, numero_contato, email_contato from cliente order by nome";
        
            try
            {
                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, this.dao.connection))
                {
                    Adpt.Fill(dt);                    
                }
            }
            catch(Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
            
            return dt;
        }

        private string retmask(string strToRet)
        {
            if (strToRet == null)
                strToRet = "";
            

            string strNewStr = strToRet;

            strNewStr = strNewStr.Replace("-", "").Trim();
            strNewStr = strNewStr.Replace(",", "").Trim();
            strNewStr = strNewStr.Replace(".", "").Trim();
            strNewStr = strNewStr.Replace("/", "").Trim();
            strNewStr = strNewStr.Replace("'", "").Trim();
            strNewStr = strNewStr.Replace(":", "").Trim();
            strNewStr = strNewStr.Replace("(", "").Trim();
            strNewStr = strNewStr.Replace(")", "").Trim();
            strNewStr = strNewStr.Replace(" ", "").Trim();

            return strNewStr;
        }

        public int buscarCep(string strCep)
        {
            MessageBox.Show(strCep);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + retmask(strCep) + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {                
                return 503; // Sai da rotina
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    return -1;
                                }
                            }

                            //Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                logradouro = valor[1].Trim();
                            }

                            //Complemento
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                complemento = valor[1].Trim();
                            }

                            //Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                bairro = valor[1].Trim();
                            }

                            //Localidade (Cidade)
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                localidade = valor[1].Trim();
                            }

                            //Estado (UF)
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                uf = valor[1].Trim();
                            }

                            cont++;
                        }
                        cep = strCep;
                        return 1;
                    }
                }
                else
                {
                    return -2;
                }
                
            }
        }




    }
}
