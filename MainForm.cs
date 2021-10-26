using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cronometro
{
	public partial class MainForm : Form
	{
		int horas=0, minutos=0, segundos=0;
		
		public MainForm()
		{
			InitializeComponent();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			string auxs="", auxm="", auxh="";
			
			auxs = "";

			if (segundos>=10){
				
				auxs = auxs + segundos;
			
			}else{
				
				auxs = auxs + "0" + segundos;	
			}
			
			lbl_segundos.Text = auxs;
			
			segundos++;	
			
			if (segundos>=60){
				
				minutos++;
				segundos=0;
				
				auxm = auxm + minutos;
				
			}else{
				
				auxm = auxm + "0" + minutos;	
			}
			
			lbl_minutos.Text = auxm;
			
			if (minutos>=60){
						
				horas++;
				minutos=0;
				
				auxh = auxh + horas;	
				
			}else{
				
				auxh = auxh + "0" + horas;	
			}
			
			lbl_horas.Text = auxh;
		}	
			
		void Btn_iniciarClick(object sender, EventArgs e)
		{
			tmr_cronometro.Enabled = true;
		}
		void Btn_detenerClick(object sender, EventArgs e)
		{
			tmr_cronometro.Enabled = false;
		}
		void Btn_reiniciarClick(object sender, EventArgs e)
		{
			horas=0;
			minutos=0;
			segundos=0;
			
			lbl_horas.Text= "00";
			lbl_minutos.Text= "00";
			lbl_segundos.Text= "00";
			
			tmr_cronometro.Enabled = false;
		}	
	}
}
