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
        //new database connection
        dbConn DBConn = new dbConn();
        public BusinessContactsForm()
        {
            //intiliasise the components on calling this class
            InitializeComponent();
        }

        private void BusinessContactsForm_Load(object sender, EventArgs e)
        {
            //on form load, refresh the dgv using the getallbusiness method from dbconn class
            dgvBusiness.DataSource = DBConn.GetAllBusiness();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //on clicking the refresh button, refresh the dgv using the getallbusiness method from dbconn class
            dgvBusiness.DataSource = DBConn.GetAllBusiness();
        }
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            //on clicking add new, enable the relevant text boxes (aka all of them)
            txbxFirstName.Enabled = true;
            txbxLastName.Enabled = true;
            txbxMobile.Enabled = true;
            txbxEmail.Enabled = true;
            txbxAddr1.Enabled = true;
            txbxAddr2.Enabled = true;
            txbxCity.Enabled = true;
            txbxPostcode.Enabled = true;
            txbxBusinessTel.Enabled = true;
            //disable the relevant and enable the relevant buttons
            buttonDeleteSel.Enabled = false;
            buttonUpdateSel.Enabled = false;
            buttonSaveNew.Enabled = true;
            //make sure all the textboxes are empty
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
            //upon clicking save new, create a new contact, with the data from the textboxes
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
            //call the insert businessness method from db conn
            DBConn.InsertBusiness(BusinessContact);
            //once inserted, disable the text boxes again
            txbxFirstName.Enabled = false;
            txbxLastName.Enabled = false;
            txbxMobile.Enabled = false;
            txbxEmail.Enabled = false;
            txbxAddr1.Enabled = false;
            txbxAddr2.Enabled = false;
            txbxCity.Enabled = false;
            txbxPostcode.Enabled = false;
            txbxBusinessTel.Enabled = false;
            //and enable/disable the buttons again
            buttonDeleteSel.Enabled = true;
            buttonUpdateSel.Enabled = true;
            buttonSaveNew.Enabled = false;
            //then refresh the dgv
            dgvBusiness.DataSource = DBConn.GetAllBusiness();


        }

        private void buttonUpdateSel_Click(object sender, EventArgs e)
        {
            //upon clicking the update selected button, enable the text boxes
            txbxFirstName.Enabled = true;
            txbxLastName.Enabled = true;
            txbxMobile.Enabled = true;
            txbxEmail.Enabled = true;
            txbxAddr1.Enabled = true;
            txbxAddr2.Enabled = true;
            txbxCity.Enabled = true;
            txbxPostcode.Enabled = true;
            txbxBusinessTel.Enabled = true;
            //then disable/enable relevant buttons
            buttonDeleteSel.Enabled = false;
            buttonUpdateSel.Enabled = false;
            buttonAddNew.Enabled = false;
            buttonSaveNew.Enabled = false;
            buttonSaveSel.Enabled = true;


        }



        private void dgvBusiness_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //upon clicking a row/cell in the dgv, pass the information from the row to the appropriate text bxoes
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
            //upon clicking save selected, pass the information in the text boxes to a new contact
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
            //then call the updatebusiness method, passing it the new contact as parameters
            DBConn.UpdateBusiness(BusinessContact);
            //then, update the dgv again
            dgvBusiness.DataSource = DBConn.GetAllBusiness();

            //also disable the text boxes
            txbxFirstName.Enabled = false;
            txbxLastName.Enabled = false;
            txbxMobile.Enabled = false;
            txbxEmail.Enabled = false;
            txbxAddr1.Enabled = false;
            txbxAddr2.Enabled = false;
            txbxCity.Enabled = false;
            txbxPostcode.Enabled = false;
            txbxBusinessTel.Enabled = false;
            //and enable/disable correct buttons
            buttonAddNew.Enabled = true;
            buttonDeleteSel.Enabled = true;
            buttonUpdateSel.Enabled = true;
            buttonSaveNew.Enabled = false;
            buttonSaveSel.Enabled = false;

        }

        private void buttonDeleteSel_Click(object sender, EventArgs e)
        {
            //upon clicking the delete button set these string variables
            string delmessage = "Are you sure you want to delete?";
            string delcaption = "Do you want to delete the record with ID" + Int32.Parse(dgvBusiness.SelectedCells[0].Value.ToString()) + "?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result;
            //show a dialog box with the set variables
            result = MessageBox.Show(delmessage, delcaption, buttons);
            if (result == DialogResult.Yes)
            {
                //if they click yes, run the deleteBusiness method, using th selected row as a parameter
                DBConn.DeleteBusiness(Int32.Parse(dgvBusiness.SelectedCells[0].Value.ToString()));
                dgvBusiness.DataSource = DBConn.GetAllBusiness();
            }

        }

            }

}
