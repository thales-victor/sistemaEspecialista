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
            this.se_label = new MaterialSkin.Controls.MaterialLabel();
            this.fato_combobox = new System.Windows.Forms.ComboBox();
            this.operador_combobox = new System.Windows.Forms.ComboBox();
            this.resposta_combobox = new System.Windows.Forms.ComboBox();
            this.gb_Group = new System.Windows.Forms.GroupBox();
            this.ou_radio = new MaterialSkin.Controls.MaterialRadioButton();
            this.e_radio = new MaterialSkin.Controls.MaterialRadioButton();
            this.ok_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cancelar_btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.respostaNumerica = new System.Windows.Forms.NumericUpDown();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.gb_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.respostaNumerica)).BeginInit();
            this.SuspendLayout();
            // 
            // se_label
            // 
            this.se_label.AutoSize = true;
            this.se_label.Depth = 0;
            this.se_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.se_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.se_label.Location = new System.Drawing.Point(144, 112);
            this.se_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.se_label.Name = "se_label";
            this.se_label.Size = new System.Drawing.Size(27, 19);
            this.se_label.TabIndex = 0;
            this.se_label.Text = "SE";
            // 
            // fato_combobox
            // 
            this.fato_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fato_combobox.FormattingEnabled = true;
            this.fato_combobox.Location = new System.Drawing.Point(177, 111);
            this.fato_combobox.Name = "fato_combobox";
            this.fato_combobox.Size = new System.Drawing.Size(121, 21);
            this.fato_combobox.TabIndex = 1;
            this.fato_combobox.SelectedIndexChanged += new System.EventHandler(this.fato_combobox_SelectedIndexChanged);
            // 
            // operador_combobox
            // 
            this.operador_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operador_combobox.FormattingEnabled = true;
            this.operador_combobox.Location = new System.Drawing.Point(321, 111);
            this.operador_combobox.Name = "operador_combobox";
            this.operador_combobox.Size = new System.Drawing.Size(54, 21);
            this.operador_combobox.TabIndex = 2;
            // 
            // resposta_combobox
            // 
            this.resposta_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resposta_combobox.FormattingEnabled = true;
            this.resposta_combobox.Location = new System.Drawing.Point(392, 111);
            this.resposta_combobox.Name = "resposta_combobox";
            this.resposta_combobox.Size = new System.Drawing.Size(121, 21);
            this.resposta_combobox.TabIndex = 3;
            // 
            // gb_Group
            // 
            this.gb_Group.Controls.Add(this.ou_radio);
            this.gb_Group.Controls.Add(this.e_radio);
            this.gb_Group.Location = new System.Drawing.Point(18, 87);
            this.gb_Group.Name = "gb_Group";
            this.gb_Group.Size = new System.Drawing.Size(108, 93);
            this.gb_Group.TabIndex = 4;
            this.gb_Group.TabStop = false;
            this.gb_Group.Text = "Conectivo";
            // 
            // ou_radio
            // 
            this.ou_radio.AutoSize = true;
            this.ou_radio.Depth = 0;
            this.ou_radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.ou_radio.Location = new System.Drawing.Point(29, 51);
            this.ou_radio.Margin = new System.Windows.Forms.Padding(0);
            this.ou_radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ou_radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.ou_radio.Name = "ou_radio";
            this.ou_radio.Ripple = true;
            this.ou_radio.Size = new System.Drawing.Size(47, 30);
            this.ou_radio.TabIndex = 1;
            this.ou_radio.Text = "OU";
            this.ou_radio.UseVisualStyleBackColor = true;
            // 
            // e_radio
            // 
            this.e_radio.AutoSize = true;
            this.e_radio.Checked = true;
            this.e_radio.Depth = 0;
            this.e_radio.Font = new System.Drawing.Font("Roboto", 10F);
            this.e_radio.Location = new System.Drawing.Point(29, 19);
            this.e_radio.Margin = new System.Windows.Forms.Padding(0);
            this.e_radio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.e_radio.MouseState = MaterialSkin.MouseState.HOVER;
            this.e_radio.Name = "e_radio";
            this.e_radio.Ripple = true;
            this.e_radio.Size = new System.Drawing.Size(37, 30);
            this.e_radio.TabIndex = 0;
            this.e_radio.TabStop = true;
            this.e_radio.Text = "E";
            this.e_radio.UseVisualStyleBackColor = true;
            // 
            // ok_btn
            // 
            this.ok_btn.Depth = 0;
            this.ok_btn.Location = new System.Drawing.Point(439, 224);
            this.ok_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Primary = true;
            this.ok_btn.Size = new System.Drawing.Size(82, 36);
            this.ok_btn.TabIndex = 5;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.AutoSize = true;
            this.cancelar_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelar_btn.Depth = 0;
            this.cancelar_btn.Location = new System.Drawing.Point(350, 224);
            this.cancelar_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelar_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Primary = false;
            this.cancelar_btn.Size = new System.Drawing.Size(82, 36);
            this.cancelar_btn.TabIndex = 6;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // respostaNumerica
            // 
            this.respostaNumerica.Location = new System.Drawing.Point(393, 112);
            this.respostaNumerica.Name = "respostaNumerica";
            this.respostaNumerica.ReadOnly = true;
            this.respostaNumerica.Size = new System.Drawing.Size(120, 20);
            this.respostaNumerica.TabIndex = 7;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(11, 209);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(512, 1);
            this.materialDivider1.TabIndex = 8;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // NovaRegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 272);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.respostaNumerica);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.gb_Group);
            this.Controls.Add(this.resposta_combobox);
            this.Controls.Add(this.operador_combobox);
            this.Controls.Add(this.fato_combobox);
            this.Controls.Add(this.se_label);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(533, 272);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(533, 272);
            this.Name = "NovaRegra";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Condição";
            this.Load += new System.EventHandler(this.NovaRegra_Load);
            this.gb_Group.ResumeLayout(false);
            this.gb_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.respostaNumerica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel se_label;
        private System.Windows.Forms.ComboBox fato_combobox;
        private System.Windows.Forms.ComboBox operador_combobox;
        private System.Windows.Forms.ComboBox resposta_combobox;
        private System.Windows.Forms.GroupBox gb_Group;
        private MaterialSkin.Controls.MaterialRadioButton ou_radio;
        private MaterialSkin.Controls.MaterialRadioButton e_radio;
        private MaterialSkin.Controls.MaterialRaisedButton ok_btn;
        private MaterialSkin.Controls.MaterialFlatButton cancelar_btn;
        private System.Windows.Forms.NumericUpDown respostaNumerica;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}