
namespace AC.UI
{
    partial class frmCadastro
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
            this.dataGridView_frmCadastro = new System.Windows.Forms.DataGridView();
            this.btnCasdastrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDuplicar = new System.Windows.Forms.Button();
            this.lblCadastro_De_Endereços = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_frmCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_frmCadastro
            // 
            this.dataGridView_frmCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_frmCadastro.Location = new System.Drawing.Point(12, 233);
            this.dataGridView_frmCadastro.Name = "dataGridView_frmCadastro";
            this.dataGridView_frmCadastro.Size = new System.Drawing.Size(776, 128);
            this.dataGridView_frmCadastro.TabIndex = 0;
            // 
            // btnCasdastrar
            // 
            this.btnCasdastrar.BackColor = System.Drawing.Color.Green;
            this.btnCasdastrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasdastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCasdastrar.Location = new System.Drawing.Point(12, 399);
            this.btnCasdastrar.Name = "btnCasdastrar";
            this.btnCasdastrar.Size = new System.Drawing.Size(104, 23);
            this.btnCasdastrar.TabIndex = 1;
            this.btnCasdastrar.Text = "Cadastrar";
            this.btnCasdastrar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Green;
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.Location = new System.Drawing.Point(241, 399);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(12, 107);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(389, 20);
            this.txbNome.TabIndex = 3;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(12, 146);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(389, 20);
            this.txbEmail.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(389, 20);
            this.textBox3.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(9, 91);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 14);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(9, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 14);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelefone.Location = new System.Drawing.Point(9, 169);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 14);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(407, 107);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(39, 20);
            this.txbId.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblId.Location = new System.Drawing.Point(404, 91);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 14);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Green;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizar.Location = new System.Drawing.Point(461, 399);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(104, 23);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnDuplicar
            // 
            this.btnDuplicar.BackColor = System.Drawing.Color.Green;
            this.btnDuplicar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuplicar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDuplicar.Location = new System.Drawing.Point(684, 399);
            this.btnDuplicar.Name = "btnDuplicar";
            this.btnDuplicar.Size = new System.Drawing.Size(104, 23);
            this.btnDuplicar.TabIndex = 12;
            this.btnDuplicar.Text = "Duplicar";
            this.btnDuplicar.UseVisualStyleBackColor = false;
            // 
            // lblCadastro_De_Endereços
            // 
            this.lblCadastro_De_Endereços.AutoSize = true;
            this.lblCadastro_De_Endereços.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro_De_Endereços.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCadastro_De_Endereços.Location = new System.Drawing.Point(260, 30);
            this.lblCadastro_De_Endereços.Name = "lblCadastro_De_Endereços";
            this.lblCadastro_De_Endereços.Size = new System.Drawing.Size(257, 27);
            this.lblCadastro_De_Endereços.TabIndex = 13;
            this.lblCadastro_De_Endereços.Text = "Cadastro de Endereços";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCadastro_De_Endereços);
            this.Controls.Add(this.btnDuplicar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCasdastrar);
            this.Controls.Add(this.dataGridView_frmCadastro);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_frmCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_frmCadastro;
        private System.Windows.Forms.Button btnCasdastrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDuplicar;
        private System.Windows.Forms.Label lblCadastro_De_Endereços;
    }
}