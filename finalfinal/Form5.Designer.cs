/*
 * Created by SharpDevelop.
 * User: Rea
 * Date: 3/22/2019
 * Time: 4:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace finalfinal
{
	partial class Form5
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button button4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(97, 38);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 128);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(114, 171);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Deliver";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(508, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(254, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "Time:";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(508, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(233, 29);
			this.label3.TabIndex = 3;
			this.label3.Text = "Date:";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(97, 222);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 32);
			this.label4.TabIndex = 4;
			this.label4.Text = "Name:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(37, 291);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 32);
			this.label5.TabIndex = 5;
			this.label5.Text = "Phone Number:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(179, 226);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(131, 20);
			this.textBox3.TabIndex = 8;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(179, 295);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(131, 20);
			this.textBox4.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(368, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(282, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Please input the exact location.";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(508, 377);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(205, 31);
			this.button1.TabIndex = 21;
			this.button1.Text = "CONFIRM LOCATION";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(367, 108);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(372, 23);
			this.label9.TabIndex = 17;
			this.label9.Text = "Enter the address where you want to deliver.";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(483, 291);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(290, 23);
			this.label10.TabIndex = 20;
			this.label10.Text = "Landmark or Nearest street corner.";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(483, 209);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(258, 23);
			this.label11.TabIndex = 19;
			this.label11.Text = "Street/ Subdivision/ Barangay";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Glacial Indifference", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(483, 143);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(225, 23);
			this.label12.TabIndex = 18;
			this.label12.Text = "House no./ Unit no./ Floor.";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(483, 169);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(279, 20);
			this.textBox5.TabIndex = 24;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(483, 249);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(279, 20);
			this.textBox6.TabIndex = 25;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(483, 332);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(279, 20);
			this.textBox7.TabIndex = 26;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.DarkOrange;
			this.button4.Location = new System.Drawing.Point(12, 10);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(62, 39);
			this.button4.TabIndex = 27;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(903, 452);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form5";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form5";
			this.Load += new System.EventHandler(this.Form5Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
