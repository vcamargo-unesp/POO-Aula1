using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aula1_2
{
    public class Aluno
    {
        private string nome;
        public double nota;
        //ATRIBUTOS - características

        public string? Nome
        {
            get => this.nome.ToUpper();
            set
            {
                if (value != null && value != "")
                    this.nome = value;
            }
        }
        //PROPRIEDADES - validações

        public Aluno(string nome)
        {
            this.nome = nome;
        }
        public Aluno(string nome, double nota)
        {
            this.nome = nome;
            this.nota = nota;
        }
        public Aluno() { }
        //Construtor
        public bool Verificar(double n)
        {
            return nota >= n;
        }
        //MÉTODO - Ação
    }
}
