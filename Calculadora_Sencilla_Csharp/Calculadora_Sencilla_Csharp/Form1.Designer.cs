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
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lblsegundonum = new System.Windows.Forms.Label();
            this.lblprimernum = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.txtresultado);
            this.panel1.Controls.Add(this.lblresultado);
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
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(610, 266);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(112, 53);
            this.btndiv.TabIndex = 8;
            this.btndiv.Text = "Division";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(465, 266);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(112, 53);
            this.btnmulti.TabIndex = 7;
            this.btnmulti.Text = "Multiplicacion";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(610, 171);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(112, 53);
            this.btnresta.TabIndex = 6;
            this.btnresta.Text = "Resta";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(465, 171);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(112, 53);
            this.btnsuma.TabIndex = 5;
            this.btnsuma.Text = "Suma";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(258, 295);
            this.txtnum2.Multiline = true;
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(135, 24);
            this.txtnum2.TabIndex = 4;
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(258, 188);
            this.txtnum1.Multiline = true;
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(135, 24);
            this.txtnum1.TabIndex = 3;
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
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(202, 367);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(109, 24);
            this.lblresultado.TabIndex = 9;
            this.lblresultado.Text = "Resultado:";
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(339, 367);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(135, 24);
            this.txtresultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(818, 454);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label lblresultado;
    }
}

