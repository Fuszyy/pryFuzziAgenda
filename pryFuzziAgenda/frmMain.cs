using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFuzziAgenda
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtSurname.Enabled = true;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            txtPhone.Enabled = true;
        }

        private void txtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtMail.Enabled = true;
        }


        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            cbxCategory.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSurname.Text == "" || txtPhone.Text == "" || txtMail.Text == "" || cbxCategory.Text == "")
            {
                MessageBox.Show("Complete los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Datos Guardados correctamente.", "Tarea Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
