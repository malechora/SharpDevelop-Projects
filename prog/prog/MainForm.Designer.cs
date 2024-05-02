/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 3/12/2023
 * Time: 14:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace prog
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label MODELO;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.MODELO = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(64, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(9, 8);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label2.Location = new System.Drawing.Point(19, 194);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "MARCA :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(196, 195);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(296, 22);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(197, 230);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(296, 22);
			this.textBox2.TabIndex = 3;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(197, 265);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(296, 22);
			this.textBox3.TabIndex = 4;
			// 
			// MODELO
			// 
			this.MODELO.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.MODELO.Location = new System.Drawing.Point(19, 230);
			this.MODELO.Name = "MODELO";
			this.MODELO.Size = new System.Drawing.Size(112, 23);
			this.MODELO.TabIndex = 5;
			this.MODELO.Text = "MODELO :";
			this.MODELO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.MODELO.Click += new System.EventHandler(this.MODELOClick);
			// 
			// label3
			// 
			this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.label3.Location = new System.Drawing.Point(19, 265);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "CANT. NÚCLEOS :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(14, 300);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "MEM. RAM :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(196, 299);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(296, 22);
			this.textBox4.TabIndex = 8;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(197, 332);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(296, 22);
			this.textBox5.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(19, 331);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "MEM VIDEO :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(196, 368);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(296, 22);
			this.textBox6.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(19, 367);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "HDD/SSD :";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(847, 195);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(296, 22);
			this.textBox7.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(684, 195);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(146, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "PUERTOS USB :";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(694, 230);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "RED RJ45 :";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(847, 230);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(296, 22);
			this.textBox8.TabIndex = 16;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(28, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1218, 148);
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label9.Location = new System.Drawing.Point(226, 45);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(1006, 78);
			this.label9.TabIndex = 18;
			this.label9.Text = "        NOTEBOOK";
			this.label9.UseWaitCursor = true;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(19, 531);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "modificar";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(197, 531);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(71, 23);
			this.label11.TabIndex = 25;
			this.label11.Text = "agregar";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(375, 531);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(73, 23);
			this.label12.TabIndex = 26;
			this.label12.Text = "eliminar";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(559, 531);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(57, 30);
			this.label13.TabIndex = 27;
			this.label13.Text = "limpiar";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(740, 531);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(47, 23);
			this.label14.TabIndex = 28;
			this.label14.Text = "salir";
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(91, 524);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 30);
			this.button1.TabIndex = 29;
			this.button1.Text = " ";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(261, 524);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 30);
			this.button2.TabIndex = 30;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(439, 523);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 31);
			this.button3.TabIndex = 31;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(613, 524);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 31);
			this.button4.TabIndex = 32;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(780, 521);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 34);
			this.button5.TabIndex = 33;
			this.button5.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 571);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.MODELO);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
