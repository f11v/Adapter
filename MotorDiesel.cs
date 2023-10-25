using System;

namespace Adapter
{
	public class MotorDiesel : Motor
	{
		public override string Acelerar()
		{
			return "Acelerando el motor diesel..";
		}

		public override string Arrancar()
		{
			return "Arrancando el motor diesel..";
		}

		public override string CargarCombustible()
		{
			return "Cargando combustible al motor diesel..";
		}

		public override string Detener()
		{
			return "Deteniendo el motor diesel..";
		}
	}
}


