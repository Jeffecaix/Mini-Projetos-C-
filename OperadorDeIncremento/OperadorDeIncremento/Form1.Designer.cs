
namespace OperadorDeIncremento
{
    partial class Form1
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
            this.btnPos = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(402, 187);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(143, 23);
            this.btnPos.TabIndex = 0;
            this.btnPos.Text = "Incremento Pós-fixado";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(236, 187);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(147, 23);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "Incremento Pré-fixado";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(283, 80);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 23);
            this.txtX.TabIndex = 2;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(236, 80);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 15);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnPos);
            this.Name = "Form1";
            this.Text = "Operandor de Incremento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblX;
    }
}

