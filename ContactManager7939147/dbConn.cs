using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager7939147
{
    public class dbConn
    {
        //creating a string of the database connection details to use repeatedly
        private string connString = "Server=db212it.cgvico87j64y.us-east-1.rds.amazonaws.com;UserID=admin;Password=212itc0ventry;Database=harriscontactdb;";

        //creating a datatable with the function of get all personal, via the database
        public DataTable GetAllPersonal()
        {
            //using the connection string we made earlier to connect to a MySQL databse
            using (var conn = new MySqlConnection(connString))
            {
                //opening the connection
                conn.Open();
                //Creating a new datatable
                DataTable personalContactDT = new DataTable();
                //creating a new list within the table
                List<personalContact> personalContacts = new List<personalContact>();
                //setting up variables so we don't have to type out the whole string
                //using mysql commands + reading the command
                using (var cmd = new MySqlCommand("CALL selectAllPersonal();", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        //whilst the cmd is executed, add the results as a new personalContact using the following strings and getting the data from the database
                        personalContacts.Add(new personalContact
                        {
                            conID = reader.GetInt32(0),
                            conFName = reader.GetString(1),
                            conLName = reader.GetString(2),
                            conTel = reader.GetString(3),
                            conEmail = reader.GetString(4),
                            conAddr1 = reader.GetString(5),
                            conAddr2 = reader.GetString(6),
                            conCity = reader.GetString(7),
                            conPostcode = reader.GetString(8),
                            conHTel = reader.GetString(9)
                        });
                    }
                //add the columns to the datatable, with the following titles
                        personalContactDT.Columns.Add("Contact ID");
                        personalContactDT.Columns.Add("First Name");
                        personalContactDT.Columns.Add("Last Name");
                        personalContactDT.Columns.Add("Mobile Telephone");
                        personalContactDT.Columns.Add("E-Mail Address");
                        personalContactDT.Columns.Add("Address (Line 1)");
                        personalContactDT.Columns.Add("Address (Line 2)");
                        personalContactDT.Columns.Add("City");
                        personalContactDT.Columns.Add("Postcode");
                        personalContactDT.Columns.Add("Home Telephone");

                    //for each 'item' or 'record' in personalcontact, make a new row in the datable, and populate them with the desired data
                foreach (var item in personalContacts)
                {
                    var row = personalContactDT.NewRow();

                    row["Contact ID"] = item.conID;
                    row["First Name"] = item.conFName;
                    row["Last Name"] = item.conLName;
                    row["Mobile Telephone"] = item.conTel;
                    row["E-Mail Address"] = item.conEmail;
                    row["Address (Line 1)"] = item.conAddr1;
                    row["Address (Line 2)"] = item.conAddr2;
                    row["City"] = item.conCity;
                    row["Postcode"] = item.conPostcode;
                    row["Home Telephone"] = item.conHTel;

                    personalContactDT.Rows.Add(row);
                }
                //finally, return the datatable with all the data in it
                return personalContactDT;


            }
        }
        //create a method for inserting personal data, called InsertPersonal
        public async void InsertPersonal(personalContact personalContact)
        {
            //use the same connection string as before
            using (var conn = new MySqlConnection(connString))
            {
                //open the connection asynchronously
               await conn.OpenAsync();
                //use mysql commands 
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    //the command text is calling the preprepared statement we made on the database side
                    cmd.CommandText = "CALL insertPersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    //here, it's setting the values appropriately
                    cmd.Parameters.AddWithValue("p1", personalContact.conFName);
                    cmd.Parameters.AddWithValue("p2", personalContact.conLName);
                    cmd.Parameters.AddWithValue("p3", personalContact.conTel);
                    cmd.Parameters.AddWithValue("p4", personalContact.conEmail);
                    cmd.Parameters.AddWithValue("p5", personalContact.conAddr1);
                    cmd.Parameters.AddWithValue("p6", personalContact.conAddr2);
                    cmd.Parameters.AddWithValue("p7", personalContact.conCity);
                    cmd.Parameters.AddWithValue("p8", personalContact.conPostcode);
                    cmd.Parameters.AddWithValue("p9", personalContact.conHTel);
                    //execute the command asynchronously
                   await cmd.ExecuteNonQueryAsync();
                }
            }

        }

        //creating a method to update personal contacts
        public async void UpdatePersonal(personalContact personalContact)
        {
            //use the same connection string to connect to the same database
            using (var conn = new MySqlConnection(connString))
            {
                //open the connection asynchronously
                await conn.OpenAsync();
                //new mysql command, shorthand so we don't have to type it out each time
                using (var cmd = new MySqlCommand())
                {
                    //similair process as before, calling the prepared statement with values set appropriately
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updatePersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10);";
                    cmd.Parameters.AddWithValue("p1", personalContact.conID);
                    cmd.Parameters.AddWithValue("p2", personalContact.conFName);
                    cmd.Parameters.AddWithValue("p3", personalContact.conLName);
                    cmd.Parameters.AddWithValue("p4", personalContact.conTel);
                    cmd.Parameters.AddWithValue("p5", personalContact.conEmail);
                    cmd.Parameters.AddWithValue("p6", personalContact.conAddr1);
                    cmd.Parameters.AddWithValue("p7", personalContact.conAddr2);
                    cmd.Parameters.AddWithValue("p8", personalContact.conCity);
                    cmd.Parameters.AddWithValue("p9", personalContact.conPostcode);
                    cmd.Parameters.AddWithValue("p10", personalContact.conHTel);
                   await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        //setting the deletepersonal method
        public async void DeletePersonal(int id)
        {
            //using the database connection string
            using (var conn = new MySqlConnection(connString))
            {
                //open the connection asynchronously
                await conn.OpenAsync();
                //set the var cmd to avoid having to type out each time
                using (var cmd = new MySqlCommand())
                {
                    //calling the command, setting the values 
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deletePersonal(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    //executing the statement asynchronously
                    await cmd.ExecuteNonQueryAsync();
                }
            }
     
       }

        //creating the method for getallbusiness, similair to the getallpersonal
        public DataTable GetAllBusiness()
        {
            //using the connstring specfied earlier, creating a variable from it
            using (var conn = new MySqlConnection(connString))
            {
                //opening the connection
                conn.Open();
                //creating the datatable for the content
                DataTable businessContactDT = new DataTable();
                //creating the list for the contacts
                List<businessContact> businessContacts = new List<businessContact>();
                //setting variables to shorten code
                using (var cmd = new MySqlCommand("CALL selectAllBusiness();", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        //add new contacts with the data from the database
                        businessContacts.Add(new businessContact
                        {
                            conID = reader.GetInt32(0),
                            conFName = reader.GetString(1),
                            conLName = reader.GetString(2),
                            conTel = reader.GetString(3),
                            conEmail = reader.GetString(4),
                            conAddr1 = reader.GetString(5),
                            conAddr2 = reader.GetString(6),
                            conCity = reader.GetString(7),
                            conPostcode= reader.GetString(8),
                            conBTel = reader.GetString(9)
                        });
                    }
                //add column titles
                        businessContactDT.Columns.Add("Contact ID");
                        businessContactDT.Columns.Add("First Name");
                        businessContactDT.Columns.Add("Last Name");
                        businessContactDT.Columns.Add("Mobile Telephone");
                        businessContactDT.Columns.Add("E-Mail Address");
                        businessContactDT.Columns.Add("Address (Line 1)");
                        businessContactDT.Columns.Add("Address (Line 2)");
                        businessContactDT.Columns.Add("City");
                        businessContactDT.Columns.Add("Postcode");
                        businessContactDT.Columns.Add("Business Telephone");

                foreach (var item in businessContacts)
                {
                    //for each record, create a new row with the appropriate data
                    var row = businessContactDT.NewRow();

                    row["Contact ID"] = item.conID;
                    row["First Name"] = item.conFName;
                    row["Last Name"] = item.conLName;
                    row["Mobile Telephone"] = item.conTel;
                    row["E-Mail Address"] = item.conEmail;
                    row["Address (Line 1)"] = item.conAddr1;
                    row["Address (Line 2)"] = item.conAddr2;
                    row["City"] = item.conCity;
                    row["Postcode"] = item.conPostcode;
                    row["Business Telephone"] = item.conBTel;

                    businessContactDT.Rows.Add(row);
                }
                return businessContactDT;

             //finally return the new datatable
            }
        }

        //create the insertBusinessMethod relating to the businessContact
        public async void InsertBusiness(businessContact businessContact)
        {
            //using the database connection string
            using (var conn = new MySqlConnection(connString))
            {
                //open the connection asynchronously
                await conn.OpenAsync();
                //set the cmd variable to shorten code
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    //call the stored procedure in the database, with set values appropriately
                    cmd.CommandText = "CALL insertBusiness(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    cmd.Parameters.AddWithValue("p1", businessContact.conFName);
                    cmd.Parameters.AddWithValue("p2", businessContact.conLName);
                    cmd.Parameters.AddWithValue("p3", businessContact.conTel);
                    cmd.Parameters.AddWithValue("p4", businessContact.conEmail);
                    cmd.Parameters.AddWithValue("p5", businessContact.conAddr1);
                    cmd.Parameters.AddWithValue("p6", businessContact.conAddr2);
                    cmd.Parameters.AddWithValue("p7", businessContact.conCity);
                    cmd.Parameters.AddWithValue("p8", businessContact.conPostcode);
                    cmd.Parameters.AddWithValue("p9", businessContact.conBTel);
                    //execute it asyncohrnoushly
                    await cmd.ExecuteNonQueryAsync();
                }
            }

        }

        //set up async method updatebusiness relating to busniesscontact
        public async void UpdateBusiness(businessContact businessContact)
        {
            //setting up shorthand- variable for the connstring conenciton to shorten code
            using (var conn = new MySqlConnection(connString))
            {
                //opening the connection asynchronously
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    //calling the stored procedure, with the assigned parameters
                    cmd.CommandText = "CALL updateBusiness(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10);";
                    cmd.Parameters.AddWithValue("p1", businessContact.conID);
                    cmd.Parameters.AddWithValue("p2", businessContact.conFName);
                    cmd.Parameters.AddWithValue("p3", businessContact.conLName);
                    cmd.Parameters.AddWithValue("p4", businessContact.conTel);
                    cmd.Parameters.AddWithValue("p5", businessContact.conEmail);
                    cmd.Parameters.AddWithValue("p6", businessContact.conAddr1);
                    cmd.Parameters.AddWithValue("p7", businessContact.conAddr2);
                    cmd.Parameters.AddWithValue("p8", businessContact.conCity);
                    cmd.Parameters.AddWithValue("p9", businessContact.conPostcode);
                    cmd.Parameters.AddWithValue("p10", businessContact.conBTel);
                    //executing asynchronously
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        //creating async class delete business, being passed one parameter
        public async void DeleteBusiness(int id)
        {
            //shortening code via variable creation
            using (var conn = new MySqlConnection(connString))
            {
                //opening connection asynchrnsouly
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    //calling the stored procedure from the database, passing it parameter
                    cmd.CommandText = "CALL deleteBusiness(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    //executing asynchrnously
                   await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }

}