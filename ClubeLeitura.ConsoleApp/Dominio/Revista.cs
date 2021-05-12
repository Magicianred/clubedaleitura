using System;
using ClubeLeitura.ConsoleApp.Util;

namespace ClubeLeitura.ConsoleApp.Dominio
{
    public class Revista : Entidade
    {
        public int id;
        public string tipoColecao;
        public int numeroEdicao;
        public int ano;
        public Caixa caixa;

        public Revista()
        {
            id = GerarIdRevista();
        }

        public Revista(int id)
        {
            this.id = id;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            Revista rev = (Revista)obj;

            if (rev != null && rev.id == this.id)
                return true;

            return false;
        }

        public string Validar()
        {
            string resultadoValidacao = "";

            if (caixa == null)
                resultadoValidacao += "O ID da caixa informada não existe\n";

            if (string.IsNullOrEmpty(resultadoValidacao))
                resultadoValidacao = "REVISTA_VALIDA";

            return resultadoValidacao;
        }
    }
}
