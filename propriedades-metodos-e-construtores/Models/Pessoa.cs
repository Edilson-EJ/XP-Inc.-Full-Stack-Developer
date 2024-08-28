using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos_e_construtores.Models
{
    public class Pessoa
    {
        private string _nome;     
        private int _idade;

        public string Nome { 

            get{
                return _nome.ToUpper();
            } 

            set{
                if (value == ""){
                    throw new ArgumentException("o nome não pode ser vazio");
                }

                _nome = value;
            } 

            }
        public int Idade { 
            get{
                return _idade;
            } 

            set{
                if (value < 0){
                    throw new ArgumentException("Idade não pode ser menor que zero");
                }

                _idade = value;
            }
            
             }

        public void Apresentar(){
            Console.WriteLine($"nome: {Nome} e {Idade}");
        }
    }
}