namespace Import
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConnection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // textBoxConnection
            // 
            this.textBoxConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxConnection.Location = new System.Drawing.Point(18, 58);
            this.textBoxConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxConnection.Name = "textBoxConnection";
            this.textBoxConnection.Size = new System.Drawing.Size(775, 26);
            this.textBoxConnection.TabIndex = 1;
            this.textBoxConnection.Text = "Data Source=DESKTOP-I3ASE6T\\SQLEXPRESS;Initial Catalog=Pedich02;Integrated Securi" +
    "ty=True";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите строку подключения";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPath.Location = new System.Drawing.Point(18, 160);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(775, 26);
            this.textBoxPath.TabIndex = 2;
            this.textBoxPath.Text = "C:\\Users\\pedic\\OneDrive\\Рабочий стол\\Matisik-main\\Сессия1\\Товар_import";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Укажите путь к папке с фото";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(316, 212);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(161, 97);
            this.buttonUpload.TabIndex = 3;
            this.buttonUpload.Text = "Загрузить фото";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 341);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.textBoxConnection);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpload;
    }
}

