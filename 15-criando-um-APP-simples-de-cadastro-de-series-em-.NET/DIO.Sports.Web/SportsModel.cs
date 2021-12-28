using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Sports.Web
{
    public class SportsModel
    {
        public int Id { get; set; }
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }


        public SportsModel() { }


        public SportsModel(Sports sports)
        { 
            Id = sports.retornaId();
            Genero = sports.retornaGenero();
            Titulo = sports.retornaTitulo();
            Descricao = sports.retornaDescricao();
            Ano = sports.retornaAno();
            Excluido = sports.retornaExcluido();
            
        }

        public Sports ToSports()
        {
            return new Sports(Id, Genero, Titulo, Descricao, Ano);

        }
    }
}
