namespace InfernusMonsterApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMonsterSheet = new System.Windows.Forms.Button();
            this.btnNPCSheet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Gray;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFechar.Location = new System.Drawing.Point(874, 391);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(96, 38);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Sair do Programa";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMonsterSheet
            // 
            this.btnMonsterSheet.BackColor = System.Drawing.Color.Gray;
            this.btnMonsterSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonsterSheet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMonsterSheet.Location = new System.Drawing.Point(355, 210);
            this.btnMonsterSheet.Name = "btnMonsterSheet";
            this.btnMonsterSheet.Size = new System.Drawing.Size(96, 38);
            this.btnMonsterSheet.TabIndex = 2;
            this.btnMonsterSheet.Text = "Ficha de Monstro";
            this.btnMonsterSheet.UseVisualStyleBackColor = false;
            this.btnMonsterSheet.Click += new System.EventHandler(this.btnMonsterSheet_Click);
            // 
            // btnNPCSheet
            // 
            this.btnNPCSheet.BackColor = System.Drawing.Color.Gray;
            this.btnNPCSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNPCSheet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNPCSheet.Location = new System.Drawing.Point(572, 210);
            this.btnNPCSheet.Name = "btnNPCSheet";
            this.btnNPCSheet.Size = new System.Drawing.Size(96, 38);
            this.btnNPCSheet.TabIndex = 3;
            this.btnNPCSheet.Text = "Ficha de NPC";
            this.btnNPCSheet.UseVisualStyleBackColor = false;
            this.btnNPCSheet.Click += new System.EventHandler(this.btnNPCSheet_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 463);
            this.Controls.Add(this.btnNPCSheet);
            this.Controls.Add(this.btnMonsterSheet);
            this.Controls.Add(this.btnFechar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1050, 502);
            this.MinimumSize = new System.Drawing.Size(1050, 502);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMonsterSheet;
        private System.Windows.Forms.Button btnNPCSheet;
    }
}