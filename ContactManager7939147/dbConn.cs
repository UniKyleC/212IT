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
        private string connString = "Server=db212it.cgvico87j64y.us-east-1.rds.amazonaws.com;UserID=admin;Password=212itc0ventry;Database=harriscontactdb;";

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
                    cmd.Parameters.AddWithValue("p1", personalContact.conFName);
                    cmd.Parameters.AddWithValue("p2", personalContact.conLName);
                    cmd.Parameters.AddWithValue("p3", personalContact.conTel);
                    cmd.Parameters.AddWithValue("p4", personalContact.conEmail);
                    cmd.Parameters.AddWithValue("p5", personalContact.conAddr1);
                    cmd.Parameters.AddWithValue("p6", personalContact.conAddr2);
                    cmd.Parameters.AddWithValue("p7", personalContact.conCity);
                    cmd.Parameters.AddWithValue("p8", personalContact.conPostcode);
                    cmd.Parameters.AddWithValue("p9", personalContact.conHTel);
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
                    cmd.Parameters.AddWithValue("p1", businessContact.conFName);
                    cmd.Parameters.AddWithValue("p2", businessContact.conLName);
                    cmd.Parameters.AddWithValue("p3", businessContact.conTel);
                    cmd.Parameters.AddWithValue("p4", businessContact.conEmail);
                    cmd.Parameters.AddWithValue("p5", businessContact.conAddr1);
                    cmd.Parameters.AddWithValue("p6", businessContact.conAddr2);
                    cmd.Parameters.AddWithValue("p7", businessContact.conCity);
                    cmd.Parameters.AddWithValue("p8", businessContact.conPostcode);
                    cmd.Parameters.AddWithValue("p9", businessContact.conBTel);
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