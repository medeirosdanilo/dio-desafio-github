using System;
using System.Collections.Generic;
using DIO.Sports.Interfaces;

namespace DIO.Sports
{
    public class SportsRepositorio : IRepositorio<Sports>
    {
        private List<Sports> listaSports = new List<Sports>();  
        public void Atualiza(int id, Sports entidade)
        {
            listaSports[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSports[id].Excluir();
        }

        public void Insere(Sports entidade)
        {
            listaSports.Add(entidade);
        }

        public List<Sports> Lista()
        {
            return listaSports;
        }

        public int ProximoId()
        {
            return listaSports.Count;
        }

        public Sports RetornaPorId(int id)
        {
            return listaSports[id];
        }
    }
}