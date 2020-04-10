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
    //inherit the inbuilt form class
    public partial class contactForm : Form
    {
        public contactForm()
        {
            //intilise the form when the class is called
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //no on-load actions
        }

        private void buttonPC_Click(object sender, EventArgs e)
        {
            //upon clicking the buttonPC (personal contacts) load the personal contacts form and show it
            PersonalContactsForm personal = new PersonalContactsForm();
            personal.Show();
        }

        private void buttonBC_Click(object sender, EventArgs e)
        {
            //upon clicking buttonBC (business contacts) load the busines form and show it
            BusinessContactsForm business = new BusinessContactsForm();
            business.Show();
        }
    }
}
