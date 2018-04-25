using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66
        }

        protected Franja _FranjaHoraria;

        #region Constr
        public Provincial(float duracion, string nroDestino, string nroOrigen, Franja miFranja)
            : base(duracion, nroDestino, nroOrigen)
        {
            this._FranjaHoraria = miFranja;
        }

        public Provincial (Llamada llamada, Franja miFranja)
            : this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, miFranja)
        {

        }
        #endregion


        #region setgets
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region CalcularCosto
        private float CalcularCosto()
        {
            float retornoFloat = 0;

            switch (_FranjaHoraria)
            {
                case Franja.Franja_1:
                    retornoFloat = this._duracion * (float)Franja.Franja_1 / 100;
                    break;
                case Franja.Franja_2:
                    retornoFloat = this._duracion * (float)Franja.Franja_2 / 100;
                    break;
                case Franja.Franja_3:
                    retornoFloat = this._duracion * (float)Franja.Franja_3 / 100;
                    break;
            }

            return retornoFloat;
        }
        #endregion
    }
}
