
namespace ExchangesRate
{
    partial class MainForm
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
            this.db_dialog_richTextBox = new System.Windows.Forms.RichTextBox();
            this.db_request_label = new System.Windows.Forms.Label();
            this.get_from_db_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.parseOnDate_button = new System.Windows.Forms.Button();
            this.todayParse_label = new System.Windows.Forms.Label();
            this.db_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.info_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExchangesRate_TextBox = new System.Windows.Forms.RichTextBox();
            this.parseToday_button = new System.Windows.Forms.Button();
            this.chart_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // db_dialog_richTextBox
            // 
            this.db_dialog_richTextBox.Location = new System.Drawing.Point(355, 2);
            this.db_dialog_richTextBox.Name = "db_dialog_richTextBox";
            this.db_dialog_richTextBox.Size = new System.Drawing.Size(315, 178);
            this.db_dialog_richTextBox.TabIndex = 18;
            this.db_dialog_richTextBox.Text = "";
            // 
            // db_request_label
            // 
            this.db_request_label.AutoSize = true;
            this.db_request_label.Location = new System.Drawing.Point(445, 201);
            this.db_request_label.Name = "db_request_label";
            this.db_request_label.Size = new System.Drawing.Size(205, 13);
            this.db_request_label.TabIndex = 17;
            this.db_request_label.Text = "Выгрузить курс валют из базы данных";
            // 
            // get_from_db_button
            // 
            this.get_from_db_button.Location = new System.Drawing.Point(505, 217);
            this.get_from_db_button.Name = "get_from_db_button";
            this.get_from_db_button.Size = new System.Drawing.Size(95, 34);
            this.get_from_db_button.TabIndex = 16;
            this.get_from_db_button.Text = "Получить";
            this.get_from_db_button.UseVisualStyleBackColor = true;
            this.get_from_db_button.Click += new System.EventHandler(this.get_from_db_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Получить курс валют на выбранную дату";
            // 
            // parseOnDate_button
            // 
            this.parseOnDate_button.Location = new System.Drawing.Point(251, 217);
            this.parseOnDate_button.Name = "parseOnDate_button";
            this.parseOnDate_button.Size = new System.Drawing.Size(95, 34);
            this.parseOnDate_button.TabIndex = 14;
            this.parseOnDate_button.Text = "Получить";
            this.parseOnDate_button.UseVisualStyleBackColor = true;
            this.parseOnDate_button.Click += new System.EventHandler(this.parseOnDate_button_Click);
            // 
            // todayParse_label
            // 
            this.todayParse_label.AutoSize = true;
            this.todayParse_label.Location = new System.Drawing.Point(9, 201);
            this.todayParse_label.Name = "todayParse_label";
            this.todayParse_label.Size = new System.Drawing.Size(173, 13);
            this.todayParse_label.TabIndex = 13;
            this.todayParse_label.Text = "Получить курс валют на сегодня";
            // 
            // db_dateTimePicker
            // 
            this.db_dateTimePicker.Location = new System.Drawing.Point(459, 257);
            this.db_dateTimePicker.Name = "db_dateTimePicker";
            this.db_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.db_dateTimePicker.TabIndex = 11;
            // 
            // info_dateTimePicker
            // 
            this.info_dateTimePicker.Location = new System.Drawing.Point(194, 257);
            this.info_dateTimePicker.Name = "info_dateTimePicker";
            this.info_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.info_dateTimePicker.TabIndex = 12;
            // 
            // ExchangesRate_TextBox
            // 
            this.ExchangesRate_TextBox.Location = new System.Drawing.Point(12, 2);
            this.ExchangesRate_TextBox.Name = "ExchangesRate_TextBox";
            this.ExchangesRate_TextBox.Size = new System.Drawing.Size(315, 178);
            this.ExchangesRate_TextBox.TabIndex = 10;
            this.ExchangesRate_TextBox.Text = "";
            // 
            // parseToday_button
            // 
            this.parseToday_button.Location = new System.Drawing.Point(47, 217);
            this.parseToday_button.Name = "parseToday_button";
            this.parseToday_button.Size = new System.Drawing.Size(95, 34);
            this.parseToday_button.TabIndex = 9;
            this.parseToday_button.Text = "Получить";
            this.parseToday_button.UseVisualStyleBackColor = true;
            this.parseToday_button.Click += new System.EventHandler(this.parseToday_button_Click);
            // 
            // chart_button
            // 
            this.chart_button.Location = new System.Drawing.Point(47, 295);
            this.chart_button.Name = "chart_button";
            this.chart_button.Size = new System.Drawing.Size(151, 29);
            this.chart_button.TabIndex = 19;
            this.chart_button.Text = "Показать графики";
            this.chart_button.UseVisualStyleBackColor = true;
            this.chart_button.Click += new System.EventHandler(this.chart_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 338);
            this.Controls.Add(this.chart_button);
            this.Controls.Add(this.db_dialog_richTextBox);
            this.Controls.Add(this.db_request_label);
            this.Controls.Add(this.get_from_db_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parseOnDate_button);
            this.Controls.Add(this.todayParse_label);
            this.Controls.Add(this.db_dateTimePicker);
            this.Controls.Add(this.info_dateTimePicker);
            this.Controls.Add(this.ExchangesRate_TextBox);
            this.Controls.Add(this.parseToday_button);
            this.Name = "MainForm";
            this.Text = "Парсер курса валют";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox db_dialog_richTextBox;
        private System.Windows.Forms.Label db_request_label;
        private System.Windows.Forms.Button get_from_db_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button parseOnDate_button;
        private System.Windows.Forms.Label todayParse_label;
        private System.Windows.Forms.DateTimePicker db_dateTimePicker;
        private System.Windows.Forms.DateTimePicker info_dateTimePicker;
        private System.Windows.Forms.RichTextBox ExchangesRate_TextBox;
        private System.Windows.Forms.Button parseToday_button;
        private System.Windows.Forms.Button chart_button;
    }
}

