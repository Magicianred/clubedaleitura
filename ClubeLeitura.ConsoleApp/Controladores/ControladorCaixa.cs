using System;
using ClubeLeitura.ConsoleApp.Dominio;

namespace ClubeLeitura.ConsoleApp.Controladores
{
    public class ControladorCaixa : ControladorBase
    {
        public bool RegistrarCaixa(int id, string cor, string etiqueta)
        {
            Caixa novaCaixa;
            int posicao;

            if (id == 0)
            {
                posicao = ObterPosicaoVazia();
                novaCaixa = new Caixa();
            }
            else
            {
                posicao = ObterPosicaoExistente(new Caixa(id));
                novaCaixa = (Caixa)registros[posicao];
            }

            novaCaixa.cor = cor;
            novaCaixa.etiqueta = etiqueta;

            registros[posicao] = novaCaixa;

            return true;
        }

        public Caixa[] SelecionarTodasCaixas()
        {
            object[] arrayAux = SelecionarTodosRegistros();

            Caixa[] caixas = new Caixa[arrayAux.Length];

            Array.Copy(arrayAux, caixas, arrayAux.Length);

            return caixas;
        }

        public Caixa SelecionarCaixaPorId(int id)
        {
            return (Caixa)SelecionarRegistroPorId(new Caixa(id));
        }
    }
}
