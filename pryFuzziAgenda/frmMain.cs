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
            if (txtName.Text != "")
            {
                txtSurname.Enabled = true;
            }
            else
            {
                txtSurname.Clear();
                txtSurname.Enabled = false;
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (txtSurname.Text != "")
            {
                txtPhone.Enabled = true;
            }
            else
            {
                txtPhone.Clear();
                txtPhone.Enabled = false;
            }
        }

        private void txtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }


        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (txtMail.Text != "")
            {
                cbxCategory.Enabled = true;
            }
            else
            {
                cbxCategory.SelectedItem = null;
                cbxCategory.Enabled = false;
            }
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
                dgvContacts.Rows.Add(txtName.Text, txtSurname.Text, txtPhone.Text, txtMail.Text, cbxCategory.Text);
                txtName.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtMail.Text = string.Empty;
                txtSurname.Text = string.Empty;
                cbxCategory.SelectedItem = null;

                txtPhone.Enabled = false;
                txtMail.Enabled = false;
                txtSurname.Enabled = false;
                cbxCategory.Enabled = false;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text != "")
            {
                txtMail.Enabled = true;
            }
            else
            {
                txtMail.Clear();
                txtMail.Enabled = false;
            }
        }
    }
}
