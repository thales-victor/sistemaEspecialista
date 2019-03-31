using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Estruturas;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;

namespace Project
{
    public partial class AdicionarRegra : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        Regra regra;
        public AdicionarRegra()
        {
            regra = new Regra();

            InitializeComponent();

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            PrepareListBox();
            PrepareObjetivos();
        }

        void PrepareListBox()
        {
            listaCondicao_listbox.DataSource = regra.Condicao.ToArray();
        }

        void PrepareObjetivos()
        {
            listaObjetivos_listbox.DataSource = regra.ListarCondicaoObjetivos();
        }

        private void listaCondicao_listbox_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Condicao)
            {
                var cond = ((Condicao)e.ListItem);

                object obj;
                if (cond.Fato.Tipo == TipoResposta.Numerico)
                    obj = cond.Resposta.Valor;
                else
                    obj = cond.Resposta.Descricao;


                string str = cond.Primeiro ? "" : cond.Conectivo.ToString() + " ";

                e.Value = string.Format($"{str}{cond.Fato.Nome} {Util.ParseOperador(cond.Operador)} {obj}");

            }
            else
            {
                e.Value = "Item desconhecido";
            }
        }
        
        private void addCondicao_btn_Click(object sender, EventArgs e)
        {
            var frmAddRegra = new NovaRegra(regra);
            frmAddRegra.ShowDialog();
            PrepareListBox();
        }

        private void addObjetivo_btn_Click(object sender, EventArgs e)
        {
            var frmAddObjetivo = new NovoObjetivo(regra);
            frmAddObjetivo.ShowDialog();

            PrepareObjetivos();
        }
       

        private void listaObjetivos_listbox_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is CondicaoObjetivo)
            {
                var cond = ((CondicaoObjetivo)e.ListItem);
                
                e.Value = string.Format($"{cond.Fato.Nome} {Util.ParseOperador(cond.Operador)} {cond.Resposta.Descricao}");

            }
            else
            {
                e.Value = "Item desconhecido";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (novaRegra_txtbox.Text == string.Empty)
            {
                var msgBox = new CustomMsgBox("Salvar Regra", "Preencha corretamente os campos para poder salvar!", MessageBoxType.E_OK);
                msgBox.ShowDialog();
            }
            else
            {
                Manager.instance.AdicionarRegra(regra);

                var msgBox = new CustomMsgBox("Regra Criada", $"Regra {novaRegra_txtbox.Text} criada com sucesso!", MessageBoxType.E_OK);
                msgBox.ShowDialog();

                this.Close();
            }


        }

        private void novaRegra_txtbox_TextChanged(object sender, EventArgs e)
        {
            regra.Nome = novaRegra_txtbox.Text;
        }

        private void AdicionarRegra_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listaCondicao_listbox.SelectedItem == null) return;

            var cond = listaCondicao_listbox.SelectedItem as Estruturas.Condicao;
            regra.RemoverCondicao(cond);


            PrepareListBox();
        }
        private void removeObjetivo_btn_Click(object sender, EventArgs e)
        {
            if (listaObjetivos_listbox.SelectedItem == null) return;

            var cond = listaObjetivos_listbox.SelectedItem as Estruturas.CondicaoObjetivo;

            regra.RemoverCondicaoObjetivo(cond);
            PrepareObjetivos();
        }


    }
}
