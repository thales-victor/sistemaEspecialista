namespace Project
{
    partial class NovaRegra
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
            this.se_label = new System.Windows.Forms.Label();
            this.fato_combobox = new System.Windows.Forms.ComboBox();
            this.operador_combobox = new System.Windows.Forms.ComboBox();
            this.resposta_combobox = new System.Windows.Forms.ComboBox();
            this.gb_Group = new System.Windows.Forms.GroupBox();
            this.ou_radio = new System.Windows.Forms.RadioButton();
            this.e_radio = new System.Windows.Forms.RadioButton();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.respostaNumerica = new System.Windows.Forms.NumericUpDown();
            this.gb_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.respostaNumerica)).BeginInit();
            this.SuspendLayout();
            // 
            // se_label
            // 
            this.se_label.AutoSize = true;
            this.se_label.Location = new System.Drawing.Point(154, 39);
            this.se_label.Name = "se_label";
            this.se_label.Size = new System.Drawing.Size(21, 13);
            this.se_label.TabIndex = 0;
            this.se_label.Text = "SE";
            // 
            // fato_combobox
            // 
            this.fato_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fato_combobox.FormattingEnabled = true;
            this.fato_combobox.Location = new System.Drawing.Point(181, 36);
            this.fato_combobox.Name = "fato_combobox";
            this.fato_combobox.Size = new System.Drawing.Size(121, 21);
            this.fato_combobox.TabIndex = 1;
            this.fato_combobox.SelectedIndexChanged += new System.EventHandler(this.fato_combobox_SelectedIndexChanged);
            // 
            // operador_combobox
            // 
            this.operador_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operador_combobox.FormattingEnabled = true;
            this.operador_combobox.Location = new System.Drawing.Point(325, 36);
            this.operador_combobox.Name = "operador_combobox";
            this.operador_combobox.Size = new System.Drawing.Size(54, 21);
            this.operador_combobox.TabIndex = 2;
            // 
            // resposta_combobox
            // 
            this.resposta_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resposta_combobox.FormattingEnabled = true;
            this.resposta_combobox.Location = new System.Drawing.Point(396, 36);
            this.resposta_combobox.Name = "resposta_combobox";
            this.resposta_combobox.Size = new System.Drawing.Size(121, 21);
            this.resposta_combobox.TabIndex = 3;
            // 
            // gb_Group
            // 
            this.gb_Group.Controls.Add(this.ou_radio);
            this.gb_Group.Controls.Add(this.e_radio);
            this.gb_Group.Location = new System.Drawing.Point(12, 12);
            this.gb_Group.Name = "gb_Group";
            this.gb_Group.Size = new System.Drawing.Size(113, 71);
            this.gb_Group.TabIndex = 4;
            this.gb_Group.TabStop = false;
            this.gb_Group.Text = "Conectivo";
            // 
            // ou_radio
            // 
            this.ou_radio.AutoSize = true;
            this.ou_radio.Location = new System.Drawing.Point(17, 43);
            this.ou_radio.Name = "ou_radio";
            this.ou_radio.Size = new System.Drawing.Size(41, 17);
            this.ou_radio.TabIndex = 1;
            this.ou_radio.Text = "OU";
            this.ou_radio.UseVisualStyleBackColor = true;
            // 
            // e_radio
            // 
            this.e_radio.AutoSize = true;
            this.e_radio.Checked = true;
            this.e_radio.Location = new System.Drawing.Point(17, 20);
            this.e_radio.Name = "e_radio";
            this.e_radio.Size = new System.Drawing.Size(32, 17);
            this.e_radio.TabIndex = 0;
            this.e_radio.TabStop = true;
            this.e_radio.Text = "E";
            this.e_radio.UseVisualStyleBackColor = true;
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(442, 111);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 5;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(348, 111);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.cancelar_btn.TabIndex = 6;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // respostaNumerica
            // 
            this.respostaNumerica.Location = new System.Drawing.Point(397, 37);
            this.respostaNumerica.Name = "respostaNumerica";
            this.respostaNumerica.ReadOnly = true;
            this.respostaNumerica.Size = new System.Drawing.Size(120, 20);
            this.respostaNumerica.TabIndex = 7;
            // 
            // NovaRegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 148);
            this.Controls.Add(this.respostaNumerica);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.gb_Group);
            this.Controls.Add(this.resposta_combobox);
            this.Controls.Add(this.operador_combobox);
            this.Controls.Add(this.fato_combobox);
            this.Controls.Add(this.se_label);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "NovaRegra";
            this.Text = "NovaRegra";
            this.gb_Group.ResumeLayout(false);
            this.gb_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.respostaNumerica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label se_label;
        private System.Windows.Forms.ComboBox fato_combobox;
        private System.Windows.Forms.ComboBox operador_combobox;
        private System.Windows.Forms.ComboBox resposta_combobox;
        private System.Windows.Forms.GroupBox gb_Group;
        private System.Windows.Forms.RadioButton ou_radio;
        private System.Windows.Forms.RadioButton e_radio;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.NumericUpDown respostaNumerica;
    }
}