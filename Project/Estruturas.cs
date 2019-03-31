using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Estruturas
{
    public class Fato
    {
        public int Id;
        public string Nome;
        public TipoResposta Tipo;
        public List<Resposta> Respostas = new List<Resposta>();

        public Fato(int id, string nome, TipoResposta tipo, Resposta[] respostas)
        {
            Nome = nome;
            Id = id;
            Tipo = tipo;
            Respostas = new List<Resposta>(respostas);
        }

        public Resposta[] ListarRespostas()
        {
            return this.Respostas.ToArray();
        }
    }

    public class Resposta
    {
        public int Id;
        public string Descricao;
        public int Valor;

        public Resposta(int id, string desc)
        {
            this.Id = id;
            Descricao = desc;
        }
        public Resposta(int id, int num)
        {
            this.Id = id;
            Valor = num;
        }

        public Resposta()
        {

        }
    }

    public class Regra
    {
        public int Id;
        public string Nome;
        public List<Condicao> Condicao = new List<Condicao>();
        public List<CondicaoObjetivo> condicaoObjetivos = new List<CondicaoObjetivo>();
        public Regra(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Regra(int id)
        {
            Id = id;
        }

        public Regra()
        {
        }

        public void Save()
        {
            Id = Manager.instance.IncrementRegraIndex();
        }

        public void AdicionarCondicao(bool primeiro, Conectivo con, Fato f, Operador o, Resposta r)
        {
            Condicao.Add(new Condicao()
            {
                Conectivo = con,
                Fato = f,
                Operador = o,
                Resposta = r,
                Primeiro = primeiro
            });

            InserirPrimeiraCond();
        }

        public void RemoverCondicao(Condicao c)
        {
            if(c == null) return;

            Condicao.Remove(c);

            InserirPrimeiraCond();
        }

        public void InserirPrimeiraCond()
        {
            if (Condicao.Count() == 0)
                return;

            for(int i = 0; i < Condicao.Count(); i++)
            {
                var item = Condicao[i];
                if (i == 0)
                    item.Primeiro = true;
                else
                    item.Primeiro = false;

            }
        }

        public void CondicaoObjetivo(Fato f, Operador o, Resposta r)
        {
            condicaoObjetivos.Add(new CondicaoObjetivo()
            {
                Fato = f,
                Operador = o,
                Resposta = r,
            });
        }

        public void RemoverCondicaoObjetivo(CondicaoObjetivo c)
        {
            if (c == null) return;

            condicaoObjetivos.Remove(c);
        }

        public CondicaoObjetivo[] ListarCondicaoObjetivos()
        {
            return condicaoObjetivos.ToArray();
        }



        public Fato[] ListarCondObjetivoFatos()
        {
            return condicaoObjetivos.ToArray().Select(x => x.Fato).ToArray();
        }
    }

    public class Condicao
    {
        public Conectivo Conectivo;
        public Fato Fato;
        public Operador Operador;
        public Resposta Resposta;
        public bool Primeiro;
    }

    public class CondicaoObjetivo
    {
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
        Igual,
        Diferente,
        Maior,
        Menor,
        Maior_Igual,
        Menor_Igual
    }


    public class Util
    {
        public static string ParseOperador(Estruturas.Operador op)
        {
            switch (op)
            {
                case Estruturas.Operador.Maior:
                    return ">";
                    break;
                case Estruturas.Operador.Menor:
                    return "<";
                    break;
                case Estruturas.Operador.Igual:
                    return "=";
                    break;
                case Estruturas.Operador.Diferente:
                    return "<>";
                    break;
                case Estruturas.Operador.Maior_Igual:
                    return ">=";
                    break;
                case Estruturas.Operador.Menor_Igual:
                    return "<=";
                    break;
                default:
                    return "error";
                    break;
            }
        }


        static public string[] ListarOperadores(TipoResposta tipo)
        {
            List<string> str = new List<string>();

            var OperadorMax = Operador.Igual; // = 0;

            if (tipo == TipoResposta.Numerico)
            {
                OperadorMax = Operador.Menor_Igual;
            }
            else
            {
                OperadorMax = Operador.Diferente;
            }


            for (int i = 0; i < (int)OperadorMax+1; i++)
            {
                str.Add(ParseOperador((Operador)i));
            }

            return str.ToArray();
        }
    }
}
