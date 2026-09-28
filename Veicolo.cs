using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _28092026
{
    internal class Veicolo
    {
        private string _targa;
        private string _modello;
        private string _dataultimarevisione;
        private string _tipocarburante;
        private float _kilometraggio;
        public string targa { get; set; }
        public string modello { get; set; }
        public string dataultimarevisione { get; set; }
        public string tipocarburante { get; set; }
        public float kilometraggio { get; set; }
        public Veicolo()
        {
            _targa = "00000000"; // targa base
            _modello = "Modello base"; // modello base
            _dataultimarevisione = "Mai effettuata"; // data base
            _tipocarburante = "Benzina"; // carburante base
            _kilometraggio = 0; // valore base
        }

        public Veicolo (string ta, string mo, string da, string ti, float ki)
        {
            if (ta.Length != 8)
            {
                throw new ArgumentException("Errore");
            } 
            else
            {
                _targa = ta;
            }

            if (mo.Length <= 0)
            {
                throw new ArgumentException("Errore");
            }
            else
            {
                _modello = mo;
            }

            if (da != "" && da.Length != 8)
            {
                throw new ArgumentException("Errore");
            }
            else if (da == "")
            {
                _dataultimarevisione = "Mai effettuata";
            }
            else
            {
                _dataultimarevisione = da;
            }

            if (ti != "Benzina" && ti != "Diesel" && ti != "Elettrica" && ti != "Ibrida")
            {
                throw new ArgumentException("Errore");
            } 
            else
            {
                _tipocarburante = ti;
            }
            
            if (ki < 0)
            {
                throw new ArgumentException("Errore");
            } 
            else
            {
                _kilometraggio = ki;
            }
        }

        public override string ToString()
        {
            return "Targa: " + _targa + ", Modello: " + _modello + ", Data ultima revisione: " + _dataultimarevisione + ", Tipo carburante: " + _tipocarburante + ", kilometraggio: " + _kilometraggio + ".";
        }
    }
}
