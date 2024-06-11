namespace Calculadora_Sencilla_Csharp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblprimernum = new System.Windows.Forms.Label();
            this.lblsegundonum = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Sencilla";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btndiv);
            this.panel1.Controls.Add(this.btnmulti);
            this.panel1.Controls.Add(this.btnresta);
            this.panel1.Controls.Add(this.btnsuma);
            this.panel1.Controls.Add(this.txtnum2);
            this.panel1.Controls.Add(this.txtnum1);
            this.panel1.Controls.Add(this.lblsegundonum);
            this.panel1.Controls.Add(this.lblprimernum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 430);
            this.panel1.TabIndex = 1;
            // 
            // lblprimernum
            // 
            this.lblprimernum.AutoSize = true;
            this.lblprimernum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprimernum.Location = new System.Drawing.Point(50, 188);
            this.lblprimernum.Name = "lblprimernum";
            this.lblprimernum.Size = new System.Drawing.Size(158, 24);
            this.lblprimernum.TabIndex = 1;
            this.lblprimernum.Text = "Primer Numero:";
            // 
            // lblsegundonum
            // 
            this.lblsegundonum.AutoSize = true;
            this.lblsegundonum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsegundonum.Location = new System.Drawing.Point(50, 295);
            this.lblsegundonum.Name = "lblsegundonum";
            this.lblsegundonum.Size = new System.Drawing.Size(182, 24);
            this.lblsegundonum.TabIndex = 2;
            this.lblsegundonum.Text = "Segundo Numero:";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(258, 188);
            this.txtnum1.Multiline = true;
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(135, 24);
            this.txtnum1.TabIndex = 3;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(258, 295);
            this.txtnum2.Multiline = true;
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(135, 24);
            this.txtnum2.TabIndex = 4;
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(465, 171);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(112, 53);
            this.btnsuma.TabIndex = 5;
            this.btnsuma.Text = "Suma";
            this.btnsuma.UseVisualStyleBackColor = true;
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(610, 171);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(112, 53);
            this.btnresta.TabIndex = 6;
            this.btnresta.Text = "Resta";
            this.btnresta.UseVisualStyleBackColor = true;
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(465, 266);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(112, 53);
            this.btnmulti.TabIndex = 7;
            this.btnmulti.Text = "Multiplicacion";
            this.btnmulti.UseVisualStyleBackColor = true;
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(610, 266);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(112, 53);
            this.btndiv.TabIndex = 8;
            this.btndiv.Text = "Division";
            this.btndiv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(818, 454);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lblsegundonum;
        private System.Windows.Forms.Label lblprimernum;
    }
}

