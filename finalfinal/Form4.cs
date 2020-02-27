/*
 * Created by SharpDevelop.
 * User: Rea
 * Date: 3/21/2019
 * Time: 3:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace finalfinal
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Hide();
			Form5 sistema = new Form5();
			sistema.ShowDialog();
			this.Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
			Form5 sistema = new Form5();
			sistema.ShowDialog();
			this.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			this.Hide();
			Form5 sistema = new Form5();
			sistema.ShowDialog();
			this.Close();
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm sistema = new MainForm();
			sistema.ShowDialog();
			this.Close();
		}
	}
}
