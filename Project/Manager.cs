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
           // public List<RespostaFatos> resposta_Fatos;

            public int resposta_UltimoID;
            public List<Resposta> respostas;

            public int regras_UltimoID;
            public List<Regra> regras;

            public int objetivo_UltimoID;
            public List<Objetivo> objetivo;

            public int condição_UltimoID;
            public List<Condição> condição;

            //public int lista_condição_UltimoID;
           // public List<ListaCondição> listaCondiçãos;

            public ToJSONData()
            {
                Fatos_UltimoID = 0;
                resposta_fatos_UltimoID = 0;
                resposta_UltimoID = 0;
                regras_UltimoID = 0;
                objetivo_UltimoID = 0;
                condição_UltimoID = 0;
                //lista_condição_UltimoID = 0;

                fatos = new List<Fato>();
               // resposta_Fatos = new List<RespostaFatos>();
                respostas = new List<Resposta>();
                regras = new List<Regra>();
                objetivo = new List<Objetivo>();
                condição = new List<Condição>();
                //listaCondiçãos = new List<ListaCondição>();
            }
        }

        public Manager()
        {
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
            return j_Data.fatos.Where(x => x.id == id).First();
        }

        public List<Resposta> GetRespostaFatosById(int id)
        {
            return j_Data.resposta_Fatos.Where(x => x.id == id).First();
        }


        public Fato CriarFato(string nome, E_T_RespostaFato tipo, string resposta)
        {
            var fato = new Fato(j_Data.Fatos_UltimoID++, nome);
            j_Data.fatos.Add(fato);


            var r_fato = new RespostaFatos(j_Data.resposta_fatos_UltimoID++, fato.id, tipo);
            j_Data.resposta_Fatos.Add(r_fato);

            var list_r = new Resposta(j_Data.resposta_UltimoID++, r_fato.id, resposta);
            j_Data.respostas.Add(list_r);

            return fato;
        }


        /*
        private Tuple<Fato, RespostaFatos, RespostaFatos, RespostaFatos, RespostaFatos> teste()
        {
            return new Tuple<Fato, RespostaFatos, RespostaFatos, RespostaFatos, RespostaFatos>(null, null, null, null, null);
        }*/

    }
}
