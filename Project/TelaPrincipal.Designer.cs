namespace Project
{
    partial class frmMain
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.criarObjetivo_btn = new System.Windows.Forms.Button();
            this.criarRegra_btn = new System.Windows.Forms.Button();
            this.regrasCriadas_listbox = new System.Windows.Forms.ListBox();
            this.regrasCriadas_label = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pnTop.Controls.Add(this.button1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(679, 45);
            this.pnTop.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fatos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // criarObjetivo_btn
            // 
            this.criarObjetivo_btn.Location = new System.Drawing.Point(297, 108);
            this.criarObjetivo_btn.Name = "criarObjetivo_btn";
            this.criarObjetivo_btn.Size = new System.Drawing.Size(75, 23);
            this.criarObjetivo_btn.TabIndex = 2;
            this.criarObjetivo_btn.Text = "Objetivos";
            this.criarObjetivo_btn.UseVisualStyleBackColor = true;
            this.criarObjetivo_btn.Click += new System.EventHandler(this.criarObjetivo_btn_Click);
            // 
            // criarRegra_btn
            // 
            this.criarRegra_btn.Location = new System.Drawing.Point(482, 108);
            this.criarRegra_btn.Name = "criarRegra_btn";
            this.criarRegra_btn.Size = new System.Drawing.Size(75, 23);
            this.criarRegra_btn.TabIndex = 3;
            this.criarRegra_btn.Text = "Regras";
            this.criarRegra_btn.UseVisualStyleBackColor = true;
            this.criarRegra_btn.Click += new System.EventHandler(this.criarRegra_btn_Click);
            // 
            // regrasCriadas_listbox
            // 
            this.regrasCriadas_listbox.FormattingEnabled = true;
            this.regrasCriadas_listbox.Location = new System.Drawing.Point(482, 184);
            this.regrasCriadas_listbox.Name = "regrasCriadas_listbox";
            this.regrasCriadas_listbox.Size = new System.Drawing.Size(120, 95);
            this.regrasCriadas_listbox.TabIndex = 4;
            this.regrasCriadas_listbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.regrasCriadas_listbox_Format);
            // 
            // regrasCriadas_label
            // 
            this.regrasCriadas_label.AutoSize = true;
            this.regrasCriadas_label.ForeColor = System.Drawing.SystemColors.Control;
            this.regrasCriadas_label.Location = new System.Drawing.Point(482, 165);
            this.regrasCriadas_label.Name = "regrasCriadas_label";
            this.regrasCriadas_label.Size = new System.Drawing.Size(78, 13);
            this.regrasCriadas_label.TabIndex = 5;
            this.regrasCriadas_label.Text = "Regras criadas";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(679, 497);
            this.Controls.Add(this.regrasCriadas_label);
            this.Controls.Add(this.regrasCriadas_listbox);
            this.Controls.Add(this.criarRegra_btn);
            this.Controls.Add(this.criarObjetivo_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button criarObjetivo_btn;
        private System.Windows.Forms.Button criarRegra_btn;
        private System.Windows.Forms.ListBox regrasCriadas_listbox;
        private System.Windows.Forms.Label regrasCriadas_label;
    }
}

