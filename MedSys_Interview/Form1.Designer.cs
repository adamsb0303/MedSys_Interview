namespace MedSys_Interview
{
    partial class Form1
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
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.editUpdateButton = new System.Windows.Forms.Button();
            this.editCancelButton = new System.Windows.Forms.Button();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(30, 12);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(742, 20);
            this.itemTextBox.TabIndex = 1;
            this.itemTextBox.KeyDown += this.itemTextBox_KeyDown;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(535, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(30, 69);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(742, 342);
            this.itemListBox.TabIndex = 3;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged);
            this.itemListBox.KeyDown += itemListBox_KeyDown;
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(697, 38);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(616, 38);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editUpdateButton
            // 
            this.editUpdateButton.Location = new System.Drawing.Point(578, 38);
            this.editUpdateButton.Name = "editUpdateButton";
            this.editUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.editUpdateButton.TabIndex = 6;
            this.editUpdateButton.Text = "Update";
            this.editUpdateButton.UseVisualStyleBackColor = true;
            this.editUpdateButton.Click += new System.EventHandler(this.editUpdateButton_Click);
            // 
            // editCancelButton
            // 
            this.editCancelButton.Location = new System.Drawing.Point(659, 38);
            this.editCancelButton.Name = "editCancelButton";
            this.editCancelButton.Size = new System.Drawing.Size(75, 23);
            this.editCancelButton.TabIndex = 7;
            this.editCancelButton.Text = "Cancel";
            this.editCancelButton.UseVisualStyleBackColor = true;
            this.editCancelButton.Click += new System.EventHandler(this.editCancelButton_Click);
            // 
            // editTextBox
            // 
            this.editTextBox.Location = new System.Drawing.Point(30, 12);
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.Size = new System.Drawing.Size(742, 20);
            this.editTextBox.TabIndex = 8;
            this.editTextBox.KeyDown += this.editTextBox_KeyDown;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.editTextBox);
            this.Controls.Add(this.editCancelButton);
            this.Controls.Add(this.editUpdateButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.itemTextBox);
            this.Name = "Form1";
            this.Text = "MedSys Interview";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += this.Form1_Closing;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button editUpdateButton;
        private System.Windows.Forms.Button editCancelButton;
        private System.Windows.Forms.TextBox editTextBox;
    }
}

