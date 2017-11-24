using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Etec.SistemaMotoboy.CLASS;
using Etec.SistemaMotoboy.Model;

namespace Etec.SistemaMotoboy.Controller
{
    public class FuncionarioController
    {

        public List<FuncionarioClass> listarFuncionario()
        {
            FuncionarioModel mt = new FuncionarioModel();
            return mt.listarFuncionario();
        }

        public void inserirFuncionario(FuncionarioClass classe)
        {
            FuncionarioModel mt = new FuncionarioModel();
            mt.inserirFuncionario(classe);
        }

        public void atualizarFuncionario(FuncionarioClass classe)
        {
            FuncionarioModel mt = new FuncionarioModel();
            mt.atualizarFuncionario(classe);
        }

        public void excluirFuncionario(int idFuncionario)
        {
            FuncionarioModel mt = new FuncionarioModel();
            mt.excluirFuncionario(idFuncionario);
        }

    }
}
