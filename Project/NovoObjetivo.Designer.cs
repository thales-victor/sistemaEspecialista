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
            this.cancelar_btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.ok_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.resposta_combobox = new System.Windows.Forms.ComboBox();
            this.operador_combobox = new System.Windows.Forms.ComboBox();
            this.fato_combobox = new System.Windows.Forms.ComboBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.entao_label = new MaterialSkin.Controls.MaterialLabel();
            this.respostaNumerica = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.respostaNumerica)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.AutoSize = true;
            this.cancelar_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelar_btn.Depth = 0;
            this.cancelar_btn.Location = new System.Drawing.Point(199, 201);
            this.cancelar_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelar_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Primary = false;
            this.cancelar_btn.Size = new System.Drawing.Size(82, 36);
            this.cancelar_btn.TabIndex = 14;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Depth = 0;
            this.ok_btn.Location = new System.Drawing.Point(288, 201);
            this.ok_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Primary = true;
            this.ok_btn.Size = new System.Drawing.Size(82, 36);
            this.ok_btn.TabIndex = 13;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // resposta_combobox
            // 
            this.resposta_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resposta_combobox.FormattingEnabled = true;
            this.resposta_combobox.Location = new System.Drawing.Point(239, 117);
            this.resposta_combobox.Name = "resposta_combobox";
            this.resposta_combobox.Size = new System.Drawing.Size(121, 21);
            this.resposta_combobox.TabIndex = 11;
            // 
            // operador_combobox
            // 
            this.operador_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operador_combobox.FormattingEnabled = true;
            this.operador_combobox.Location = new System.Drawing.Point(168, 117);
            this.operador_combobox.Name = "operador_combobox";
            this.operador_combobox.Size = new System.Drawing.Size(54, 21);
            this.operador_combobox.TabIndex = 10;
            // 
            // fato_combobox
            // 
            this.fato_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fato_combobox.FormattingEnabled = true;
            this.fato_combobox.Location = new System.Drawing.Point(24, 117);
            this.fato_combobox.Name = "fato_combobox";
            this.fato_combobox.Size = new System.Drawing.Size(121, 21);
            this.fato_combobox.TabIndex = 9;
            this.fato_combobox.SelectedIndexChanged += new System.EventHandler(this.fato_combobox_SelectedIndexChanged);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(10, 189);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(362, 1);
            this.materialDivider1.TabIndex = 15;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // entao_label
            // 
            this.entao_label.AutoSize = true;
            this.entao_label.Depth = 0;
            this.entao_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.entao_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.entao_label.Location = new System.Drawing.Point(24, 81);
            this.entao_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.entao_label.Name = "entao_label";
            this.entao_label.Size = new System.Drawing.Size(58, 19);
            this.entao_label.TabIndex = 16;
            this.entao_label.Text = "ENTÃO";
            // 
            // respostaNumerica
            // 
            this.respostaNumerica.Location = new System.Drawing.Point(240, 118);
            this.respostaNumerica.Name = "respostaNumerica";
            this.respostaNumerica.ReadOnly = true;
            this.respostaNumerica.Size = new System.Drawing.Size(120, 20);
            this.respostaNumerica.TabIndex = 17;
            // 
            // NovoObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 249);
            this.Controls.Add(this.respostaNumerica);
            this.Controls.Add(this.entao_label);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.resposta_combobox);
            this.Controls.Add(this.operador_combobox);
            this.Controls.Add(this.fato_combobox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 249);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 249);
            this.Name = "NovoObjetivo";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Objetivo";
            this.Load += new System.EventHandler(this.NovoObjetivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.respostaNumerica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton cancelar_btn;
        private MaterialSkin.Controls.MaterialRaisedButton ok_btn;
        private System.Windows.Forms.ComboBox resposta_combobox;
        private System.Windows.Forms.ComboBox operador_combobox;
        private System.Windows.Forms.ComboBox fato_combobox;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel entao_label;
        private System.Windows.Forms.NumericUpDown respostaNumerica;
    }
}