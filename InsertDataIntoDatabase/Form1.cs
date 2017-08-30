using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace InsertDataIntoDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\sriharsha21\Documents\Visual Studio 2010\Projects\InsertDataIntoDatabase\InsertDataIntoDatabase\UserDetails.mdf;Integrated Security=True;User Instance=True");
            string cmdText = @"INSERT INTO UserDetails
                       (id, name) 
                       VALUES (@id,@name)";
            SqlCommand cmd = new SqlCommand(cmdText, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);

            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();

            if(i!=0){
                MessageBox.Show(e + "Data Saved");
            }

        }

        public static void main(string[] args)
        {

            Application.Run(new Form1());

        } 
    }
}
