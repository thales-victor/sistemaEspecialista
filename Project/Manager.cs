using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Project.Estruturas;

namespace Project
{
    public class Manager
    {
        private string DBName = "database.json";
        ToJSONData j_Data;
        class ToJSONData
        {

            public int Fatos_UltimoID;
            public List<Fato> fatos;

            public int resposta_fatos_UltimoID;

            public int resposta_UltimoID;
            public List<Resposta> respostas;

            public int regras_UltimoID;
            public List<Regra> regras;

            public int objetivo_UltimoID;
            public List<Objetivo> objetivo;

            public int condição_UltimoID;
            public List<Condicao> condição;

            public ToJSONData()
            {
                Fatos_UltimoID = 0;
                resposta_fatos_UltimoID = 0;
                resposta_UltimoID = 0;
                regras_UltimoID = 0;
                objetivo_UltimoID = 0;
                condição_UltimoID = 0;

                fatos = new List<Fato>();
                respostas = new List<Resposta>();
                regras = new List<Regra>();
                objetivo = new List<Objetivo>();
                condição = new List<Condicao>();
            }
        }


        public static Manager instance;
        public Manager()
        {
            if(instance != null)
            {
                throw new Exception("Instancia Manager já existe!");
            }
            instance = this;
            j_Data = new ToJSONData();
            LoadAllData();
        }

        public void SaveAllData()
        {
            File.WriteAllText(DBName, JsonConvert.SerializeObject(j_Data, Formatting.Indented));

        }

        public void LoadAllData()
        {
            if (File.Exists(DBName))
                j_Data = JsonConvert.DeserializeObject<ToJSONData>(File.ReadAllText(DBName));
            else
                SaveAllData();
        }


        public Fato GetFatoById(int id)
        {
            if (j_Data.fatos.Count == 0)
                return null;

            var returnvalue = j_Data.fatos.Where(x => x.Id == id);
            if (returnvalue.Count() == 0)
                return null;

            return returnvalue.First();
        }


        public Fato CriarFato(string nome, TipoResposta tipo, List<Resposta> respostas)
        {
            var fato = new Fato(j_Data.Fatos_UltimoID++, nome, tipo, respostas);
            j_Data.fatos.Add(fato);

            SaveAllData();
            return fato;
        }

        public Objetivo ObterObjetivo(string nome)
        {
            if (j_Data.objetivo.Count == 0)
                return null;

            var returnvalue = j_Data.objetivo.Where(x => x.Nome == nome);
            if (returnvalue.Count() == 0)
                return null;

            return returnvalue.First();
        }
        public void CriarObjetivo(string nome, string desc)
        {
            j_Data.objetivo.Add(new Objetivo(j_Data.objetivo_UltimoID++, nome, desc));
            SaveAllData();
        }

        public void RemoverObjetivoIndex(int index)
        {
            if(j_Data.objetivo[index] != null)
                j_Data.objetivo.Remove(j_Data.objetivo[index]);

            SaveAllData();
        }

        public Objetivo[] ListarObjetivos()
        {
            return j_Data.objetivo.ToArray();
        }

        /*
        private Tuple<Fato, RespostaFatos, RespostaFatos, RespostaFatos, RespostaFatos> teste()
        {
            return new Tuple<Fato, RespostaFatos, RespostaFatos, RespostaFatos, RespostaFatos>(null, null, null, null, null);
        }*/

    }
}
