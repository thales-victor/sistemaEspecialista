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
            this.entao_combobox = new System.Windows.Forms.ComboBox();
            this.addCondicao_btn = new System.Windows.Forms.Button();
            this.listaCondicao_listbox = new System.Windows.Forms.ListBox();
            this.se_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeRegra_label
            // 
            this.nomeRegra_label.AutoSize = true;
            this.nomeRegra_label.Location = new System.Drawing.Point(48, 39);
            this.nomeRegra_label.Name = "nomeRegra_label";
            this.nomeRegra_label.Size = new System.Drawing.Size(82, 13);
            this.nomeRegra_label.TabIndex = 0;
            this.nomeRegra_label.Text = "Nome da Regra";
            // 
            // novaRegra_txtbox
            // 
            this.novaRegra_txtbox.Location = new System.Drawing.Point(136, 36);
            this.novaRegra_txtbox.Name = "novaRegra_txtbox";
            this.novaRegra_txtbox.Size = new System.Drawing.Size(100, 20);
            this.novaRegra_txtbox.TabIndex = 1;
            // 
            // entao_label
            // 
            this.entao_label.AutoSize = true;
            this.entao_label.Location = new System.Drawing.Point(71, 313);
            this.entao_label.Name = "entao_label";
            this.entao_label.Size = new System.Drawing.Size(44, 13);
            this.entao_label.TabIndex = 6;
            this.entao_label.Text = "ENTÃO";
            // 
            // entao_combobox
            // 
            this.entao_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entao_combobox.FormattingEnabled = true;
            this.entao_combobox.Location = new System.Drawing.Point(74, 340);
            this.entao_combobox.Name = "entao_combobox";
            this.entao_combobox.Size = new System.Drawing.Size(146, 21);
            this.entao_combobox.TabIndex = 7;
            // 
            // addCondicao_btn
            // 
            this.addCondicao_btn.Location = new System.Drawing.Point(575, 120);
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
            this.listaCondicao_listbox.Location = new System.Drawing.Point(74, 109);
            this.listaCondicao_listbox.Name = "listaCondicao_listbox";
            this.listaCondicao_listbox.Size = new System.Drawing.Size(227, 69);
            this.listaCondicao_listbox.TabIndex = 9;
            this.listaCondicao_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listaCondicao_listbox_Format);
            // 
            // se_label
            // 
            this.se_label.AutoSize = true;
            this.se_label.Location = new System.Drawing.Point(71, 93);
            this.se_label.Name = "se_label";
            this.se_label.Size = new System.Drawing.Size(21, 13);
            this.se_label.TabIndex = 2;
            this.se_label.Text = "SE";
            // 
            // AdicionarRegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaCondicao_listbox);
            this.Controls.Add(this.addCondicao_btn);
            this.Controls.Add(this.entao_combobox);
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
        private System.Windows.Forms.ComboBox entao_combobox;
        private System.Windows.Forms.Button addCondicao_btn;
        private System.Windows.Forms.ListBox listaCondicao_listbox;
        private System.Windows.Forms.Label se_label;
    }
}