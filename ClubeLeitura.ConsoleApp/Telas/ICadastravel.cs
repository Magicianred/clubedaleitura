using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp.Telas
{
    public interface ICadastravel
    {
        void InserirNovoRegistro(int id);
        void VisualizarRegistros();
        void MontarCabecalhoTabela();
        string ObterOpcao();
    }
}
