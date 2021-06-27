using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationApp
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_ResizeEnd(object sender, EventArgs e)
        {
            MessageBox.Show("Size has changed");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
            //MessageBox.Show($"First name: {txtFirstName.Text}")

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("First name is required", "Bad Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Last name is required", "Bad Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblwyk.Text = radPod.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblwyk.Text = radWy.Text;
        }

        private void radSrd_CheckedChanged(object sender, EventArgs e)
        {
            lblwyk.Text = radSrd.Text;
        }
        private void birthCal_CloseUp(object sender, EventArgs e)
        {
            lbldate.Text = birthCal.Text;
        }
    }
}
