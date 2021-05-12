using System;
using ClubeLeitura.ConsoleApp.Controladores;
using ClubeLeitura.ConsoleApp.Telas;

namespace ClubeLeitura.ConsoleApp.Telas
{
    public class TelaPrincipal : TelaBase
    {
        protected ControladorCaixa controladorCaixa;
        protected ControladorRevista controladorRevista;
        protected TelaCaixa telaCaixa;
        protected TelaRevista telaRevista;

        public TelaPrincipal(ControladorCaixa ctrlCaixa, ControladorRevista ctrlRevista,
            TelaCaixa tCaixa, TelaRevista tRevista) : base("Clube da Leitura")
        {
            controladorCaixa = ctrlCaixa;
            controladorRevista = ctrlRevista;
            telaCaixa = tCaixa;
            telaRevista = tRevista;
        }

        public IEditavel ObterTela()
        {
            IEditavel telaSelecionada = null;

            ConfigurarTela("O que deseja fazer?");

            Console.WriteLine("Digite 1 para cadastrar caixas");
            Console.WriteLine("Digite 2 para cadastrar revistas");
            Console.WriteLine("Digite 3 para cadastrar amigos");

            Console.WriteLine("Digite S para Sair");

            string opcao = Console.ReadLine();

            if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                Environment.Exit(0);

            if (opcao == "1")
                telaSelecionada = telaCaixa;

            else if (opcao == "2")
                telaSelecionada = telaRevista;

            else if (opcao == "3")
                telaSelecionada = null;

            return telaSelecionada;
        }

    }
}
