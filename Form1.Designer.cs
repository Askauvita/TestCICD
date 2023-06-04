
namespace Lab2___Part_1_Cesar
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
            this.breakingTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.breaking = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.loadFile = new System.Windows.Forms.Button();
            this.Language = new System.Windows.Forms.GroupBox();
            this.russian = new System.Windows.Forms.RadioButton();
            this.english = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Language.SuspendLayout();
            this.SuspendLayout();
            // 
            // breakingTextBox
            // 
            this.breakingTextBox.Location = new System.Drawing.Point(23, 72);
            this.breakingTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.breakingTextBox.Multiline = true;
            this.breakingTextBox.Name = "breakingTextBox";
            this.breakingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.breakingTextBox.Size = new System.Drawing.Size(211, 236);
            this.breakingTextBox.TabIndex = 0;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(244, 72);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(221, 236);
            this.resultTextBox.TabIndex = 1;
            // 
            // breaking
            // 
            this.breaking.Location = new System.Drawing.Point(202, 317);
            this.breaking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.breaking.Name = "breaking";
            this.breaking.Size = new System.Drawing.Size(75, 32);
            this.breaking.TabIndex = 2;
            this.breaking.Text = "Взлом";
            this.breaking.UseVisualStyleBackColor = true;
            this.breaking.Click += new System.EventHandler(this.breaking_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(483, 220);
            this.keyTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keyTextBox.MinimumSize = new System.Drawing.Size(18, 33);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keyTextBox.Size = new System.Drawing.Size(100, 55);
            this.keyTextBox.TabIndex = 3;
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(479, 125);
            this.loadFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(104, 49);
            this.loadFile.TabIndex = 4;
            this.loadFile.Text = "Загрузить из файла";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // Language
            // 
            this.Language.Controls.Add(this.russian);
            this.Language.Controls.Add(this.english);
            this.Language.Location = new System.Drawing.Point(479, 15);
            this.Language.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Language.Name = "Language";
            this.Language.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Language.Size = new System.Drawing.Size(111, 93);
            this.Language.TabIndex = 5;
            this.Language.TabStop = false;
            this.Language.Text = "Язык";
            // 
            // russian
            // 
            this.russian.AutoSize = true;
            this.russian.Location = new System.Drawing.Point(20, 61);
            this.russian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.russian.Name = "russian";
            this.russian.Size = new System.Drawing.Size(73, 19);
            this.russian.TabIndex = 1;
            this.russian.TabStop = true;
            this.russian.Text = "Русский";
            this.russian.UseVisualStyleBackColor = true;
            // 
            // english
            // 
            this.english.AutoSize = true;
            this.english.Location = new System.Drawing.Point(20, 31);
            this.english.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(69, 19);
            this.english.TabIndex = 0;
            this.english.TabStop = true;
            this.english.Text = "English";
            this.english.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Текс для взлома";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Результат";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Определенный ключ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Очистить все поля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.loadFile);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.breaking);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.breakingTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Взлом шифра Цезаря";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Language.ResumeLayout(false);
            this.Language.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox breakingTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button breaking;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.GroupBox Language;
        private System.Windows.Forms.RadioButton russian;
        private System.Windows.Forms.RadioButton english;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

