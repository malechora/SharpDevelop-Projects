/*
 * Created by SharpDevelop.
 * User: migue
 * Date: 11/11/2023
 * Time: 15:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PracticaCrud
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
			this.lblCrud = new System.Windows.Forms.Label();
			this.boxGroup = new System.Windows.Forms.GroupBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.lblRed = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.lblUsb = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.lblDisco = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblMemVideo = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.lblBusqueda = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.lblModelo = new System.Windows.Forms.Label();
			this.lblCantNucleos = new System.Windows.Forms.Label();
			this.lblMemRam = new System.Windows.Forms.Label();
			this.lblMarca = new System.Windows.Forms.Label();
			this.boxGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCrud
			// 
			this.lblCrud.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCrud.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblCrud.Location = new System.Drawing.Point(0, 0);
			this.lblCrud.Name = "lblCrud";
			this.lblCrud.Size = new System.Drawing.Size(900, 53);
			this.lblCrud.TabIndex = 0;
			this.lblCrud.Text = "NOTEBOOK";
			this.lblCrud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// boxGroup
			// 
			this.boxGroup.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.boxGroup.Controls.Add(this.textBox5);
			this.boxGroup.Controls.Add(this.lblRed);
			this.boxGroup.Controls.Add(this.textBox4);
			this.boxGroup.Controls.Add(this.lblUsb);
			this.boxGroup.Controls.Add(this.textBox3);
			this.boxGroup.Controls.Add(this.lblDisco);
			this.boxGroup.Controls.Add(this.textBox1);
			this.boxGroup.Controls.Add(this.lblMemVideo);
			this.boxGroup.Controls.Add(this.btnSalir);
			this.boxGroup.Controls.Add(this.btnLimpiar);
			this.boxGroup.Controls.Add(this.btnEliminar);
			this.boxGroup.Controls.Add(this.btnModificar);
			this.boxGroup.Controls.Add(this.btnAgregar);
			this.boxGroup.Controls.Add(this.dataGridView1);
			this.boxGroup.Controls.Add(this.panel1);
			this.boxGroup.Controls.Add(this.txtNombre);
			this.boxGroup.Controls.Add(this.txtPrecio);
			this.boxGroup.Controls.Add(this.textBox2);
			this.boxGroup.Controls.Add(this.txtModelo);
			this.boxGroup.Controls.Add(this.lblModelo);
			this.boxGroup.Controls.Add(this.lblCantNucleos);
			this.boxGroup.Controls.Add(this.lblMemRam);
			this.boxGroup.Controls.Add(this.lblMarca);
			this.boxGroup.Location = new System.Drawing.Point(0, 48);
			this.boxGroup.Name = "boxGroup";
			this.boxGroup.Size = new System.Drawing.Size(900, 581);
			this.boxGroup.TabIndex = 1;
			this.boxGroup.TabStop = false;
			
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(531, 143);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(233, 20);
			this.textBox5.TabIndex = 24;
			// 
			// lblRed
			// 
			this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRed.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblRed.Location = new System.Drawing.Point(409, 141);
			this.lblRed.Name = "lblRed";
			this.lblRed.Size = new System.Drawing.Size(99, 22);
			this.lblRed.TabIndex = 23;
			this.lblRed.Text = "Red RJ45:";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(531, 105);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(233, 20);
			this.textBox4.TabIndex = 22;
			// 
			// lblUsb
			// 
			this.lblUsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsb.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblUsb.Location = new System.Drawing.Point(409, 103);
			this.lblUsb.Name = "lblUsb";
			this.lblUsb.Size = new System.Drawing.Size(125, 22);
			this.lblUsb.TabIndex = 21;
			this.lblUsb.Text = "Puertos USB:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(143, 219);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(233, 20);
			this.textBox3.TabIndex = 20;
			// 
			// lblDisco
			// 
			this.lblDisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisco.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblDisco.Location = new System.Drawing.Point(21, 217);
			this.lblDisco.Name = "lblDisco";
			this.lblDisco.Size = new System.Drawing.Size(99, 22);
			this.lblDisco.TabIndex = 19;
			this.lblDisco.Text = "HDD/SSD:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(143, 183);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(233, 20);
			this.textBox1.TabIndex = 18;
			// 
			// lblMemVideo
			// 
			this.lblMemVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMemVideo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblMemVideo.Location = new System.Drawing.Point(21, 181);
			this.lblMemVideo.Name = "lblMemVideo";
			this.lblMemVideo.Size = new System.Drawing.Size(116, 22);
			this.lblMemVideo.TabIndex = 17;
			this.lblMemVideo.Text = "Mem. Video:";
			// 
			// btnSalir
			// 
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.Location = new System.Drawing.Point(636, 529);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(82, 34);
			this.btnSalir.TabIndex = 16;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
			this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimpiar.Location = new System.Drawing.Point(512, 529);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(90, 34);
			this.btnLimpiar.TabIndex = 15;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.Location = new System.Drawing.Point(385, 529);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(90, 34);
			this.btnEliminar.TabIndex = 14;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnModificar.Location = new System.Drawing.Point(270, 529);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(87, 34);
			this.btnModificar.TabIndex = 13;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.UseVisualStyleBackColor = true;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.Location = new System.Drawing.Point(148, 529);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(91, 34);
			this.btnAgregar.TabIndex = 12;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Modelo,
									this.Column1,
									this.Column2,
									this.Proveedor,
									this.NIF,
									this.Column3,
									this.Column4,
									this.Column5,
									this.Column6,
									this.Column7,
									this.Column8,
									this.Column9,
									this.Column10,
									this.Column11,
									this.Column12});
			this.dataGridView1.Location = new System.Drawing.Point(21, 351);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(873, 172);
			this.dataGridView1.TabIndex = 11;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			// 
			// Modelo
			// 
			this.Modelo.HeaderText = "Marca";
			this.Modelo.Name = "Modelo";
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Modelo";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Cantidad de Núcleos";
			this.Column2.Name = "Column2";
			// 
			// Proveedor
			// 
			this.Proveedor.HeaderText = "Memoria RAM";
			this.Proveedor.Name = "Proveedor";
			// 
			// NIF
			// 
			this.NIF.FillWeight = 50F;
			this.NIF.HeaderText = "Memoria Video";
			this.NIF.Name = "NIF";
			this.NIF.Width = 50;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "HDD/SSD";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Pertos USB";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Red RJ45";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Wifi";
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Sistema Operativo Base";
			this.Column7.Name = "Column7";
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Precio Unitario";
			this.Column8.Name = "Column8";
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Cantidad Adquiridas";
			this.Column9.Name = "Column9";
			// 
			// Column10
			// 
			this.Column10.HeaderText = "Cantidad Vendidas";
			this.Column10.Name = "Column10";
			// 
			// Column11
			// 
			this.Column11.HeaderText = "En Stock";
			this.Column11.Name = "Column11";
			// 
			// Column12
			// 
			this.Column12.HeaderText = "Valor Stock";
			this.Column12.Name = "Column12";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.txtBusqueda);
			this.panel1.Controls.Add(this.lblBusqueda);
			this.panel1.Location = new System.Drawing.Point(21, 301);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(900, 47);
			this.panel1.TabIndex = 10;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(376, 13);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(35, 31);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(143, 16);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(227, 20);
			this.txtBusqueda.TabIndex = 12;
			// 
			// lblBusqueda
			// 
			this.lblBusqueda.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBusqueda.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblBusqueda.Location = new System.Drawing.Point(21, 13);
			this.lblBusqueda.Name = "lblBusqueda";
			this.lblBusqueda.Size = new System.Drawing.Size(116, 23);
			this.lblBusqueda.TabIndex = 11;
			this.lblBusqueda.Text = "Búsqueda:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(143, 67);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(233, 20);
			this.txtNombre.TabIndex = 7;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(143, 103);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(233, 20);
			this.txtPrecio.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(143, 145);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(233, 20);
			this.textBox2.TabIndex = 5;
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(143, 33);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(233, 20);
			this.txtModelo.TabIndex = 4;
			// 
			// lblModelo
			// 
			this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblModelo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblModelo.Location = new System.Drawing.Point(21, 67);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(78, 20);
			this.lblModelo.TabIndex = 3;
			this.lblModelo.Text = "Modelo:";
			// 
			// lblCantNucleos
			// 
			this.lblCantNucleos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantNucleos.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblCantNucleos.Location = new System.Drawing.Point(21, 103);
			this.lblCantNucleos.Name = "lblCantNucleos";
			this.lblCantNucleos.Size = new System.Drawing.Size(137, 22);
			this.lblCantNucleos.TabIndex = 2;
			this.lblCantNucleos.Text = "Cant. Núcleos:";
			// 
			// lblMemRam
			// 
			this.lblMemRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMemRam.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblMemRam.Location = new System.Drawing.Point(21, 143);
			this.lblMemRam.Name = "lblMemRam";
			this.lblMemRam.Size = new System.Drawing.Size(116, 20);
			this.lblMemRam.TabIndex = 1;
			this.lblMemRam.Text = "Mem. RAM:";
			// 
			// lblMarca
			// 
			this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMarca.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblMarca.Location = new System.Drawing.Point(21, 31);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(78, 22);
			this.lblMarca.TabIndex = 0;
			this.lblMarca.Text = "Marca:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(892, 623);
			this.Controls.Add(this.boxGroup);
			this.Controls.Add(this.lblCrud);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PracticaCrud";
			this.boxGroup.ResumeLayout(false);
			this.boxGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblMemVideo;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblDisco;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label lblUsb;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label lblRed;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
		private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblBusqueda;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.Label lblMemRam;
		private System.Windows.Forms.Label lblCantNucleos;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.GroupBox boxGroup;
		private System.Windows.Forms.Label lblCrud;
	
		

		

	}
}

