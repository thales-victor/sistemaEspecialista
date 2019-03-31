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
    public partial class VisualizarRegra : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        private Regra Regra;
        public VisualizarRegra(Regra regra)
        {
            if (regra == null)
                Close();

            InitializeComponent();

            Regra = regra;
            this.Text = regra.Nome;

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void VisualizarRegra_Load(object sender, EventArgs e)
        {
            listaCondicao_listbox.DataSource = Regra.Condicao.ToArray();
            listaObjetivos_listbox.DataSource = Regra.ListarCondicaoObjetivos();
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
