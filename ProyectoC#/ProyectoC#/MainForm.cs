/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC12
 * Fecha: 23/10/2026
 * Hora: 07:31 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoC_
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void LimpiarToolStripMenuItemClick(object sender, EventArgs e)
		{
			txtNum1.Text="";
			txtNum2.Text="";
					
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double n1, n2, multiplicacion;
			n1=Convert.ToDouble(txtNum1.Text);
			n2=Convert.ToDouble(txtNum2.Text);
			multiplicacion=n1*n2;
			MessageBox.Show("El Resultado es: " + Convert.ToString(multiplicacion));
		}
	}
}
