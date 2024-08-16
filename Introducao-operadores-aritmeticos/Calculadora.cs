using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introducao_operadores_aritmeticos
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y){
            double potencia = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {potencia}");
        }
    }
}