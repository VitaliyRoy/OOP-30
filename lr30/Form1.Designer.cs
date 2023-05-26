namespace lr30
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGetSize = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.FadList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(454, 16);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 73);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Підключення та отримання списку каталогів та файлів";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(122, 17);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(326, 20);
            this.tbHost.TabIndex = 2;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(122, 43);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(326, 20);
            this.tbUser.TabIndex = 3;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(122, 69);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(326, 20);
            this.tbPass.TabIndex = 4;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(218, 148);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(350, 20);
            this.tbFilePath.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(218, 178);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(350, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(218, 207);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(350, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(218, 235);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(350, 20);
            this.textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(218, 264);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(350, 20);
            this.textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(51, 300);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(517, 20);
            this.textBox9.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Хост";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ім\'я користувача";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Файл";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Каталог";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Каталог";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Файл";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Каталог";
            // 
            // btnGetSize
            // 
            this.btnGetSize.Location = new System.Drawing.Point(15, 146);
            this.btnGetSize.Name = "btnGetSize";
            this.btnGetSize.Size = new System.Drawing.Size(143, 23);
            this.btnGetSize.TabIndex = 19;
            this.btnGetSize.Text = "Розмір файлу";
            this.btnGetSize.UseVisualStyleBackColor = true;
            this.btnGetSize.Click += new System.EventHandler(this.btnGetSize_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Створити каталог";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Видалити каталог";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Видалити файл";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Завантажити на FTP";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Шлях";
            // 
            // FadList
            // 
            this.FadList.FormattingEnabled = true;
            this.FadList.Location = new System.Drawing.Point(574, 17);
            this.FadList.Name = "FadList";
            this.FadList.Size = new System.Drawing.Size(344, 303);
            this.FadList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 333);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGetSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.FadList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGetSize;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox FadList;
    }
}

