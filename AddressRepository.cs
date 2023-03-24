﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AddressBookingSystem
{
    public class AddressRepository
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Addressbookservies;Integrated Security=True";
        public static SqlConnection sqlConnection = null;
        public static Contact model = new Contact();
        public List<PersonContactsThread> contactsDetailsListThread = new List<PersonContactsThread>();

        public static void GetAllEntriesFromDB()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                string query = "select * from AddressBook";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //Console.WriteLine("Connections is established successfully.....");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        model.firstName = reader["firstName"] == DBNull.Value ? default : reader["firstName"].ToString();
                        model.lastName = reader["lastName"] == DBNull.Value ? default : reader["lastName"].ToString();
                        model.address = reader["address"] == DBNull.Value ? default : reader["address"].ToString();
                        model.city = reader["city"] == DBNull.Value ? default : reader["city"].ToString();
                        model.state = reader["state"] == DBNull.Value ? default : reader["state"].ToString();
                        model.zipcode = Convert.ToInt32(reader["zipcode"] == DBNull.Value ? default : reader["zipcode"]);
                        model.phoneNumber = Convert.ToInt64(reader["phoneNumber"] == DBNull.Value ? default : reader["phoneNumber"]);
                        model.email = reader["email"] == DBNull.Value ? default : reader["email"].ToString();

                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", model.firstName, model.lastName, model.address, model.city, model.state, model.zipcode, model.phoneNumber, model.email);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        /// <summary>
        /// UC17-Update contacts 
        /// </summary>
        /// <param name="model"></param>
        public static void UpdateContacts(Contact model)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("dbo.spUpdateInformations", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                command.Parameters.AddWithValue("@firstName", model.firstName);
                command.Parameters.AddWithValue("@City", model.city);
                int num = command.ExecuteNonQuery();
                if (num != 0)
                    Console.WriteLine("City update Successfully......");
                else
                    Console.WriteLine("Something went Wrong");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        /// <summary>
        /// UC18-Ability to contacts at a particular date
        /// </summary>
        /// <param name="model"></param>
        public static void RetrieveParticularDate(Contact model)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                string query = "select * from AddressBook where StartDate between cast('2019-01-01' as date ) AND GETDATE();";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        model.firstName = reader["firstName"] == DBNull.Value ? default : reader["firstName"].ToString();
                        model.lastName = reader["lastName"] == DBNull.Value ? default : reader["lastName"].ToString();
                        model.address = reader["address"] == DBNull.Value ? default : reader["address"].ToString();
                        model.city = reader["city"] == DBNull.Value ? default : reader["city"].ToString();
                        model.state = reader["state"] == DBNull.Value ? default : reader["state"].ToString();
                        model.zipcode = Convert.ToInt32(reader["zipcode"] == DBNull.Value ? default : reader["zipcode"]);
                        model.phoneNumber = Convert.ToInt64(reader["phoneNumber"] == DBNull.Value ? default : reader["phoneNumber"]);
                        model.email = reader["email"] == DBNull.Value ? default : reader["email"].ToString();
                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", model.firstName, model.lastName, model.address, model.city, model.state, model.zipcode, model.phoneNumber, model.email);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        /// <summary>
        /// UC18-Ability to contacts at a particular date
        /// </summary>
        /// <param name="model"></param>
        public static void RetrieveParticularDate(Contact model)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                string query = "select * from AddressBook where StartDate between cast('2019-01-01' as date ) AND GETDATE();";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        model.firstName = reader["firstName"] == DBNull.Value ? default : reader["firstName"].ToString();
                        model.lastName = reader["lastName"] == DBNull.Value ? default : reader["lastName"].ToString();
                        model.address = reader["address"] == DBNull.Value ? default : reader["address"].ToString();
                        model.city = reader["city"] == DBNull.Value ? default : reader["city"].ToString();
                        model.state = reader["state"] == DBNull.Value ? default : reader["state"].ToString();
                        model.zipcode = Convert.ToInt32(reader["zipcode"] == DBNull.Value ? default : reader["zipcode"]);
                        model.phoneNumber = Convert.ToInt64(reader["phoneNumber"] == DBNull.Value ? default : reader["phoneNumber"]);
                        model.email = reader["email"] == DBNull.Value ? default : reader["email"].ToString();
                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", model.firstName, model.lastName, model.address, model.city, model.state, model.zipcode, model.phoneNumber, model.email);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        /// <summary>
        /// UC19-Retrieve contact by city or state
        /// </summary>
        /// <param name="model"></param>
        public static void RetrieveByCityOrState(Contact model)
        {
            Console.WriteLine("1.RetrieveByCity\n" +
                    "2.RetrieveByState\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    try
                    {
                        int count = 0;
                        sqlConnection = new SqlConnection(connectionString);
                        string query = "select * from AddressBook  where City='Ghaziabad' ";
                        SqlCommand cmd = new SqlCommand(query, sqlConnection);
                        sqlConnection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                model.firstName = reader["firstName"] == DBNull.Value ? default : reader["firstName"].ToString();
                                model.lastName = reader["lastName"] == DBNull.Value ? default : reader["lastName"].ToString();
                                model.address = reader["address"] == DBNull.Value ? default : reader["address"].ToString();
                                model.city = reader["city"] == DBNull.Value ? default : reader["city"].ToString();
                                model.state = reader["state"] == DBNull.Value ? default : reader["state"].ToString();
                                model.zipcode = Convert.ToInt32(reader["zipcode"] == DBNull.Value ? default : reader["zipcode"]);
                                model.phoneNumber = Convert.ToInt64(reader["phoneNumber"] == DBNull.Value ? default : reader["phoneNumber"]);
                                model.email = reader["email"] == DBNull.Value ? default : reader["email"].ToString();
                                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", model.firstName, model.lastName, model.address, model.city, model.state, model.zipcode, model.phoneNumber, model.email);
                                count++;
                            }
                            Console.WriteLine("\nNumber of contacts present in \"{0}\" city => {1}", model.city, count);
                            Console.Write("\nPress any key to continue...... ");
                            Console.ReadLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                    Console.Clear();
                    break;
                case 2:
                    try
                    {
                        int count = 0;
                        sqlConnection = new SqlConnection(connectionString);
                        string query = "select * from AddressBook  where State='UP' ";
                        SqlCommand cmd = new SqlCommand(query, sqlConnection);
                        sqlConnection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                model.firstName = reader["firstName"] == DBNull.Value ? default : reader["firstName"].ToString();
                                model.lastName = reader["lastName"] == DBNull.Value ? default : reader["lastName"].ToString();
                                model.address = reader["address"] == DBNull.Value ? default : reader["address"].ToString();
                                model.city = reader["city"] == DBNull.Value ? default : reader["city"].ToString();
                                model.state = reader["state"] == DBNull.Value ? default : reader["state"].ToString();
                                model.zipcode = Convert.ToInt32(reader["zipcode"] == DBNull.Value ? default : reader["zipcode"]);
                                model.phoneNumber = Convert.ToInt64(reader["phoneNumber"] == DBNull.Value ? default : reader["phoneNumber"]);
                                model.email = reader["email"] == DBNull.Value ? default : reader["email"].ToString();
                                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", model.firstName, model.lastName, model.address, model.city, model.state, model.zipcode, model.phoneNumber, model.email);
                                count++;
                            }
                            Console.WriteLine("\nNumber of contacts present in \"{0}\" State => {1}", model.state, count);
                            Console.Write("\nPress any key to continue...... ");
                            Console.ReadLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Select only give options");
                    break;
            }
        }
        /// <summary>
        /// UC20- Add new Contacts in AddressBook
        /// </summary>
        /// <param name="model"></param>
        public static void AddNewContacts(Contact model)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("dbo.spAddNewPerson", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                command.Parameters.AddWithValue("@firstName", model.firstName);
                command.Parameters.AddWithValue("@lastName", model.lastName);
                command.Parameters.AddWithValue("@address", model.address);
                command.Parameters.AddWithValue("@city", model.city);
                command.Parameters.AddWithValue("@state", model.state);
                command.Parameters.AddWithValue("@zipcode", model.zipcode);
                command.Parameters.AddWithValue("@phoneNumber", model.phoneNumber);
                command.Parameters.AddWithValue("@email", model.email);
                int num = command.ExecuteNonQuery();
                if (num != 0)
                    Console.WriteLine("Contacts Added Successfully");
                else
                    Console.WriteLine("Something went Wrong");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
