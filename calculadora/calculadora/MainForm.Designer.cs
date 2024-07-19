/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 18/7/2024
 * Time: 22:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace calculadora
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnresta = new System.Windows.Forms.Button();
			this.btnsuma = new System.Windows.Forms.Button();
			this.btndiv = new System.Windows.Forms.Button();
			this.btnigual = new System.Windows.Forms.Button();
			this.btnmult = new System.Windows.Forms.Button();
			this.btnreset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(101, 346);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(76, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(191, 346);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(76, 50);
			this.button2.TabIndex = 1;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(286, 346);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(76, 50);
			this.button3.TabIndex = 2;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(101, 258);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(76, 50);
			this.button4.TabIndex = 3;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(191, 258);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(76, 50);
			this.button5.TabIndex = 4;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(286, 258);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(76, 50);
			this.button6.TabIndex = 5;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(101, 182);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(76, 50);
			this.button7.TabIndex = 6;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(191, 182);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(76, 50);
			this.button8.TabIndex = 7;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(286, 182);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(76, 50);
			this.button9.TabIndex = 8;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(101, 102);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(270, 47);
			this.textBox1.TabIndex = 9;
			this.textBox1.Text = "0";
			// 
			// btnresta
			// 
			this.btnresta.Location = new System.Drawing.Point(408, 346);
			this.btnresta.Name = "btnresta";
			this.btnresta.Size = new System.Drawing.Size(69, 50);
			this.btnresta.TabIndex = 10;
			this.btnresta.Text = "-";
			this.btnresta.UseVisualStyleBackColor = true;
			this.btnresta.Click += new System.EventHandler(this.BtnrestaClick);
			// 
			// btnsuma
			// 
			this.btnsuma.Location = new System.Drawing.Point(408, 258);
			this.btnsuma.Name = "btnsuma";
			this.btnsuma.Size = new System.Drawing.Size(69, 50);
			this.btnsuma.TabIndex = 11;
			this.btnsuma.Text = "+";
			this.btnsuma.UseVisualStyleBackColor = true;
			this.btnsuma.Click += new System.EventHandler(this.BtnsumaClick);
			// 
			// btndiv
			// 
			this.btndiv.Location = new System.Drawing.Point(408, 182);
			this.btndiv.Name = "btndiv";
			this.btndiv.Size = new System.Drawing.Size(69, 50);
			this.btndiv.TabIndex = 12;
			this.btndiv.Text = "/";
			this.btndiv.UseVisualStyleBackColor = true;
			this.btndiv.Click += new System.EventHandler(this.BtndivClick);
			// 
			// btnigual
			// 
			this.btnigual.Location = new System.Drawing.Point(408, 429);
			this.btnigual.Name = "btnigual";
			this.btnigual.Size = new System.Drawing.Size(69, 53);
			this.btnigual.TabIndex = 14;
			this.btnigual.Text = "=";
			this.btnigual.UseVisualStyleBackColor = true;
			this.btnigual.Click += new System.EventHandler(this.BtnigualClick);
			// 
			// btnmult
			// 
			this.btnmult.Location = new System.Drawing.Point(408, 104);
			this.btnmult.Name = "btnmult";
			this.btnmult.Size = new System.Drawing.Size(69, 45);
			this.btnmult.TabIndex = 13;
			this.btnmult.Text = "*";
			this.btnmult.UseVisualStyleBackColor = true;
			this.btnmult.Click += new System.EventHandler(this.BtnmultClick);
			// 
			// btnreset
			// 
			this.btnreset.Location = new System.Drawing.Point(408, 26);
			this.btnreset.Name = "btnreset";
			this.btnreset.Size = new System.Drawing.Size(69, 48);
			this.btnreset.TabIndex = 15;
			this.btnreset.Text = "RESET";
			this.btnreset.UseVisualStyleBackColor = true;
			this.btnreset.Click += new System.EventHandler(this.BtnresetClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 494);
			this.Controls.Add(this.btnreset);
			this.Controls.Add(this.btnigual);
			this.Controls.Add(this.btnmult);
			this.Controls.Add(this.btndiv);
			this.Controls.Add(this.btnsuma);
			this.Controls.Add(this.btnresta);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "calculadora";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnreset;
		private System.Windows.Forms.Button btnmult;
		private System.Windows.Forms.Button btnigual;
		private System.Windows.Forms.Button btndiv;
		private System.Windows.Forms.Button btnsuma;
		private System.Windows.Forms.Button btnresta;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
