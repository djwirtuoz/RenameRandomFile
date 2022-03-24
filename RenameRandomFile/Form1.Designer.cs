namespace RenameRandomFile
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RUNBUTTON = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.minLetterTextBox = new System.Windows.Forms.TextBox();
            this.maxLetterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pathBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RUNBUTTON
            // 
            this.RUNBUTTON.Enabled = false;
            this.RUNBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RUNBUTTON.Location = new System.Drawing.Point(450, 81);
            this.RUNBUTTON.Name = "RUNBUTTON";
            this.RUNBUTTON.Size = new System.Drawing.Size(143, 54);
            this.RUNBUTTON.TabIndex = 0;
            this.RUNBUTTON.Text = "Rename";
            this.RUNBUTTON.UseVisualStyleBackColor = true;
            this.RUNBUTTON.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(12, 28);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(500, 20);
            this.pathTextBox.TabIndex = 1;
            // 
            // minLetterTextBox
            // 
            this.minLetterTextBox.Location = new System.Drawing.Point(12, 75);
            this.minLetterTextBox.Name = "minLetterTextBox";
            this.minLetterTextBox.Size = new System.Drawing.Size(100, 20);
            this.minLetterTextBox.TabIndex = 2;
            this.minLetterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minLetterTextBox_KeyPress);
            // 
            // maxLetterTextBox
            // 
            this.maxLetterTextBox.Location = new System.Drawing.Point(12, 115);
            this.maxLetterTextBox.Name = "maxLetterTextBox";
            this.maxLetterTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxLetterTextBox.TabIndex = 3;
            this.maxLetterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxLetterTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max";
            // 
            // pathBTN
            // 
            this.pathBTN.Location = new System.Drawing.Point(518, 26);
            this.pathBTN.Name = "pathBTN";
            this.pathBTN.Size = new System.Drawing.Size(75, 23);
            this.pathBTN.TabIndex = 7;
            this.pathBTN.Text = "Path";
            this.pathBTN.UseVisualStyleBackColor = true;
            this.pathBTN.Click += new System.EventHandler(this.pathBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 153);
            this.Controls.Add(this.pathBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxLetterTextBox);
            this.Controls.Add(this.minLetterTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.RUNBUTTON);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RRF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RUNBUTTON;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.TextBox minLetterTextBox;
        private System.Windows.Forms.TextBox maxLetterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pathBTN;
    }
}

