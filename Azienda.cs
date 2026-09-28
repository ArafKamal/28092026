using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _28092026
{
    internal class Azienda
    {
        private string _ragionesociale;
        private Veicolo[] _flotta;
        public string ragionesociale { get; set; }
        public Veicolo[] flotta { get; set; }

        public Azienda()
        {
            _ragionesociale = "Ragione sociale base";
            _flotta = [];
        }
        public Azienda(string ra, Veicolo[] fl)
        {
            if (ra == "")
            {
                throw new ArgumentException("Errore");
            } else
            {
                _ragionesociale = ra;
            }
            _flotta = fl;
        }

        public override string ToString()
        {
            string risultato = "Ragione sociale: " + _ragionesociale + ", Veicoli: {";
            for (int i = 0; i < _flotta.Length; i++)
            {
                risultato += "(" + _flotta[i].modello.ToString() + ", " + _flotta[i].targa.ToString() + ")";
            }
            return risultato + "}";
        }

        public float kilometraggioTotale()
        {
            float somma = 0;
            for (int i = 0; i < _flotta.Length; i++)
            {
                somma += _flotta[i].kilometraggio;
            }
            return somma;
        }

        public float KilometraggioMedio()
        {
            return kilometraggioTotale() / _flotta.Length;
        }

        public Veicolo[] CercaPerCarburante(string ti)
        {
            Veicolo[] risultato = new Veicolo[_flotta.Length];
            int c = 0;

            for (int i = 0; i < _flotta.Length; i++)
            {
                if (_flotta[i].tipocarburante == ti)
                {
                    risultato[c] = _flotta[i];
                    c++;
                }
            }
            return risultato;
        }
    }
}
