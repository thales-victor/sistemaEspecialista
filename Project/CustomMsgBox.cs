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

namespace Project
{
    public enum MessageBoxType
    {
        E_SimNao,
        E_OK
    }
    public partial class CustomMsgBox : MaterialForm
    {
        private MessageBoxType type;

        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public CustomMsgBox(string titulo, string mensagem, MessageBoxType type)
        {
            this.type = type;
            InitializeComponent();

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            this.Text = titulo;
            this.label_Mensagem.Text = mensagem;

            if (type == MessageBoxType.E_OK)
            {
                btn_cancel.Hide();
            }
            else
            {
                btn_cancel.Text = "NÃO";
                btn_OK.Text = "SIM";
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        Timer timer_Fade;
        private void CustomMsgBox_Load(object sender, EventArgs e)
        {
           /* Opacity = 0;

            timer_Fade = new Timer();

            timer_Fade.Interval = 10;
            timer_Fade.Tick += FadeIn;
            timer_Fade.Start();*/
        }

        private void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer_Fade.Stop();
            else
                Opacity += 0.10;
        }

        private void FadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                timer_Fade.Stop();
                Close();
            }
            else
                Opacity -= 0.05;
        }

       /* private void CustomMsgBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;


            timer_Fade.Tick += FadeOut;
            timer_Fade.Start();

            if (Opacity == 0)
                e.Cancel = false;
        }*/
    }
}
