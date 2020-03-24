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
        private string connString = "Server=db212it.cgvico87j64y.us-east-1.rds.amazonaws.com;User ID=admin;Password=212itc0ventry;Database=harriscontactdb;";

        public DataTable GetAllPersonal()
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                DataTable personalContactDT = new DataTable();
                List<personalContact> personalContacts = new List<personalContact>();
                using (var cmd = new MySqlCommand("CALL selectAllPersonal();", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        personalContacts.Add(new personalContact
                        {
                            ContactID = reader.GetInt32(0),
                            ContactFName = reader.GetString(1),
                            ContactLName = reader.GetString(2),
                            ContactTel = reader.GetString(3),
                            ContactEmail = reader.GetString(4),
                            ContactAddr1 = reader.GetString(5),
                            ContactAddr2 = reader.GetString(6),
                            ContactCity = reader.GetString(7),
                            ContactPostcode = reader.GetString(8),
                            ContactHomeTel = reader.GetString(9)
                        });
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

                    }
                foreach (var item in personalContacts)
                {
                    var row = personalContactDT.NewRow();

                    row["Contact ID"] = item.ContactID;
                    row["First Name"] = item.ContactFName;
                    row["Last Name"] = item.ContactLName;
                    row["Mobile Telephone"] = item.ContactTel;
                    row["E-Mail Address"] = item.ContactEmail;
                    row["Address (Line 1)"] = item.ContactAddr1;
                    row["Address (Line 2)"] = item.ContactAddr2;
                    row["City"] = item.ContactCity;
                    row["Postcode"] = item.ContactPostcode;
                    row["Home Telephone"] = item.ContactHomeTel;

                    personalContactDT.Rows.Add(row);
                }
                return personalContactDT;


            }
        }
        public void InsertPersonal(personalContact personalContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertPersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactFName);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactLName);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactTel);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p9", personalContact.ContactHomeTel);
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void UpdatePersonal(personalContact personalContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updatePersonal((@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10);";
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactFName);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactLName);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactTel);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p9", personalContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p10", personalContact.ContactHomeTel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletePersonal(int id)
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deletePersonal(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    cmd.ExecuteNonQuery();
                }
            }
     
       }
        public DataTable GetAllBusiness()
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                DataTable businessContactDT = new DataTable();
                List<businessContact> businessContacts = new List<businessContact>();
                using (var cmd = new MySqlCommand("CALL selectAllBusiness();", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        businessContacts.Add(new businessContact
                        {
                            ContactID = reader.GetInt32(0),
                            ContactFName = reader.GetString(1),
                            ContactLName = reader.GetString(2),
                            ContactTel = reader.GetString(3),
                            ContactEmail = reader.GetString(4),
                            ContactAddr1 = reader.GetString(5),
                            ContactAddr2 = reader.GetString(6),
                            ContactCity = reader.GetString(7),
                            ContactPostcode = reader.GetString(8),
                            ContactBusinessTel = reader.GetString(9)
                        });
                        businessContactDT.Columns.Add("Contact ID");
                        businessContactDT.Columns.Add("First Name");
                        businessContactDT.Columns.Add("Last Name");
                        businessContactDT.Columns.Add("Mobile Telephone");
                        businessContactDT.Columns.Add("E-Mail Address");
                        businessContactDT.Columns.Add("Address (Line 1)");
                        businessContactDT.Columns.Add("Address (Line 2)");
                        businessContactDT.Columns.Add("City");
                        businessContactDT.Columns.Add("Postcode");
                        businessContactDT.Columns.Add("Home Telephone");

                    }
                foreach (var item in businessContacts)
                {
                    var row = businessContactDT.NewRow();

                    row["Contact ID"] = item.ContactID;
                    row["First Name"] = item.ContactFName;
                    row["Last Name"] = item.ContactLName;
                    row["Mobile Telephone"] = item.ContactTel;
                    row["E-Mail Address"] = item.ContactEmail;
                    row["Address (Line 1)"] = item.ContactAddr1;
                    row["Address (Line 2)"] = item.ContactAddr2;
                    row["City"] = item.ContactCity;
                    row["Postcode"] = item.ContactPostcode;
                    row["Home Telephone"] = item.ContactBusinessTel;

                    businessContactDT.Rows.Add(row);
                }
                return businessContactDT;


            }
        }
        public void InsertBusiness(businessContact businessContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.CommandText = "CALL insertBusiness(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactFName);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactLName);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactTel);
                    cmd.Parameters.AddWithValue("p4", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p5", businessContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p9", businessContact.ContactBusinessTel);
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void UpdateBusiness(businessContact businessContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updateBusiness((@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10);";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactFName);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactLName);
                    cmd.Parameters.AddWithValue("p4", businessContact.ContactTel);
                    cmd.Parameters.AddWithValue("p5", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p9", businessContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p10", businessContact.ContactBusinessTel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteBusiness(int id)
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deleteBusiness(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}