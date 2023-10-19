using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<String> _historico;

        public Calculadora()
        {
            _historico = new List<String>();
        }
        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            _historico.Insert(0, "Res: " + resultado);
            return resultado;
        }
        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            _historico.Insert(0, "Res: " + resultado);
            return resultado;
        }
        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            _historico.Insert(0, "Res: " + resultado);
            return resultado;
        }
        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            _historico.Insert(0, "Res: " + resultado);
            return resultado;
        }
        
        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }

    }
}
