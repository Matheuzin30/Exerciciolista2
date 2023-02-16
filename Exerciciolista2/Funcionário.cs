using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    internal class Funcionário
    {
        public int id { get; set; }
        public string Nome { get; set; }

        public double Salario { get; private set; }

        public Funcionário(int id, string nome, double salario)
        {
            this.id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncreaseSalario(double percentage)
        {
            Salario = Salario * percentage / 100;
        }

        public override string ToString()
        {
            return id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
