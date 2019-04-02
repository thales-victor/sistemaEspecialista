using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using Project.Estruturas;

namespace Project
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public MainForm()
        {
            InitializeComponent();

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
            Accent.LightBlue200,
            TextShade.WHITE);

            AtualizarFatosCriados();

            FatoObjetivos.AddRange(Manager.instance.ListarFatos());
            AtualizarObjetivos();

            AtualizarRegrasCriadas();
        }

        
        private void AtualizarFatosCriados()
        {
            fatosCriados_listbox.DataSource = Manager.instance.ListarFatos().Select(o => o.Nome).ToList();
        }
        private void AtualizarObjetivos()
        {
            UpdateListBox();
        }
        private void AtualizarRegrasCriadas()
        {
            regrasCriadas_listbox.DataSource = Manager.instance.ListarRegras();
        }

        
        //POR FAVOR NÃO MEXE NISSO SEM FALAR COMIGO, EU DEI A VIDA PRA FAZER ISSO FUNCIONAR
        // -VICTOR
        private Regra[] ObterRegrasComObjetivosAlvo()
        {
            Fato[] FatosAlvos = Manager.instance.ListarAlvos();

            List<Regra> RegrasAlvo = new List<Regra>();

            Dictionary<Regra, Fato[]> FatosAlvosComRegra = new Dictionary<Regra, Fato[]>();

            foreach (var item in Manager.instance.ListarRegras())
            {
                FatosAlvosComRegra.Add(item, item.ListarCondObjetivoFatos());
            }

            foreach(var item in FatosAlvosComRegra)
            {
                var regra = item.Key;
                var fatos = item.Value;
                
                var newData = FatosAlvos.Intersect(fatos);

                if (newData.Count() > 0)
                    RegrasAlvo.Add(regra);
            }

            return RegrasAlvo.ToArray();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            var regras = ObterRegrasComObjetivosAlvo();

            if (regras.Length == 0)
                return;

            var RespostasUsuario = new RespostasUsuario();

            foreach (var regra in regras)
            {
                var condicoes = regra.Condicao;
                if (condicoes.Count == 0)
                    return;
                foreach (var condicao in condicoes)
                {
                    using (var perguntas = new Perguntas(condicao.Fato))
                    {
                        perguntas.ShowDialog();
                        var resposta = Manager.instance.GetRespostaByIdFatoAndIdResposta(condicao.Fato.Id, perguntas.Return);
                        RespostasUsuario.AdicionaResposta(condicao.Fato, resposta);

                        //if (resposta gerar resultado false e regra possuir somente conectivo &&)
                        //{
                        //    continue;
                        //}
                    }
                }
            }

        }


        #region FATOS
        private void removerFato_btn_Click(object sender, EventArgs e)
        {
            if(fatosCriados_listbox.SelectedItem == null) return;

            var nome = fatosCriados_listbox.SelectedItem as string;

            var msgBox = new CustomMsgBox("Remover Fato", $"Você tem certeza de que deseja remover o fato {nome}?", MessageBoxType.E_SimNao);
            var result = msgBox.ShowDialog();

            if(result == DialogResult.OK)
            {
                var sel = fatosCriados_listbox.SelectedIndex;

                var item = Manager.instance.FindFatoByName(nome);

                if (item == null) return;

                ObjetivosAlvo.Remove(item);

                Manager.instance.RemoverFatoItem(item);

                ReUpdateFatoObjetivos();

                AtualizarFatosCriados();
                AtualizarObjetivos();
            }
        }

        private void novoFato_btn_Click(object sender, EventArgs e)
        {
            var addFato = new AdicionarFato();
            addFato.ShowDialog();

            ReUpdateFatoObjetivos();

            AtualizarFatosCriados();
            AtualizarObjetivos();
        }

        #endregion

        #region OBJETIVOS

        private List<Estruturas.Fato> FatoObjetivos = new List<Estruturas.Fato>();
        private List<Estruturas.Fato> ObjetivosAlvo = new List<Estruturas.Fato>();

        void ReUpdateFatoObjetivos()
        {
            FatoObjetivos.Clear();
            FatoObjetivos.AddRange(Manager.instance.ListarFatos());
        }

        private void UpdateListBox()
        {
            PopulateListBoxObjetivos();
            PopulateListBoxAlvo();
        }

        void PopulateListBoxAlvo()
        {
            objetivosAlvo_listbox.DataSource = ObjetivosAlvo.ToArray();
        }

        void PopulateListBoxObjetivos()
        {
            objetivos_listbox.DataSource = FatoObjetivos.ToArray();
        }
        
        private void objetivos_listbox_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Estruturas.Fato)
            {
                e.Value = ((Estruturas.Fato)e.ListItem).Nome;
            }
            else
            {
                e.Value = "Item desconhecido";
            }
        }

        private void objetivosAlvo_listbox_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Estruturas.Fato)
            {
                e.Value = ((Estruturas.Fato)e.ListItem).Nome;
            }
            else
            {
                e.Value = "Item desconhecido";
            }
        }

        private void SalvarObjetivo()
        {
            Manager.instance.AtualizarAlvos(ObjetivosAlvo.ToArray());
        }

        private void addObjetivo_btn_Click(object sender, EventArgs e)
        {
            var alvo = (Estruturas.Fato)objetivos_listbox.SelectedItem;
            if (alvo == null) return;

            ObjetivosAlvo.Add(alvo);
            FatoObjetivos.Remove(alvo);

            UpdateListBox();
            SalvarObjetivo();
        }
        private void removeObjetivo_btn_Click(object sender, EventArgs e)
        {
            var sel = (Estruturas.Fato)objetivosAlvo_listbox.SelectedItem;

            if (sel == null) return;

            FatoObjetivos.Add(sel);
            ObjetivosAlvo.Remove(sel);

            UpdateListBox();
            SalvarObjetivo();
        }


        #endregion

        #region REGRAS


        private void novaRegra_btn_Click(object sender, EventArgs e)
        {
            var addRegra = new AdicionarRegra();
            addRegra.ShowDialog();

            AtualizarRegrasCriadas();
        }
        private void visualizarRegra_btn_Click(object sender, EventArgs e)
        {
            if (regrasCriadas_listbox.SelectedItem == null) return;


            var visualizarRegra = new VisualizarRegra(regrasCriadas_listbox.SelectedItem as Estruturas.Regra);
            visualizarRegra.ShowDialog();
        }
        private void removerRegra_btn_Click(object sender, EventArgs e)
        {
            if (regrasCriadas_listbox.SelectedItem == null) return;

            var r = regrasCriadas_listbox.SelectedItem as Estruturas.Regra;

            var msgBox = new CustomMsgBox("Remover Regra", $"Você tem certeza de que deseja remover a regra {r.Nome}?", MessageBoxType.E_SimNao);
            var result = msgBox.ShowDialog();

            if (result == DialogResult.OK)
            {
                Manager.instance.RemoverRegra(r);
                AtualizarRegrasCriadas();
            }
        }
        private void regrasCriadas_listbox_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Estruturas.Regra)
            {
                Estruturas.Regra regra = (Estruturas.Regra)e.ListItem;

                e.Value = string.Format($"{regra.Nome}");

            }
            else
            {
                e.Value = "Item desconhecido";
            }
        }


        #endregion


        //Checar quais regras tem como "ENTÃO" um ou mais fatos mencionados na aba Objetivos
        private void testObjetivosEmComum_btn_Click(object sender, EventArgs e)
        {
            var regrasAlvos = ObterRegrasComObjetivosAlvo();

            StringBuilder str = new StringBuilder();

            foreach (var item in regrasAlvos)
                str.Append(item.Nome).Append(Environment.NewLine);

            MessageBox.Show(str.ToString());
        }
    }
}
