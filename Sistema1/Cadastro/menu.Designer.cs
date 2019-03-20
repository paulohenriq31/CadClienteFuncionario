namespace Cadastro
{
    partial class menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Cadastro.Properties.Resources.iconfinder__signin_in_common_door_exit_login_4247896;
            this.btnSair.Location = new System.Drawing.Point(106, 138);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 75);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Image = global::Cadastro.Properties.Resources.iconfinder_7_avatar_2754582__3_;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(190, 29);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(134, 75);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Image = global::Cadastro.Properties.Resources.iconfinder_4_avatar_2754580__4_;
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.Location = new System.Drawing.Point(23, 29);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(134, 75);
            this.btnFuncionario.TabIndex = 0;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 237);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnSair;
    }
}

