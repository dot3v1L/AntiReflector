namespace AntiReflector
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.bSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bSelect);
            this.groupBox1.Controls.Add(this.tbFile);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(49, 29);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(216, 20);
            this.tbFile.TabIndex = 0;
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(271, 28);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(24, 20);
            this.bSelect.TabIndex = 1;
            this.bSelect.Text = "...";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Antis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 113);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "AntiReflector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSelect;
    }
}

