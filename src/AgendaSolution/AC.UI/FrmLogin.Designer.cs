namespace AC.UI
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblAgendaApp = new System.Windows.Forms.Label();
            this.lblAcesso_Restrito = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.BtnAcessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(166, 125);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(271, 20);
            this.txbUsuario.TabIndex = 0;
            this.txbUsuario.TextChanged += new System.EventHandler(this.txbUsuario_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(166, 183);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(271, 20);
            this.txbSenha.TabIndex = 2;
            // 
            // lblAgendaApp
            // 
            this.lblAgendaApp.AutoSize = true;
            this.lblAgendaApp.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendaApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAgendaApp.Location = new System.Drawing.Point(12, 19);
            this.lblAgendaApp.Name = "lblAgendaApp";
            this.lblAgendaApp.Size = new System.Drawing.Size(133, 27);
            this.lblAgendaApp.TabIndex = 3;
            this.lblAgendaApp.Text = "AgendaApp";
            // 
            // lblAcesso_Restrito
            // 
            this.lblAcesso_Restrito.AutoSize = true;
            this.lblAcesso_Restrito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcesso_Restrito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAcesso_Restrito.Location = new System.Drawing.Point(252, 46);
            this.lblAcesso_Restrito.Name = "lblAcesso_Restrito";
            this.lblAcesso_Restrito.Size = new System.Drawing.Size(104, 16);
            this.lblAcesso_Restrito.TabIndex = 4;
            this.lblAcesso_Restrito.Text = "Acesso Restrito";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(163, 109);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 16);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(163, 167);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 16);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha";
            // 
            // BtnAcessar
            // 
            this.BtnAcessar.BackColor = System.Drawing.Color.Green;
            this.BtnAcessar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcessar.Location = new System.Drawing.Point(227, 243);
            this.BtnAcessar.Name = "BtnAcessar";
            this.BtnAcessar.Size = new System.Drawing.Size(129, 30);
            this.BtnAcessar.TabIndex = 7;
            this.BtnAcessar.Text = "Acessar";
            this.BtnAcessar.UseVisualStyleBackColor = false;
            this.BtnAcessar.Click += new System.EventHandler(this.BtnAcessar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(617, 345);
            this.Controls.Add(this.BtnAcessar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblAcesso_Restrito);
            this.Controls.Add(this.lblAgendaApp);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblAgendaApp;
        private System.Windows.Forms.Label lblAcesso_Restrito;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button BtnAcessar;
    }
}

