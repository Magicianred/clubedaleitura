using System;
using ClubeLeitura.ConsoleApp.Telas;
using ClubeLeitura.ConsoleApp.Controladores;

namespace ClubeLeitura.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ControladorCaixa ctrlCaixa = new ControladorCaixa();
            ControladorRevista ctrlRevista = new ControladorRevista(ctrlCaixa);

            TelaCaixa telaCaixa = new TelaCaixa(ctrlCaixa);
            TelaRevista telaRevista = new TelaRevista(ctrlRevista, telaCaixa);

            TelaPrincipal telaPrincipal = new TelaPrincipal(ctrlCaixa, ctrlRevista, telaCaixa, telaRevista);

            IEditavel telaSelecionada;

            Console.Clear();

            string opcaoCadastro;

            do
            {
                telaSelecionada = telaPrincipal.ObterTela();

                Console.Clear();

                opcaoCadastro = telaSelecionada.ObterOpcao();

                if (opcaoCadastro == "1")
                    telaSelecionada.InserirNovoRegistro(0);

                else if (opcaoCadastro == "2")
                    telaSelecionada.VisualizarRegistros();

                else if (opcaoCadastro == "3")
                    telaSelecionada.EditarRegistro();

                else if (opcaoCadastro == "4")
                {
                    ICadastravel x = (ICadastravel)telaSelecionada;
                    x.ExcluirRegistro();
                }


                Console.Clear();
            } while (telaSelecionada != null);
        }
    }
}
