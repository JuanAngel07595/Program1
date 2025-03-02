using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class backform : Form
    {
        public backform()
        {
            InitializeComponent();
        }

        private void TextNombre_Click(object sender, EventArgs e)
        {

        }

        private void TextCorreo_Click(object sender, EventArgs e)
        {

        }

        private void BarraID_TextChanged(object sender, EventArgs e)
        {
            
        
    }

        private void boxinfopersonal_Enter(object sender, EventArgs e)
        {

        }

        private void Barname_TextChanged(object sender, EventArgs e)
        {

        }

        private void BarLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void bartel_TextChanged(object sender, EventArgs e)
        {

        }

        private void baremail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");

        }

        private void btncancel_Click(object sender, EventArgs e)
        {

            baridentity.Text ="";
            Barname.Text ="";
            BarLastname.Text ="";
            bartel.Text ="";
            baremail.Text ="";
            baridentity.Focus();

        }

        private void backform_Load(object sender, EventArgs e)
        {

            baridentity.Focus();

        }

        private void boxcontacto_Enter(object sender, EventArgs e)
        {

        }

        private void baridentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Presionaste enter!");
                Barname.Focus();
            }
        }

        private void Barname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Presionaste enter!");
                BarLastname.Focus();
            }
        }

        private void BarLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Presionaste enter!");
                bartel.Focus();
            }
        }

        private void bartel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Presionaste enter!");
                baremail.Focus();
            }
        }

        private void baremail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Presionaste enter!");
                btnok.Focus();
            }
        }
    }
}
