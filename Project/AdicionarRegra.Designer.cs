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
            this.nomeRegra_label = new MaterialSkin.Controls.MaterialLabel();
            this.novaRegra_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.entao_label = new MaterialSkin.Controls.MaterialLabel();
            this.addCondicao_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listaCondicao_listbox = new System.Windows.Forms.ListBox();
            this.se_label = new MaterialSkin.Controls.MaterialLabel();
            this.listaObjetivos_listbox = new System.Windows.Forms.ListBox();
            this.addObjetivo_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ok_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.removeObjetivo_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeRegra_label
            // 
            this.nomeRegra_label.AutoSize = true;
            this.nomeRegra_label.Depth = 0;
            this.nomeRegra_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.nomeRegra_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nomeRegra_label.Location = new System.Drawing.Point(14, 79);
            this.nomeRegra_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomeRegra_label.Name = "nomeRegra_label";
            this.nomeRegra_label.Size = new System.Drawing.Size(112, 19);
            this.nomeRegra_label.TabIndex = 0;
            this.nomeRegra_label.Text = "Nome da Regra";
            // 
            // novaRegra_txtbox
            // 
            this.novaRegra_txtbox.Depth = 0;
            this.novaRegra_txtbox.Hint = "";
            this.novaRegra_txtbox.Location = new System.Drawing.Point(132, 79);
            this.novaRegra_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.novaRegra_txtbox.Name = "novaRegra_txtbox";
            this.novaRegra_txtbox.PasswordChar = '\0';
            this.novaRegra_txtbox.SelectedText = "";
            this.novaRegra_txtbox.SelectionLength = 0;
            this.novaRegra_txtbox.SelectionStart = 0;
            this.novaRegra_txtbox.Size = new System.Drawing.Size(153, 23);
            this.novaRegra_txtbox.TabIndex = 1;
            this.novaRegra_txtbox.UseSystemPasswordChar = false;
            this.novaRegra_txtbox.TextChanged += new System.EventHandler(this.novaRegra_txtbox_TextChanged);
            // 
            // entao_label
            // 
            this.entao_label.AutoSize = true;
            this.entao_label.Depth = 0;
            this.entao_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.entao_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.entao_label.Location = new System.Drawing.Point(44, 241);
            this.entao_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.entao_label.Name = "entao_label";
            this.entao_label.Size = new System.Drawing.Size(58, 19);
            this.entao_label.TabIndex = 6;
            this.entao_label.Text = "ENTÃO";
            // 
            // addCondicao_btn
            // 
            this.addCondicao_btn.Depth = 0;
            this.addCondicao_btn.Location = new System.Drawing.Point(309, 148);
            this.addCondicao_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCondicao_btn.Name = "addCondicao_btn";
            this.addCondicao_btn.Primary = true;
            this.addCondicao_btn.Size = new System.Drawing.Size(41, 23);
            this.addCondicao_btn.TabIndex = 8;
            this.addCondicao_btn.Text = "+";
            this.addCondicao_btn.UseVisualStyleBackColor = true;
            this.addCondicao_btn.Click += new System.EventHandler(this.addCondicao_btn_Click);
            // 
            // listaCondicao_listbox
            // 
            this.listaCondicao_listbox.FormattingEnabled = true;
            this.listaCondicao_listbox.Location = new System.Drawing.Point(45, 142);
            this.listaCondicao_listbox.Name = "listaCondicao_listbox";
            this.listaCondicao_listbox.Size = new System.Drawing.Size(238, 69);
            this.listaCondicao_listbox.TabIndex = 9;
            this.listaCondicao_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listaCondicao_listbox_Format);
            // 
            // se_label
            // 
            this.se_label.AutoSize = true;
            this.se_label.Depth = 0;
            this.se_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.se_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.se_label.Location = new System.Drawing.Point(44, 120);
            this.se_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.se_label.Name = "se_label";
            this.se_label.Size = new System.Drawing.Size(27, 19);
            this.se_label.TabIndex = 2;
            this.se_label.Text = "SE";
            // 
            // listaObjetivos_listbox
            // 
            this.listaObjetivos_listbox.FormattingEnabled = true;
            this.listaObjetivos_listbox.Location = new System.Drawing.Point(45, 263);
            this.listaObjetivos_listbox.Name = "listaObjetivos_listbox";
            this.listaObjetivos_listbox.Size = new System.Drawing.Size(238, 69);
            this.listaObjetivos_listbox.TabIndex = 10;
            this.listaObjetivos_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listaObjetivos_listbox_Format);
            // 
            // addObjetivo_btn
            // 
            this.addObjetivo_btn.Depth = 0;
            this.addObjetivo_btn.Location = new System.Drawing.Point(309, 270);
            this.addObjetivo_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addObjetivo_btn.Name = "addObjetivo_btn";
            this.addObjetivo_btn.Primary = true;
            this.addObjetivo_btn.Size = new System.Drawing.Size(41, 23);
            this.addObjetivo_btn.TabIndex = 11;
            this.addObjetivo_btn.Text = "+";
            this.addObjetivo_btn.UseVisualStyleBackColor = true;
            this.addObjetivo_btn.Click += new System.EventHandler(this.addObjetivo_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Depth = 0;
            this.ok_btn.Location = new System.Drawing.Point(298, 400);
            this.ok_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Primary = true;
            this.ok_btn.Size = new System.Drawing.Size(82, 36);
            this.ok_btn.TabIndex = 12;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // removeObjetivo_btn
            // 
            this.removeObjetivo_btn.Location = new System.Drawing.Point(309, 303);
            this.removeObjetivo_btn.Name = "removeObjetivo_btn";
            this.removeObjetivo_btn.Size = new System.Drawing.Size(41, 23);
            this.removeObjetivo_btn.TabIndex = 14;
            this.removeObjetivo_btn.Text = "-";
            this.removeObjetivo_btn.UseVisualStyleBackColor = true;
            this.removeObjetivo_btn.Click += new System.EventHandler(this.removeObjetivo_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.AutoSize = true;
            this.cancelar_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelar_btn.Depth = 0;
            this.cancelar_btn.Location = new System.Drawing.Point(209, 400);
            this.cancelar_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelar_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Primary = false;
            this.cancelar_btn.Size = new System.Drawing.Size(82, 36);
            this.cancelar_btn.TabIndex = 15;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(11, 387);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(374, 1);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdicionarRegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.removeObjetivo_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.addObjetivo_btn);
            this.Controls.Add(this.listaObjetivos_listbox);
            this.Controls.Add(this.listaCondicao_listbox);
            this.Controls.Add(this.addCondicao_btn);
            this.Controls.Add(this.entao_label);
            this.Controls.Add(this.se_label);
            this.Controls.Add(this.novaRegra_txtbox);
            this.Controls.Add(this.nomeRegra_label);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(395, 450);
            this.Name = "AdicionarRegra";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Regra";
            this.Load += new System.EventHandler(this.AdicionarRegra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel nomeRegra_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField novaRegra_txtbox;
        private MaterialSkin.Controls.MaterialLabel entao_label;
        private MaterialSkin.Controls.MaterialRaisedButton addCondicao_btn;
        private System.Windows.Forms.ListBox listaCondicao_listbox;
        private MaterialSkin.Controls.MaterialLabel se_label;
        private System.Windows.Forms.ListBox listaObjetivos_listbox;
        private MaterialSkin.Controls.MaterialRaisedButton addObjetivo_btn;
        private MaterialSkin.Controls.MaterialRaisedButton ok_btn;
        private System.Windows.Forms.Button removeObjetivo_btn;
        private MaterialSkin.Controls.MaterialFlatButton cancelar_btn;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Button button1;
    }
}