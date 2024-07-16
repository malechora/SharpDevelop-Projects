
using System;
using System.Drawing;
using System.Windows.Forms;

namespace piedra_paoel_o_tijera
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			
			
			
			InitializeComponent();
			
		
			
			
		}
		
		
		void BtnpapelClick(object sender, EventArgs e)
		{
			
			variables misVariables = new variables();
			if(misVariables.EleccionHum == 1){
				btnpapel.BackColor = Color.Green;
			}
			
			if (eleccionHum == papel)
{
   btnpapel.BackColor = Color.Green;
}
			
		}
	}
}
