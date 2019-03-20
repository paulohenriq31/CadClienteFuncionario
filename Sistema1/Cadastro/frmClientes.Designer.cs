namespace Cadastro
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(38, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "&Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(38, 68);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "&Telefone:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(38, 100);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "&Cidade:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(41, 150);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(183, 58);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "Americana",
            "Piracicaba",
            "Nova Odessa",
            "Sumaré",
            "Campinas"});
            this.cmbCidade.Location = new System.Drawing.Point(103, 92);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(121, 21);
            this.cmbCidade.TabIndex = 4;
            // 
            // maskTelefone
            // 
            this.maskTelefone.Location = new System.Drawing.Point(103, 61);
            this.maskTelefone.Mask = "(99) 00000-0000";
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(121, 20);
            this.maskTelefone.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 6;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 238);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.maskTelefone);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientes";
            this.Text = "Formulario Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.TextBox txtNome;
    }
}