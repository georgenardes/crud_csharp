using System;
using System.Windows.Forms;

namespace teste
{
    public partial class frmCadastro : Form
    {
        Cliente cliente = null;
        bool alterando = false;


        public frmCadastro()
        {            
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();

            bind();
        }

        private void onClickInserir(object sender, EventArgs e)
        {
            if (alterando)           
                cliente.alterar();
            else
                cliente.gravar();
            
            dgvCliente.DataSource = cliente.getAll();

            inflar();
            alterando = false;
            btnExcluir.Enabled = true;
        }

        private void onClickDeletar(object sender, EventArgs e)
        {
            cliente.deletar();
            dgvCliente.DataSource = cliente.getAll();            
        }

        private void onClickAlterar(object sender, EventArgs e)
        {
            cliente.ler();
            inflar();
            alterando = true;
            btnExcluir.Enabled = false;
        }

        private void onClickCancelar(object sender, EventArgs e)
        {
            cliente.limpar();
            inflar();
            alterando = false;
            btnExcluir.Enabled = true;
        }

        
        private void dgvFunci_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cliente.Id = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells[0].Value);
        }
        
        private void bind()
        {
            /* Grid*/
            dgvCliente.DataSource = cliente.getAll();

            dgvCliente.AutoResizeColumns();
            
            mtxtCPF.DataBindings.Add(new Binding("Text", cliente, "cpf"));
            txtNome.DataBindings.Add(new Binding("Text", cliente, "nome"));
            dtpDataNascimento.DataBindings.Add(new Binding("Value", cliente, "data_nascimento"));
            mtxtNumeroContato.DataBindings.Add(new Binding("Text", cliente, "numero_contato"));
            txtEmailContato.DataBindings.Add(new Binding("Text", cliente, "email_contato"));
            mtxtCEP.DataBindings.Add(new Binding("Text", cliente, "cep"));
            txtLogradouro.DataBindings.Add(new Binding("Text", cliente, "logradouro"));
            txtNumeroEndereco.DataBindings.Add(new Binding("Text", cliente, "numero_endereco"));
            txtComplemento.DataBindings.Add(new Binding("Text", cliente, "complemento"));
            txtBairro.DataBindings.Add(new Binding("Text", cliente, "bairro"));
            txtLocalidade.DataBindings.Add(new Binding("Text", cliente, "localidade"));
            txtUf.DataBindings.Add(new Binding("Text", cliente, "uf"));
            txtObservacoes.DataBindings.Add(new Binding("Text", cliente, "observacoes"));
           
        }

        private void inflar()
        {
            mtxtCPF.Text = cliente.Cpf;
            txtNome.Text = cliente.Nome;
            dtpDataNascimento.Value = cliente.Data_nascimento;
            mtxtNumeroContato.Text = cliente.Numero_contato;
            txtEmailContato.Text = cliente.Email_contato;
            mtxtCEP.Text = cliente.Cep;
            txtLogradouro.Text = cliente.Logradouro;
            txtNumeroEndereco.Text = cliente.Numero_endereco.ToString();
            txtComplemento.Text = cliente.Complemento;
            txtBairro.Text = cliente.Bairro;
            txtLocalidade.Text = cliente.Localidade;
            txtUf.Text = cliente.Uf;
            txtObservacoes.Text = cliente.Observacoes;
            
        }

        private void MtxtCEP_Leave(object sender, EventArgs e)
        {
            if (mtxtCEP.Text.Length > 8)
            {
                switch (cliente.buscarCep(mtxtCEP.Text))
                {
                    case 1:                        
                        inflar();

                        txtNumeroEndereco.Focus();
                        break;
                    case -1:
                        MessageBox.Show("CEP não encontrado");
                        break;
                    case 503:
                        MessageBox.Show("Servidor indisponível");
                        break;
                    default:
                        MessageBox.Show("Erro desconhecido ao buscar CEP");
                        mtxtCEP.Focus();
                        break;
                }
            }
        }

        private void DtpDataNascimento_Leave(object sender, EventArgs e)
        {
            validaData();
        }

        private void validaData()
        {
            DateTime dt = dtpDataNascimento.Value;
            DateTime dt_hoje = DateTime.Now;

            if (dt.AddYears(9) >= dt_hoje.Date)
            {
                MessageBox.Show("O cliente deve ter mais de 9 anos.");
                dtpDataNascimento.Focus();
            }
        }

        private void mtxtCPF_Leave(object sender, EventArgs e)
        {
            if (!Cliente.retmask(mtxtCPF.Text).Equals(""))
            {
                if (!validaCpf(mtxtCPF.Text))
                {
                    MessageBox.Show("Cpf é invalido!");
                    mtxtCPF.Focus();
                }
            }
        }

        private bool validaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digito;

            int soma;
            int resto;

            cpf = Cliente.retmask(cpf);

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();


            return cpf.EndsWith(digito);
        }
    }
}
