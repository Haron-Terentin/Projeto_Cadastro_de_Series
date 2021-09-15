using System;
using System.Collections.Generic;
using DIO.Series.Interface;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            throw new NotimplementedException();
        }

        public List<Serie> Lista()
        {
            throw new NotimplementedException();
        }

        public int ProximoId()
        {
            throw new NotimplementedException();
        }

        public Serie RetornaPorId(int id)
        {
            throw new NotimplementedException();
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}