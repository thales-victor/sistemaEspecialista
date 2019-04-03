namespace Project
{
    partial class Perguntas
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
            this.pergunta_label = new MaterialSkin.Controls.MaterialLabel();
            this.button1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // pergunta_label
            // 
            this.pergunta_label.AutoSize = true;
            this.pergunta_label.Depth = 0;
            this.pergunta_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.pergunta_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pergunta_label.Location = new System.Drawing.Point(12, 75);
            this.pergunta_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.pergunta_label.Name = "pergunta_label";
            this.pergunta_label.Size = new System.Drawing.Size(113, 19);
            this.pergunta_label.TabIndex = 0;
            this.pergunta_label.Text = "Qual o valor de ";
            // 
            // button1
            // 
            this.button1.Depth = 0;
            this.button1.Location = new System.Drawing.Point(163, 347);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = true;
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 335);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(396, 1);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // Perguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 393);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pergunta_label);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 393);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 393);
            this.Name = "Perguntas";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perguntas";
            this.Load += new System.EventHandler(this.Perguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel pergunta_label;
        private MaterialSkin.Controls.MaterialRaisedButton button1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}