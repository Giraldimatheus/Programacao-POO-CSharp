using ByteBank3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank3
{
    internal class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonicacao()
        {
            return _totalBonificacao;
        }




    }
}
