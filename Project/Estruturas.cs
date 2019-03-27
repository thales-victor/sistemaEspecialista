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
        public E_T_RespostaFato Tipo;
        public List<Resposta> Respostas;
        public Fato(int id, string nome, E_T_RespostaFato tipo, List<Resposta> respostas)
        {
            Nome = nome;
            Id = id;
            Tipo = tipo;
            Respostas = respostas;
        }
    }

    public class Resposta
    {
        public int id;
        public string desc;

        public Resposta(int id, string desc)
        {
            this.id = id;
            this.desc = desc;
        }
    }

    public enum E_T_RespostaFato
    {
        Univalorado,
        Multivalorado,
        Numerico,
    }


    public class Regra
    {
        public int id;
        public string nome;
        public List<Condição> Condição;
        public List<Objetivo> Objetivo;
        public Regra(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }


    public class Objetivo
    {
        public int id;
        public string nome;
        public string desc;

        public Objetivo(int id, string nome, string desc)
        {
            this.id = id;
            this.nome = nome;
            this.desc = desc;
        }
    }


    public class Condição
    {
        public int id;
        public Conectivo con;
        public Fato Fato;
        public Operador operador;
        public Resposta Resposta;
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
