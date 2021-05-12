using System;
using ClubeLeitura.ConsoleApp.Util;

namespace ClubeLeitura.ConsoleApp.Dominio
{
    public class Caixa : Entidade
    {
        public int id;
        //public int numero;
        public string cor;
        public string etiqueta;
        public Revista[] revistas;

        public Caixa()
        {
            id = GerarIdCaixa();
        }

        public Caixa(int id)
        {
            this.id = id;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            Caixa caixa = (Caixa)obj;

            if (caixa != null && caixa.id == this.id)
                return true;

            return false;
        }
    }
}
