using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubeLeitura.ConsoleApp.Controladores;

namespace ClubeLeitura.ConsoleApp.Telas
{
    public class TelaEmprestimo : TelaBase, ICadastravel
    {
        private readonly ControladorEmprestimo ctrlEmprestimo;

        public TelaEmprestimo(ControladorEmprestimo ctrlEmprestimo) : base("Cadastro de Empréstimos")
        {
            this.ctrlEmprestimo = ctrlEmprestimo;
        }

        public void InserirNovoRegistro(int id)
        {
            throw new NotImplementedException();
        }

        public void ObterOpcao()
        {
            throw new NotImplementedException();
        }

        public void VisualizarRegistros()
        {
            throw new NotImplementedException();
        }

        public void MontarCabecalhoTabela()
        {
            throw new NotImplementedException();
        }

        string ICadastravel.ObterOpcao()
        {
            throw new NotImplementedException();
        }
    }
}
