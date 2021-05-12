using System;
using ClubeLeitura.ConsoleApp.Controladores;
using ClubeLeitura.ConsoleApp.Util;

namespace ClubeLeitura.ConsoleApp.Telas
{
    public abstract class TelaBase
    {
        protected readonly string titulo;

        public TelaBase(string titulo)
        {
            this.titulo = titulo;
        }

        protected void ApresentarMensagem(string mensagem, TipoMensagem tipo)
        {
            switch (tipo)
            {
                case TipoMensagem.Sucesso:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case TipoMensagem.Atencao:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;

                case TipoMensagem.Erro:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                default:
                    break;
            }

            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();
        }
        protected enum TipoMensagem
        {
            Sucesso, Erro, Atencao
        }

        protected void ConfigurarTela(string subtitulo)
        {
            Console.Clear();

            ApresentarTitulo("-------------------------------------------");
            ApresentarTitulo(titulo);
            ApresentarTitulo("-------------------------------------------");
            ApresentarTitulo(subtitulo);
            ApresentarTitulo("-------------------------------------------");
        }

        protected void MensagemPressioneEnter()
        {
            Console.Write("Pressione ENTER para continuar: ");
            Console.ReadLine();
            Console.Clear();
        }

        private void ApresentarTitulo(string titulo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(titulo);
            Console.ResetColor();
        }

        public virtual void MontarCabecalhoTabela()
        {
        }

    }
}
