namespace Filmoteka
{
    partial class Form_CompanysDlg
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
            this.button_close = new System.Windows.Forms.Button();
            this.button_action = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_productName = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(12, 82);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(97, 40);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Закрити";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(539, 82);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(97, 40);
            this.button_action.TabIndex = 1;
            this.button_action.Text = "Внести зміни";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(125, 12);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(511, 20);
            this.textBox_id.TabIndex = 2;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(97, 15);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(22, 13);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "id#";
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Location = new System.Drawing.Point(38, 45);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(85, 13);
            this.label_productName.TabIndex = 5;
            this.label_productName.Text = "Назва компанії";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(125, 38);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(511, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // Form_CompanysDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 139);
            this.Controls.Add(this.label_productName);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CompanysDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ProductDlg";
            this.Load += new System.EventHandler(this.Form_ProductDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_productName;
        private System.Windows.Forms.TextBox textBox_name;
        public System.Windows.Forms.Button button_action;
    }
}