using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Etec.SistemaMotoboy.CLASS;
using Etec.SistemaMotoboy.Model;

namespace Etec.SistemaMotoboy.Controller
{
    public class ClienteController
    {

        public List<ClienteClass> listarCliente()
        {
            ClienteModel mt = new ClienteModel();
            return mt.listarCliente();
        }

        public void inserirCliente(ClienteClass classe)
        {
            ClienteModel mt = new ClienteModel();
            mt.inserirCliente(classe);
        }

        public void atualizarCliente(ClienteClass classe)
        {
            ClienteModel mt = new ClienteModel();
            mt.atualizarCliente(classe);
        }

        public void excluirCliente(int idCliente)
        {
            ClienteModel mt = new ClienteModel();
            mt.excluirCliente(idCliente);
        }


    }
}
