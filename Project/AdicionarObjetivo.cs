using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AdicionarObjetivo : Form
    {
        public AdicionarObjetivo()
        {
            InitializeComponent();
            PopulateListBox();
        }

        private void salvarObjetivo_btn_Click(object sender, EventArgs e)
        {
            SalvarObjetivo();
        }

        void SalvarObjetivo()
        {
            var nome = nomeObjetivo_txtbox.Text;
            if (nome != null || descObjetivo_txtbox.Text != null)
            {
                if (Manager.instance.ObterObjetivo(nome) == null)
                {
                    Manager.instance.CriarObjetivo(nomeObjetivo_txtbox.Text, descObjetivo_txtbox.Text); // nao existe
                }
                else
                    MessageBox.Show("Objetivo já existe");//existe
            }
            else
            {
                MessageBox.Show("campos invalidos");//existe
            }
            PopulateListBox();
        }

        void PopulateListBox()
        {
            list_Objetivos.DataSource = Manager.instance.ListarObjetivos();
        }

        private void list_Objetivos_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Estruturas.Objetivo)
            {
                e.Value = ((Estruturas.Objetivo)e.ListItem).Nome;
            }
            else
            {
                e.Value = "Item desconhecido";
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var sel = list_Objetivos.SelectedIndex;

            if(sel != -1)
            {
                Manager.instance.RemoverObjetivoIndex(sel);
                PopulateListBox();
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
