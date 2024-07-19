using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calculadora
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
	
			
			InitializeComponent();
			
		
		}
		
		string operador = "";
		int num1;
		int num2;
	
		
		void BtnresetClick(object sender, EventArgs e)
		{
		textBox1.Text = "0";
		}
			
		void Button1Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" ){
                textBox1.Text = "1";
            }else{
                textBox1.Text += "1";
            }
        }
		
		void Button2Click(object sender, EventArgs e)
		{
			 if(textBox1.Text == "0" ){
                textBox1.Text = "2";
            }else{
                textBox1.Text += "2";
            }
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			 if(textBox1.Text == "0"){
                textBox1.Text = "3";
            }else{
                textBox1.Text += "3";
            }
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "0" ){
                textBox1.Text = "4";
            }else{
                textBox1.Text += "4";
            }
		}
		
		
		void Button5Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "0" ){
                textBox1.Text = "5";
            }else{
                textBox1.Text += "5";
            }
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "0" ){
                textBox1.Text = "6";
            }else{
                textBox1.Text += "6";
            }
		}
		
		
		void Button7Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "0"){
                textBox1.Text = "7";
            }else{
                textBox1.Text += "7";
            }
		}
		void Button8Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "0" ){
                textBox1.Text = "8";
            }else{
                textBox1.Text += "8";
            }
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "0" ){
                textBox1.Text = "9";
            }else{
                textBox1.Text += "9";
            }
		}
		
		
		
		void BtnigualClick(object sender, EventArgs e)
		{
			num2= Convert.ToInt32(textBox1.Text);
			
			switch(operador){
					case "+": textBox1.Text = (num1+num2).ToString();
				break;
				case "-": textBox1.Text = (num1-num2).ToString();
				break;
				case "/": textBox1.Text = (num1/num2).ToString();
				break;
				case "*": textBox1.Text = (num1*num2).ToString();
				break;
		}
		}
		
		void BtnrestaClick(object sender, EventArgs e)
		{
			operador = "-";
			num1=Convert.ToInt32(textBox1.Text);
			textBox1.Text = "0";
		}
		
		void BtnsumaClick(object sender, EventArgs e)
		{
			operador = "+";
			num1=Convert.ToInt32(textBox1.Text);
			textBox1.Text = "0";
		}
		
		void BtndivClick(object sender, EventArgs e)
		{
			operador = "/";
			num1=Convert.ToInt32(textBox1.Text);
			textBox1.Text = "0";
		}
		
		void BtnmultClick(object sender, EventArgs e)
		{
			operador = "*";
			num1=Convert.ToInt32(textBox1.Text);
			textBox1.Text = "0";
		}
}
}
