namespace Project
{
    partial class NovoObjetivo
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
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.resposta_combobox = new System.Windows.Forms.ComboBox();
            this.operador_combobox = new System.Windows.Forms.ComboBox();
            this.fato_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(206, 114);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.cancelar_btn.TabIndex = 14;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(300, 114);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 13;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // resposta_combobox
            // 
            this.resposta_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resposta_combobox.FormattingEnabled = true;
            this.resposta_combobox.Location = new System.Drawing.Point(244, 40);
            this.resposta_combobox.Name = "resposta_combobox";
            this.resposta_combobox.Size = new System.Drawing.Size(121, 21);
            this.resposta_combobox.TabIndex = 11;
            // 
            // operador_combobox
            // 
            this.operador_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operador_combobox.FormattingEnabled = true;
            this.operador_combobox.Location = new System.Drawing.Point(173, 40);
            this.operador_combobox.Name = "operador_combobox";
            this.operador_combobox.Size = new System.Drawing.Size(54, 21);
            this.operador_combobox.TabIndex = 10;
            // 
            // fato_combobox
            // 
            this.fato_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fato_combobox.FormattingEnabled = true;
            this.fato_combobox.Location = new System.Drawing.Point(29, 40);
            this.fato_combobox.Name = "fato_combobox";
            this.fato_combobox.Size = new System.Drawing.Size(121, 21);
            this.fato_combobox.TabIndex = 9;
            // 
            // NovoObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 160);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.resposta_combobox);
            this.Controls.Add(this.operador_combobox);
            this.Controls.Add(this.fato_combobox);
            this.Name = "NovoObjetivo";
            this.Text = "NovoObjetivo";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.ComboBox resposta_combobox;
        private System.Windows.Forms.ComboBox operador_combobox;
        private System.Windows.Forms.ComboBox fato_combobox;
    }
}