namespace Project
{
    partial class AdicionarObjetivo
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
            this.nomeObjetivo_label = new System.Windows.Forms.Label();
            this.salvarObjetivo_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.objetivosAlvo_listbox = new System.Windows.Forms.ListBox();
            this.listaObjetivos_label = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.objetivos_listbox = new System.Windows.Forms.ListBox();
            this.addObjetivo_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeObjetivo_label
            // 
            this.nomeObjetivo_label.AutoSize = true;
            this.nomeObjetivo_label.Location = new System.Drawing.Point(12, 15);
            this.nomeObjetivo_label.Name = "nomeObjetivo_label";
            this.nomeObjetivo_label.Size = new System.Drawing.Size(51, 13);
            this.nomeObjetivo_label.TabIndex = 0;
            this.nomeObjetivo_label.Text = "Objetivos";
            // 
            // salvarObjetivo_btn
            // 
            this.salvarObjetivo_btn.Location = new System.Drawing.Point(470, 347);
            this.salvarObjetivo_btn.Name = "salvarObjetivo_btn";
            this.salvarObjetivo_btn.Size = new System.Drawing.Size(75, 23);
            this.salvarObjetivo_btn.TabIndex = 4;
            this.salvarObjetivo_btn.Text = "Salvar";
            this.salvarObjetivo_btn.UseVisualStyleBackColor = true;
            this.salvarObjetivo_btn.Click += new System.EventHandler(this.salvarObjetivo_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(551, 347);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.cancelar_btn.TabIndex = 5;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // objetivosAlvo_listbox
            // 
            this.objetivosAlvo_listbox.FormattingEnabled = true;
            this.objetivosAlvo_listbox.Location = new System.Drawing.Point(384, 40);
            this.objetivosAlvo_listbox.Name = "objetivosAlvo_listbox";
            this.objetivosAlvo_listbox.Size = new System.Drawing.Size(242, 134);
            this.objetivosAlvo_listbox.TabIndex = 6;
            this.objetivosAlvo_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.list_Objetivos_Format);
            // 
            // listaObjetivos_label
            // 
            this.listaObjetivos_label.AutoSize = true;
            this.listaObjetivos_label.Location = new System.Drawing.Point(381, 15);
            this.listaObjetivos_label.Name = "listaObjetivos_label";
            this.listaObjetivos_label.Size = new System.Drawing.Size(70, 13);
            this.listaObjetivos_label.TabIndex = 7;
            this.listaObjetivos_label.Text = "Objetivo Alvo";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(395, 180);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // objetivos_listbox
            // 
            this.objetivos_listbox.FormattingEnabled = true;
            this.objetivos_listbox.Location = new System.Drawing.Point(15, 40);
            this.objetivos_listbox.Name = "objetivos_listbox";
            this.objetivos_listbox.Size = new System.Drawing.Size(242, 134);
            this.objetivos_listbox.TabIndex = 9;
            this.objetivos_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.objetivos_listbox_Format);
            // 
            // addObjetivo_btn
            // 
            this.addObjetivo_btn.Location = new System.Drawing.Point(294, 86);
            this.addObjetivo_btn.Name = "addObjetivo_btn";
            this.addObjetivo_btn.Size = new System.Drawing.Size(58, 45);
            this.addObjetivo_btn.TabIndex = 10;
            this.addObjetivo_btn.Text = ">";
            this.addObjetivo_btn.UseVisualStyleBackColor = true;
            this.addObjetivo_btn.Click += new System.EventHandler(this.addObjetivo_btn_Click);
            // 
            // AdicionarObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 387);
            this.Controls.Add(this.addObjetivo_btn);
            this.Controls.Add(this.objetivos_listbox);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.listaObjetivos_label);
            this.Controls.Add(this.objetivosAlvo_listbox);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.salvarObjetivo_btn);
            this.Controls.Add(this.nomeObjetivo_label);
            this.Name = "AdicionarObjetivo";
            this.Text = "AdicionarObjetivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeObjetivo_label;
        private System.Windows.Forms.Button salvarObjetivo_btn;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.ListBox objetivosAlvo_listbox;
        private System.Windows.Forms.Label listaObjetivos_label;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListBox objetivos_listbox;
        private System.Windows.Forms.Button addObjetivo_btn;
    }
}