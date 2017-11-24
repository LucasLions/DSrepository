using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Etec.SistemaMotoboy.CLASS;
using Etec.SistemaMotoboy.Model;

namespace Etec.SistemaMotoboy.Controller
{
    public class MotoboyController
    {

        public List<MotoboyClass> listarMotoboy(){
            MotoboyModel mt = new MotoboyModel();
            return mt.listarMotoboy();
        }

        public void inserirMotoboy(MotoboyClass classe)
        {
            MotoboyModel mt = new MotoboyModel();
            mt.inserirMotoboy(classe);
        }

        public void atualizarMotoboy(MotoboyClass classe)
        {
            MotoboyModel mt = new MotoboyModel();
            mt.atualizarMotoboy(classe);
        }

        public void excluirMotoboy(int idMotoboy)
        {
            MotoboyModel mt = new MotoboyModel();
            mt.excluirMotoboy(idMotoboy);
        }

    }
}
