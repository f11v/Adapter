using System;

namespace Adapter
{
	public abstract class Motor
	{
		public abstract string Acelerar();
		public abstract string Arrancar();
		public abstract string Detener();
		public abstract string CargarCombustible();
	}
}

