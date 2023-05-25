using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-IKTSBR8\\SQLEXPRESS;Initial Catalog=healthcare;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using our system");
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelconter4.ForeColor = System.Drawing.Color.Red;
            labelconter2.ForeColor = System.Drawing.Color.Black;
            labelconter3.ForeColor = System.Drawing.Color.Black;
            labelconter1.ForeColor = System.Drawing.Color.Black;


        }

        private void btnaddpt_Click(object sender, EventArgs e)
        {
            labelconter1.ForeColor = System.Drawing.Color.Red;
            labelconter2.ForeColor = System.Drawing.Color.Black;
            labelconter3.ForeColor = System.Drawing.Color.Black;

            labelconter4.ForeColor = System.Drawing.Color.Black;
            panel2.Visible = true;
        }

        private void btnAddstaf_Click(object sender, EventArgs e)
        {
            labelconter2.ForeColor = System.Drawing.Color.Red;
            labelconter1.ForeColor = System.Drawing.Color.Black;
            labelconter3.ForeColor = System.Drawing.Color.Black;
            labelconter4.ForeColor = System.Drawing.Color.Black;


        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            labelconter3.ForeColor = System.Drawing.Color.Red;
            labelconter2.ForeColor = System.Drawing.Color.Black;
            labelconter1.ForeColor = System.Drawing.Color.Black;
            labelconter4.ForeColor = System.Drawing.Color.Black;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textName.Text;
                string address = textAddress.Text;
                Int64 contact = Convert.ToInt64(textContactNumber.Text);
                int age = Convert.ToInt32(textAge.Text);
                string gender = comboGender.Text;
                string blood = textBloodGroup.Text;
                string any = textAny.Text;
                int pid = Convert.ToInt32(textPid.Text);
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string q = "insert into test2(name,address,contact,age,gender,blood,pid)values('" + textName.Text + "','" + textAddress.Text + "','" + textContactNumber.Text.ToString() + "','" + textAge.Text.ToString() + "','" + comboGender.Text + "','" + textBloodGroup.Text + "','" + textPid.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    //cmd.CommandText = "INSERT INTO Patients (Name, Full_Address, Contact, Age, Gender, Blood_Group, Major_Disease, pid) " +
                    //"VALUES (@Name, @Full_Address, @Contact, @Age, @Gender, @Blood_Group, @Major_Disease, @pid)";

                }
                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the data: " + ex.Message);
            }
        }

  
    } 
}