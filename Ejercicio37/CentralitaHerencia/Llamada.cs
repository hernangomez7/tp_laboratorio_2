using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    
    public class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        #region Llamada
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }
        #endregion

        #region setgets
        public float Duracion
        {
            get
            {
                return _duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return _nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return _nroOrigen;
            }
        }
        #endregion

        #region OrdenarPorDuracion
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int intRetorno = 0 ;
            if (llamada1 == null && llamada1 == null)
            {
                if (llamada1.Duracion > llamada2.Duracion)
                {
                    intRetorno = 1;
                }
                else if (llamada1.Duracion < llamada2.Duracion)
                {
                    intRetorno = -1;
                }
            }
            return intRetorno;
        }
        #endregion

        #region Mostrar
        public string Mostrar()
        {
            string stringReturn = "";
            StringBuilder sb = new StringBuilder();

            sb.Append("Duracion: "+this.Duracion);
            sb.Append(Convert.ToString("NroDestino: " + this.NroDestino));
            sb.Append(Convert.ToString("NroOrigen: " + this.NroOrigen));

            stringReturn = sb.ToString();
            return stringReturn;
        }
        #endregion

    }
}
