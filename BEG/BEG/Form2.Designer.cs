namespace BEG
{
    partial class frmexercicio1
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
            this.lblcod = new System.Windows.Forms.Label();
            this.lblqtdl = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtlitros = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod.Location = new System.Drawing.Point(264, 158);
            this.lblcod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(159, 24);
            this.lblcod.TabIndex = 0;
            this.lblcod.Text = "Digite o código:";
            this.lblcod.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblqtdl
            // 
            this.lblqtdl.AutoSize = true;
            this.lblqtdl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtdl.Location = new System.Drawing.Point(264, 217);
            this.lblqtdl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblqtdl.Name = "lblqtdl";
            this.lblqtdl.Size = new System.Drawing.Size(282, 24);
            this.lblqtdl.TabIndex = 1;
            this.lblqtdl.Text = "Digite a quantidade de litros:";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(264, 277);
            this.lbldesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(144, 24);
            this.lbldesc.TabIndex = 2;
            this.lbldesc.Text = "O desconto é:";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(445, 156);
            this.txtcod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(253, 22);
            this.txtcod.TabIndex = 3;
            // 
            // txtlitros
            // 
            this.txtlitros.Location = new System.Drawing.Point(575, 215);
            this.txtlitros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlitros.Name = "txtlitros";
            this.txtlitros.Size = new System.Drawing.Size(253, 22);
            this.txtlitros.TabIndex = 4;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(427, 276);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.ReadOnly = true;
            this.txtdesc.Size = new System.Drawing.Size(253, 22);
            this.txtdesc.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(240, 401);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(161, 60);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(645, 401);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(161, 60);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(445, 401);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(161, 60);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frmexercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtlitros);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lblqtdl);
            this.Controls.Add(this.lblcod);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmexercicio1";
            this.Text = "Exercício 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblqtdl;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtlitros;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
    }
}