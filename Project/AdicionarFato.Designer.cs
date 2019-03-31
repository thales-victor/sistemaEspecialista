namespace Project
{
    partial class AdicionarFato
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
            this.nomeFato_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tipoResposta_label = new MaterialSkin.Controls.MaterialLabel();
            this.univalorada_radio = new MaterialSkin.Controls.MaterialRadioButton();
            this.multivalorada_radio = new MaterialSkin.Controls.MaterialRadioButton();
            this.numerica_radio = new MaterialSkin.Controls.MaterialRadioButton();
            this.resp_min_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addResposta_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.resposta_label = new MaterialSkin.Controls.MaterialLabel();
            this.max_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.min_label = new MaterialSkin.Controls.MaterialLabel();
            this.max_label = new MaterialSkin.Controls.MaterialLabel();
            this.listaResposta_label = new MaterialSkin.Controls.MaterialLabel();
            this.salvarFato_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listaResposta_listbox = new System.Windows.Forms.ListBox();
            this.cancelar_btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.removerResposta_btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.nome_label = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // nomeFato_txtbox
            // 
            this.nomeFato_txtbox.Depth = 0;
            this.nomeFato_txtbox.Hint = "";
            this.nomeFato_txtbox.Location = new System.Drawing.Point(77, 80);
            this.nomeFato_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomeFato_txtbox.Name = "nomeFato_txtbox";
            this.nomeFato_txtbox.PasswordChar = '\0';
            this.nomeFato_txtbox.SelectedText = "";
            this.nomeFato_txtbox.SelectionLength = 0;
            this.nomeFato_txtbox.SelectionStart = 0;
            this.nomeFato_txtbox.Size = new System.Drawing.Size(122, 23);
            this.nomeFato_txtbox.TabIndex = 1;
            this.nomeFato_txtbox.UseSystemPasswordChar = false;
            // 
            // tipoResposta_label
            // 
            this.tipoResposta_label.AutoSize = true;
            this.tipoResposta_label.Depth = 0;
            this.tipoResposta_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.tipoResposta_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tipoResposta_label.Location = new System.Drawing.Point(21, 122);
            this.tipoResposta_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.tipoResposta_label.Name = "tipoResposta_label";
            this.tipoResposta_label.Size = new System.Drawing.Size(122, 19);
            this.tipoResposta_label.TabIndex = 2;
            this.tipoResposta_label.Text = "Tipo de resposta";
            // 
            // univalorada_radio
            // 
            this.univalorada_radio.AutoSize = true;
            this.univalorada_radio.Depth = 0;
            this.univalorada_radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.univalorada_radio.Location = new System.Drawing.Point(31, 151);
            this.univalorada_radio.Margin = new System.Windows.Forms.Padding(0);
            this.univalorada_radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.univalorada_radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.univalorada_radio.Name = "univalorada_radio";
            this.univalorada_radio.Ripple = true;
            this.univalorada_radio.Size = new System.Drawing.Size(102, 30);
            this.univalorada_radio.TabIndex = 3;
            this.univalorada_radio.TabStop = true;
            this.univalorada_radio.Text = "Univalorada";
            this.univalorada_radio.UseVisualStyleBackColor = true;
            this.univalorada_radio.CheckedChanged += new System.EventHandler(this.univalorada_radio_CheckedChanged);
            // 
            // multivalorada_radio
            // 
            this.multivalorada_radio.AutoSize = true;
            this.multivalorada_radio.Depth = 0;
            this.multivalorada_radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.multivalorada_radio.Location = new System.Drawing.Point(31, 217);
            this.multivalorada_radio.Margin = new System.Windows.Forms.Padding(0);
            this.multivalorada_radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.multivalorada_radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.multivalorada_radio.Name = "multivalorada_radio";
            this.multivalorada_radio.Ripple = true;
            this.multivalorada_radio.Size = new System.Drawing.Size(113, 30);
            this.multivalorada_radio.TabIndex = 4;
            this.multivalorada_radio.TabStop = true;
            this.multivalorada_radio.Text = "Multivalorada";
            this.multivalorada_radio.UseVisualStyleBackColor = true;
            this.multivalorada_radio.CheckedChanged += new System.EventHandler(this.multivalorada_radio_CheckedChanged);
            // 
            // numerica_radio
            // 
            this.numerica_radio.AutoSize = true;
            this.numerica_radio.Depth = 0;
            this.numerica_radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.numerica_radio.Location = new System.Drawing.Point(31, 184);
            this.numerica_radio.Margin = new System.Windows.Forms.Padding(0);
            this.numerica_radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.numerica_radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.numerica_radio.Name = "numerica_radio";
            this.numerica_radio.Ripple = true;
            this.numerica_radio.Size = new System.Drawing.Size(89, 30);
            this.numerica_radio.TabIndex = 5;
            this.numerica_radio.TabStop = true;
            this.numerica_radio.Text = "Numérica";
            this.numerica_radio.UseVisualStyleBackColor = true;
            this.numerica_radio.CheckedChanged += new System.EventHandler(this.numerica_radio_CheckedChanged);
            // 
            // resp_min_txtbox
            // 
            this.resp_min_txtbox.Depth = 0;
            this.resp_min_txtbox.Hint = "";
            this.resp_min_txtbox.Location = new System.Drawing.Point(99, 289);
            this.resp_min_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.resp_min_txtbox.Name = "resp_min_txtbox";
            this.resp_min_txtbox.PasswordChar = '\0';
            this.resp_min_txtbox.SelectedText = "";
            this.resp_min_txtbox.SelectionLength = 0;
            this.resp_min_txtbox.SelectionStart = 0;
            this.resp_min_txtbox.Size = new System.Drawing.Size(100, 23);
            this.resp_min_txtbox.TabIndex = 6;
            this.resp_min_txtbox.UseSystemPasswordChar = false;
            // 
            // addResposta_btn
            // 
            this.addResposta_btn.Depth = 0;
            this.addResposta_btn.Location = new System.Drawing.Point(213, 282);
            this.addResposta_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addResposta_btn.Name = "addResposta_btn";
            this.addResposta_btn.Primary = true;
            this.addResposta_btn.Size = new System.Drawing.Size(103, 36);
            this.addResposta_btn.TabIndex = 7;
            this.addResposta_btn.Text = "Adicionar";
            this.addResposta_btn.UseVisualStyleBackColor = true;
            this.addResposta_btn.Click += new System.EventHandler(this.addResposta_btn_Click);
            // 
            // resposta_label
            // 
            this.resposta_label.AutoSize = true;
            this.resposta_label.Depth = 0;
            this.resposta_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.resposta_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resposta_label.Location = new System.Drawing.Point(21, 289);
            this.resposta_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.resposta_label.Name = "resposta_label";
            this.resposta_label.Size = new System.Drawing.Size(72, 19);
            this.resposta_label.TabIndex = 8;
            this.resposta_label.Text = "Resposta";
            // 
            // max_txtbox
            // 
            this.max_txtbox.Depth = 0;
            this.max_txtbox.Hint = "";
            this.max_txtbox.Location = new System.Drawing.Point(99, 338);
            this.max_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.max_txtbox.Name = "max_txtbox";
            this.max_txtbox.PasswordChar = '\0';
            this.max_txtbox.SelectedText = "";
            this.max_txtbox.SelectionLength = 0;
            this.max_txtbox.SelectionStart = 0;
            this.max_txtbox.Size = new System.Drawing.Size(100, 23);
            this.max_txtbox.TabIndex = 9;
            this.max_txtbox.UseSystemPasswordChar = false;
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.Depth = 0;
            this.min_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.min_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.min_label.Location = new System.Drawing.Point(95, 267);
            this.min_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(34, 19);
            this.min_label.TabIndex = 10;
            this.min_label.Text = "Min";
            // 
            // max_label
            // 
            this.max_label.AutoSize = true;
            this.max_label.Depth = 0;
            this.max_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.max_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.max_label.Location = new System.Drawing.Point(96, 316);
            this.max_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.max_label.Name = "max_label";
            this.max_label.Size = new System.Drawing.Size(37, 19);
            this.max_label.TabIndex = 11;
            this.max_label.Text = "Max";
            // 
            // listaResposta_label
            // 
            this.listaResposta_label.AutoSize = true;
            this.listaResposta_label.Depth = 0;
            this.listaResposta_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.listaResposta_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listaResposta_label.Location = new System.Drawing.Point(355, 70);
            this.listaResposta_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.listaResposta_label.Name = "listaResposta_label";
            this.listaResposta_label.Size = new System.Drawing.Size(133, 19);
            this.listaResposta_label.TabIndex = 12;
            this.listaResposta_label.Text = "Lista de respostas";
            // 
            // salvarFato_btn
            // 
            this.salvarFato_btn.Depth = 0;
            this.salvarFato_btn.Location = new System.Drawing.Point(562, 401);
            this.salvarFato_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.salvarFato_btn.Name = "salvarFato_btn";
            this.salvarFato_btn.Primary = true;
            this.salvarFato_btn.Size = new System.Drawing.Size(82, 36);
            this.salvarFato_btn.TabIndex = 13;
            this.salvarFato_btn.Text = "Salvar";
            this.salvarFato_btn.UseVisualStyleBackColor = true;
            this.salvarFato_btn.Click += new System.EventHandler(this.salvarFato_btn_Click);
            // 
            // listaResposta_listbox
            // 
            this.listaResposta_listbox.FormattingEnabled = true;
            this.listaResposta_listbox.Location = new System.Drawing.Point(359, 101);
            this.listaResposta_listbox.Name = "listaResposta_listbox";
            this.listaResposta_listbox.Size = new System.Drawing.Size(239, 95);
            this.listaResposta_listbox.TabIndex = 14;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.AutoSize = true;
            this.cancelar_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelar_btn.Depth = 0;
            this.cancelar_btn.Location = new System.Drawing.Point(473, 401);
            this.cancelar_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelar_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Primary = false;
            this.cancelar_btn.Size = new System.Drawing.Size(82, 36);
            this.cancelar_btn.TabIndex = 15;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // removerResposta_btn
            // 
            this.removerResposta_btn.AutoSize = true;
            this.removerResposta_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removerResposta_btn.Depth = 0;
            this.removerResposta_btn.Location = new System.Drawing.Point(395, 205);
            this.removerResposta_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removerResposta_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.removerResposta_btn.Name = "removerResposta_btn";
            this.removerResposta_btn.Primary = false;
            this.removerResposta_btn.Size = new System.Drawing.Size(169, 36);
            this.removerResposta_btn.TabIndex = 19;
            this.removerResposta_btn.Text = "Remover Selecionado";
            this.removerResposta_btn.UseVisualStyleBackColor = true;
            this.removerResposta_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Depth = 0;
            this.nome_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.nome_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nome_label.Location = new System.Drawing.Point(21, 80);
            this.nome_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(50, 19);
            this.nome_label.TabIndex = 20;
            this.nome_label.Text = "Nome";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(25, 387);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(623, 1);
            this.materialDivider1.TabIndex = 21;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // AdicionarFato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 453);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.removerResposta_btn);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.listaResposta_listbox);
            this.Controls.Add(this.salvarFato_btn);
            this.Controls.Add(this.listaResposta_label);
            this.Controls.Add(this.max_label);
            this.Controls.Add(this.min_label);
            this.Controls.Add(this.max_txtbox);
            this.Controls.Add(this.resposta_label);
            this.Controls.Add(this.addResposta_btn);
            this.Controls.Add(this.resp_min_txtbox);
            this.Controls.Add(this.numerica_radio);
            this.Controls.Add(this.multivalorada_radio);
            this.Controls.Add(this.univalorada_radio);
            this.Controls.Add(this.tipoResposta_label);
            this.Controls.Add(this.nomeFato_txtbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarFato";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Fato";
            this.Load += new System.EventHandler(this.AdicionarFato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField nomeFato_txtbox;
        private MaterialSkin.Controls.MaterialLabel tipoResposta_label;
        private MaterialSkin.Controls.MaterialRadioButton univalorada_radio;
        private MaterialSkin.Controls.MaterialRadioButton multivalorada_radio;
        private MaterialSkin.Controls.MaterialRadioButton numerica_radio;
        private MaterialSkin.Controls.MaterialSingleLineTextField resp_min_txtbox;
        private MaterialSkin.Controls.MaterialRaisedButton addResposta_btn;
        private MaterialSkin.Controls.MaterialLabel resposta_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField max_txtbox;
        private MaterialSkin.Controls.MaterialLabel min_label;
        private MaterialSkin.Controls.MaterialLabel max_label;
        private MaterialSkin.Controls.MaterialLabel listaResposta_label;
        private MaterialSkin.Controls.MaterialRaisedButton salvarFato_btn;
        private System.Windows.Forms.ListBox listaResposta_listbox;
        private MaterialSkin.Controls.MaterialFlatButton cancelar_btn;
        private MaterialSkin.Controls.MaterialFlatButton removerResposta_btn;
        private MaterialSkin.Controls.MaterialLabel nome_label;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}