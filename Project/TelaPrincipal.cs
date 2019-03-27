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
    public partial class frmMain : Form
    {
        private Manager mgr;

        public frmMain(Manager manager)
        {
            this.mgr = manager;
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            var fatos = new ListaFatos();
            fatos.ShowDialog();
        }

        private void criarObjetivo_btn_Click(object sender, EventArgs e)
        {
            var objetivos = new ListaObjetivos();
            objetivos.ShowDialog();
        }

        private void criarRegra_btn_Click(object sender, EventArgs e)
        {
            var regras = new ListaRegras();
            regras.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var regras = Manager.instance.ListarRegras();
            if (regras.Count == 0)
                return;
            var regra = regras.FirstOrDefault();
            var condicoes = regra.Condicao;
            if (condicoes.Count == 0)
                return;

            foreach (var condicao in condicoes)
            {
                using (var perguntas = new Perguntas(condicao))
                {
                    perguntas.ShowDialog();
                }
            }

        }
    }
}
