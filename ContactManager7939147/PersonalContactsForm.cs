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
    public partial class PersonalContactsForm : Form
    {
        dbConn DBConn = new dbConn();
        public PersonalContactsForm()
        {
            InitializeComponent();
        }

        private void PersonalContactsForm_Load(object sender, EventArgs e)
        {
            dgvPersonal.DataSource = DBConn.GetAllPersonal();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dgvPersonal.DataSource = DBConn.GetAllPersonal();
        }
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            txbxFirstName.Enabled = true;
            txbxLastName.Enabled = true;
            txbxMobile.Enabled = true;
            txbxEmail.Enabled = true;
            txbxAddr1.Enabled = true;
            txbxAddr2.Enabled = true;
            txbxCity.Enabled = true;
            txbxPostcode.Enabled = true;
            txbxPersonalTel.Enabled = true;

            buttonDeleteSel.Enabled = false;
            buttonUpdateSel.Enabled = false;
            buttonSaveNew.Enabled = true;

            txbxFirstName.Text = String.Empty;
            txbxLastName.Text = String.Empty;
            txbxMobile.Text = String.Empty;
            txbxEmail.Text = String.Empty;
            txbxAddr1.Text = String.Empty;
            txbxAddr2.Text = String.Empty;
            txbxCity.Text = String.Empty;
            txbxPostcode.Text = String.Empty;
            txbxPersonalTel.Text = String.Empty;




        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            personalContact personalContact = new personalContact();
            personalContact.conFName = txbxFirstName.Text;
            personalContact.conLName = txbxLastName.Text;
            personalContact.conTel = txbxMobile.Text;
            personalContact.conEmail = txbxEmail.Text;
            personalContact.conAddr1 = txbxAddr1.Text;
            personalContact.conAddr2 = txbxAddr2.Text;
            personalContact.conCity = txbxCity.Text;
            personalContact.conPostcode = txbxPostcode.Text;
            personalContact.conHTel = txbxPersonalTel.Text;

            DBConn.InsertPersonal(personalContact);

            txbxFirstName.Enabled = false;
            txbxLastName.Enabled = false;
            txbxMobile.Enabled = false;
            txbxEmail.Enabled = false;
            txbxAddr1.Enabled = false;
            txbxAddr2.Enabled = false;
            txbxCity.Enabled = false;
            txbxPostcode.Enabled = false;
            txbxPersonalTel.Enabled = false;

            buttonDeleteSel.Enabled = true;
            buttonUpdateSel.Enabled = true;
            buttonSaveNew.Enabled = false;

            dgvPersonal.DataSource = DBConn.GetAllPersonal();


        }

        private void buttonUpdateSel_Click(object sender, EventArgs e)
        {

            txbxFirstName.Enabled = true;
            txbxLastName.Enabled = true;
            txbxMobile.Enabled = true;
            txbxEmail.Enabled = true;
            txbxAddr1.Enabled = true;
            txbxAddr2.Enabled = true;
            txbxCity.Enabled = true;
            txbxPostcode.Enabled = true;
            txbxPersonalTel.Enabled = true;

            buttonDeleteSel.Enabled = false;
            buttonUpdateSel.Enabled = false;
            buttonAddNew.Enabled = false;
            buttonSaveNew.Enabled = false;
            buttonSaveSel.Enabled = true;


        }



        private void dgvPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = Int32.Parse(dgvPersonal.SelectedCells[0].Value.ToString());
            txbxFirstName.Text = dgvPersonal.SelectedCells[1].Value.ToString();
            txbxLastName.Text = dgvPersonal.SelectedCells[2].Value.ToString();
            txbxMobile.Text = dgvPersonal.SelectedCells[3].Value.ToString();
            txbxEmail.Text = dgvPersonal.SelectedCells[4].Value.ToString();
            txbxAddr1.Text = dgvPersonal.SelectedCells[5].Value.ToString();
            txbxAddr2.Text = dgvPersonal.SelectedCells[6].Value.ToString();
            txbxCity.Text = dgvPersonal.SelectedCells[7].Value.ToString();
            txbxPostcode.Text = dgvPersonal.SelectedCells[8].Value.ToString();
            txbxPersonalTel.Text = dgvPersonal.SelectedCells[9].Value.ToString();
        }

        private void buttonSaveSel_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(dgvPersonal.SelectedCells[0].Value.ToString());
            personalContact personalContact = new personalContact();
            personalContact.conID = index;
            personalContact.conFName = txbxFirstName.Text;
            personalContact.conLName = txbxLastName.Text;
            personalContact.conTel = txbxMobile.Text;
            personalContact.conEmail = txbxEmail.Text;
            personalContact.conHTel = txbxPersonalTel.Text;
            personalContact.conAddr1 = txbxAddr1.Text;
            personalContact.conAddr2 = txbxAddr2.Text;
            personalContact.conCity = txbxCity.Text;
            personalContact.conPostcode = txbxPostcode.Text;

            DBConn.UpdatePersonal(personalContact);
            dgvPersonal.DataSource = DBConn.GetAllPersonal();


            txbxFirstName.Enabled = false;
            txbxLastName.Enabled = false;
            txbxMobile.Enabled = false;
            txbxEmail.Enabled = false;
            txbxAddr1.Enabled = false;
            txbxAddr2.Enabled = false;
            txbxCity.Enabled = false;
            txbxPostcode.Enabled = false;
            txbxPersonalTel.Enabled = false;

            buttonAddNew.Enabled = true;
            buttonDeleteSel.Enabled = true;
            buttonUpdateSel.Enabled = true;
            buttonSaveNew.Enabled = false;
            buttonSaveSel.Enabled = false;

        }

        private void buttonDeleteSel_Click(object sender, EventArgs e)
        {
            string delmessage = "Are you sure you want to delete?";
            string delcaption = "Do you want to delete the record with ID" + Int32.Parse(dgvPersonal.SelectedCells[0].Value.ToString()) + "?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result;

           result =  MessageBox.Show(delmessage, delcaption, buttons);
            if (result == DialogResult.Yes)
            {
                DBConn.DeletePersonal(Int32.Parse(dgvPersonal.SelectedCells[0].Value.ToString()));
                dgvPersonal.DataSource =  DBConn.GetAllPersonal();
            }

        }
    }

}
