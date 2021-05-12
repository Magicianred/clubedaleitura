using System;
using ClubeLeitura.ConsoleApp.Util;

namespace ClubeLeitura.ConsoleApp.Dominio
{
    public class Amigo : Entidade
    {
        public int id;
        public string nome;
        public string nomeResponsavel;
        public string telefone;
        public string endereco;
        public Emprestimo[] emprestimos;

        public Amigo()
        {
            id = GerarIdAmigo();
        }

        public Amigo(int id)
        {
            this.id = id;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            Amigo amigo = (Amigo)obj;

            if (amigo != null && amigo.id == this.id)
                return true;

            return false;
        }

    }
}
