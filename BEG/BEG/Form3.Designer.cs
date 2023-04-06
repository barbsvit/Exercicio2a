namespace BEG
{
    partial class frmfor
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
            this.lbltab = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txttab = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncalcular2 = new System.Windows.Forms.Button();
            this.btncalcular3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltab
            // 
            this.lbltab.AutoSize = true;
            this.lbltab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltab.Location = new System.Drawing.Point(107, 94);
            this.lbltab.Name = "lbltab";
            this.lbltab.Size = new System.Drawing.Size(278, 24);
            this.lbltab.TabIndex = 0;
            this.lbltab.Text = "Digite o número da tabuada:";
            this.lbltab.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(107, 145);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(145, 24);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "O resultado é:";
            // 
            // txttab
            // 
            this.txttab.Location = new System.Drawing.Point(391, 94);
            this.txttab.Name = "txttab";
            this.txttab.Size = new System.Drawing.Size(233, 22);
            this.txttab.TabIndex = 2;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(251, 133);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(233, 36);
            this.txtresult.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(226, 262);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(93, 65);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular 1";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(258, 351);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(93, 42);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(391, 351);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(93, 42);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btncalcular2
            // 
            this.btncalcular2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular2.Location = new System.Drawing.Point(339, 262);
            this.btncalcular2.Name = "btncalcular2";
            this.btncalcular2.Size = new System.Drawing.Size(93, 65);
            this.btncalcular2.TabIndex = 7;
            this.btncalcular2.Text = "Calcular 2";
            this.btncalcular2.UseVisualStyleBackColor = true;
            this.btncalcular2.Click += new System.EventHandler(this.btncalcular2_Click);
            // 
            // btncalcular3
            // 
            this.btncalcular3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular3.Location = new System.Drawing.Point(452, 262);
            this.btncalcular3.Name = "btncalcular3";
            this.btncalcular3.Size = new System.Drawing.Size(93, 65);
            this.btncalcular3.TabIndex = 8;
            this.btncalcular3.Text = "Calcular 3";
            this.btncalcular3.UseVisualStyleBackColor = true;
            this.btncalcular3.Click += new System.EventHandler(this.btncalcular3_Click);
            // 
            // frmfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular3);
            this.Controls.Add(this.btncalcular2);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txttab);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbltab);
            this.Name = "frmfor";
            this.Text = "Exercício 2a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltab;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txttab;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncalcular2;
        private System.Windows.Forms.Button btncalcular3;
    }
}