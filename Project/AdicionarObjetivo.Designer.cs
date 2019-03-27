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
            this.descObjetivo_label = new System.Windows.Forms.Label();
            this.nomeObjetivo_txtbox = new System.Windows.Forms.TextBox();
            this.descObjetivo_txtbox = new System.Windows.Forms.TextBox();
            this.salvarObjetivo_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.list_Objetivos = new System.Windows.Forms.ListBox();
            this.listaObjetivos_label = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeObjetivo_label
            // 
            this.nomeObjetivo_label.AutoSize = true;
            this.nomeObjetivo_label.Location = new System.Drawing.Point(78, 62);
            this.nomeObjetivo_label.Name = "nomeObjetivo_label";
            this.nomeObjetivo_label.Size = new System.Drawing.Size(35, 13);
            this.nomeObjetivo_label.TabIndex = 0;
            this.nomeObjetivo_label.Text = "Nome";
            // 
            // descObjetivo_label
            // 
            this.descObjetivo_label.AutoSize = true;
            this.descObjetivo_label.Location = new System.Drawing.Point(78, 101);
            this.descObjetivo_label.Name = "descObjetivo_label";
            this.descObjetivo_label.Size = new System.Drawing.Size(55, 13);
            this.descObjetivo_label.TabIndex = 1;
            this.descObjetivo_label.Text = "Descrição";
            // 
            // nomeObjetivo_txtbox
            // 
            this.nomeObjetivo_txtbox.Location = new System.Drawing.Point(155, 55);
            this.nomeObjetivo_txtbox.Name = "nomeObjetivo_txtbox";
            this.nomeObjetivo_txtbox.Size = new System.Drawing.Size(100, 20);
            this.nomeObjetivo_txtbox.TabIndex = 2;
            // 
            // descObjetivo_txtbox
            // 
            this.descObjetivo_txtbox.Location = new System.Drawing.Point(155, 98);
            this.descObjetivo_txtbox.Name = "descObjetivo_txtbox";
            this.descObjetivo_txtbox.Size = new System.Drawing.Size(100, 20);
            this.descObjetivo_txtbox.TabIndex = 3;
            // 
            // salvarObjetivo_btn
            // 
            this.salvarObjetivo_btn.Location = new System.Drawing.Point(526, 347);
            this.salvarObjetivo_btn.Name = "salvarObjetivo_btn";
            this.salvarObjetivo_btn.Size = new System.Drawing.Size(75, 23);
            this.salvarObjetivo_btn.TabIndex = 4;
            this.salvarObjetivo_btn.Text = "Salvar";
            this.salvarObjetivo_btn.UseVisualStyleBackColor = true;
            this.salvarObjetivo_btn.Click += new System.EventHandler(this.salvarObjetivo_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(669, 347);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.cancelar_btn.TabIndex = 5;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // list_Objetivos
            // 
            this.list_Objetivos.FormattingEnabled = true;
            this.list_Objetivos.Location = new System.Drawing.Point(459, 55);
            this.list_Objetivos.Name = "list_Objetivos";
            this.list_Objetivos.Size = new System.Drawing.Size(296, 95);
            this.list_Objetivos.TabIndex = 6;
            this.list_Objetivos.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.list_Objetivos_Format);
            // 
            // listaObjetivos_label
            // 
            this.listaObjetivos_label.AutoSize = true;
            this.listaObjetivos_label.Location = new System.Drawing.Point(456, 29);
            this.listaObjetivos_label.Name = "listaObjetivos_label";
            this.listaObjetivos_label.Size = new System.Drawing.Size(91, 13);
            this.listaObjetivos_label.TabIndex = 7;
            this.listaObjetivos_label.Text = "Lista de Objetivos";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(562, 166);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // AdicionarObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.listaObjetivos_label);
            this.Controls.Add(this.list_Objetivos);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.salvarObjetivo_btn);
            this.Controls.Add(this.descObjetivo_txtbox);
            this.Controls.Add(this.nomeObjetivo_txtbox);
            this.Controls.Add(this.descObjetivo_label);
            this.Controls.Add(this.nomeObjetivo_label);
            this.Name = "AdicionarObjetivo";
            this.Text = "AdicionarObjetivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeObjetivo_label;
        private System.Windows.Forms.Label descObjetivo_label;
        private System.Windows.Forms.TextBox nomeObjetivo_txtbox;
        private System.Windows.Forms.TextBox descObjetivo_txtbox;
        private System.Windows.Forms.Button salvarObjetivo_btn;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.ListBox list_Objetivos;
        private System.Windows.Forms.Label listaObjetivos_label;
        private System.Windows.Forms.Button btnRemover;
    }
}