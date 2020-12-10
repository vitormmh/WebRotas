using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace WebRotas.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }
        [DisplayFormat(DataFormatString = "{0://dd/MM/yyyy}")]
        public DateTime Data { get; set; }


        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
        {
                    new Noticia {
                    NoticiaId = 1,
                    Titulo = "Ronaldo Campeão",
                    Categoria = "Desporto",
                    Conteudo = "Cristiano Ronaldo consagrou-se novamente campeão mundial e o melhor goleador",
                    Data = new DateTime(2019, 12, 3)
                    },
                 new Noticia
                 {
                     NoticiaId = 2,
                     Titulo = "Presidente prepara nova candidatura",
                     Categoria = "Politica",
                     Conteudo = "O Presidente da Republica prepara nova candidatura para o segundo mandato",
                     Data = new DateTime(2019, 11, 5)
                 },
                  new Noticia
                  {
                      NoticiaId = 3,
                      Titulo = "Presidente prepara nova candidatura",
                      Categoria = "Politica",
                      Conteudo = "O Presidente da Republica prepara nova candidatura para o segundo mandato",
                      Data = new DateTime(2019, 11, 5)
                  },

                      new Noticia
                      {
                          NoticiaId = 4,
                          Titulo = "Tanto para saber e em tão pouco tempo",
                          Categoria = "Atualidade",
                          Conteudo = "O Tempo é inimigo da perfeição... Se eu quiser aprender tenho que trabalhar e dedicarme totalmente, depois como sei que sou capaz, os resultados hão-de vir  ",
                          Data = new DateTime(2019, 12, 10)
                      }


        };
            return retorno;
        }

    }
}