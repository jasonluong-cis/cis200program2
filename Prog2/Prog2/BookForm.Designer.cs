namespace LibraryItems
{
    partial class BookForm
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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.publisherlabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.loanPeriodLabel = new System.Windows.Forms.Label();
            this.callLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.publisherTextbox = new System.Windows.Forms.TextBox();
            this.copyrightTextbox = new System.Windows.Forms.TextBox();
            this.loanPeriodTextbox = new System.Windows.Forms.TextBox();
            this.callNumberTextBox = new System.Windows.Forms.TextBox();
            this.authorTextbox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(81, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // publisherlabel
            // 
            this.publisherlabel.AutoSize = true;
            this.publisherlabel.Location = new System.Drawing.Point(58, 70);
            this.publisherlabel.Name = "publisherlabel";
            this.publisherlabel.Size = new System.Drawing.Size(53, 13);
            this.publisherlabel.TabIndex = 1;
            this.publisherlabel.Text = "Publisher:";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(59, 98);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(54, 13);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright:";
            // 
            // loanPeriodLabel
            // 
            this.loanPeriodLabel.AutoSize = true;
            this.loanPeriodLabel.Location = new System.Drawing.Point(44, 124);
            this.loanPeriodLabel.Name = "loanPeriodLabel";
            this.loanPeriodLabel.Size = new System.Drawing.Size(67, 13);
            this.loanPeriodLabel.TabIndex = 3;
            this.loanPeriodLabel.Text = "Loan Period:";
            // 
            // callLabel
            // 
            this.callLabel.AutoSize = true;
            this.callLabel.Location = new System.Drawing.Point(44, 150);
            this.callLabel.Name = "callLabel";
            this.callLabel.Size = new System.Drawing.Size(70, 13);
            this.callLabel.TabIndex = 4;
            this.callLabel.Text = "Call Number: ";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(70, 176);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 5;
            this.authorLabel.Text = "Author:";
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(147, 41);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(125, 20);
            this.titleTextbox.TabIndex = 6;
            this.titleTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.titleTextbox_Validating);
            this.titleTextbox.Validated += new System.EventHandler(this.titleTextbox_Validated);
            // 
            // publisherTextbox
            // 
            this.publisherTextbox.Location = new System.Drawing.Point(147, 67);
            this.publisherTextbox.Name = "publisherTextbox";
            this.publisherTextbox.Size = new System.Drawing.Size(125, 20);
            this.publisherTextbox.TabIndex = 7;
            this.publisherTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.publisherTextbox_Validating);
            this.publisherTextbox.Validated += new System.EventHandler(this.publisherTextbox_Validated);
            // 
            // copyrightTextbox
            // 
            this.copyrightTextbox.Location = new System.Drawing.Point(147, 95);
            this.copyrightTextbox.Name = "copyrightTextbox";
            this.copyrightTextbox.Size = new System.Drawing.Size(125, 20);
            this.copyrightTextbox.TabIndex = 8;
            this.copyrightTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.copyrightTextbox_Validating);
            this.copyrightTextbox.Validated += new System.EventHandler(this.copyrightTextbox_Validated);
            // 
            // loanPeriodTextbox
            // 
            this.loanPeriodTextbox.Location = new System.Drawing.Point(147, 121);
            this.loanPeriodTextbox.Name = "loanPeriodTextbox";
            this.loanPeriodTextbox.Size = new System.Drawing.Size(125, 20);
            this.loanPeriodTextbox.TabIndex = 9;
            this.loanPeriodTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.loanPeriodTextbox_Validating);
            this.loanPeriodTextbox.Validated += new System.EventHandler(this.loanPeriodTextbox_Validated);
            // 
            // callNumberTextBox
            // 
            this.callNumberTextBox.Location = new System.Drawing.Point(147, 147);
            this.callNumberTextBox.Name = "callNumberTextBox";
            this.callNumberTextBox.Size = new System.Drawing.Size(125, 20);
            this.callNumberTextBox.TabIndex = 10;
            this.callNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.callNumberTextBox_Validating);
            this.callNumberTextBox.Validated += new System.EventHandler(this.callNumberTextBox_Validated);
            // 
            // authorTextbox
            // 
            this.authorTextbox.Location = new System.Drawing.Point(147, 173);
            this.authorTextbox.Name = "authorTextbox";
            this.authorTextbox.Size = new System.Drawing.Size(125, 20);
            this.authorTextbox.TabIndex = 11;
            this.authorTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.authorTextbox_Validating);
            this.authorTextbox.Validated += new System.EventHandler(this.authorTextbox_Validated);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(71, 229);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(66, 20);
            this.OkButton.TabIndex = 12;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(147, 229);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(66, 20);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.authorTextbox);
            this.Controls.Add(this.callNumberTextBox);
            this.Controls.Add(this.loanPeriodTextbox);
            this.Controls.Add(this.copyrightTextbox);
            this.Controls.Add(this.publisherTextbox);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.callLabel);
            this.Controls.Add(this.loanPeriodLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.publisherlabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label publisherlabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label loanPeriodLabel;
        private System.Windows.Forms.Label callLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelButton;
        internal System.Windows.Forms.TextBox titleTextbox;
        internal System.Windows.Forms.TextBox publisherTextbox;
        internal System.Windows.Forms.TextBox copyrightTextbox;
        internal System.Windows.Forms.TextBox loanPeriodTextbox;
        internal System.Windows.Forms.TextBox callNumberTextBox;
        internal System.Windows.Forms.TextBox authorTextbox;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}