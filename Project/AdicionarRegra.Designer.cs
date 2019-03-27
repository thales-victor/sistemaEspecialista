namespace Project
{
    partial class AdicionarRegra
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
            this.nomeRegra_label = new System.Windows.Forms.Label();
            this.novaRegra_txtbox = new System.Windows.Forms.TextBox();
            this.entao_label = new System.Windows.Forms.Label();
            this.addCondicao_btn = new System.Windows.Forms.Button();
            this.listaCondicao_listbox = new System.Windows.Forms.ListBox();
            this.se_label = new System.Windows.Forms.Label();
            this.listaObjetivos_listbox = new System.Windows.Forms.ListBox();
            this.addObjetivo_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.removeCondicao_btn = new System.Windows.Forms.Button();
            this.removeObjetivo_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeRegra_label
            // 
            this.nomeRegra_label.AutoSize = true;
            this.nomeRegra_label.Location = new System.Drawing.Point(35, 24);
            this.nomeRegra_label.Name = "nomeRegra_label";
            this.nomeRegra_label.Size = new System.Drawing.Size(82, 13);
            this.nomeRegra_label.TabIndex = 0;
            this.nomeRegra_label.Text = "Nome da Regra";
            // 
            // novaRegra_txtbox
            // 
            this.novaRegra_txtbox.Location = new System.Drawing.Point(123, 22);
            this.novaRegra_txtbox.Name = "novaRegra_txtbox";
            this.novaRegra_txtbox.Size = new System.Drawing.Size(100, 20);
            this.novaRegra_txtbox.TabIndex = 1;
            this.novaRegra_txtbox.TextChanged += new System.EventHandler(this.novaRegra_txtbox_TextChanged);
            // 
            // entao_label
            // 
            this.entao_label.AutoSize = true;
            this.entao_label.Location = new System.Drawing.Point(64, 255);
            this.entao_label.Name = "entao_label";
            this.entao_label.Size = new System.Drawing.Size(44, 13);
            this.entao_label.TabIndex = 6;
            this.entao_label.Text = "ENTÃO";
            // 
            // addCondicao_btn
            // 
            this.addCondicao_btn.Location = new System.Drawing.Point(316, 104);
            this.addCondicao_btn.Name = "addCondicao_btn";
            this.addCondicao_btn.Size = new System.Drawing.Size(41, 23);
            this.addCondicao_btn.TabIndex = 8;
            this.addCondicao_btn.Text = "+";
            this.addCondicao_btn.UseVisualStyleBackColor = true;
            this.addCondicao_btn.Click += new System.EventHandler(this.addCondicao_btn_Click);
            // 
            // listaCondicao_listbox
            // 
            this.listaCondicao_listbox.FormattingEnabled = true;
            this.listaCondicao_listbox.Location = new System.Drawing.Point(65, 98);
            this.listaCondicao_listbox.Name = "listaCondicao_listbox";
            this.listaCondicao_listbox.Size = new System.Drawing.Size(227, 69);
            this.listaCondicao_listbox.TabIndex = 9;
            this.listaCondicao_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listaCondicao_listbox_Format);
            // 
            // se_label
            // 
            this.se_label.AutoSize = true;
            this.se_label.Location = new System.Drawing.Point(64, 82);
            this.se_label.Name = "se_label";
            this.se_label.Size = new System.Drawing.Size(21, 13);
            this.se_label.TabIndex = 2;
            this.se_label.Text = "SE";
            // 
            // listaObjetivos_listbox
            // 
            this.listaObjetivos_listbox.FormattingEnabled = true;
            this.listaObjetivos_listbox.Location = new System.Drawing.Point(65, 273);
            this.listaObjetivos_listbox.Name = "listaObjetivos_listbox";
            this.listaObjetivos_listbox.Size = new System.Drawing.Size(227, 69);
            this.listaObjetivos_listbox.TabIndex = 10;
            this.listaObjetivos_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listaObjetivos_listbox_Format);
            // 
            // addObjetivo_btn
            // 
            this.addObjetivo_btn.Location = new System.Drawing.Point(316, 280);
            this.addObjetivo_btn.Name = "addObjetivo_btn";
            this.addObjetivo_btn.Size = new System.Drawing.Size(41, 23);
            this.addObjetivo_btn.TabIndex = 11;
            this.addObjetivo_btn.Text = "+";
            this.addObjetivo_btn.UseVisualStyleBackColor = true;
            this.addObjetivo_btn.Click += new System.EventHandler(this.addObjetivo_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(294, 400);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 12;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // removeCondicao_btn
            // 
            this.removeCondicao_btn.Location = new System.Drawing.Point(316, 134);
            this.removeCondicao_btn.Name = "removeCondicao_btn";
            this.removeCondicao_btn.Size = new System.Drawing.Size(41, 23);
            this.removeCondicao_btn.TabIndex = 13;
            this.removeCondicao_btn.Text = "-";
            this.removeCondicao_btn.UseVisualStyleBackColor = true;
            this.removeCondicao_btn.Click += new System.EventHandler(this.removeCondicao_btn_Click);
            // 
            // removeObjetivo_btn
            // 
            this.removeObjetivo_btn.Location = new System.Drawing.Point(316, 313);
            this.removeObjetivo_btn.Name = "removeObjetivo_btn";
            this.removeObjetivo_btn.Size = new System.Drawing.Size(41, 23);
            this.removeObjetivo_btn.TabIndex = 14;
            this.removeObjetivo_btn.Text = "-";
            this.removeObjetivo_btn.UseVisualStyleBackColor = true;
            this.removeObjetivo_btn.Click += new System.EventHandler(this.removeObjetivo_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(201, 400);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.cancelar_btn.TabIndex = 15;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdicionarRegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.removeObjetivo_btn);
            this.Controls.Add(this.removeCondicao_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.addObjetivo_btn);
            this.Controls.Add(this.listaObjetivos_listbox);
            this.Controls.Add(this.listaCondicao_listbox);
            this.Controls.Add(this.addCondicao_btn);
            this.Controls.Add(this.entao_label);
            this.Controls.Add(this.se_label);
            this.Controls.Add(this.novaRegra_txtbox);
            this.Controls.Add(this.nomeRegra_label);
            this.Name = "AdicionarRegra";
            this.Text = "AdicionarRegra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeRegra_label;
        private System.Windows.Forms.TextBox novaRegra_txtbox;
        private System.Windows.Forms.Label entao_label;
        private System.Windows.Forms.Button addCondicao_btn;
        private System.Windows.Forms.ListBox listaCondicao_listbox;
        private System.Windows.Forms.Label se_label;
        private System.Windows.Forms.ListBox listaObjetivos_listbox;
        private System.Windows.Forms.Button addObjetivo_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button removeCondicao_btn;
        private System.Windows.Forms.Button removeObjetivo_btn;
        private System.Windows.Forms.Button cancelar_btn;
    }
}