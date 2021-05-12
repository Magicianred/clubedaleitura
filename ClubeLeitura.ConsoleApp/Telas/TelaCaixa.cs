using System;
using ClubeLeitura.ConsoleApp.Controladores;
using ClubeLeitura.ConsoleApp.Dominio;

namespace ClubeLeitura.ConsoleApp.Telas
{
    public class TelaCaixa : TelaBase, IEditavel
    {
        private readonly ControladorCaixa ctrlCaixa;

        public TelaCaixa(ControladorCaixa ctrlCaixa) : base("Cadastro de Caixas")
        {
            this.ctrlCaixa = ctrlCaixa;
        }

        public string ObterOpcao()
        {
            ConfigurarTela("Visualizando opções...");

            Console.WriteLine("1 - Registrar nova caixa");
            Console.WriteLine("2 - Visualizar caixas registradas");
            Console.WriteLine("3 - Editar caixas registradas");
            Console.WriteLine("S - Voltar para o início");
            Console.WriteLine("-------------------------------------------");
            Console.Write("O que deseja fazer?");

            string strOpcao = Console.ReadLine();

            return strOpcao;
        }

        public void InserirNovoRegistro(int id)
        {
            ConfigurarTela("Registrando uma nova revista...");

            Console.Write("Digite a cor da caixa: ");
            string cor = Console.ReadLine();

            Console.Write("Digite a etiqueta da caixa: ");
            string etiqueta = Console.ReadLine();

            bool conseguiuRegistrar = ctrlCaixa.RegistrarCaixa(id, cor, etiqueta);

            if (conseguiuRegistrar)
                ApresentarMensagem("Registro concluído com sucesso!", TipoMensagem.Sucesso);
            else
            {
                ApresentarMensagem("Falha ao registrar!", TipoMensagem.Erro);
                InserirNovoRegistro(id);
            }
        }

        public void EditarRegistro()
        {
            ConfigurarTela("Editando uma caixa...");

            VisualizarRegistros();

            Console.Write("Digite o ID da caixa que deseja editar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            InserirNovoRegistro(id);
        }

        public void ExcluirRegistro()
        {
            throw new NotImplementedException();
        }

        public override void MontarCabecalhoTabela()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("{0,-4} | {1,-20} | {2,-20}", "Id", "Cor", "Etiqueta");

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
        }

        public void VisualizarRegistros()
        {
            ConfigurarTela("Visualizando registros...");

            MensagemPressioneEnter();

            MontarCabecalhoTabela();

            Caixa[] caixas = ctrlCaixa.SelecionarTodasCaixas();

            foreach (Caixa caixa in caixas)
            {
                Console.WriteLine("{0,-4} | {1,-20} | {2,-20}", caixa.id, caixa.cor, caixa.etiqueta);

                Console.WriteLine();
            }

            if (caixas.Length == 0)
                ApresentarMensagem("Nenhum registro encontrado!", TipoMensagem.Atencao);

            Console.ReadLine();
        }

    }

}
