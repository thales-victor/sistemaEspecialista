namespace Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.regrasCriadas_listbox = new System.Windows.Forms.ListBox();
            this.btn_play = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.novoFato_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.removerFato_btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.fatosCriados_listbox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.removeObjetivo_btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.addObjetivo_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.objetivos_listbox = new System.Windows.Forms.ListBox();
            this.objetivosAlvo_listbox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.visualizarRegra_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.removerRegra_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.novaRegra_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.testObjetivosEmComum_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // regrasCriadas_listbox
            // 
            this.regrasCriadas_listbox.FormattingEnabled = true;
            this.regrasCriadas_listbox.Location = new System.Drawing.Point(6, 24);
            this.regrasCriadas_listbox.Name = "regrasCriadas_listbox";
            this.regrasCriadas_listbox.Size = new System.Drawing.Size(238, 121);
            this.regrasCriadas_listbox.TabIndex = 4;
            this.regrasCriadas_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.regrasCriadas_listbox_Format);
            // 
            // btn_play
            // 
            this.btn_play.Depth = 0;
            this.btn_play.Location = new System.Drawing.Point(400, 430);
            this.btn_play.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_play.Name = "btn_play";
            this.btn_play.Primary = true;
            this.btn_play.Size = new System.Drawing.Size(91, 37);
            this.btn_play.TabIndex = 6;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.button3_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 105);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(483, 257);
            this.materialTabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.novoFato_btn);
            this.tabPage1.Controls.Add(this.removerFato_btn);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.fatosCriados_listbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(475, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fatos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // novoFato_btn
            // 
            this.novoFato_btn.Depth = 0;
            this.novoFato_btn.Location = new System.Drawing.Point(287, 72);
            this.novoFato_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.novoFato_btn.Name = "novoFato_btn";
            this.novoFato_btn.Primary = true;
            this.novoFato_btn.Size = new System.Drawing.Size(119, 35);
            this.novoFato_btn.TabIndex = 9;
            this.novoFato_btn.Text = "+ Novo Fato";
            this.novoFato_btn.UseVisualStyleBackColor = true;
            this.novoFato_btn.Click += new System.EventHandler(this.novoFato_btn_Click);
            // 
            // removerFato_btn
            // 
            this.removerFato_btn.AutoSize = true;
            this.removerFato_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removerFato_btn.Depth = 0;
            this.removerFato_btn.Location = new System.Drawing.Point(20, 151);
            this.removerFato_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removerFato_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.removerFato_btn.Name = "removerFato_btn";
            this.removerFato_btn.Primary = true;
            this.removerFato_btn.Size = new System.Drawing.Size(169, 36);
            this.removerFato_btn.TabIndex = 10;
            this.removerFato_btn.Text = "Remover Selecionado";
            this.removerFato_btn.UseVisualStyleBackColor = true;
            this.removerFato_btn.Click += new System.EventHandler(this.removerFato_btn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(2, 2);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(103, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Fatos Criados";
            // 
            // fatosCriados_listbox
            // 
            this.fatosCriados_listbox.FormattingEnabled = true;
            this.fatosCriados_listbox.Location = new System.Drawing.Point(6, 24);
            this.fatosCriados_listbox.Name = "fatosCriados_listbox";
            this.fatosCriados_listbox.Size = new System.Drawing.Size(196, 121);
            this.fatosCriados_listbox.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.removeObjetivo_btn);
            this.tabPage2.Controls.Add(this.addObjetivo_btn);
            this.tabPage2.Controls.Add(this.objetivos_listbox);
            this.tabPage2.Controls.Add(this.objetivosAlvo_listbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(475, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Objetivos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(2, 2);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 19);
            this.materialLabel4.TabIndex = 15;
            this.materialLabel4.Text = "Fatos";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(268, 2);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(72, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Objetivos";
            // 
            // removeObjetivo_btn
            // 
            this.removeObjetivo_btn.AutoSize = true;
            this.removeObjetivo_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeObjetivo_btn.Depth = 0;
            this.removeObjetivo_btn.Location = new System.Drawing.Point(283, 124);
            this.removeObjetivo_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removeObjetivo_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeObjetivo_btn.Name = "removeObjetivo_btn";
            this.removeObjetivo_btn.Primary = true;
            this.removeObjetivo_btn.Size = new System.Drawing.Size(169, 36);
            this.removeObjetivo_btn.TabIndex = 13;
            this.removeObjetivo_btn.Text = "Remover Selecionado";
            this.removeObjetivo_btn.UseVisualStyleBackColor = true;
            this.removeObjetivo_btn.Click += new System.EventHandler(this.removeObjetivo_btn_Click);
            // 
            // addObjetivo_btn
            // 
            this.addObjetivo_btn.Depth = 0;
            this.addObjetivo_btn.Location = new System.Drawing.Point(210, 52);
            this.addObjetivo_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addObjetivo_btn.Name = "addObjetivo_btn";
            this.addObjetivo_btn.Primary = true;
            this.addObjetivo_btn.Size = new System.Drawing.Size(51, 36);
            this.addObjetivo_btn.TabIndex = 12;
            this.addObjetivo_btn.Text = ">";
            this.addObjetivo_btn.UseVisualStyleBackColor = true;
            this.addObjetivo_btn.Click += new System.EventHandler(this.addObjetivo_btn_Click);
            // 
            // objetivos_listbox
            // 
            this.objetivos_listbox.FormattingEnabled = true;
            this.objetivos_listbox.Location = new System.Drawing.Point(6, 24);
            this.objetivos_listbox.Name = "objetivos_listbox";
            this.objetivos_listbox.Size = new System.Drawing.Size(196, 95);
            this.objetivos_listbox.TabIndex = 11;
            this.objetivos_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.objetivos_listbox_Format);
            // 
            // objetivosAlvo_listbox
            // 
            this.objetivosAlvo_listbox.FormattingEnabled = true;
            this.objetivosAlvo_listbox.Location = new System.Drawing.Point(269, 24);
            this.objetivosAlvo_listbox.Name = "objetivosAlvo_listbox";
            this.objetivosAlvo_listbox.Size = new System.Drawing.Size(196, 95);
            this.objetivosAlvo_listbox.TabIndex = 10;
            this.objetivosAlvo_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.objetivosAlvo_listbox_Format);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.visualizarRegra_btn);
            this.tabPage3.Controls.Add(this.removerRegra_btn);
            this.tabPage3.Controls.Add(this.novaRegra_btn);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.regrasCriadas_listbox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(475, 231);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Regras";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // visualizarRegra_btn
            // 
            this.visualizarRegra_btn.Depth = 0;
            this.visualizarRegra_btn.Location = new System.Drawing.Point(6, 151);
            this.visualizarRegra_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.visualizarRegra_btn.Name = "visualizarRegra_btn";
            this.visualizarRegra_btn.Primary = true;
            this.visualizarRegra_btn.Size = new System.Drawing.Size(116, 27);
            this.visualizarRegra_btn.TabIndex = 8;
            this.visualizarRegra_btn.Text = "Visualizar";
            this.visualizarRegra_btn.UseVisualStyleBackColor = true;
            this.visualizarRegra_btn.Click += new System.EventHandler(this.visualizarRegra_btn_Click);
            // 
            // removerRegra_btn
            // 
            this.removerRegra_btn.Depth = 0;
            this.removerRegra_btn.Location = new System.Drawing.Point(128, 151);
            this.removerRegra_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.removerRegra_btn.Name = "removerRegra_btn";
            this.removerRegra_btn.Primary = true;
            this.removerRegra_btn.Size = new System.Drawing.Size(116, 27);
            this.removerRegra_btn.TabIndex = 7;
            this.removerRegra_btn.Text = "Remover";
            this.removerRegra_btn.UseVisualStyleBackColor = true;
            this.removerRegra_btn.Click += new System.EventHandler(this.removerRegra_btn_Click);
            // 
            // novaRegra_btn
            // 
            this.novaRegra_btn.Depth = 0;
            this.novaRegra_btn.Location = new System.Drawing.Point(287, 72);
            this.novaRegra_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.novaRegra_btn.Name = "novaRegra_btn";
            this.novaRegra_btn.Primary = true;
            this.novaRegra_btn.Size = new System.Drawing.Size(119, 35);
            this.novaRegra_btn.TabIndex = 6;
            this.novaRegra_btn.Text = "+ Nova regra";
            this.novaRegra_btn.UseVisualStyleBackColor = true;
            this.novaRegra_btn.Click += new System.EventHandler(this.novaRegra_btn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(2, 2);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Regras Criadas";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(513, 35);
            this.materialTabSelector1.TabIndex = 8;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 418);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(483, 1);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // testObjetivosEmComum_btn
            // 
            this.testObjetivosEmComum_btn.Depth = 0;
            this.testObjetivosEmComum_btn.Location = new System.Drawing.Point(16, 430);
            this.testObjetivosEmComum_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.testObjetivosEmComum_btn.Name = "testObjetivosEmComum_btn";
            this.testObjetivosEmComum_btn.Primary = true;
            this.testObjetivosEmComum_btn.Size = new System.Drawing.Size(144, 36);
            this.testObjetivosEmComum_btn.TabIndex = 10;
            this.testObjetivosEmComum_btn.Text = "Regras Play";
            this.testObjetivosEmComum_btn.UseVisualStyleBackColor = true;
            this.testObjetivosEmComum_btn.Click += new System.EventHandler(this.testObjetivosEmComum_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(508, 479);
            this.Controls.Add(this.testObjetivosEmComum_btn);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.btn_play);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(508, 479);
            this.MinimumSize = new System.Drawing.Size(508, 479);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ambiente para Sistemas Especialistas";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox regrasCriadas_listbox;
        private MaterialSkin.Controls.MaterialRaisedButton btn_play;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton removerRegra_btn;
        private MaterialSkin.Controls.MaterialRaisedButton novaRegra_btn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ListBox fatosCriados_listbox;
        private MaterialSkin.Controls.MaterialRaisedButton novoFato_btn;
        private System.Windows.Forms.ListBox objetivos_listbox;
        private System.Windows.Forms.ListBox objetivosAlvo_listbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton removeObjetivo_btn;
        private MaterialSkin.Controls.MaterialRaisedButton addObjetivo_btn;
        private MaterialSkin.Controls.MaterialFlatButton removerFato_btn;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton visualizarRegra_btn;
        private MaterialSkin.Controls.MaterialRaisedButton testObjetivosEmComum_btn;
    }
}

