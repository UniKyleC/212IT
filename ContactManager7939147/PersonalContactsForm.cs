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
        //new database connection 
        dbConn DBConn = new dbConn();
        public PersonalContactsForm()
        {
            //upon calling this class, initislise the components
            InitializeComponent();
        }

        private void PersonalContactsForm_Load(object sender, EventArgs e)
        {
            //on form load, use the GetAllPersonal to populate the data grid view with the database as a source
            dgvPersonal.DataSource = DBConn.GetAllPersonal();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //on clicking the refresh button, use GetAllPersonal to populate the dgv with the database as a source
            dgvPersonal.DataSource = DBConn.GetAllPersonal();
        }
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            //Upon clicking the 'add new' button, enable the text boxes for data input
            txbxFirstName.Enabled = true;
            txbxLastName.Enabled = true;
            txbxMobile.Enabled = true;
            txbxEmail.Enabled = true;
            txbxAddr1.Enabled = true;
            txbxAddr2.Enabled = true;
            txbxCity.Enabled = true;
            txbxPostcode.Enabled = true;
            txbxPersonalTel.Enabled = true;
            //also, disable the selection buttons but enable the save new button
            buttonDeleteSel.Enabled = false;
            buttonUpdateSel.Enabled = false;
            buttonSaveNew.Enabled = true;
            //make sure the text boxes are empty when you come to add a new contact
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
            //upon clicking the save new button, create a new personalContact with the following data
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

            //call the method InsertPersonal to insert the data
            DBConn.InsertPersonal(personalContact);
            //disable the text boxes after saving the data
            txbxFirstName.Enabled = false;
            txbxLastName.Enabled = false;
            txbxMobile.Enabled = false;
            txbxEmail.Enabled = false;
            txbxAddr1.Enabled = false;
            txbxAddr2.Enabled = false;
            txbxCity.Enabled = false;
            txbxPostcode.Enabled = false;
            txbxPersonalTel.Enabled = false;
            //re-enable the other buttons, and disable the save button again
            buttonDeleteSel.Enabled = true;
            buttonUpdateSel.Enabled = true;
            buttonSaveNew.Enabled = false;
            //refresh the dgv with getallpersonal method
            dgvPersonal.DataSource = DBConn.GetAllPersonal();


        }

        private void buttonUpdateSel_Click(object sender, EventArgs e)
        {
            //enable the text boxes upon clicking
            txbxFirstName.Enabled = true;
            txbxLastName.Enabled = true;
            txbxMobile.Enabled = true;
            txbxEmail.Enabled = true;
            txbxAddr1.Enabled = true;
            txbxAddr2.Enabled = true;
            txbxCity.Enabled = true;
            txbxPostcode.Enabled = true;
            txbxPersonalTel.Enabled = true;
            //disable unwanted buttons and enable the saveselected button
            buttonDeleteSel.Enabled = false;
            buttonUpdateSel.Enabled = false;
            buttonAddNew.Enabled = false;
            buttonSaveNew.Enabled = false;
            buttonSaveSel.Enabled = true;


        }



        private void dgvPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //upon clicking a cell in the table, send the data to the text boxes
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
            //send the data from the text boxes to the personal contact
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

            //call the update personal method, passing it the new contact we just made
            DBConn.UpdatePersonal(personalContact);
            //update the dgv
            dgvPersonal.DataSource = DBConn.GetAllPersonal();

            //disable the text boxes
            txbxFirstName.Enabled = false;
            txbxLastName.Enabled = false;
            txbxMobile.Enabled = false;
            txbxEmail.Enabled = false;
            txbxAddr1.Enabled = false;
            txbxAddr2.Enabled = false;
            txbxCity.Enabled = false;
            txbxPostcode.Enabled = false;
            txbxPersonalTel.Enabled = false;
            //disable-enable buttons as appropriate
            buttonAddNew.Enabled = true;
            buttonDeleteSel.Enabled = true;
            buttonUpdateSel.Enabled = true;
            buttonSaveNew.Enabled = false;
            buttonSaveSel.Enabled = false;

        }

        private void buttonDeleteSel_Click(object sender, EventArgs e)
        {
            //upon trying to delete a selected record, set variables for the popup box
            string delmessage = "Are you sure you want to delete?";
            string delcaption = "Do you want to delete the record with ID" + Int32.Parse(dgvPersonal.SelectedCells[0].Value.ToString()) + "?";
           //create a message box with yes-no buttons
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
           //save the result
            DialogResult result;
            //show the box, with the buttons, caption and message. 
           result =  MessageBox.Show(delmessage, delcaption, buttons);
            //if the result is yes do the following code
            if (result == DialogResult.Yes)
            {
                //call the delete personal method, passing the id of the selected row
                DBConn.DeletePersonal(Int32.Parse(dgvPersonal.SelectedCells[0].Value.ToString()));
                //refresh the dgv
                dgvPersonal.DataSource =  DBConn.GetAllPersonal();
            }

        }
    }

}
