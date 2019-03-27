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

namespace Project
{
    public partial class AdicionarRegra : Form
    {

        Estruturas.Regra regra;
        public AdicionarRegra()
        {
            regra = new Estruturas.Regra();
            InitializeComponent();
            PrepareListBox();
            PrepareObjetivos();
        }




        void PrepareListBox()
        {
            listaCondicao_listbox.DataSource = regra.Condicao.ToArray();
        }

        void PrepareObjetivos()
        {
            //entao_combobox.DataSource =
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
    }
}
