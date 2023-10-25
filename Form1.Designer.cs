namespace Adapter
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnMotorDiesel = new System.Windows.Forms.Button();
			this.btnMotorElectrico = new System.Windows.Forms.Button();
			this.btnMotorNaftero = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnMotorDiesel
			// 
			this.btnMotorDiesel.Location = new System.Drawing.Point(45, 36);
			this.btnMotorDiesel.Name = "btnMotorDiesel";
			this.btnMotorDiesel.Size = new System.Drawing.Size(120, 40);
			this.btnMotorDiesel.TabIndex = 0;
			this.btnMotorDiesel.Text = "Motor Diesel";
			this.btnMotorDiesel.UseVisualStyleBackColor = true;
			this.btnMotorDiesel.Click += new System.EventHandler(this.btnMotorDiesel_Click);
			// 
			// btnMotorElectrico
			// 
			this.btnMotorElectrico.Location = new System.Drawing.Point(45, 97);
			this.btnMotorElectrico.Name = "btnMotorElectrico";
			this.btnMotorElectrico.Size = new System.Drawing.Size(120, 40);
			this.btnMotorElectrico.TabIndex = 1;
			this.btnMotorElectrico.Text = "Motor Eléctrico";
			this.btnMotorElectrico.UseVisualStyleBackColor = true;
			this.btnMotorElectrico.Click += new System.EventHandler(this.btnMotorElectrico_Click);
			// 
			// btnMotorNaftero
			// 
			this.btnMotorNaftero.Location = new System.Drawing.Point(45, 158);
			this.btnMotorNaftero.Name = "btnMotorNaftero";
			this.btnMotorNaftero.Size = new System.Drawing.Size(120, 40);
			this.btnMotorNaftero.TabIndex = 2;
			this.btnMotorNaftero.Text = "Motor Naftero";
			this.btnMotorNaftero.UseVisualStyleBackColor = true;
			this.btnMotorNaftero.Click += new System.EventHandler(this.btnMotorNaftero_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 230);
			this.Controls.Add(this.btnMotorNaftero);
			this.Controls.Add(this.btnMotorElectrico);
			this.Controls.Add(this.btnMotorDiesel);
			this.Name = "MainForm";
			this.Text = "Información de Motores";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnMotorDiesel;
		private System.Windows.Forms.Button btnMotorElectrico;
		private System.Windows.Forms.Button btnMotorNaftero;
	}
}

