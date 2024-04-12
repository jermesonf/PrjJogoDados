namespace PrjJogoDados
{
    partial class FrmJogoDados
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
            this.components = new System.ComponentModel.Container();
            this.btnSortear = new System.Windows.Forms.Button();
            this.pctboxDado = new System.Windows.Forms.PictureBox();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.rdoAut = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pctBoxDado2 = new System.Windows.Forms.PictureBox();
            this.btnSortear2 = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxDado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxDado2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSortear
            // 
            this.btnSortear.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortear.Location = new System.Drawing.Point(117, 297);
            this.btnSortear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(179, 55);
            this.btnSortear.TabIndex = 0;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Visible = false;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // pctboxDado
            // 
            this.pctboxDado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctboxDado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctboxDado.Image = global::PrjJogoDados.Properties.Resources.template;
            this.pctboxDado.InitialImage = global::PrjJogoDados.Properties.Resources.template;
            this.pctboxDado.Location = new System.Drawing.Point(48, 12);
            this.pctboxDado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctboxDado.Name = "pctboxDado";
            this.pctboxDado.Size = new System.Drawing.Size(313, 267);
            this.pctboxDado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctboxDado.TabIndex = 2;
            this.pctboxDado.TabStop = false;
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMan.Location = new System.Drawing.Point(400, 53);
            this.rdoMan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(97, 27);
            this.rdoMan.TabIndex = 3;
            this.rdoMan.Text = "Manual";
            this.rdoMan.UseVisualStyleBackColor = true;
            this.rdoMan.CheckedChanged += new System.EventHandler(this.rdoMan_CheckedChanged);
            // 
            // rdoAut
            // 
            this.rdoAut.AutoSize = true;
            this.rdoAut.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAut.Location = new System.Drawing.Point(400, 18);
            this.rdoAut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoAut.Name = "rdoAut";
            this.rdoAut.Size = new System.Drawing.Size(141, 27);
            this.rdoAut.TabIndex = 4;
            this.rdoAut.Text = "Automatico";
            this.rdoAut.UseVisualStyleBackColor = true;
            this.rdoAut.CheckedChanged += new System.EventHandler(this.rdoAut_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pctBoxDado2
            // 
            this.pctBoxDado2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxDado2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctBoxDado2.Image = global::PrjJogoDados.Properties.Resources.template;
            this.pctBoxDado2.InitialImage = global::PrjJogoDados.Properties.Resources.template;
            this.pctBoxDado2.Location = new System.Drawing.Point(595, 12);
            this.pctBoxDado2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctBoxDado2.Name = "pctBoxDado2";
            this.pctBoxDado2.Size = new System.Drawing.Size(319, 267);
            this.pctBoxDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxDado2.TabIndex = 6;
            this.pctBoxDado2.TabStop = false;
            // 
            // btnSortear2
            // 
            this.btnSortear2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortear2.Location = new System.Drawing.Point(670, 297);
            this.btnSortear2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSortear2.Name = "btnSortear2";
            this.btnSortear2.Size = new System.Drawing.Size(179, 55);
            this.btnSortear2.TabIndex = 5;
            this.btnSortear2.Text = "Sortear";
            this.btnSortear2.UseVisualStyleBackColor = true;
            this.btnSortear2.Visible = false;
            this.btnSortear2.Click += new System.EventHandler(this.btnSortear2_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 16;
            this.lstBox.Location = new System.Drawing.Point(400, 102);
            this.lstBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(159, 164);
            this.lstBox.TabIndex = 7;
            // 
            // FrmJogoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(934, 370);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.pctBoxDado2);
            this.Controls.Add(this.btnSortear2);
            this.Controls.Add(this.rdoAut);
            this.Controls.Add(this.rdoMan);
            this.Controls.Add(this.pctboxDado);
            this.Controls.Add(this.btnSortear);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmJogoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.pctboxDado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxDado2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.PictureBox pctboxDado;
        private System.Windows.Forms.RadioButton rdoMan;
        private System.Windows.Forms.RadioButton rdoAut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pctBoxDado2;
        private System.Windows.Forms.Button btnSortear2;
        private System.Windows.Forms.ListBox lstBox;
    }
}

