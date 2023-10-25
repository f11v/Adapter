using System;

namespace Adapter
{
	public class MotorElectrico
	{
		bool _conectado;
		bool _activo;
		bool _moviendo;

		public string Conectar()
		{
			if (_conectado)
				return "Imposible conectar un motor eléctrico ya conectado!";

			_conectado = true;
			return "Motor eléctrico conectado!";
		}

		public string Activar()
		{
			if (!_conectado)
				return "Imposible activar un motor eléctrico no conectado";

			_activo = true;
			return "Motor eléctrico activado!";
		}

		public string Mover()
		{
			if (_conectado && _activo)
			{
				_moviendo = true;
				return "Moviendo vehículo con motor eléctrico...";
			}

			return "El motor eléctrico debe estar conectado y activo para mover el vehículo.";
		}

		public string Parar()
		{
			if (_moviendo)
			{
				_moviendo = false;
				return "Parando vehículo con motor eléctrico...";
			}

			return "Imposible detener un motor eléctrico que no está en movimiento.";
		}

		public string Desconectar()
		{
			if (_conectado)
			{
				_conectado = false;
				return "Motor eléctrico desconectado...";
			}

			return "Imposible desconectar un motor eléctrico que no está conectado.";
		}

		public string Desactivar()
		{
			if (_activo)
			{
				_activo = false;
				return "Motor eléctrico desactivado...";
			}

			return "Imposible desactivar un motor eléctrico que no está activo.";
		}

		public string Enchufar()
		{
			if (!_activo)
			{
				_activo = true;
				return "Motor eléctrico cargando las baterías...";
			}

			return "Imposible enchufar un motor eléctrico que está activo.";
		}
	}
}
