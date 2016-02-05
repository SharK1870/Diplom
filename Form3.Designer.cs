namespace Диплом
{
    partial class NewPresentation
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
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrganization = new System.Windows.Forms.TextBox();
            this.tbTheme = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.btnNewPresentationCancel = new System.Windows.Forms.Button();
            this.btnNewPresentationOK = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbTheme
            // 
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Items.AddRange(new object[] {
            "beige",
            "blood",
            "default",
            "moon",
            "night",
            "serif",
            "simple",
            "sky",
            "solarized"});
            this.cbTheme.Location = new System.Drawing.Point(125, 110);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(158, 21);
            this.cbTheme.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Тема отображения\r\nпрезентации:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Организация:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Тема:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Автор:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название:";
            // 
            // tbOrganization
            // 
            this.tbOrganization.Location = new System.Drawing.Point(125, 87);
            this.tbOrganization.Name = "tbOrganization";
            this.tbOrganization.Size = new System.Drawing.Size(158, 20);
            this.tbOrganization.TabIndex = 15;
            // 
            // tbTheme
            // 
            this.tbTheme.Location = new System.Drawing.Point(125, 61);
            this.tbTheme.Name = "tbTheme";
            this.tbTheme.Size = new System.Drawing.Size(158, 20);
            this.tbTheme.TabIndex = 14;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(125, 35);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(158, 20);
            this.tbAuthor.TabIndex = 13;
            // 
            // btnNewPresentationCancel
            // 
            this.btnNewPresentationCancel.Location = new System.Drawing.Point(146, 147);
            this.btnNewPresentationCancel.Name = "btnNewPresentationCancel";
            this.btnNewPresentationCancel.Size = new System.Drawing.Size(137, 23);
            this.btnNewPresentationCancel.TabIndex = 17;
            this.btnNewPresentationCancel.Text = "Отмена";
            this.btnNewPresentationCancel.UseVisualStyleBackColor = true;
            this.btnNewPresentationCancel.Click += new System.EventHandler(this.btnNewPresentationCancel_Click);
            // 
            // btnNewPresentationOK
            // 
            this.btnNewPresentationOK.Location = new System.Drawing.Point(3, 147);
            this.btnNewPresentationOK.Name = "btnNewPresentationOK";
            this.btnNewPresentationOK.Size = new System.Drawing.Size(137, 23);
            this.btnNewPresentationOK.TabIndex = 16;
            this.btnNewPresentationOK.Text = "OK";
            this.btnNewPresentationOK.UseVisualStyleBackColor = true;
            this.btnNewPresentationOK.Click += new System.EventHandler(this.btnNewPresentationOK_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(125, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(158, 20);
            this.tbName.TabIndex = 12;
            // 
            // NewPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 177);
            this.Controls.Add(this.cbTheme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOrganization);
            this.Controls.Add(this.tbTheme);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.btnNewPresentationCancel);
            this.Controls.Add(this.btnNewPresentationOK);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPresentation";
            this.Text = "Создание презентации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbTheme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbOrganization;
        public System.Windows.Forms.TextBox tbTheme;
        public System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Button btnNewPresentationCancel;
        private System.Windows.Forms.Button btnNewPresentationOK;
        public System.Windows.Forms.TextBox tbName;
    }
}