namespace Filmoteka
{
    partial class Form_FilmsDlg
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
            this.comboBox_director = new System.Windows.Forms.ComboBox();
            this.comboBox_company = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_dtrel = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_filmName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.label_number = new System.Windows.Forms.Label();
            this.label_itemsName = new System.Windows.Forms.Label();
            this.label_director = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_action = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_director
            // 
            this.comboBox_director.FormattingEnabled = true;
            this.comboBox_director.Location = new System.Drawing.Point(183, 116);
            this.comboBox_director.Name = "comboBox_director";
            this.comboBox_director.Size = new System.Drawing.Size(232, 21);
            this.comboBox_director.TabIndex = 69;
            // 
            // comboBox_company
            // 
            this.comboBox_company.FormattingEnabled = true;
            this.comboBox_company.Location = new System.Drawing.Point(183, 141);
            this.comboBox_company.Name = "comboBox_company";
            this.comboBox_company.Size = new System.Drawing.Size(232, 21);
            this.comboBox_company.TabIndex = 68;
            // 
            // dateTimePicker_dtrel
            // 
            this.dateTimePicker_dtrel.CustomFormat = "dd.MM.yyyy ";
            this.dateTimePicker_dtrel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dtrel.Location = new System.Drawing.Point(183, 90);
            this.dateTimePicker_dtrel.Name = "dateTimePicker_dtrel";
            this.dateTimePicker_dtrel.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker_dtrel.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Дата випуску";
            // 
            // textBox_filmName
            // 
            this.textBox_filmName.Location = new System.Drawing.Point(183, 38);
            this.textBox_filmName.Name = "textBox_filmName";
            this.textBox_filmName.Size = new System.Drawing.Size(232, 20);
            this.textBox_filmName.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Назва Фільму";
            // 
            // textBox_genre
            // 
            this.textBox_genre.Location = new System.Drawing.Point(183, 64);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(232, 20);
            this.textBox_genre.TabIndex = 55;
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(141, 71);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(36, 13);
            this.label_number.TabIndex = 54;
            this.label_number.Text = "Жанр";
            // 
            // label_itemsName
            // 
            this.label_itemsName.AutoSize = true;
            this.label_itemsName.Location = new System.Drawing.Point(123, 149);
            this.label_itemsName.Name = "label_itemsName";
            this.label_itemsName.Size = new System.Drawing.Size(54, 13);
            this.label_itemsName.TabIndex = 53;
            this.label_itemsName.Text = "Компанія";
            // 
            // label_director
            // 
            this.label_director.AutoSize = true;
            this.label_director.Location = new System.Drawing.Point(125, 124);
            this.label_director.Name = "label_director";
            this.label_director.Size = new System.Drawing.Size(52, 13);
            this.label_director.TabIndex = 52;
            this.label_director.Text = "Режисер";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(155, 15);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(22, 13);
            this.label_id.TabIndex = 51;
            this.label_id.Text = "id#";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(183, 12);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(232, 20);
            this.textBox_id.TabIndex = 50;
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(318, 190);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(97, 40);
            this.button_action.TabIndex = 49;
            this.button_action.Text = "Внести зміни";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(12, 190);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(97, 40);
            this.button_close.TabIndex = 48;
            this.button_close.Text = "Закрити";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form_FilmsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 255);
            this.Controls.Add(this.comboBox_director);
            this.Controls.Add(this.comboBox_company);
            this.Controls.Add(this.dateTimePicker_dtrel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_filmName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_itemsName);
            this.Controls.Add(this.label_director);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_FilmsDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SupplylogDlg";
            this.Load += new System.EventHandler(this.Form_SupplylogDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_director;
        private System.Windows.Forms.ComboBox comboBox_company;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dtrel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_filmName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_genre;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_itemsName;
        private System.Windows.Forms.Label label_director;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        public System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Button button_close;
    }
}