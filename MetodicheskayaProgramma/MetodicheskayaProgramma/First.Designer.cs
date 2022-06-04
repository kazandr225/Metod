
namespace MetodicheskayaProgramma
{
    partial class First
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First));
            this.ExitBtn_First = new System.Windows.Forms.Button();
            this.NextBtn_First = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitBtn_First
            // 
            this.ExitBtn_First.Location = new System.Drawing.Point(788, 12);
            this.ExitBtn_First.Name = "ExitBtn_First";
            this.ExitBtn_First.Size = new System.Drawing.Size(82, 29);
            this.ExitBtn_First.TabIndex = 0;
            this.ExitBtn_First.Text = "Выход";
            this.ExitBtn_First.UseVisualStyleBackColor = true;
            this.ExitBtn_First.Click += new System.EventHandler(this.ExitBtn_First_Click);
            // 
            // NextBtn_First
            // 
            this.NextBtn_First.Location = new System.Drawing.Point(788, 462);
            this.NextBtn_First.Name = "NextBtn_First";
            this.NextBtn_First.Size = new System.Drawing.Size(82, 29);
            this.NextBtn_First.TabIndex = 0;
            this.NextBtn_First.Text = "Далее";
            this.NextBtn_First.UseVisualStyleBackColor = true;
            this.NextBtn_First.Click += new System.EventHandler(this.NextBtn_First_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(53, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Данная обучающая программа создана как методическое пособие для студентов, исполь" +
    "зующих. Тама программы \"Построение канонической задачи минимизации и результатов" +
    " 1-ой симплекс-таблицы\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(258, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 109);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextBtn_First);
            this.Controls.Add(this.ExitBtn_First);
            this.Name = "First";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начальное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn_First;
        private System.Windows.Forms.Button NextBtn_First;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

