using System;
using System.Text;

namespace dio_Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido {get; set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Gênero: " + this.Genero + Environment.NewLine);
            str.Append("Título: " + this.Titulo + Environment.NewLine);
            str.Append("Descrição: " + this.Descricao + Environment.NewLine);
            str.Append("Ano de Início: " + this.Ano);
            return str.ToString();
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaID()
        {
            return this.id;
        }
        public bool retornaExcluido()
		{
			return this.Excluido;
		}

        public void Excluir()
        {
            this.Excluido = true;
        }
    }


}