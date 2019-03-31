namespace Project
{
    partial class VisualizarRegra
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
            this.listaObjetivos_listbox = new System.Windows.Forms.ListBox();
            this.listaCondicao_listbox = new System.Windows.Forms.ListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // listaObjetivos_listbox
            // 
            this.listaObjetivos_listbox.FormattingEnabled = true;
            this.listaObjetivos_listbox.Location = new System.Drawing.Point(48, 232);
            this.listaObjetivos_listbox.Name = "listaObjetivos_listbox";
            this.listaObjetivos_listbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listaObjetivos_listbox.Size = new System.Drawing.Size(290, 69);
            this.listaObjetivos_listbox.TabIndex = 14;
            this.listaObjetivos_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listaObjetivos_listbox_Format);
            // 
            // listaCondicao_listbox
            // 
            this.listaCondicao_listbox.FormattingEnabled = true;
            this.listaCondicao_listbox.Location = new System.Drawing.Point(48, 108);
            this.listaCondicao_listbox.Name = "listaCondicao_listbox";
            this.listaCondicao_listbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listaCondicao_listbox.Size = new System.Drawing.Size(290, 69);
            this.listaCondicao_listbox.TabIndex = 13;
            this.listaCondicao_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listaCondicao_listbox_Format);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(48, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(27, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "SE";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(48, 210);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "ENTÃO";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 328);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(360, 1);
            this.materialDivider1.TabIndex = 17;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(272, 339);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(89, 35);
            this.materialRaisedButton1.TabIndex = 18;
            this.materialRaisedButton1.Text = "OK";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // VisualizarRegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 386);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listaObjetivos_listbox);
            this.Controls.Add(this.listaCondicao_listbox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(384, 386);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(384, 386);
            this.Name = "VisualizarRegra";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizarRegra";
            this.Load += new System.EventHandler(this.VisualizarRegra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaObjetivos_listbox;
        private System.Windows.Forms.ListBox listaCondicao_listbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}