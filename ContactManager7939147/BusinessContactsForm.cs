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
    public partial class BusinessContactsForm : Form
    {
        dbConn DBConn = new dbConn();
        public BusinessContactsForm()
        {
            InitializeComponent();
        }

        private void BusinessContactsForm_Load(object sender, EventArgs e)
        {
            dgvBusiness.DataSource = DBConn.GetAllBusiness();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dgvBusiness.DataSource = DBConn.GetAllBusiness();
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
            txbxBusinessTel.Enabled = true;

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
            txbxBusinessTel.Text = String.Empty;




        }

        private void buttonSaveNew_Click(object sender, EventArgs e)
        {
            businessContact BusinessContact = new businessContact();
            BusinessContact.conFName = txbxFirstName.Text;
            BusinessContact.conLName = txbxLastName.Text;
            BusinessContact.conTel = txbxMobile.Text;
            BusinessContact.conEmail = txbxEmail.Text;
            BusinessContact.conAddr1 = txbxAddr1.Text;
            BusinessContact.conAddr2 = txbxAddr2.Text;
            BusinessContact.conCity = txbxCity.Text;
            BusinessContact.conPostcode = txbxPostcode.Text;
            BusinessContact.conBTel = txbxBusinessTel.Text;

            DBConn.InsertBusiness(BusinessContact);

            txbxFirstName.Enabled = false;
            txbxLastName.Enabled = false;
            txbxMobile.Enabled = false;
            txbxEmail.Enabled = false;
            txbxAddr1.Enabled = false;
            txbxAddr2.Enabled = false;
            txbxCity.Enabled = false;
            txbxPostcode.Enabled = false;
            txbxBusinessTel.Enabled = false;

            buttonDeleteSel.Enabled = true;
            buttonUpdateSel.Enabled = true;
            buttonSaveNew.Enabled = false;

            dgvBusiness.DataSource = DBConn.GetAllBusiness();


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
            txbxBusinessTel.Enabled = true;

            buttonDeleteSel.Enabled = false;
            buttonUpdateSel.Enabled = false;
            buttonAddNew.Enabled = false;
            buttonSaveNew.Enabled = false;
            buttonSaveSel.Enabled = true;


        }



        private void dgvBusiness_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = Int32.Parse(dgvBusiness.SelectedCells[0].Value.ToString());
            txbxFirstName.Text = dgvBusiness.SelectedCells[1].Value.ToString();
            txbxLastName.Text = dgvBusiness.SelectedCells[2].Value.ToString();
            txbxMobile.Text = dgvBusiness.SelectedCells[3].Value.ToString();
            txbxEmail.Text = dgvBusiness.SelectedCells[4].Value.ToString();
            txbxAddr1.Text = dgvBusiness.SelectedCells[5].Value.ToString();
            txbxAddr2.Text = dgvBusiness.SelectedCells[6].Value.ToString();
            txbxCity.Text = dgvBusiness.SelectedCells[7].Value.ToString();
            txbxPostcode.Text = dgvBusiness.SelectedCells[8].Value.ToString();
            txbxBusinessTel.Text = dgvBusiness.SelectedCells[9].Value.ToString();
        }

        private void buttonSaveSel_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(dgvBusiness.SelectedCells[0].Value.ToString());
            businessContact BusinessContact = new businessContact();
            BusinessContact.conID = index;
            BusinessContact.conFName = txbxFirstName.Text;
            BusinessContact.conLName = txbxLastName.Text;
            BusinessContact.conTel = txbxMobile.Text;
            BusinessContact.conEmail = txbxEmail.Text;
            BusinessContact.conBTel = txbxBusinessTel.Text;
            BusinessContact.conAddr1 = txbxAddr1.Text;
            BusinessContact.conAddr2 = txbxAddr2.Text;
            BusinessContact.conCity = txbxCity.Text;
            BusinessContact.conPostcode = txbxPostcode.Text;

            DBConn.UpdateBusiness(BusinessContact);
            dgvBusiness.DataSource = DBConn.GetAllBusiness();


            txbxFirstName.Enabled = false;
            txbxLastName.Enabled = false;
            txbxMobile.Enabled = false;
            txbxEmail.Enabled = false;
            txbxAddr1.Enabled = false;
            txbxAddr2.Enabled = false;
            txbxCity.Enabled = false;
            txbxPostcode.Enabled = false;
            txbxBusinessTel.Enabled = false;

            buttonAddNew.Enabled = true;
            buttonDeleteSel.Enabled = true;
            buttonUpdateSel.Enabled = true;
            buttonSaveNew.Enabled = false;
            buttonSaveSel.Enabled = false;

        }

        private void buttonDeleteSel_Click(object sender, EventArgs e)
        {
            string delmessage = "Are you sure you want to delete?";
            string delcaption = "Do you want to delete the record with ID" + Int32.Parse(dgvBusiness.SelectedCells[0].Value.ToString()) + "?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result;

            result = MessageBox.Show(delmessage, delcaption, buttons);
            if (result == DialogResult.Yes)
            {
                DBConn.DeleteBusiness(Int32.Parse(dgvBusiness.SelectedCells[0].Value.ToString()));
                dgvBusiness.DataSource = DBConn.GetAllBusiness();
            }

        }

            }

}
