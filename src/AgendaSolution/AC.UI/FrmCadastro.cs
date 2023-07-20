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


        }

        private void dataGridView_frmCadastro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
     
}
