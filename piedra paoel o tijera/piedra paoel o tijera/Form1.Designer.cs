/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 16/7/2024
 * Time: 14:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace piedra_paoel_o_tijera
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnpapel = new System.Windows.Forms.Button();
			this.btnpiedra = new System.Windows.Forms.Button();
			this.btntijera = new System.Windows.Forms.Button();
			this.btnpapelmaquina = new System.Windows.Forms.Button();
			this.btnpiedramaquina = new System.Windows.Forms.Button();
			this.btntijeramaquina = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnpapel
			// 
			this.btnpapel.Image = ((System.Drawing.Image)(resources.GetObject("btnpapel.Image")));
			this.btnpapel.Location = new System.Drawing.Point(84, 50);
			this.btnpapel.Name = "btnpapel";
			this.btnpapel.Size = new System.Drawing.Size(195, 178);
			this.btnpapel.TabIndex = 0;
			this.btnpapel.UseVisualStyleBackColor = true;
			this.btnpapel.Click += new System.EventHandler(this.BtnpapelClick);
			// 
			// btnpiedra
			// 
			this.btnpiedra.Image = ((System.Drawing.Image)(resources.GetObject("btnpiedra.Image")));
			this.btnpiedra.Location = new System.Drawing.Point(494, 46);
			this.btnpiedra.Name = "btnpiedra";
			this.btnpiedra.Size = new System.Drawing.Size(216, 178);
			this.btnpiedra.TabIndex = 1;
			this.btnpiedra.UseVisualStyleBackColor = true;
			// 
			// btntijera
			// 
			this.btntijera.Image = ((System.Drawing.Image)(resources.GetObject("btntijera.Image")));
			this.btntijera.Location = new System.Drawing.Point(896, 46);
			this.btntijera.Name = "btntijera";
			this.btntijera.Size = new System.Drawing.Size(204, 182);
			this.btntijera.TabIndex = 2;
			this.btntijera.UseVisualStyleBackColor = true;
			// 
			// btnpapelmaquina
			// 
			this.btnpapelmaquina.Image = ((System.Drawing.Image)(resources.GetObject("btnpapelmaquina.Image")));
			this.btnpapelmaquina.Location = new System.Drawing.Point(84, 325);
			this.btnpapelmaquina.Name = "btnpapelmaquina";
			this.btnpapelmaquina.Size = new System.Drawing.Size(195, 178);
			this.btnpapelmaquina.TabIndex = 3;
			this.btnpapelmaquina.UseVisualStyleBackColor = true;
			// 
			// btnpiedramaquina
			// 
			this.btnpiedramaquina.Image = ((System.Drawing.Image)(resources.GetObject("btnpiedramaquina.Image")));
			this.btnpiedramaquina.Location = new System.Drawing.Point(494, 325);
			this.btnpiedramaquina.Name = "btnpiedramaquina";
			this.btnpiedramaquina.Size = new System.Drawing.Size(216, 178);
			this.btnpiedramaquina.TabIndex = 4;
			this.btnpiedramaquina.UseVisualStyleBackColor = true;
			// 
			// btntijeramaquina
			// 
			this.btntijeramaquina.Image = ((System.Drawing.Image)(resources.GetObject("btntijeramaquina.Image")));
			this.btntijeramaquina.Location = new System.Drawing.Point(896, 325);
			this.btntijeramaquina.Name = "btntijeramaquina";
			this.btntijeramaquina.Size = new System.Drawing.Size(204, 182);
			this.btntijeramaquina.TabIndex = 5;
			this.btntijeramaquina.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1133, 543);
			this.Controls.Add(this.btntijeramaquina);
			this.Controls.Add(this.btnpiedramaquina);
			this.Controls.Add(this.btnpapelmaquina);
			this.Controls.Add(this.btntijera);
			this.Controls.Add(this.btnpiedra);
			this.Controls.Add(this.btnpapel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btntijeramaquina;
		private System.Windows.Forms.Button btnpiedramaquina;
		private System.Windows.Forms.Button btnpapelmaquina;
		private System.Windows.Forms.Button btntijera;
		private System.Windows.Forms.Button btnpiedra;
		private System.Windows.Forms.Button btnpapel;
	}
}
