using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Estruturas
{
    /*
     * FATOS
     */
    public class Fato
    {
        public int Id;
        public string Nome;
        public TipoResposta Tipo;
        public List<Resposta> Respostas;
        public Fato(int id, string nome, TipoResposta tipo, List<Resposta> respostas)
        {
            Nome = nome;
            Id = id;
            Tipo = tipo;
            Respostas = respostas;
        }
    }

    public class Resposta
    {
        public int Id;
        public string Descricao;

        public Resposta(int id, string desc)
        {
            this.Id = id;
            this.Descricao = desc;
        }
    }

    public class Regra
    {
        public int Id;
        public string Nome;
        public List<Condicao> Condicao;
        public List<Objetivo> Objetivo;
        public Regra(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }

    public class Objetivo
    {
        public int Id;
        public string Nome;
        public string Descricao;

        public Objetivo(int id, string nome, string desc)
        {
            Id = id;
            Nome = nome;
            Descricao = desc;
        }
    }

    public class Condicao
    {
        public int Id;
        public Conectivo Conectivo;
        public Fato Fato;
        public Operador Operador;
        public Resposta Resposta;
    }

    public enum TipoResposta
    {
        Univalorado,
        Multivalorado,
        Numerico,
    }

    public enum Conectivo
    {
        E,
        OU,
    }

    public enum Operador
    {
        Maior,
        Menor,
        Igual,
        Diferente,
        Maior_Igual,
        Menor_Igual
    }
}
