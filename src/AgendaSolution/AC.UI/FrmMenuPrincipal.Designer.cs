
namespace AC.UI
{
    partial class frmMenuPrincipal
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
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnCadastrar_Endereco = new System.Windows.Forms.Button();
            this.lblAgendaApp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(274, 88);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(183, 30);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "Menu Principal";
            // 
            // btnCadastrar_Endereco
            // 
            this.btnCadastrar_Endereco.BackColor = System.Drawing.Color.Green;
            this.btnCadastrar_Endereco.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar_Endereco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar_Endereco.Location = new System.Drawing.Point(277, 273);
            this.btnCadastrar_Endereco.Name = "btnCadastrar_Endereco";
            this.btnCadastrar_Endereco.Size = new System.Drawing.Size(180, 66);
            this.btnCadastrar_Endereco.TabIndex = 1;
            this.btnCadastrar_Endereco.Text = "Cadastrar";
            this.btnCadastrar_Endereco.UseVisualStyleBackColor = false;
            // 
            // lblAgendaApp
            // 
            this.lblAgendaApp.AutoSize = true;
            this.lblAgendaApp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendaApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAgendaApp.Location = new System.Drawing.Point(12, 9);
            this.lblAgendaApp.Name = "lblAgendaApp";
            this.lblAgendaApp.Size = new System.Drawing.Size(99, 19);
            this.lblAgendaApp.TabIndex = 2;
            this.lblAgendaApp.Text = "AgendaApp";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(730, 493);
            this.Controls.Add(this.lblAgendaApp);
            this.Controls.Add(this.btnCadastrar_Endereco);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Button btnCadastrar_Endereco;
        private System.Windows.Forms.Label lblAgendaApp;
    }
}