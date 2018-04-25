using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected float _costo;

        #region Constr
        public Local(float duracion, string nroDestino, string nroOrigen, float costo)
            : base(duracion, nroDestino, nroOrigen)
        {
             this._costo = costo;
        }

        public Local (Llamada llamada, float costo)
            : this(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen,costo)
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

        #region Mostrar
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.Duracion);
            sb.Append(" ");
            sb.Append(Convert.ToString(this.NroDestino));
            sb.Append(" ");
            sb.Append(Convert.ToString(this.NroOrigen));
            sb.Append(" ");
            sb.Append(Convert.ToString(this._costo));

            return sb.ToString();
        }
        #endregion

        #region CalcularCosto
        private float CalcularCosto()
        {
            float retornoFloat;
            retornoFloat = _costo * this._duracion;
            return retornoFloat;
        }
        #endregion

    }
}
