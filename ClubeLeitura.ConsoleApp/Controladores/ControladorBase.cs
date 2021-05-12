using System;


namespace ClubeLeitura.ConsoleApp.Controladores
{
    public class ControladorBase
    {
        private const int TAMANHO_MAXIMO = 20;

        protected object[] registros = null;

        public ControladorBase()
        {
            registros = new object[TAMANHO_MAXIMO];
        }

        protected object[] SelecionarTodosRegistros()
        {
            object[] registrosAux = new object[QtdRegistrosCadastrados(registros)];

            int i = 0;

            foreach (object registro in registros)
            {
                if (registro != null)
                    registrosAux[i++] = registro;
            }

            return registrosAux;
        }

        protected object SelecionarRegistroPorId(object obj)
        {
            object objAux = null;

            for (int i = 0; i < registros.Length; i++)
            {
                if (registros[i] != null && registros[i].Equals(obj))
                {
                    objAux = registros[i];
                    break;
                }
            }

            return objAux;
        }

        protected int ObterPosicaoVazia()
        {
            int posicao = 0;

            for (int i = 0; i < registros.Length; i++)
            {
                //retorna uma posição para inserir equipamento
                if (registros[i] == null)
                {
                    posicao = i;
                    break;
                }
            }

            return posicao;
        }

        protected int ObterPosicaoExistente(object obj)
        {
            int posicao = 0;

            for (int i = 0; i < registros.Length; i++)
            {
                //retorna uma posição de um equipamento existente
                if (registros[i] != null && registros[i].Equals(obj)) //editando...
                {
                    posicao = i;
                    break;
                }
            }

            return posicao;
        }

        #region Métodos Privados

        private int QtdRegistrosCadastrados(object[] arrayObj)
        {
            int numeroRegistros = 0;

            for (int i = 0; i < arrayObj.Length; i++)
            {
                if (arrayObj[i] != null)
                    numeroRegistros++;
            }

            return numeroRegistros;
        }

        #endregion
    }
}

