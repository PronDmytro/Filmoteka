namespace Filmoteka
{
    partial class Form_DirectorsDlg
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
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_productNameId = new System.Windows.Forms.Label();
            this.button_action = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(141, 21);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(22, 13);
            this.label_id.TabIndex = 5;
            this.label_id.Text = "id#";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(169, 14);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(160, 20);
            this.textBox_id.TabIndex = 7;
            this.textBox_id.TabStop = false;
            // 
            // label_productNameId
            // 
            this.label_productNameId.AutoSize = true;
            this.label_productNameId.Location = new System.Drawing.Point(86, 48);
            this.label_productNameId.Name = "label_productNameId";
            this.label_productNameId.Size = new System.Drawing.Size(79, 13);
            this.label_productNameId.TabIndex = 7;
            this.label_productNameId.Text = "ПІБ Режисера";
            // 
            // button_action
            // 
            this.button_action.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_action.Location = new System.Drawing.Point(206, 85);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(123, 37);
            this.button_action.TabIndex = 5;
            this.button_action.Text = "Додати";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_close.Location = new System.Drawing.Point(12, 85);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(123, 37);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "Відміна";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(169, 41);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(160, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // Form_DirectorsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 134);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.label_productNameId);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DirectorsDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DrugstoreDlg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_productNameId;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_name;
        public System.Windows.Forms.Button button_action;
    }
}