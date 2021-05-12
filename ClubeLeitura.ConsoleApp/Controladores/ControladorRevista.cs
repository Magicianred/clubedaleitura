using System;
using ClubeLeitura.ConsoleApp.Dominio;

namespace ClubeLeitura.ConsoleApp.Controladores
{
    public class ControladorRevista : ControladorBase
    {
        private ControladorCaixa ctrlCaixa;

        public ControladorRevista(ControladorCaixa ctrlCaixa)
        {
            this.ctrlCaixa = ctrlCaixa;
        }

        public string RegistrarRevista(int id, string tipoColecao, int numeroEdicao, int ano, int idCaixaRevista)
        {
            Revista novaRevista;
            int posicao;

            if (id == 0)
            {
                posicao = ObterPosicaoVazia();
                novaRevista = new Revista();
            }
            else
            {
                posicao = ObterPosicaoExistente(new Revista(id));
                novaRevista = (Revista)registros[posicao];
            }

            novaRevista.tipoColecao = tipoColecao;
            novaRevista.numeroEdicao = numeroEdicao;
            novaRevista.ano = ano;
            novaRevista.caixa = ctrlCaixa.SelecionarCaixaPorId(idCaixaRevista);

            string resultadoValidacao = novaRevista.Validar();

            if (resultadoValidacao == "REVISTA_VALIDA")
                registros[posicao] = novaRevista;

            return resultadoValidacao;
        }

        public Revista[] SelecionarTodasRevistas()
        {
            object[] arrayAux = SelecionarTodosRegistros();

            Revista[] revistas = new Revista[arrayAux.Length];

            Array.Copy(arrayAux, revistas, arrayAux.Length);

            return revistas;
        }

        public Revista SelecionarRevistaPorId(int id)
        {
            return (Revista)SelecionarRegistroPorId(new Revista(id));
        }
    }
}
