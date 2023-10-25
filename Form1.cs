
using System;
using System.Text;
using System.Windows.Forms;

namespace Adapter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnMotorDiesel_Click(object sender, EventArgs e)
		{
			Motor motorDiesel = new MotorDiesel();
			string datosMotor = ObtenerDatosMotor(motorDiesel);
			MessageBox.Show(datosMotor, "Motor Diesel");
		}

		private void btnMotorElectrico_Click(object sender, EventArgs e)
		{
			Motor motorElectrico = new MotorElectricoAdapter();
			string datosMotor = ObtenerDatosMotor(motorElectrico);
			MessageBox.Show(datosMotor, "Motor Eléctrico");
		}

		private void btnMotorNaftero_Click(object sender, EventArgs e)
		{
			Motor motorNaftero = new MotorNaftero();
			string datosMotor = ObtenerDatosMotor(motorNaftero);
			MessageBox.Show(datosMotor, "Motor Naftero");
		}

		private string ObtenerDatosMotor(Motor motor)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Datos del motor:");
			sb.AppendLine("--------------------");
			sb.AppendLine("Tipo de motor: " + motor.GetType().Name);
			sb.AppendLine("Aceleración: " + motor.Acelerar());
			sb.AppendLine("Arranque: " + motor.Arrancar());
			sb.AppendLine("Detención: " + motor.Detener());
			sb.AppendLine("Carga: " + motor.CargarCombustible());
			return sb.ToString();
		}
	}
}
