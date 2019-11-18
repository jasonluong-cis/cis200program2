namespace LibraryItems
{
    partial class CheckoutForm
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
            this.itemCombobox = new System.Windows.Forms.ComboBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.patronLabel = new System.Windows.Forms.Label();
            this.patronCombobox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // itemCombobox
            // 
            this.itemCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCombobox.FormattingEnabled = true;
            this.itemCombobox.Location = new System.Drawing.Point(30, 45);
            this.itemCombobox.Name = "itemCombobox";
            this.itemCombobox.Size = new System.Drawing.Size(211, 21);
            this.itemCombobox.TabIndex = 0;
            this.itemCombobox.Validating += new System.ComponentModel.CancelEventHandler(this.itemCombobox_Validating);
            this.itemCombobox.Validated += new System.EventHandler(this.itemCombobox_Validated);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(27, 29);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(63, 13);
            this.selectLabel.TabIndex = 1;
            this.selectLabel.Text = "Select Item:";
            // 
            // patronLabel
            // 
            this.patronLabel.AutoSize = true;
            this.patronLabel.Location = new System.Drawing.Point(27, 82);
            this.patronLabel.Name = "patronLabel";
            this.patronLabel.Size = new System.Drawing.Size(74, 13);
            this.patronLabel.TabIndex = 2;
            this.patronLabel.Text = "Select Patron:";
            // 
            // patronCombobox
            // 
            this.patronCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patronCombobox.FormattingEnabled = true;
            this.patronCombobox.Location = new System.Drawing.Point(30, 98);
            this.patronCombobox.Name = "patronCombobox";
            this.patronCombobox.Size = new System.Drawing.Size(162, 21);
            this.patronCombobox.TabIndex = 3;
            this.patronCombobox.Validating += new System.ComponentModel.CancelEventHandler(this.patronCombobox_Validating);
            this.patronCombobox.Validated += new System.EventHandler(this.patronCombobox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(30, 140);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(140, 140);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CancelButton_MouseDown);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 214);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.patronCombobox);
            this.Controls.Add(this.patronLabel);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.itemCombobox);
            this.Name = "CheckoutForm";
            this.Text = "CheckOut";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label patronLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        internal System.Windows.Forms.ComboBox itemCombobox;
        internal System.Windows.Forms.ComboBox patronCombobox;
        internal System.Windows.Forms.Button CancelButton;
        internal System.Windows.Forms.Button OkButton;
    }
}