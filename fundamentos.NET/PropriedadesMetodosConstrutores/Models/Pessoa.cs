using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade, string sobrenome)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Sobrenome = sobrenome;

        }
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = this.Nome;
            sobrenome = this.Sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper(); //body expression

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); //prop somente leitura

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}