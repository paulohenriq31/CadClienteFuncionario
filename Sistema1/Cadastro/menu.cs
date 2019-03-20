using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarios fFuncioonarios = new frmFuncionarios();
            fFuncioonarios.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClientes fcliente = new frmClientes();
            fcliente.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
