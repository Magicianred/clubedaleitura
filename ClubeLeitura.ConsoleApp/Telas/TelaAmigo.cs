using System;
using ClubeLeitura.ConsoleApp.Controladores;

namespace ClubeLeitura.ConsoleApp.Telas
{
    public class TelaAmigo : TelaBase
    {
        private readonly ControladorAmigo ctrlCrianca;

        public TelaAmigo(ControladorAmigo ctrlCrianca) : base("Cadastro de Crianças")
        {
            this.ctrlCrianca = ctrlCrianca;
        }

        public void InserirNovoRegistro(int id)
        {
            throw new NotImplementedException();
        }

        public override void MontarCabecalhoTabela()
        {
            throw new NotImplementedException();
        }

        public void VisualizarRegistros()
        {
            throw new NotImplementedException();
        }

        public string ObterOpcao()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            throw new NotImplementedException();
        }
    }
}
