namespace Cadastro
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.lblNome = new System.Windows.Forms.Label();
            this.grbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(38, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome: ";
            // 
            // grbEstadoCivil
            // 
            this.grbEstadoCivil.Controls.Add(this.rdbSolteiro);
            this.grbEstadoCivil.Controls.Add(this.rdbCasado);
            this.grbEstadoCivil.Location = new System.Drawing.Point(37, 82);
            this.grbEstadoCivil.Name = "grbEstadoCivil";
            this.grbEstadoCivil.Size = new System.Drawing.Size(183, 55);
            this.grbEstadoCivil.TabIndex = 1;
            this.grbEstadoCivil.TabStop = false;
            this.grbEstadoCivil.Text = "Estao Civil";
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(6, 19);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(61, 17);
            this.rdbCasado.TabIndex = 0;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(97, 19);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rdbSolteiro.TabIndex = 1;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(37, 155);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(183, 58);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(144, 20);
            this.txtNome.TabIndex = 3;
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 238);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grbEstadoCivil);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFuncionarios";
            this.Text = "Cadastro Funcionarios";
            this.grbEstadoCivil.ResumeLayout(false);
            this.grbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grbEstadoCivil;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
    }
}