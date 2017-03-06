namespace usecases
{
    partial class Form1
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
            this.canvas = new System.Windows.Forms.Panel();
            this.rabUseCase = new System.Windows.Forms.RadioButton();
            this.rabActor = new System.Windows.Forms.RadioButton();
            this.rabLine = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rabMove = new System.Windows.Forms.RadioButton();
            this.rabSelect = new System.Windows.Forms.RadioButton();
            this.rabAdd = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.Location = new System.Drawing.Point(12, 124);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(687, 355);
            this.canvas.TabIndex = 0;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            // 
            // rabUseCase
            // 
            this.rabUseCase.AutoSize = true;
            this.rabUseCase.Location = new System.Drawing.Point(6, 21);
            this.rabUseCase.Name = "rabUseCase";
            this.rabUseCase.Size = new System.Drawing.Size(86, 21);
            this.rabUseCase.TabIndex = 1;
            this.rabUseCase.TabStop = true;
            this.rabUseCase.Text = "UseCase";
            this.rabUseCase.UseVisualStyleBackColor = true;
            // 
            // rabActor
            // 
            this.rabActor.AutoSize = true;
            this.rabActor.Location = new System.Drawing.Point(6, 48);
            this.rabActor.Name = "rabActor";
            this.rabActor.Size = new System.Drawing.Size(62, 21);
            this.rabActor.TabIndex = 1;
            this.rabActor.TabStop = true;
            this.rabActor.Text = "Actor";
            this.rabActor.UseVisualStyleBackColor = true;
            // 
            // rabLine
            // 
            this.rabLine.AutoSize = true;
            this.rabLine.Location = new System.Drawing.Point(6, 75);
            this.rabLine.Name = "rabLine";
            this.rabLine.Size = new System.Drawing.Size(56, 21);
            this.rabLine.TabIndex = 2;
            this.rabLine.TabStop = true;
            this.rabLine.Text = "Line";
            this.rabLine.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabUseCase);
            this.groupBox1.Controls.Add(this.rabLine);
            this.groupBox1.Controls.Add(this.rabActor);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elementen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rabMove);
            this.groupBox2.Controls.Add(this.rabSelect);
            this.groupBox2.Controls.Add(this.rabAdd);
            this.groupBox2.Location = new System.Drawing.Point(179, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 105);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modes";
            // 
            // rabMove
            // 
            this.rabMove.AutoSize = true;
            this.rabMove.Location = new System.Drawing.Point(7, 76);
            this.rabMove.Name = "rabMove";
            this.rabMove.Size = new System.Drawing.Size(63, 21);
            this.rabMove.TabIndex = 0;
            this.rabMove.TabStop = true;
            this.rabMove.Text = "Move";
            this.rabMove.UseVisualStyleBackColor = true;
            // 
            // rabSelect
            // 
            this.rabSelect.AutoSize = true;
            this.rabSelect.Location = new System.Drawing.Point(7, 49);
            this.rabSelect.Name = "rabSelect";
            this.rabSelect.Size = new System.Drawing.Size(104, 21);
            this.rabSelect.TabIndex = 0;
            this.rabSelect.TabStop = true;
            this.rabSelect.Text = "Select / Edit";
            this.rabSelect.UseVisualStyleBackColor = true;
            // 
            // rabAdd
            // 
            this.rabAdd.AutoSize = true;
            this.rabAdd.Location = new System.Drawing.Point(7, 22);
            this.rabAdd.Name = "rabAdd";
            this.rabAdd.Size = new System.Drawing.Size(54, 21);
            this.rabAdd.TabIndex = 0;
            this.rabAdd.TabStop = true;
            this.rabAdd.Text = "Add";
            this.rabAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.RadioButton rabUseCase;
        private System.Windows.Forms.RadioButton rabActor;
        private System.Windows.Forms.RadioButton rabLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rabMove;
        private System.Windows.Forms.RadioButton rabSelect;
        private System.Windows.Forms.RadioButton rabAdd;
    }
}

