/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 17/7/2024
 * Time: 19:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace pied_papel_tijera
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnpiedra = new System.Windows.Forms.Button();
			this.btnpapel = new System.Windows.Forms.Button();
			this.btntijera = new System.Windows.Forms.Button();
			this.imgpiedra = new System.Windows.Forms.PictureBox();
			this.imgpapel = new System.Windows.Forms.PictureBox();
			this.imgtijera = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.imgpiedra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgpapel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgtijera)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(127, 215);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(244, 22);
			this.textBox1.TabIndex = 0;
			// 
			// btnpiedra
			// 
			this.btnpiedra.Image = ((System.Drawing.Image)(resources.GetObject("btnpiedra.Image")));
			this.btnpiedra.Location = new System.Drawing.Point(212, 282);
			this.btnpiedra.Name = "btnpiedra";
			this.btnpiedra.Size = new System.Drawing.Size(176, 222);
			this.btnpiedra.TabIndex = 1;
			this.btnpiedra.UseVisualStyleBackColor = true;
			this.btnpiedra.Click += new System.EventHandler(this.BtnpiedraClick);
			// 
			// btnpapel
			// 
			this.btnpapel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpapel.BackgroundImage")));
			this.btnpapel.Location = new System.Drawing.Point(478, 282);
			this.btnpapel.Name = "btnpapel";
			this.btnpapel.Size = new System.Drawing.Size(172, 222);
			this.btnpapel.TabIndex = 2;
			this.btnpapel.UseVisualStyleBackColor = true;
			this.btnpapel.Click += new System.EventHandler(this.BtnpapelClick);
			// 
			// btntijera
			// 
			this.btntijera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntijera.BackgroundImage")));
			this.btntijera.Location = new System.Drawing.Point(719, 282);
			this.btntijera.Name = "btntijera";
			this.btntijera.Size = new System.Drawing.Size(177, 222);
			this.btntijera.TabIndex = 3;
			this.btntijera.UseVisualStyleBackColor = true;
			this.btntijera.Click += new System.EventHandler(this.BtntijeraClick);
			// 
			// imgpiedra
			// 
			this.imgpiedra.Image = ((System.Drawing.Image)(resources.GetObject("imgpiedra.Image")));
			this.imgpiedra.Location = new System.Drawing.Point(212, 12);
			this.imgpiedra.Name = "imgpiedra";
			this.imgpiedra.Size = new System.Drawing.Size(120, 176);
			this.imgpiedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgpiedra.TabIndex = 4;
			this.imgpiedra.TabStop = false;
			// 
			// imgpapel
			// 
			this.imgpapel.Image = ((System.Drawing.Image)(resources.GetObject("imgpapel.Image")));
			this.imgpapel.Location = new System.Drawing.Point(493, 12);
			this.imgpapel.Name = "imgpapel";
			this.imgpapel.Size = new System.Drawing.Size(147, 176);
			this.imgpapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgpapel.TabIndex = 5;
			this.imgpapel.TabStop = false;
			// 
			// imgtijera
			// 
			this.imgtijera.Image = ((System.Drawing.Image)(resources.GetObject("imgtijera.Image")));
			this.imgtijera.Location = new System.Drawing.Point(741, 12);
			this.imgtijera.Name = "imgtijera";
			this.imgtijera.Size = new System.Drawing.Size(141, 176);
			this.imgtijera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgtijera.TabIndex = 6;
			this.imgtijera.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 218);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "LA PC ELIGIO:";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(51, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1025, 197);
			this.panel1.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1136, 516);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.imgtijera);
			this.Controls.Add(this.imgpapel);
			this.Controls.Add(this.imgpiedra);
			this.Controls.Add(this.btntijera);
			this.Controls.Add(this.btnpapel);
			this.Controls.Add(this.btnpiedra);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "pied papel tijera";
			((System.ComponentModel.ISupportInitialize)(this.imgpiedra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgpapel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgtijera)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox imgtijera;
		private System.Windows.Forms.PictureBox imgpapel;
		private System.Windows.Forms.PictureBox imgpiedra;
		private System.Windows.Forms.Button btntijera;
		private System.Windows.Forms.Button btnpapel;
		private System.Windows.Forms.Button btnpiedra;
		private System.Windows.Forms.TextBox textBox1;
	}
}
