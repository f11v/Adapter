using System;

namespace Adapter
{
	public class MotorNaftero : Motor
	{
		public override string Acelerar()
		{
			return "Acelerando el motor naftero..";
		}

		public override string Arrancar()
		{
			return "Arrancando el motor naftero..";
		}

		public override string CargarCombustible()
		{
			return "Cargando combustible al motor naftero..";
		}

		public override string Detener()
		{
			return "Deteniendo el motor naftero..";
		}
	}
}
