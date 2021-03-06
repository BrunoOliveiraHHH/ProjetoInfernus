namespace InfernusApp
{
    partial class Armas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Armas));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gbArma = new System.Windows.Forms.GroupBox();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbxDurabilidade = new System.Windows.Forms.ComboBox();
            this.cbxMoeda = new System.Windows.Forms.ComboBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtEfeitos = new System.Windows.Forms.TextBox();
            this.txtPropriedades = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtTipoDano = new System.Windows.Forms.TextBox();
            this.txtDano = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblEfeitos = new System.Windows.Forms.Label();
            this.lblDurabilidade = new System.Windows.Forms.Label();
            this.lblPropriedades = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTipoDano = new System.Windows.Forms.Label();
            this.lblDano = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbArma.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Gray;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Location = new System.Drawing.Point(873, 390);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 38);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gbArma
            // 
            this.gbArma.Controls.Add(this.lblRetorno);
            this.gbArma.Controls.Add(this.btnEnviar);
            this.gbArma.Controls.Add(this.cbxDurabilidade);
            this.gbArma.Controls.Add(this.cbxMoeda);
            this.gbArma.Controls.Add(this.txtObservacoes);
            this.gbArma.Controls.Add(this.txtEfeitos);
            this.gbArma.Controls.Add(this.txtPropriedades);
            this.gbArma.Controls.Add(this.txtPeso);
            this.gbArma.Controls.Add(this.txtTipoDano);
            this.gbArma.Controls.Add(this.txtDano);
            this.gbArma.Controls.Add(this.txtCusto);
            this.gbArma.Controls.Add(this.txtNome);
            this.gbArma.Controls.Add(this.lblObservacoes);
            this.gbArma.Controls.Add(this.lblEfeitos);
            this.gbArma.Controls.Add(this.lblDurabilidade);
            this.gbArma.Controls.Add(this.lblPropriedades);
            this.gbArma.Controls.Add(this.lblPeso);
            this.gbArma.Controls.Add(this.lblTipoDano);
            this.gbArma.Controls.Add(this.lblDano);
            this.gbArma.Controls.Add(this.lblMoeda);
            this.gbArma.Controls.Add(this.lblCusto);
            this.gbArma.Controls.Add(this.lblNome);
            this.gbArma.Location = new System.Drawing.Point(227, 69);
            this.gbArma.Name = "gbArma";
            this.gbArma.Size = new System.Drawing.Size(579, 324);
            this.gbArma.TabIndex = 3;
            this.gbArma.TabStop = false;
            this.gbArma.Text = "Adicionar Item";
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Location = new System.Drawing.Point(372, 157);
            this.lblRetorno.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(48, 13);
            this.lblRetorno.TabIndex = 21;
            this.lblRetorno.Text = "Retorno:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnviar.Location = new System.Drawing.Point(245, 283);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(121, 25);
            this.btnEnviar.TabIndex = 20;
            this.btnEnviar.Text = "Enviar Dados";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cbxDurabilidade
            // 
            this.cbxDurabilidade.FormattingEnabled = true;
            this.cbxDurabilidade.Location = new System.Drawing.Point(245, 207);
            this.cbxDurabilidade.Name = "cbxDurabilidade";
            this.cbxDurabilidade.Size = new System.Drawing.Size(121, 21);
            this.cbxDurabilidade.TabIndex = 19;
            // 
            // cbxMoeda
            // 
            this.cbxMoeda.FormattingEnabled = true;
            this.cbxMoeda.Location = new System.Drawing.Point(245, 82);
            this.cbxMoeda.Name = "cbxMoeda";
            this.cbxMoeda.Size = new System.Drawing.Size(121, 21);
            this.cbxMoeda.TabIndex = 18;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(245, 257);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(121, 20);
            this.txtObservacoes.TabIndex = 17;
            // 
            // txtEfeitos
            // 
            this.txtEfeitos.Location = new System.Drawing.Point(245, 232);
            this.txtEfeitos.Name = "txtEfeitos";
            this.txtEfeitos.Size = new System.Drawing.Size(121, 20);
            this.txtEfeitos.TabIndex = 16;
            // 
            // txtPropriedades
            // 
            this.txtPropriedades.Location = new System.Drawing.Point(245, 182);
            this.txtPropriedades.Name = "txtPropriedades";
            this.txtPropriedades.Size = new System.Drawing.Size(121, 20);
            this.txtPropriedades.TabIndex = 15;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(245, 157);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(121, 20);
            this.txtPeso.TabIndex = 14;
            // 
            // txtTipoDano
            // 
            this.txtTipoDano.Location = new System.Drawing.Point(245, 133);
            this.txtTipoDano.Name = "txtTipoDano";
            this.txtTipoDano.Size = new System.Drawing.Size(121, 20);
            this.txtTipoDano.TabIndex = 13;
            // 
            // txtDano
            // 
            this.txtDano.Location = new System.Drawing.Point(245, 107);
            this.txtDano.Name = "txtDano";
            this.txtDano.Size = new System.Drawing.Size(121, 20);
            this.txtDano.TabIndex = 12;
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(245, 57);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(121, 20);
            this.txtCusto.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(245, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 10;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(162, 261);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(73, 13);
            this.lblObservacoes.TabIndex = 9;
            this.lblObservacoes.Text = "Observações:";
            // 
            // lblEfeitos
            // 
            this.lblEfeitos.AutoSize = true;
            this.lblEfeitos.Location = new System.Drawing.Point(162, 236);
            this.lblEfeitos.Name = "lblEfeitos";
            this.lblEfeitos.Size = new System.Drawing.Size(42, 13);
            this.lblEfeitos.TabIndex = 8;
            this.lblEfeitos.Text = "Efeitos:";
            // 
            // lblDurabilidade
            // 
            this.lblDurabilidade.AutoSize = true;
            this.lblDurabilidade.Location = new System.Drawing.Point(162, 211);
            this.lblDurabilidade.Name = "lblDurabilidade";
            this.lblDurabilidade.Size = new System.Drawing.Size(69, 13);
            this.lblDurabilidade.TabIndex = 7;
            this.lblDurabilidade.Text = "Durabilidade:";
            // 
            // lblPropriedades
            // 
            this.lblPropriedades.AutoSize = true;
            this.lblPropriedades.Location = new System.Drawing.Point(162, 186);
            this.lblPropriedades.Name = "lblPropriedades";
            this.lblPropriedades.Size = new System.Drawing.Size(72, 13);
            this.lblPropriedades.TabIndex = 6;
            this.lblPropriedades.Text = "Propriedades:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(162, 161);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Peso:";
            // 
            // lblTipoDano
            // 
            this.lblTipoDano.AutoSize = true;
            this.lblTipoDano.Location = new System.Drawing.Point(162, 136);
            this.lblTipoDano.Name = "lblTipoDano";
            this.lblTipoDano.Size = new System.Drawing.Size(75, 13);
            this.lblTipoDano.TabIndex = 4;
            this.lblTipoDano.Text = "Tipo de Dano:";
            // 
            // lblDano
            // 
            this.lblDano.AutoSize = true;
            this.lblDano.Location = new System.Drawing.Point(162, 111);
            this.lblDano.Name = "lblDano";
            this.lblDano.Size = new System.Drawing.Size(36, 13);
            this.lblDano.TabIndex = 3;
            this.lblDano.Text = "Dano:";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(162, 86);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(43, 13);
            this.lblMoeda.TabIndex = 2;
            this.lblMoeda.Text = "Moeda:";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(162, 61);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(37, 13);
            this.lblCusto.TabIndex = 1;
            this.lblCusto.Text = "Custo:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(162, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // Armas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InfernusApp.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 463);
            this.Controls.Add(this.gbArma);
            this.Controls.Add(this.btnVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1050, 502);
            this.MinimumSize = new System.Drawing.Size(1050, 502);
            this.Name = "Armas";
            this.Text = "Armas";
            this.gbArma.ResumeLayout(false);
            this.gbArma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gbArma;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Label lblEfeitos;
        private System.Windows.Forms.Label lblDurabilidade;
        private System.Windows.Forms.Label lblPropriedades;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTipoDano;
        private System.Windows.Forms.Label lblDano;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbxDurabilidade;
        private System.Windows.Forms.ComboBox cbxMoeda;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtEfeitos;
        private System.Windows.Forms.TextBox txtPropriedades;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtTipoDano;
        private System.Windows.Forms.TextBox txtDano;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRetorno;
    }
}