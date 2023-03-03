
namespace Aula04DS
{
    partial class FormPersonagens
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
            this.lbNome = new System.Windows.Forms.Label();
            this.pictureBoxPersonagem = new System.Windows.Forms.PictureBox();
            this.listBoxPersonagem = new System.Windows.Forms.ListBox();
            this.comboBoxPersonagem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(207, 426);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(300, 15);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "André de Sousa Neves e Joyce Rufino Pereira";
            // 
            // pictureBoxPersonagem
            // 
            this.pictureBoxPersonagem.Location = new System.Drawing.Point(217, 33);
            this.pictureBoxPersonagem.Name = "pictureBoxPersonagem";
            this.pictureBoxPersonagem.Size = new System.Drawing.Size(290, 345);
            this.pictureBoxPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPersonagem.TabIndex = 2;
            this.pictureBoxPersonagem.TabStop = false;
            // 
            // listBoxPersonagem
            // 
            this.listBoxPersonagem.FormattingEnabled = true;
            this.listBoxPersonagem.Items.AddRange(new object[] {
            "Goku",
            "Vegeta",
            "Inuyasha",
            "Sesshoumaru",
            "Knight",
            "Sanji",
            "Kaneki",
            "Ban",
            "Violet",
            "Howl"});
            this.listBoxPersonagem.Location = new System.Drawing.Point(34, 53);
            this.listBoxPersonagem.Name = "listBoxPersonagem";
            this.listBoxPersonagem.Size = new System.Drawing.Size(129, 160);
            this.listBoxPersonagem.TabIndex = 3;
            this.listBoxPersonagem.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonagem_SelectedIndexChanged);
            // 
            // comboBoxPersonagem
            // 
            this.comboBoxPersonagem.FormattingEnabled = true;
            this.comboBoxPersonagem.Items.AddRange(new object[] {
            "Goku",
            "Vegeta",
            "Inuyasha",
            "Sesshoumaru",
            "Knight",
            "Sanji",
            "Kaneki",
            "Ban",
            "Violet",
            "Howl"});
            this.comboBoxPersonagem.Location = new System.Drawing.Point(34, 287);
            this.comboBoxPersonagem.Name = "comboBoxPersonagem";
            this.comboBoxPersonagem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPersonagem.TabIndex = 4;
            this.comboBoxPersonagem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormPersonagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxPersonagem);
            this.Controls.Add(this.listBoxPersonagem);
            this.Controls.Add(this.pictureBoxPersonagem);
            this.Controls.Add(this.lbNome);
            this.Name = "FormPersonagens";
            this.Text = "O Programa dos Personagens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.PictureBox pictureBoxPersonagem;
        private System.Windows.Forms.ListBox listBoxPersonagem;
        private System.Windows.Forms.ComboBox comboBoxPersonagem;
    }
}

