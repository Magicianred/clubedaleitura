using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp.Telas
{
    public interface IEditavel
    {
        void InserirNovoRegistro(int id);
        void EditarRegistro();
        void ExcluirRegistro();
        void VisualizarRegistros();
        string ObterOpcao();
    }
}
