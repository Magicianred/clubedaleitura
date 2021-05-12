using System;
using ClubeLeitura.ConsoleApp.Controladores;
using ClubeLeitura.ConsoleApp.Dominio;

namespace ClubeLeitura.ConsoleApp.Telas
{
    public class TelaRevista : TelaBase, IEditavel
    {
        private ControladorRevista ctrlRevista;

        private TelaCaixa telaCaixa;

        public TelaRevista(ControladorRevista ctrlRevista, TelaCaixa telaCaixa) : base("Cadastro de Revistas")
        {
            this.ctrlRevista = ctrlRevista;
            this.telaCaixa = telaCaixa;
        }

        public void InserirNovoRegistro(int id)
        {
            ConfigurarTela("Registrando uma nova revista...");

            Console.Write("Digite o nome da coleção da revista: ");
            string tipoColecao = Console.ReadLine();

            Console.Write("Digite o número da edição da revista: ");
            int numeroEdicao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o ano da revista: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            telaCaixa.VisualizarRegistros();

            Console.Write("Digite a caixa em que a revista está guardada: ");
            int idCaixaRevista = Convert.ToInt32(Console.ReadLine());

            string resultadoValidacao = ctrlRevista.RegistrarRevista(id, tipoColecao, numeroEdicao, ano, idCaixaRevista);

            if (resultadoValidacao == "REVISTA_VALIDA")
                ApresentarMensagem("Registro feito com sucesso!", TipoMensagem.Sucesso);
            else
            {
                ApresentarMensagem(resultadoValidacao, TipoMensagem.Erro);
            }

            Console.Clear();
        }

        public void EditarRegistro()
        {
            ConfigurarTela("Editando uma revista...");

            Console.Write("Digite o ID da revista que deseja editar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            InserirNovoRegistro(id);
        }

        public string ObterOpcao()
        {
            ConfigurarTela("Visualizando opções...");

            Console.WriteLine("1 - Registrar nova revistas");
            Console.WriteLine("2 - Visualizar revistas registradas");
            Console.WriteLine("3 - Editar revistas registradas");
            Console.WriteLine("S - Voltar para o início");

            string strOpcao = Console.ReadLine();

            return strOpcao;
        }

        public void MontarCabecalhoTabela()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("{0,-4} | {1,-20} | {2,-20} | {3, -4}", "Id", "Coleção", "Ano", "Caixa");

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
        }

        public void VisualizarRegistros()
        {
            ConfigurarTela("Visualizando registros...");
            MontarCabecalhoTabela();

            Revista[] revistas = ctrlRevista.SelecionarTodasRevistas();

            foreach (Revista revista in revistas)
            {
                Console.WriteLine("{0,-4} | {1,-20} | {2,-15} | {3, -5}", revista.id, revista.tipoColecao, revista.ano, revista.caixa.id);

                Console.WriteLine();
            }

            if (revistas.Length == 0)
                ApresentarMensagem("Nenhum registro encontrado!", TipoMensagem.Atencao);

            Console.ReadLine();
        }

    }
}
