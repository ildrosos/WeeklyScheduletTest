using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.OleDb;

namespace ComputerMindTest
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ηλίας\Desktop\TESTS_PWCT\visual studio\ComputerMindTest\ComputerMindTest\contacts.accdb;Persist Security Info=False";
           
        }
        
        private void NewMonthSchedule_Click(object sender, EventArgs e)
        {
            
            
            DialogResult StartingDialog = MessageBox.Show("So You wanna create a new month Schedule?", "New month schedule?", MessageBoxButtons.YesNo);
            if (StartingDialog == DialogResult.Yes)
            {
                string[] Person = new string[6];


                for (int i = 0; i < 6; i++) //Get the employees names
                {
                    Person[i] = Interaction.InputBox("Give me the Name of the Employee No", "Employee Name", "Name");

                }//stores the employees names in a string array

                DialogResult Shifts = MessageBox.Show("Ok tell me the shifts of the employees the first day of the week", "1st day shifts", MessageBoxButtons.OKCancel);
             
                string shift;
                if (Shifts == DialogResult.OK)
                {

                    for (int j = 0; j < 6; j++)
                    {
                        string ypallhlos = Person[j];
                        shift = Interaction.InputBox("ΤΙ ΒΑΡΔΙΑ ΕΧΕΙ ΤΗΝ ΠΡΩΤΗ ΜΕΡΑ ΑΥΤΟΣ Ο ΥΠΑΛΛΗΛΟΣ ; ", ypallhlos, "");

                        programma programma1 = new programma();
                        programma1.day = 1;
                        programma1.name = ypallhlos;
                        programma1.shift = shift;

                        string command = "INSERT INTO [contacts]([Day],[Shift],[Person]) VALUES ('" + programma1.GetDay() + "','" + programma1.GetShift() + "','" + programma1.GetName() + "');";
                        ConnectAndExecute(command);
                       

                    }
                    
                    for (int j = 0; j < 6; j++)
                    {
                        string ypallhlos = Person[j];
                        shift = Interaction.InputBox("ΤΙ ΒΑΡΔΙΑ ΕΧΕΙ ΤΗΝ ΔΕΥΤΕΡΗ ΜΕΡΑ ΑΥΤΟΣ Ο ΥΠΑΛΛΗΛΟΣ ;  ", ypallhlos, "");

                        programma programma1 = new programma();
                        programma1.day = 1;
                        programma1.name = ypallhlos;
                        programma1.shift = shift;

                        string command = "INSERT INTO [contacts]([Day],[Shift],[Person]) VALUES ('" + programma1.GetDay() + "','" + programma1.GetShift() + "','" + programma1.GetName() + "');";
                        ConnectAndExecute(command);


                    }


                    for (int k = 0; k < 6; k++)
                    {
                        string ypallhlos = Person[k];

                        string query = "SELECT Shift from contacts where Day ='2' and Person='" + ypallhlos + "'";
                       
                        try { 
                        OleDbCommand command = new OleDbCommand(query, connection);
                        connection.Open();
                        OleDbDataReader reader = command.ExecuteReader();
                        while(reader.Read())
                        {
                            string bardia = reader.GetString(0);

                            if (bardia == "ΠΡΩΙ") {

                                string query2 = "SELECT Shift from contacts where Day='1' and Person'" + ypallhlos + "'";
                                OleDbDataReader reader2= command.ExecuteReader();
                                while (reader2.Read())
                                {
                                    string bardia1hmera = reader.GetString(0);
                                    if (bardia1hmera == "ΠΡΩΙ")
                                    {
                                        int nextday = 3;string bardiaepommera="ΑΠΟΓΕΥΜΑ"; string onomaypallhloy=ypallhlos;
                                        string query3 = "INSERT INTO [contacts]([Day],[Shift],[Person]) VALUES ('" + nextday + "','" + bardiaepommera + "','" + onomaypallhloy + "');";
                                    }

                                }
                            }





                        }
                        reader.Close();
                        connection.Close();
                             }
                        catch(Exception ex)
                             {
                            MessageBox.Show("error" + ex);
                             }

                    }

                }

                


            }
            else if (StartingDialog == DialogResult.No) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'contactsDataSet3.contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter1.Fill(this.contactsDataSet3.contacts);
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public class programma
        {
            public int day;
            public string name;
            public string shift;

            public int GetDay()
            {
                return day;
            }

            public string GetName()
            {

                return name;
            }

            public string GetShift()
            {
                return shift;
            }


        }

        public void ConnectAndExecute(string DBCommand)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = DBCommand;
                command.ExecuteNonQuery();
                connection.Close();
            }
              catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "DELETE * FROM contacts";
            ConnectAndExecute(command);
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.contactsTableAdapter1.Fill(this.contactsDataSet3.contacts);
          
        }


    }
    
}
