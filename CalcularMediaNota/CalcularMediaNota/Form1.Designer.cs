
namespace CalcularMediaNota
{
    partial class FormCalcular
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblMed = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSit = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(189, 262);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(205, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(189, 46);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(42, 15);
            this.lblNota1.TabIndex = 1;
            this.lblNota1.Text = "Nota 1";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(189, 82);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(42, 15);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Nota 2";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(189, 117);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(42, 15);
            this.lblNota3.TabIndex = 3;
            this.lblNota3.Text = "Nota 3";
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Location = new System.Drawing.Point(189, 163);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(40, 15);
            this.lblMed.TabIndex = 4;
            this.lblMed.Text = "Média";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(294, 163);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(0, 15);
            this.lblMedia.TabIndex = 5;
            // 
            // lblSit
            // 
            this.lblSit.AutoSize = true;
            this.lblSit.Location = new System.Drawing.Point(189, 208);
            this.lblSit.Name = "lblSit";
            this.lblSit.Size = new System.Drawing.Size(52, 15);
            this.lblSit.TabIndex = 6;
            this.lblSit.Text = "Situação";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(294, 208);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 15);
            this.lblSituacao.TabIndex = 7;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(294, 38);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 23);
            this.txtNota1.TabIndex = 8;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(294, 109);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 23);
            this.txtNota3.TabIndex = 9;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(294, 74);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 23);
            this.txtNota2.TabIndex = 10;
            // 
            // FormCalcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 429);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblSit);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FormCalcular";
            this.Text = "Calcular Média Nota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblSit;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
    }
}

