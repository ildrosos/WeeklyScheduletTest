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
using System.Threading;

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
            
            
            DialogResult StartingDialog = MessageBox.Show("Θέλετε να δημιουργήσετε νέο πρόγραμμα;", "Νέο μηναίο πρόγραμμα", MessageBoxButtons.YesNo);
            if (StartingDialog == DialogResult.Yes)
            {
               // string deleteCommand = "DELETE * FROM contacts";
                //ConnectAndExecute(deleteCommand);
                string stringOfNumberOfEmployees = Interaction.InputBox("Πόσους υπάλληλους έχετε", "Υπάλληλοι", "Αριθμός υπαλλήλων");
                int NumberOfEmployees;
                NumberOfEmployees = Convert.ToInt32(stringOfNumberOfEmployees);
                NumberOfEmployees = int.Parse(stringOfNumberOfEmployees);
                string[] Person = new string[NumberOfEmployees];

                

                for (int i = 0; i < NumberOfEmployees; i++) //Get the employees names
                {
                    Person[i] = Interaction.InputBox("Εισάγετε το όνομα υπάλληλου", "Όνομα υπάλληλου", "Όνομα");


                }//stores the employees names in a string array

                DialogResult Shifts = MessageBox.Show("Παρακαλώ εισάγετε τις βάρδιες όλων των υπαλλήλων την 1η και 2η ημέρα", "Εισάγετε Βάρδυες", MessageBoxButtons.OKCancel);
             
                string shift;
                if (Shifts == DialogResult.OK)
                {

                    for (int j = 0; j < NumberOfEmployees; j++)
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
                    
                    for (int j = 0; j < NumberOfEmployees; j++)
                    {
                        string ypallhlos = Person[j];
                        shift = Interaction.InputBox("ΤΙ ΒΑΡΔΙΑ ΕΧΕΙ ΤΗΝ ΔΕΥΤΕΡΗ ΜΕΡΑ ΑΥΤΟΣ Ο ΥΠΑΛΛΗΛΟΣ ;  ", ypallhlos, "");

                        programma programma1 = new programma();
                        programma1.day = 2;
                        programma1.name = ypallhlos;
                        programma1.shift = shift;

                        string command = "INSERT INTO [contacts]([Day],[Shift],[Person]) VALUES ('" + programma1.GetDay() + "','" + programma1.GetShift() + "','" + programma1.GetName() + "');";
                        ConnectAndExecute(command);


                    }

                    progressBar2.Minimum = 0;
                    progressBar2.Maximum = 100;
                    //progressBar2.MarqueeAnimationSpeed = 1;
                    for (int k = 0; k < NumberOfEmployees; k++)
                    {
                       
                        progressBar2.Value = (k+1)*100/NumberOfEmployees;
                        label1.Text = (k*10) + " %";
                        Thread.Sleep(100);
                        this.Refresh();

                        string ypallhlos = Person[k];
                        string[] bardia2h = new string[1];
                        string[] bardia1h = new string[1];
                        string prwi = "ΠΡΩΙ", apogeuma = "ΑΠΟΓΕΥΜΑ", endiamesos = "ΕΝΔΙΑΜΕΣΟΣ", brady = "ΒΡΑΔΥ", repo = "ΡΕΠΟ";
                        //int day1 = 1; int day2 = 2;
                        string query2 = "SELECT Shift from contacts where Day =1 and Person='" + ypallhlos + "'"; //bres ti bardia tou upallhlou tin deuteri mera
                        
                        bardia2h=ConnectAndRead(query2);
                        string prwti = bardia2h[0];

                        string query1 = "SELECT Shift from contacts where Day =2 and Person='" + ypallhlos + "'"; //bres ti bardia tou upallhloy tin prwti mera

                        bardia1h = ConnectAndRead(query1);
                        string deuterh = bardia1h[0];
                       
                        if (deuterh.Equals(prwi, StringComparison.InvariantCultureIgnoreCase)) 
                        {
                          
                            if (prwti.Equals(prwi, StringComparison.InvariantCultureIgnoreCase))
                                {
                 
                                FillProgramHTANPRWI_PRWI(3, 4, ypallhlos);
                               
                                }//prwi-prwi
                            else if(prwti.Equals(repo,StringComparison.InvariantCultureIgnoreCase))
                                {
                                FillProgramHTANREPO_PRWI(3,ypallhlos);

                                }//repo-prwi
                        
                        
                        
                        }

                        if (deuterh.Equals(apogeuma, StringComparison.InvariantCultureIgnoreCase))
                        {
                            if (prwti.Equals(prwi, StringComparison.InvariantCultureIgnoreCase))
                            {

                                FillProgramHTANPRWI_APOGEUMA(3, ypallhlos);
                            }//prwi-apogeuma
                            else if(prwti.Equals(apogeuma,StringComparison.InvariantCultureIgnoreCase))
                            {
                                FillProgramHTANAPOGEUMA_APOGEUMA(3, ypallhlos);
                            }
                        }//apogeuma-apogeuma

                        if(deuterh.Equals(endiamesos,StringComparison.InvariantCultureIgnoreCase))
                        {
                            if (prwti.Equals(apogeuma, StringComparison.InvariantCultureIgnoreCase)) 
                            {
                                FillProgramHTANAPOGEUMA_ENDIAMESOS(3, ypallhlos);
                            }

                        }//apogeuma-endiamesos
                       
                        if(deuterh.Equals(brady,StringComparison.InvariantCultureIgnoreCase))
                        {
                            if(prwti.Equals(endiamesos,StringComparison.InvariantCultureIgnoreCase))
                            {
                                FillProgramHTANENDIAMESOS_BRADY(3, ypallhlos);
                            }
                        }//endiamenos-brady

                        if(deuterh.Equals(repo,StringComparison.InvariantCultureIgnoreCase))
                        {
                            if(prwti.Equals(brady,StringComparison.InvariantCultureIgnoreCase))
                            {
                                FillProgramHTANBRADY_REPO(3, ypallhlos);

                            }//brady-repo
                            else if(prwti.Equals(repo,StringComparison.InvariantCultureIgnoreCase))
                            {
                                FillProgramHTANREPO_REPO(3, ypallhlos);

                            }//repo-repo
                        }
                      

                    }
                    progressBar2.Value = 0; progressBar2.ResetText(); label1.Text = "0 %";
                    MessageBox.Show("TO ΠΡΟΓΡΑΜΜΑ ΕΙΝΑΙ ΕΤΟΙΜΟ");
                 //   this.contactsTableAdapter.Fill(this.DataSet1.contacts);
                 //   this.reportViewer1.RefreshReport();
                }

                


            }
            else if (StartingDialog == DialogResult.No) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.DataSet1.contacts);

            this.reportViewer1.RefreshReport();
            
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
  
                     
        public string[] ConnectAndRead(string DBCommand)
        {
            string[] bardia=new string[1];
           try
           { 
               connection.Open();
               OleDbCommand command = new OleDbCommand(DBCommand,connection);
               OleDbDataReader reader = command.ExecuteReader();
               reader.Read();
               int i=0;
                  
                         bardia[i] = reader.GetString(0);
                         i++;
               
               reader.Close();
               connection.Close();
           }
             catch (Exception ex)
           {
               MessageBox.Show("Error" + ex);
           }

           return bardia;
        }


        public void InsertBardia(int day,int maxDay,int bima,string bardia,string ypallhlos) {

            for (int i = day; i <= maxDay; i = i + bima)
            {
                string InsertBardia="INSERT INTO [contacts]([Day],[Shift],[Person]) VALUES ('" + i + "','" + bardia + "','" + ypallhlos + "');";
                ConnectAndExecute(InsertBardia);
            }
        
        }
      
         
      
        
        /****************************************************************************************************/
        /********************   EDW GINETAI H EISAGWGH TWN BARDIWN STH BASH *********************************/

        public void FillProgramHTANPRWI_PRWI(int prwti,int deuteri,string ypallhlos)
        {
            string prwi = "ΠΡΩΙ", apogeuma = "ΑΠΟΓΕΥΜΑ", endiamesos = "ΕΝΔΙΑΜΕΣΟΣ", brady = "ΒΡΑΔΥ", repo = "ΡΕΠΟ";

            InsertBardia(prwti, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(deuteri, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(5, 31, 8, endiamesos, ypallhlos);//endiamesos
            InsertBardia(6, 31, 8, brady, ypallhlos);//brady
            InsertBardia(7, 31, 8, repo, ypallhlos);//repo
            InsertBardia(8, 31, 8, repo, ypallhlos);//repo
            InsertBardia(9, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(10, 31, 8, prwi, ypallhlos);//prwi


        }

        public void FillProgramHTANREPO_PRWI(int prwti, string ypallhlos)
        {
            string prwi = "ΠΡΩΙ", apogeuma = "ΑΠΟΓΕΥΜΑ", endiamesos = "ΕΝΔΙΑΜΕΣΟΣ", brady = "ΒΡΑΔΥ", repo = "ΡΕΠΟ";


            InsertBardia(prwti, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(4, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(5, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(6, 31, 8, endiamesos, ypallhlos);//endiamesos
            InsertBardia(7, 31, 8, brady, ypallhlos);//brady
            InsertBardia(8, 31, 8, repo, ypallhlos);//repo
            InsertBardia(9, 31, 8, repo, ypallhlos);//repo
            InsertBardia(10, 31, 8, prwi, ypallhlos);//prwi


        }

        public void FillProgramHTANPRWI_APOGEUMA(int prwti, string ypallhlos)
        {

            string prwi = "ΠΡΩΙ", apogeuma = "ΑΠΟΓΕΥΜΑ", endiamesos = "ΕΝΔΙΑΜΕΣΟΣ", brady = "ΒΡΑΔΥ", repo = "ΡΕΠΟ";

            InsertBardia(prwti, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(4, 31, 8, endiamesos, ypallhlos);//endiamesos
            InsertBardia(5, 31, 8, brady, ypallhlos);//brady
            InsertBardia(6, 31, 8, repo, ypallhlos);//repo
            InsertBardia(7, 31, 8, repo, ypallhlos);//repo
            InsertBardia(8, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(9, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(10, 31, 8, apogeuma, ypallhlos);//apogeuma


        }

        public void FillProgramHTANAPOGEUMA_APOGEUMA(int prwti, string ypallhlos)
        {

            string prwi = "ΠΡΩΙ", apogeuma = "ΑΠΟΓΕΥΜΑ", endiamesos = "ΕΝΔΙΑΜΕΣΟΣ", brady = "ΒΡΑΔΥ", repo = "ΡΕΠΟ";

            InsertBardia(prwti, 31, 8, endiamesos, ypallhlos);//endiamesos
            InsertBardia(4, 31, 8, brady, ypallhlos);//brady
            InsertBardia(5, 31, 8, repo, ypallhlos);//repo
            InsertBardia(6, 31, 8, repo, ypallhlos);//repo
            InsertBardia(7, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(8, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(9, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(10, 31, 8, apogeuma, ypallhlos);//apogeuma


        }

        public void FillProgramHTANAPOGEUMA_ENDIAMESOS(int prwti, string ypallhlos)
        {

            string prwi = "ΠΡΩΙ", apogeuma = "ΑΠΟΓΕΥΜΑ", endiamesos = "ΕΝΔΙΑΜΕΣΟΣ", brady = "ΒΡΑΔΥ", repo = "ΡΕΠΟ";

            InsertBardia(prwti, 31, 8, brady, ypallhlos);//brady
            InsertBardia(4, 31, 8, repo, ypallhlos);//repo
            InsertBardia(5, 31, 8, repo, ypallhlos);//repo
            InsertBardia(6, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(7, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(8, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(9, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(10, 31, 8, endiamesos, ypallhlos);//endiamesos



        }
   
        public void FillProgramHTANENDIAMESOS_BRADY(int prwti,string ypallhlos)
        {
            string prwi = "ΠΡΩΙ", apogeuma = "ΑΠΟΓΕΥΜΑ", endiamesos = "ΕΝΔΙΑΜΕΣΟΣ", brady = "ΒΡΑΔΥ", repo = "ΡΕΠΟ";

            InsertBardia(prwti, 31, 8, repo, ypallhlos);//repo
            InsertBardia(4, 31, 8, repo, ypallhlos);//repo
            InsertBardia(5, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(6, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(7, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(8, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(9, 31, 8, endiamesos, ypallhlos);//endiamesos
            InsertBardia(10, 31, 8, brady, ypallhlos);//brady



        }

        public void  FillProgramHTANBRADY_REPO(int prwti, string ypallhlos)
        {
            string prwi = "ΠΡΩΙ", apogeuma = "ΑΠΟΓΕΥΜΑ", endiamesos = "ΕΝΔΙΑΜΕΣΟΣ", brady = "ΒΡΑΔΥ", repo = "ΡΕΠΟ";

            InsertBardia(prwti, 31, 8, repo, ypallhlos);//repo
            InsertBardia(4, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(5, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(6, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(7, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(8, 31, 8, endiamesos, ypallhlos);//endiamesos
            InsertBardia(9, 31, 8, brady, ypallhlos);//brady
            InsertBardia(10, 31, 8, repo, ypallhlos);//repo


        }

        public void FillProgramHTANREPO_REPO(int prwti,string ypallhlos)
        {
            string prwi = "ΠΡΩΙ", apogeuma = "ΑΠΟΓΕΥΜΑ", endiamesos = "ΕΝΔΙΑΜΕΣΟΣ", brady = "ΒΡΑΔΥ", repo = "ΡΕΠΟ";

            InsertBardia(prwti, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(4, 31, 8, prwi, ypallhlos);//prwi
            InsertBardia(5, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(6, 31, 8, apogeuma, ypallhlos);//apogeuma
            InsertBardia(7, 31, 8, endiamesos, ypallhlos);//endiamesos
            InsertBardia(8, 31, 8, brady, ypallhlos);//brady
            InsertBardia(9, 31, 8, repo, ypallhlos);//repo
            InsertBardia(10, 31, 8, repo, ypallhlos);//repo




        }





      


                   
        /****************************************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            string command = "DELETE * FROM contacts";
            ConnectAndExecute(command);
            //this.contactsTableAdapter.Fill(this.DataSet1.contacts);
            MessageBox.Show("Το πρόγραμμα διαγράφηκε επιτυχώς");
            
            
        }

      

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.contactsTableAdapter.Fill(this.DataSet1.contacts);

            this.reportViewer1.RefreshReport();
          
        }

        /*
       

        private void reportViewer1_Load(object sender, EventArgs e)
        {
             
        }*/

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }


    }
    
}
