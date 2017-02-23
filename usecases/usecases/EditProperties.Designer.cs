namespace usecases
{
    partial class EditProperties
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbSamenvatting = new System.Windows.Forms.TextBox();
            this.tbActoren = new System.Windows.Forms.TextBox();
            this.tbAannamen = new System.Windows.Forms.TextBox();
            this.tbBeschrijving = new System.Windows.Forms.TextBox();
            this.tbUitzonderingen = new System.Windows.Forms.TextBox();
            this.tbResultaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Samenvatting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Actoren:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Aannamen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Beschrijving:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Uitzonderingen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Resultaat:";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(138, 10);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(278, 22);
            this.tbNaam.TabIndex = 1;
            // 
            // tbSamenvatting
            // 
            this.tbSamenvatting.Location = new System.Drawing.Point(138, 38);
            this.tbSamenvatting.Name = "tbSamenvatting";
            this.tbSamenvatting.Size = new System.Drawing.Size(278, 22);
            this.tbSamenvatting.TabIndex = 1;
            // 
            // tbActoren
            // 
            this.tbActoren.Location = new System.Drawing.Point(138, 66);
            this.tbActoren.Name = "tbActoren";
            this.tbActoren.Size = new System.Drawing.Size(278, 22);
            this.tbActoren.TabIndex = 1;
            // 
            // tbAannamen
            // 
            this.tbAannamen.Location = new System.Drawing.Point(138, 94);
            this.tbAannamen.Name = "tbAannamen";
            this.tbAannamen.Size = new System.Drawing.Size(278, 22);
            this.tbAannamen.TabIndex = 1;
            this.tbAannamen.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tbBeschrijving
            // 
            this.tbBeschrijving.Location = new System.Drawing.Point(138, 119);
            this.tbBeschrijving.Multiline = true;
            this.tbBeschrijving.Name = "tbBeschrijving";
            this.tbBeschrijving.Size = new System.Drawing.Size(278, 130);
            this.tbBeschrijving.TabIndex = 1;
            // 
            // tbUitzonderingen
            // 
            this.tbUitzonderingen.Location = new System.Drawing.Point(138, 255);
            this.tbUitzonderingen.Multiline = true;
            this.tbUitzonderingen.Name = "tbUitzonderingen";
            this.tbUitzonderingen.Size = new System.Drawing.Size(278, 130);
            this.tbUitzonderingen.TabIndex = 1;
            // 
            // tbResultaat
            // 
            this.tbResultaat.Location = new System.Drawing.Point(138, 391);
            this.tbResultaat.Name = "tbResultaat";
            this.tbResultaat.Size = new System.Drawing.Size(278, 22);
            this.tbResultaat.TabIndex = 1;
            this.tbResultaat.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // EditProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 432);
            this.Controls.Add(this.tbUitzonderingen);
            this.Controls.Add(this.tbBeschrijving);
            this.Controls.Add(this.tbResultaat);
            this.Controls.Add(this.tbAannamen);
            this.Controls.Add(this.tbActoren);
            this.Controls.Add(this.tbSamenvatting);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditProperties";
            this.Text = "EditProperties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbSamenvatting;
        private System.Windows.Forms.TextBox tbActoren;
        private System.Windows.Forms.TextBox tbAannamen;
        private System.Windows.Forms.TextBox tbBeschrijving;
        private System.Windows.Forms.TextBox tbUitzonderingen;
        private System.Windows.Forms.TextBox tbResultaat;
    }
}