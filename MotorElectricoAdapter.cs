using System;

namespace Adapter
{
    public class MotorElectricoAdapter : Motor
    {
        private MotorElectrico motorElectrico;

        public MotorElectricoAdapter()
        {
            motorElectrico = new MotorElectrico();
        }

        public override string Acelerar()
        {
            return motorElectrico.Mover();
        }

        public override string Arrancar()
        {
            string resultado = motorElectrico.Conectar();
            resultado += "\n" + motorElectrico.Activar();
            return resultado;
        }

        public override string CargarCombustible()
        {
            return motorElectrico.Enchufar();
        }

        public override string Detener()
        {
            string resultado = motorElectrico.Parar();
            resultado += "\n" + motorElectrico.Desactivar();
            resultado += "\n" + motorElectrico.Desconectar();
            return resultado;
        }
    }
}


