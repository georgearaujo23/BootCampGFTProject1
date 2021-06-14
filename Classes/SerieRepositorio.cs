using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie  = new List<Serie>();

         public List<Serie> Listar()
         {
             return listaSerie;
         }

         public Serie RetornarPorId(int id)
         {
             return listaSerie[id];
         }

         public void Inserir(Serie entidade)
         {
             listaSerie.Add(entidade);
         }

         public void Excluir(int id)
         {
             listaSerie[id].Excluir();
         }

         public void Atualizar(int id, Serie entidade)
         {
             listaSerie[id] = entidade;
         }

         public int ProximoId()
         {
             return listaSerie.Count;
         }
    }
}