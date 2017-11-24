using System.Collections.Generic;
using Etec.SistemaMotoboy.CLASS;
using Etec.SistemaMotoboy.Model;
namespace Etec.SistemaMotoboy.Controller
{
    public class EntregaController
    {

        public List<EntregaClass> listarEntrega()
        {
            EntregaModel mt = new EntregaModel();
            return mt.listarEntrega();
        }

        public void inserirEntrega(EntregaClass classe)
        {
            EntregaModel mt = new EntregaModel();
            mt.inserirEntrega(classe);
        }

        public void atualizarEntrega(EntregaClass classe)
        {
            EntregaModel mt = new EntregaModel();
            mt.atualizarEntrega(classe);
        }

        public void excluirEntrega(int idEntrega)
        {
            EntregaModel mt = new EntregaModel();
            mt.excluirEntrega(idEntrega);
        }

    }
}
