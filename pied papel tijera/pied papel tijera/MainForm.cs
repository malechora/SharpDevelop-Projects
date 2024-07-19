using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Linq;

namespace pied_papel_tijera
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
	
		int eleccionComputadora;
    
        textBox1.Visible = false; 
        imgpapel.Visible = false;
        imgpiedra.Visible = false;
        imgtijera.Visible = false;
        
        Random random = new Random();
        eleccionComputadora = random.Next(1,4);
        
        switch (eleccionComputadora) {
        	case 1 : textBox1.Text = "tijera";
        	 imgtijera.Visible = true;
        	break;
        	case 2 : textBox1.Text = "piedra";
        	imgpiedra.Visible = true;
        	break;
        	case 3 : textBox1.Text = "papel";
        	  imgpapel.Visible = true;
        	break;
        	
        }
        
		}
		
		
		void BtnpiedraClick(object sender, EventArgs e)
		{
			textBox1.Visible = true; 
			panel1.Visible = false;
			 if(textBox1.Text == "piedra"){
				MessageBox.Show("empate");
			}else if(textBox1.Text == "papel"){
				MessageBox.Show("perdiste");
			}
			else{
				MessageBox.Show("ganaste");
			}
		}
		
		void BtnpapelClick(object sender, EventArgs e)
		{
			textBox1.Visible = true; 
				panel1.Visible = false;
			 if(textBox1.Text == "piedra"){
				MessageBox.Show("gana");
			}else if(textBox1.Text == "papel"){
				MessageBox.Show("empate");
			}
			else{
				MessageBox.Show("perdiste");
			}
		}
		
		void BtntijeraClick(object sender, EventArgs e)
		{
			textBox1.Visible = true; 
				panel1.Visible = false;
			 if(textBox1.Text == "piedra"){
				MessageBox.Show("perdiste");
			}else if(textBox1.Text == "papel"){
				MessageBox.Show("ganaste");
			}
			else{
				MessageBox.Show("empate");
			}
		}
	}
}
