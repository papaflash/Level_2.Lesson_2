namespace Task_1_Worker
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
            this.BtnSalary = new System.Windows.Forms.Button();
            this.ListWorkers = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalary
            // 
            this.BtnSalary.Location = new System.Drawing.Point(97, 258);
            this.BtnSalary.Name = "BtnSalary";
            this.BtnSalary.Size = new System.Drawing.Size(212, 48);
            this.BtnSalary.TabIndex = 0;
            this.BtnSalary.Text = "Среднемесячная ЗП";
            this.BtnSalary.UseVisualStyleBackColor = true;
            this.BtnSalary.Click += new System.EventHandler(this.BtnSalary_Click);
            // 
            // ListWorkers
            // 
            this.ListWorkers.FormattingEnabled = true;
            this.ListWorkers.Location = new System.Drawing.Point(76, 39);
            this.ListWorkers.Name = "ListWorkers";
            this.ListWorkers.Size = new System.Drawing.Size(616, 173);
            this.ListWorkers.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(434, 258);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(206, 48);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Сортировать по зарплате";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.ListWorkers);
            this.Controls.Add(this.BtnSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalary;
        private System.Windows.Forms.ListBox ListWorkers;
        private System.Windows.Forms.Button btnSort;
    }
}

