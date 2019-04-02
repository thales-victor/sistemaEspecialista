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

            public int regras_UltimoID;
            public List<Regra> regras;

            public int condição_UltimoID;
            public List<Condicao> condição;

            public List<Fato> ObjetivosAlvo;

            public ToJSONData()
            {
                Fatos_UltimoID = 0;
                resposta_fatos_UltimoID = 0;
                regras_UltimoID = 0;
                condição_UltimoID = 0;

                fatos = new List<Fato>();
                regras = new List<Regra>();
                condição = new List<Condicao>();
                ObjetivosAlvo = new List<Fato>();
            }
        }


        public int IncrementRegraIndex()
        {
            return j_Data.regras_UltimoID++;
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

        public Fato FindFatoByName(string name)
        {
            if (j_Data.fatos.Count == 0)
                return null;

            var returnvalue = j_Data.fatos.Where(x => x.Nome == name);
            if (returnvalue.Count() == 0)
                return null;

            return returnvalue.First();
        }


        public Fato CriarFato(string nome, TipoResposta tipo, Resposta[] respostas)
        {
            var fato = new Fato(j_Data.Fatos_UltimoID++, nome, tipo, respostas);
            j_Data.fatos.Add(fato);

            SaveAllData();
            return fato;
        }

        public Fato[] ListarFatos()
        {
            return j_Data.fatos.ToArray();
        }


        public Fato[] ListarAlvos()
        {
            return j_Data.ObjetivosAlvo.ToArray();
        }

        public void AtualizarAlvos(Fato[] alvos)
        {
            j_Data.ObjetivosAlvo.Clear();
            j_Data.ObjetivosAlvo.AddRange(alvos);
        }

        public Regra[] ListarRegras()
        {
            return j_Data.regras.ToArray();
        }

        public void AdicionarRegra(Regra regra)
        {
            j_Data.regras.Add(regra);
            SaveAllData();
        }

        public void RemoverRegra(Regra regra)
        {
            if(regra != null) 
                j_Data.regras.Remove(regra);

            SaveAllData();
        }

        public void RemoverFatoIndex(int index)
        {
            if (j_Data.fatos[index] != null)
                j_Data.fatos.Remove(j_Data.fatos[index]);

            SaveAllData();
        }

        public void RemoverFatoItem(Fato fato)
        {
            if (j_Data.fatos.Contains(fato))
                j_Data.fatos.Remove(fato);

            SaveAllData();
        }

        public Resposta GetRespostaByIdFatoAndIdResposta(int idFato, int idResposta)
        {
            var fato = GetFatoById(idFato);
            return fato.Respostas.Where(o => o.Id == idResposta).FirstOrDefault();
        }
    }
}
