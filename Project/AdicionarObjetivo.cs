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

            FatoObjetivos.AddRange(Manager.instance.ListarFatos());

            UpdateListBox();
        }

        void UpdateListBox()
        {
            PopulateListBoxObjetivos();
            PopulateListBoxAlvo();
        }

        private void salvarObjetivo_btn_Click(object sender, EventArgs e)
        {
            SalvarObjetivo();
        }

        void SalvarObjetivo()
        {
            Manager.instance.AtualizarAlvos(ObjetivosAlvo.ToArray());
        }

        void PopulateListBoxAlvo()
        {
            objetivosAlvo_listbox.DataSource = ObjetivosAlvo.ToArray();
        }

        void PopulateListBoxObjetivos()
        {
            objetivos_listbox.DataSource = FatoObjetivos.ToArray();
        }

        private void list_Objetivos_Format(object sender, ListControlConvertEventArgs e)
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var sel = (Estruturas.Fato)objetivosAlvo_listbox.SelectedItem;

            if (sel == null) return;

            FatoObjetivos.Add(sel);
            ObjetivosAlvo.Remove(sel);

           // Manager.instance.RemoverAlvo(sel);

            UpdateListBox();

        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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



        private List<Estruturas.Fato> FatoObjetivos = new List<Estruturas.Fato>();
        private List<Estruturas.Fato> ObjetivosAlvo = new List<Estruturas.Fato>();

        private void addObjetivo_btn_Click(object sender, EventArgs e)
        {
            var alvo = (Estruturas.Fato)objetivos_listbox.SelectedItem;
            if (alvo == null) return;

            ObjetivosAlvo.Add(alvo);
            FatoObjetivos.Remove(alvo);

            UpdateListBox();
        }
    }
}
