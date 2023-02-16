using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários vão ser registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionário> list = new List<Funcionário>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionário(id, nome, salario));
                Console.WriteLine();
            }
            Console.WriteLine("Informe o id do funcionário que terá aumento: ");
            int searchid = int.Parse(Console.ReadLine());

            Funcionário emp = list.Find(x => x.id == searchid);
            if (emp != null)
            {
                Console.Write("Digite a Porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalario(percentage);
            }
            else
            {
                Console.WriteLine("Esse id não existe: ");
            }
            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada: ");
            foreach (Funcionário obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}