namespace InfernusApp
{
    partial class Magias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magias));
            this.gbArma = new System.Windows.Forms.GroupBox();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbxEscola = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblEscola = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.txtTempConj = new System.Windows.Forms.TextBox();
            this.lblTempConj = new System.Windows.Forms.Label();
            this.txtComponentes = new System.Windows.Forms.TextBox();
            this.lblComponentes = new System.Windows.Forms.Label();
            this.gbArma.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbArma
            // 
            this.gbArma.Controls.Add(this.txtComponentes);
            this.gbArma.Controls.Add(this.lblComponentes);
            this.gbArma.Controls.Add(this.txtTempConj);
            this.gbArma.Controls.Add(this.lblTempConj);
            this.gbArma.Controls.Add(this.txtAlcance);
            this.gbArma.Controls.Add(this.lblRetorno);
            this.gbArma.Controls.Add(this.btnEnviar);
            this.gbArma.Controls.Add(this.cbxEscola);
            this.gbArma.Controls.Add(this.txtDescricao);
            this.gbArma.Controls.Add(this.txtDuracao);
            this.gbArma.Controls.Add(this.txtNivel);
            this.gbArma.Controls.Add(this.txtNome);
            this.gbArma.Controls.Add(this.lblDescricao);
            this.gbArma.Controls.Add(this.lblAlcance);
            this.gbArma.Controls.Add(this.lblDuracao);
            this.gbArma.Controls.Add(this.lblEscola);
            this.gbArma.Controls.Add(this.lblNivel);
            this.gbArma.Controls.Add(this.lblNome);
            this.gbArma.Location = new System.Drawing.Point(231, 64);
            this.gbArma.Name = "gbArma";
            this.gbArma.Size = new System.Drawing.Size(579, 324);
            this.gbArma.TabIndex = 9;
            this.gbArma.TabStop = false;
            this.gbArma.Text = "Adicionar Item";
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Location = new System.Drawing.Point(382, 163);
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
            this.btnEnviar.Location = new System.Drawing.Point(244, 293);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(121, 25);
            this.btnEnviar.TabIndex = 20;
            this.btnEnviar.Text = "Enviar Dados";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cbxEscola
            // 
            this.cbxEscola.FormattingEnabled = true;
            this.cbxEscola.Location = new System.Drawing.Point(244, 90);
            this.cbxEscola.Name = "cbxEscola";
            this.cbxEscola.Size = new System.Drawing.Size(121, 21);
            this.cbxEscola.TabIndex = 18;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(244, 265);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(121, 20);
            this.txtDescricao.TabIndex = 17;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(244, 125);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(121, 20);
            this.txtDuracao.TabIndex = 15;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(244, 55);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(121, 20);
            this.txtNivel.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(244, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 10;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(128, 269);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(128, 164);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(49, 13);
            this.lblAlcance.TabIndex = 7;
            this.lblAlcance.Text = "Alcance:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(128, 129);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(51, 13);
            this.lblDuracao.TabIndex = 5;
            this.lblDuracao.Text = "Duração:";
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Location = new System.Drawing.Point(128, 94);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(42, 13);
            this.lblEscola.TabIndex = 2;
            this.lblEscola.Text = "Escola:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(128, 59);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(34, 13);
            this.lblNivel.TabIndex = 1;
            this.lblNivel.Text = "Nivel:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(128, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Gray;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Location = new System.Drawing.Point(877, 385);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 38);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtAlcance
            // 
            this.txtAlcance.Location = new System.Drawing.Point(244, 160);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.Size = new System.Drawing.Size(121, 20);
            this.txtAlcance.TabIndex = 22;
            // 
            // txtTempConj
            // 
            this.txtTempConj.Location = new System.Drawing.Point(244, 195);
            this.txtTempConj.Name = "txtTempConj";
            this.txtTempConj.Size = new System.Drawing.Size(121, 20);
            this.txtTempConj.TabIndex = 24;
            // 
            // lblTempConj
            // 
            this.lblTempConj.AutoSize = true;
            this.lblTempConj.Location = new System.Drawing.Point(128, 199);
            this.lblTempConj.Name = "lblTempConj";
            this.lblTempConj.Size = new System.Drawing.Size(115, 13);
            this.lblTempConj.TabIndex = 23;
            this.lblTempConj.Text = "Tempo de Conjuração:";
            // 
            // txtComponentes
            // 
            this.txtComponentes.Location = new System.Drawing.Point(244, 230);
            this.txtComponentes.Name = "txtComponentes";
            this.txtComponentes.Size = new System.Drawing.Size(121, 20);
            this.txtComponentes.TabIndex = 26;
            // 
            // lblComponentes
            // 
            this.lblComponentes.AutoSize = true;
            this.lblComponentes.Location = new System.Drawing.Point(128, 234);
            this.lblComponentes.Name = "lblComponentes";
            this.lblComponentes.Size = new System.Drawing.Size(75, 13);
            this.lblComponentes.TabIndex = 25;
            this.lblComponentes.Text = "Componentes:";
            // 
            // Magias
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
            this.Name = "Magias";
            this.Text = "Magias";
            this.gbArma.ResumeLayout(false);
            this.gbArma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbArma;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbxEscola;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtAlcance;
        private System.Windows.Forms.TextBox txtComponentes;
        private System.Windows.Forms.Label lblComponentes;
        private System.Windows.Forms.TextBox txtTempConj;
        private System.Windows.Forms.Label lblTempConj;
    }
}