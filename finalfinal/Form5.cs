/*
 * Created by SharpDevelop.
 * User: Rea
 * Date: 3/22/2019
 * Time: 4:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

 
namespace finalfinal
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=testing101");
        public Form5()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
        	if( textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
        	{
                MessageBox.Show("Blank Field. Fill up necessary Fields.");  	
        		               
        	}
        	else
        		{
        			 string insertQuery = "INSERT INTO pizza.delivery(customer_name,customer_phone,House_no,Street,landmark) VALUES('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {	
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        		}
        }
        
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Form5Load(object sender, EventArgs e)
		{
			label3.Text= DateTime.Now.ToLongTimeString();
			label2.Text= DateTime.Now.ToLongDateString();
			
		}
		void Timer1Tick(object sender, EventArgs e)
		{
		label3.Text= DateTime.Now.ToLongTimeString();
		timer1.Start();
		}
		void Button4Click(object sender, EventArgs e)
		{
	
		}
				 
		
	}

}
