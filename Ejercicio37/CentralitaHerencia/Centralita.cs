using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected String razonSocial;

        #region Constr
        public Centralita()
        { 
            this.listaDeLlamadas = new List<Llamada>();
            this.razonSocial = "";
        }

        public Centralita(string NombreEmpresa)
        {
            this.listaDeLlamadas = new List<Llamada>();
            this.razonSocial = NombreEmpresa;
        }
        #endregion

        #region setgets
        
        public float GananciaPorProvincial
        {
            get
            {
                
                 
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        
        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
         
        public float GananciaPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }
        #endregion

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;
            for (int i = 0; i < this.listaDeLlamadas.Count; i++)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (this.listaDeLlamadas[i] is Local)
                        {
                            ganancia += ((Local)this.listaDeLlamadas[i]).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Provincial:
                        if (this.listaDeLlamadas[i] is Provincial)
                        {
                            ganancia += ((Provincial)this.listaDeLlamadas[i]).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Todas:
                        if (this.listaDeLlamadas[i] is Local)
                        {
                            ganancia += ((Local)this.listaDeLlamadas[i]).CostoLlamada;
                        }else if (this.listaDeLlamadas[i] is Provincial)
                        {
                            ganancia += ((Provincial)this.listaDeLlamadas[i]).CostoLlamada;
                        }
                        break;
                }
            }

            return ganancia;
        }

        #region Mostrar
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("R.social: " + this.razonSocial + " ");
            sb.Append(Convert.ToString("G.total: " + this.GananciaPorTotal + " "));
            sb.Append(Convert.ToString("G.locales: " + this.GananciaPorLocal + " "));
            sb.Append(Convert.ToString("G.provinciales: " + this.GananciaPorProvincial + " "));
            sb.Append(Convert.ToString("detalle de llamadas: " + this.Llamadas + " "));

            return sb.ToString();
        }
        #endregion

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

    }
}
