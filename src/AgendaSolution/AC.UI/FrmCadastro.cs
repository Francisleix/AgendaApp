using AC.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AC.BLL;




namespace AC.UI
{
    public partial class FrmCadastro : Form
    {
        Contato contato = new Contato();

        public FrmCadastro()
        {
            InitializeComponent();
        }

        public FrmCadastro(int ID)
        {
            InitializeComponent();

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCasdastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.Show();
            this.Close();
                 

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisado = txbPesquisar.Text;
            var contato = new ContatoBLL();
            var resultado = contato.ListarContatosPesquisa(termoPesquisado);
            dataGridView_frmCadastro.DataSource = resultado;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string Id = lblID.Text;
            int IdPessoa = 0;

            if (!string.IsNullOrEmpty(Id) && Id != "ID")
            {
                IdPessoa = Convert.ToInt32(Id);


            }
            else
            {
                MessageBox.Show("Atenção ! Selecione um contato para editar ");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string ID = lblID.Text;
            int id = 0;

            if (!string.IsNullOrEmpty( ID ) && ID != "ID")
            {
                id = Convert.ToInt32(ID);

                var contatoBLL = new ContatoBLL();

                string retorno = contatoBLL.Delete(id);

                if (!string.IsNullOrEmpty(retorno)) 
                {
                    MessageBox.Show("Contato ID : " + retorno + " excluido com sucesso !!!");
                }
            }
            else
            {
                MessageBox.Show("Atenção ! Selecione um contato para exclusão ");
            }

        }

        private void dataGridView_frmCadastro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataGridView_frmCadastro.CurrentRow.Cells[0].Value.ToString();
            string Nome = dataGridView_frmCadastro.CurrentRow.Cells[1].Value.ToString();
            string Telefone = dataGridView_frmCadastro.CurrentRow.Cells[2].Value.ToString();
            string Email = dataGridView_frmCadastro.CurrentRow.Cells[3].Value.ToString();
            string Status = dataGridView_frmCadastro.CurrentRow.Cells[4].Value.ToString();

            lblID.Text = ID;
            txbNome.Text = Nome;
            txbTelefone.Text = Telefone;
            txbEmail.Text = Email;

            checkBoxStatus.Checked = Convert.ToBoolean(Status);
                                
        }

        public void LimparCampos()
        {
            txbNome.Text = string.Empty;
            txbEmail.Text = string.Empty;
            txbTelefone.Text = string.Empty;
            checkBoxStatus.Checked = false;

        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var contatoReturn = new Contato();
            var contato = new Contato();
            contato.Nome = txbNome.Text;
            contato.Telefone = txbTelefone.Text;
            contato.Email = txbEmail.Text;
            if ( checkBoxStatus.Checked == true)
            {
                contato.Status = true;
            }
            else
            {
                contato.Status = false;
            }
            var contatoBLL = new ContatoBLL();
            try
            {
                if (!string.IsNullOrEmpty(contato.Nome) && !string.IsNullOrEmpty(contato.Email))
                    contatoReturn = contatoBLL.Create(contato);
                else
                    MessageBox.Show("Atenção ! Preencha os campos Nome e Email ante de gravar");
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar tentar cadastrar na tabela Contato" + ex);
            }

            if (contatoReturn.ID > 0 )
            {
                dataGridView_frmCadastro.DataSource = contatoBLL.ListarContatosPorID(contatoReturn.ID);
                MessageBox.Show("Dados Cadastrados com Sucesso");
                LimparCampos();
            }
        }
    }
     
}
