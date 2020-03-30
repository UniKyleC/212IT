using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager7939147
{
    public partial class contactForm : Form
    {
        public contactForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPC_Click(object sender, EventArgs e)
        {
            PersonalContactsForm personal = new PersonalContactsForm();
            personal.Show();
        }

        private void buttonBC_Click(object sender, EventArgs e)
        {
            BusinessContactsForm business = new BusinessContactsForm();
            business.Show();
        }
    }
}
