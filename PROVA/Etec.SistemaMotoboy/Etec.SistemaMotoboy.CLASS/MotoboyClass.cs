using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etec.SistemaMotoboy.CLASS
{
    public class MotoboyClass
    {
        public int idMotoboy { get; set; }
        public int idFuncionario { get; set; }
        public string nomeMotoboy { get; set; }
        public string rgMotoboy { get; set; }
        public string cpfMotoboy { get; set; }
        public string endMotoboy { get; set; }



        public MotoboyClass() { 
        
        }

        public MotoboyClass(int idMotoboy, int idFuncionario, string nomeMotoboy, string rgMotoboy, string cpfMotoboy, string endMotoboy)
        {
            this.idMotoboy = idMotoboy;
            this.idFuncionario = idFuncionario;
            this.nomeMotoboy = nomeMotoboy;
            this.rgMotoboy = rgMotoboy;
            this.cpfMotoboy = cpfMotoboy;
            this.endMotoboy = endMotoboy;

        }
    }
}
