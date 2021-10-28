
namespace CalcularSoma
{
    partial class frmSoma
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.btnInteiro = new System.Windows.Forms.Button();
            this.btnReais = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.ressultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(53, 14);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(15, 15);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(53, 46);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 15);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(105, 6);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 23);
            this.txtValorA.TabIndex = 2;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(105, 38);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(100, 23);
            this.txtValorB.TabIndex = 3;
            // 
            // btnInteiro
            // 
            this.btnInteiro.Location = new System.Drawing.Point(223, 6);
            this.btnInteiro.Name = "btnInteiro";
            this.btnInteiro.Size = new System.Drawing.Size(75, 23);
            this.btnInteiro.TabIndex = 4;
            this.btnInteiro.Text = "Inteiro";
            this.btnInteiro.UseVisualStyleBackColor = true;
            this.btnInteiro.Click += new System.EventHandler(this.btnInteiro_Click);
            // 
            // btnReais
            // 
            this.btnReais.Location = new System.Drawing.Point(223, 38);
            this.btnReais.Name = "btnReais";
            this.btnReais.Size = new System.Drawing.Size(75, 23);
            this.btnReais.TabIndex = 5;
            this.btnReais.Text = "Reais";
            this.btnReais.UseVisualStyleBackColor = true;
            this.btnReais.Click += new System.EventHandler(this.btnReais_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(105, 74);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 23);
            this.txtResultado.TabIndex = 6;
            // 
            // ressultado
            // 
            this.ressultado.AutoSize = true;
            this.ressultado.Location = new System.Drawing.Point(8, 82);
            this.ressultado.Name = "ressultado";
            this.ressultado.Size = new System.Drawing.Size(59, 15);
            this.ressultado.TabIndex = 7;
            this.ressultado.Text = "Resultado";
            // 
            // frmSoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 214);
            this.Controls.Add(this.ressultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnReais);
            this.Controls.Add(this.btnInteiro);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "frmSoma";
            this.Text = "Soma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Button btnInteiro;
        private System.Windows.Forms.Button btnReais;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label ressultado;
    }
}

