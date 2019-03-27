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
            this.nomeFato_label = new System.Windows.Forms.Label();
            this.nomeFato_txtbox = new System.Windows.Forms.TextBox();
            this.tipoResposta_label = new System.Windows.Forms.Label();
            this.univalorada_radio = new System.Windows.Forms.RadioButton();
            this.multivalorada_radio = new System.Windows.Forms.RadioButton();
            this.numerica_radio = new System.Windows.Forms.RadioButton();
            this.resp_min_txtbox = new System.Windows.Forms.TextBox();
            this.addResposta_btn = new System.Windows.Forms.Button();
            this.resposta_label = new System.Windows.Forms.Label();
            this.max_txtbox = new System.Windows.Forms.TextBox();
            this.min_label = new System.Windows.Forms.Label();
            this.max_label = new System.Windows.Forms.Label();
            this.listaResposta_label = new System.Windows.Forms.Label();
            this.salvarFato_btn = new System.Windows.Forms.Button();
            this.listaResposta_listbox = new System.Windows.Forms.ListBox();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.listaFatos_label = new System.Windows.Forms.Label();
            this.listaFatos_listbox = new System.Windows.Forms.ListBox();
            this.removerFato_btn = new System.Windows.Forms.Button();
            this.removerResposta_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeFato_label
            // 
            this.nomeFato_label.AutoSize = true;
            this.nomeFato_label.Location = new System.Drawing.Point(37, 42);
            this.nomeFato_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeFato_label.Name = "nomeFato_label";
            this.nomeFato_label.Size = new System.Drawing.Size(45, 17);
            this.nomeFato_label.TabIndex = 0;
            this.nomeFato_label.Text = "Nome";
            // 
            // nomeFato_txtbox
            // 
            this.nomeFato_txtbox.Location = new System.Drawing.Point(112, 38);
            this.nomeFato_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomeFato_txtbox.Name = "nomeFato_txtbox";
            this.nomeFato_txtbox.Size = new System.Drawing.Size(132, 22);
            this.nomeFato_txtbox.TabIndex = 1;
            // 
            // tipoResposta_label
            // 
            this.tipoResposta_label.AutoSize = true;
            this.tipoResposta_label.Location = new System.Drawing.Point(37, 101);
            this.tipoResposta_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipoResposta_label.Name = "tipoResposta_label";
            this.tipoResposta_label.Size = new System.Drawing.Size(115, 17);
            this.tipoResposta_label.TabIndex = 2;
            this.tipoResposta_label.Text = "Tipo de resposta";
            // 
            // univalorada_radio
            // 
            this.univalorada_radio.AutoSize = true;
            this.univalorada_radio.Location = new System.Drawing.Point(189, 101);
            this.univalorada_radio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.univalorada_radio.Name = "univalorada_radio";
            this.univalorada_radio.Size = new System.Drawing.Size(105, 21);
            this.univalorada_radio.TabIndex = 3;
            this.univalorada_radio.TabStop = true;
            this.univalorada_radio.Text = "Univalorada";
            this.univalorada_radio.UseVisualStyleBackColor = true;
            this.univalorada_radio.CheckedChanged += new System.EventHandler(this.univalorada_radio_CheckedChanged);
            // 
            // multivalorada_radio
            // 
            this.multivalorada_radio.AutoSize = true;
            this.multivalorada_radio.Location = new System.Drawing.Point(189, 130);
            this.multivalorada_radio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.multivalorada_radio.Name = "multivalorada_radio";
            this.multivalorada_radio.Size = new System.Drawing.Size(113, 21);
            this.multivalorada_radio.TabIndex = 4;
            this.multivalorada_radio.TabStop = true;
            this.multivalorada_radio.Text = "Multivalorada";
            this.multivalorada_radio.UseVisualStyleBackColor = true;
            this.multivalorada_radio.CheckedChanged += new System.EventHandler(this.multivalorada_radio_CheckedChanged);
            // 
            // numerica_radio
            // 
            this.numerica_radio.AutoSize = true;
            this.numerica_radio.Location = new System.Drawing.Point(189, 158);
            this.numerica_radio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numerica_radio.Name = "numerica_radio";
            this.numerica_radio.Size = new System.Drawing.Size(89, 21);
            this.numerica_radio.TabIndex = 5;
            this.numerica_radio.TabStop = true;
            this.numerica_radio.Text = "Numérica";
            this.numerica_radio.UseVisualStyleBackColor = true;
            this.numerica_radio.CheckedChanged += new System.EventHandler(this.numerica_radio_CheckedChanged);
            // 
            // resp_min_txtbox
            // 
            this.resp_min_txtbox.Location = new System.Drawing.Point(189, 228);
            this.resp_min_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resp_min_txtbox.Name = "resp_min_txtbox";
            this.resp_min_txtbox.Size = new System.Drawing.Size(132, 22);
            this.resp_min_txtbox.TabIndex = 6;
            // 
            // addResposta_btn
            // 
            this.addResposta_btn.Location = new System.Drawing.Point(364, 237);
            this.addResposta_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addResposta_btn.Name = "addResposta_btn";
            this.addResposta_btn.Size = new System.Drawing.Size(100, 28);
            this.addResposta_btn.TabIndex = 7;
            this.addResposta_btn.Text = "Adicionar";
            this.addResposta_btn.UseVisualStyleBackColor = true;
            this.addResposta_btn.Click += new System.EventHandler(this.addResposta_btn_Click);
            // 
            // resposta_label
            // 
            this.resposta_label.AutoSize = true;
            this.resposta_label.Location = new System.Drawing.Point(37, 228);
            this.resposta_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resposta_label.Name = "resposta_label";
            this.resposta_label.Size = new System.Drawing.Size(68, 17);
            this.resposta_label.TabIndex = 8;
            this.resposta_label.Text = "Resposta";
            // 
            // max_txtbox
            // 
            this.max_txtbox.Location = new System.Drawing.Point(189, 281);
            this.max_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.max_txtbox.Name = "max_txtbox";
            this.max_txtbox.Size = new System.Drawing.Size(132, 22);
            this.max_txtbox.TabIndex = 9;
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.Location = new System.Drawing.Point(185, 208);
            this.min_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(30, 17);
            this.min_label.TabIndex = 10;
            this.min_label.Text = "Min";
            // 
            // max_label
            // 
            this.max_label.AutoSize = true;
            this.max_label.Location = new System.Drawing.Point(185, 261);
            this.max_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max_label.Name = "max_label";
            this.max_label.Size = new System.Drawing.Size(33, 17);
            this.max_label.TabIndex = 11;
            this.max_label.Text = "Max";
            // 
            // listaResposta_label
            // 
            this.listaResposta_label.AutoSize = true;
            this.listaResposta_label.Location = new System.Drawing.Point(37, 345);
            this.listaResposta_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listaResposta_label.Name = "listaResposta_label";
            this.listaResposta_label.Size = new System.Drawing.Size(124, 17);
            this.listaResposta_label.TabIndex = 12;
            this.listaResposta_label.Text = "Lista de respostas";
            // 
            // salvarFato_btn
            // 
            this.salvarFato_btn.Location = new System.Drawing.Point(561, 457);
            this.salvarFato_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salvarFato_btn.Name = "salvarFato_btn";
            this.salvarFato_btn.Size = new System.Drawing.Size(100, 28);
            this.salvarFato_btn.TabIndex = 13;
            this.salvarFato_btn.Text = "Salvar";
            this.salvarFato_btn.UseVisualStyleBackColor = true;
            this.salvarFato_btn.Click += new System.EventHandler(this.salvarFato_btn_Click);
            // 
            // listaResposta_listbox
            // 
            this.listaResposta_listbox.FormattingEnabled = true;
            this.listaResposta_listbox.ItemHeight = 16;
            this.listaResposta_listbox.Location = new System.Drawing.Point(188, 345);
            this.listaResposta_listbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaResposta_listbox.Name = "listaResposta_listbox";
            this.listaResposta_listbox.Size = new System.Drawing.Size(159, 116);
            this.listaResposta_listbox.TabIndex = 14;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(697, 457);
            this.cancelar_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(100, 28);
            this.cancelar_btn.TabIndex = 15;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // listaFatos_label
            // 
            this.listaFatos_label.AutoSize = true;
            this.listaFatos_label.Location = new System.Drawing.Point(558, 41);
            this.listaFatos_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listaFatos_label.Name = "listaFatos_label";
            this.listaFatos_label.Size = new System.Drawing.Size(93, 17);
            this.listaFatos_label.TabIndex = 16;
            this.listaFatos_label.Text = "Lista de fatos";
            // 
            // listaFatos_listbox
            // 
            this.listaFatos_listbox.FormattingEnabled = true;
            this.listaFatos_listbox.ItemHeight = 16;
            this.listaFatos_listbox.Location = new System.Drawing.Point(561, 81);
            this.listaFatos_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.listaFatos_listbox.Name = "listaFatos_listbox";
            this.listaFatos_listbox.Size = new System.Drawing.Size(159, 260);
            this.listaFatos_listbox.TabIndex = 17;
            // 
            // removerFato_btn
            // 
            this.removerFato_btn.Location = new System.Drawing.Point(585, 349);
            this.removerFato_btn.Margin = new System.Windows.Forms.Padding(4);
            this.removerFato_btn.Name = "removerFato_btn";
            this.removerFato_btn.Size = new System.Drawing.Size(100, 28);
            this.removerFato_btn.TabIndex = 18;
            this.removerFato_btn.Text = "Remover";
            this.removerFato_btn.UseVisualStyleBackColor = true;
            // 
            // removerResposta_btn
            // 
            this.removerResposta_btn.Location = new System.Drawing.Point(355, 389);
            this.removerResposta_btn.Margin = new System.Windows.Forms.Padding(4);
            this.removerResposta_btn.Name = "removerResposta_btn";
            this.removerResposta_btn.Size = new System.Drawing.Size(100, 28);
            this.removerResposta_btn.TabIndex = 19;
            this.removerResposta_btn.Text = "Remover";
            this.removerResposta_btn.UseVisualStyleBackColor = true;
            this.removerResposta_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdicionarFato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 511);
            this.Controls.Add(this.removerResposta_btn);
            this.Controls.Add(this.removerFato_btn);
            this.Controls.Add(this.listaFatos_listbox);
            this.Controls.Add(this.listaFatos_label);
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
            this.Controls.Add(this.nomeFato_label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdicionarFato";
            this.Text = "Regras";
            this.Load += new System.EventHandler(this.AdicionarFato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeFato_label;
        private System.Windows.Forms.TextBox nomeFato_txtbox;
        private System.Windows.Forms.Label tipoResposta_label;
        private System.Windows.Forms.RadioButton univalorada_radio;
        private System.Windows.Forms.RadioButton multivalorada_radio;
        private System.Windows.Forms.RadioButton numerica_radio;
        private System.Windows.Forms.TextBox resp_min_txtbox;
        private System.Windows.Forms.Button addResposta_btn;
        private System.Windows.Forms.Label resposta_label;
        private System.Windows.Forms.TextBox max_txtbox;
        private System.Windows.Forms.Label min_label;
        private System.Windows.Forms.Label max_label;
        private System.Windows.Forms.Label listaResposta_label;
        private System.Windows.Forms.Button salvarFato_btn;
        private System.Windows.Forms.ListBox listaResposta_listbox;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Label listaFatos_label;
        private System.Windows.Forms.ListBox listaFatos_listbox;
        private System.Windows.Forms.Button removerFato_btn;
        private System.Windows.Forms.Button removerResposta_btn;
    }
}