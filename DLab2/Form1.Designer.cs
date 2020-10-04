namespace ALab2
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
            this.Правила = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.List1 = new System.Windows.Forms.ListBox();
            this.List2 = new System.Windows.Forms.ListBox();
            this.Память = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Правила
            // 
            this.Правила.AutoSize = true;
            this.Правила.Location = new System.Drawing.Point(12, 123);
            this.Правила.Name = "Правила";
            this.Правила.Size = new System.Drawing.Size(46, 13);
            this.Правила.TabIndex = 0;
            this.Правила.Text = "Память";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Прямой вывод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Result);
            // 
            // List1
            // 
            this.List1.FormattingEnabled = true;
            this.List1.Location = new System.Drawing.Point(15, 139);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(254, 95);
            this.List1.TabIndex = 5;
            // 
            // List2
            // 
            this.List2.FormattingEnabled = true;
            this.List2.Location = new System.Drawing.Point(12, 22);
            this.List2.Name = "List2";
            this.List2.Size = new System.Drawing.Size(652, 95);
            this.List2.TabIndex = 6;
            // 
            // Память
            // 
            this.Память.AutoSize = true;
            this.Память.Location = new System.Drawing.Point(12, 6);
            this.Память.Name = "Память";
            this.Память.Size = new System.Drawing.Size(51, 13);
            this.Память.TabIndex = 7;
            this.Память.Text = "Правила";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 259);
            this.Controls.Add(this.Память);
            this.Controls.Add(this.List2);
            this.Controls.Add(this.List1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Правила);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Правила;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox List1;
        private System.Windows.Forms.ListBox List2;
        private System.Windows.Forms.Label Память;
    }
}

