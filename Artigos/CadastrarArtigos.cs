using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artigos
{
    public partial class CadastrarArtigos : Form
    {
        public CadastrarArtigos()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtDescrição.Text = "";
            txtData.Text = "";
            cmbArea.Text = "";
        }

        private void CadastrarArtigos_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Deseja sair do cadastro?", "Cancelar cadastro", MessageBoxButtons.YesNo))
            {
                this.Hide();
            }
        }
    }
}
