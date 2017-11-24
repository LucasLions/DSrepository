using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Etec.concessionaria.CLASS;
using Etec.concessionaria.model;

namespace Etec.concessionaria.controller
{
    public class Controller
    {
        public List<Venda> listarVendasController () 
        {
            VendaModel vm = new VendaModel();
            return vm.listarVendas();
        }

        public List<Funcionario> listarFuncionarioController()
        {
            FuncionarioModel fm = new FuncionarioModel();
            return fm.listarFuncionarios();
        }

        public List<Veiculo> listarVeiculosController() 
        {
            VeiculoModel vm = new VeiculoModel();
            return vm.listarVeiculos();
        }

        public List<Cliente> listarClientesController() 
        {
            ClienteModel cm = new ClienteModel();
            return cm.listarClientes();
        }
        
    }
}
