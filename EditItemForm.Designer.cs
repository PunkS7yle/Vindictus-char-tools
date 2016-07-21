namespace Vindictus_Tools
{
    partial class EditItemForm
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
            this.prefixComboBox = new MetroFramework.Controls.MetroComboBox();
            this.suffixComboBox = new MetroFramework.Controls.MetroComboBox();
            this.sufixLabel = new MetroFramework.Controls.MetroLabel();
            this.prefixLabel = new MetroFramework.Controls.MetroLabel();
            this.doneEditButton = new MetroFramework.Controls.MetroButton();
            this.enhanceLabel = new MetroFramework.Controls.MetroLabel();
            this.enhanceComboBox = new MetroFramework.Controls.MetroComboBox();
            this.qualLabel = new MetroFramework.Controls.MetroLabel();
            this.qualityComboBox = new MetroFramework.Controls.MetroComboBox();
            this.itemClassLabel = new MetroFramework.Controls.MetroLabel();
            this.itemClassBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // prefixComboBox
            // 
            this.prefixComboBox.FormattingEnabled = true;
            this.prefixComboBox.ItemHeight = 23;
            this.prefixComboBox.Items.AddRange(new object[] {
            "null"});
            this.prefixComboBox.Location = new System.Drawing.Point(76, 185);
            this.prefixComboBox.Name = "prefixComboBox";
            this.prefixComboBox.Size = new System.Drawing.Size(121, 29);
            this.prefixComboBox.TabIndex = 0;
            this.prefixComboBox.UseSelectable = true;
            // 
            // suffixComboBox
            // 
            this.suffixComboBox.FormattingEnabled = true;
            this.suffixComboBox.ItemHeight = 23;
            this.suffixComboBox.Items.AddRange(new object[] {
            "null"});
            this.suffixComboBox.Location = new System.Drawing.Point(76, 150);
            this.suffixComboBox.Name = "suffixComboBox";
            this.suffixComboBox.Size = new System.Drawing.Size(121, 29);
            this.suffixComboBox.TabIndex = 1;
            this.suffixComboBox.UseSelectable = true;
            // 
            // sufixLabel
            // 
            this.sufixLabel.AutoSize = true;
            this.sufixLabel.Location = new System.Drawing.Point(9, 160);
            this.sufixLabel.Name = "sufixLabel";
            this.sufixLabel.Size = new System.Drawing.Size(40, 19);
            this.sufixLabel.TabIndex = 2;
            this.sufixLabel.Text = "Suffix";
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Location = new System.Drawing.Point(9, 195);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(42, 19);
            this.prefixLabel.TabIndex = 4;
            this.prefixLabel.Text = "Prefix";
            // 
            // doneEditButton
            // 
            this.doneEditButton.Location = new System.Drawing.Point(512, 547);
            this.doneEditButton.Name = "doneEditButton";
            this.doneEditButton.Size = new System.Drawing.Size(82, 48);
            this.doneEditButton.TabIndex = 5;
            this.doneEditButton.Text = "OK";
            this.doneEditButton.UseSelectable = true;
            this.doneEditButton.Click += new System.EventHandler(this.DoneEditButtonClick);
            // 
            // enhanceLabel
            // 
            this.enhanceLabel.AutoSize = true;
            this.enhanceLabel.Location = new System.Drawing.Point(9, 90);
            this.enhanceLabel.Name = "enhanceLabel";
            this.enhanceLabel.Size = new System.Drawing.Size(61, 19);
            this.enhanceLabel.TabIndex = 6;
            this.enhanceLabel.Text = "Enhance ";
            // 
            // enhanceComboBox
            // 
            this.enhanceComboBox.FormattingEnabled = true;
            this.enhanceComboBox.ItemHeight = 23;
            this.enhanceComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.enhanceComboBox.Location = new System.Drawing.Point(76, 80);
            this.enhanceComboBox.Name = "enhanceComboBox";
            this.enhanceComboBox.Size = new System.Drawing.Size(121, 29);
            this.enhanceComboBox.TabIndex = 7;
            this.enhanceComboBox.UseSelectable = true;
            // 
            // qualLabel
            // 
            this.qualLabel.AutoSize = true;
            this.qualLabel.Location = new System.Drawing.Point(9, 125);
            this.qualLabel.Name = "qualLabel";
            this.qualLabel.Size = new System.Drawing.Size(50, 19);
            this.qualLabel.TabIndex = 9;
            this.qualLabel.Text = "Quality";
            // 
            // qualityComboBox
            // 
            this.qualityComboBox.FormattingEnabled = true;
            this.qualityComboBox.ItemHeight = 23;
            this.qualityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.qualityComboBox.Location = new System.Drawing.Point(76, 115);
            this.qualityComboBox.Name = "qualityComboBox";
            this.qualityComboBox.Size = new System.Drawing.Size(121, 29);
            this.qualityComboBox.TabIndex = 10;
            this.qualityComboBox.UseSelectable = true;
            // 
            // itemClassLabel
            // 
            this.itemClassLabel.AutoSize = true;
            this.itemClassLabel.Location = new System.Drawing.Point(260, 90);
            this.itemClassLabel.Name = "itemClassLabel";
            this.itemClassLabel.Size = new System.Drawing.Size(68, 19);
            this.itemClassLabel.TabIndex = 13;
            this.itemClassLabel.Text = "Item Class";
            // 
            // itemClassBox
            // 
            this.itemClassBox.Lines = new string[0];
            this.itemClassBox.Location = new System.Drawing.Point(334, 85);
            this.itemClassBox.MaxLength = 32767;
            this.itemClassBox.Name = "itemClassBox";
            this.itemClassBox.PasswordChar = '\0';
            this.itemClassBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itemClassBox.SelectedText = "";
            this.itemClassBox.Size = new System.Drawing.Size(163, 24);
            this.itemClassBox.TabIndex = 14;
            this.itemClassBox.UseSelectable = true;
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 609);
            this.ControlBox = false;
            this.Controls.Add(this.itemClassBox);
            this.Controls.Add(this.itemClassLabel);
            this.Controls.Add(this.qualityComboBox);
            this.Controls.Add(this.qualLabel);
            this.Controls.Add(this.enhanceComboBox);
            this.Controls.Add(this.enhanceLabel);
            this.Controls.Add(this.doneEditButton);
            this.Controls.Add(this.prefixLabel);
            this.Controls.Add(this.sufixLabel);
            this.Controls.Add(this.suffixComboBox);
            this.Controls.Add(this.prefixComboBox);
            this.Name = "EditItemForm";
            this.Text = "Item Attributes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox prefixComboBox;
        private MetroFramework.Controls.MetroComboBox suffixComboBox;
        private MetroFramework.Controls.MetroLabel sufixLabel;
        private MetroFramework.Controls.MetroLabel prefixLabel;
        private MetroFramework.Controls.MetroButton doneEditButton;
        private MetroFramework.Controls.MetroLabel enhanceLabel;
        private MetroFramework.Controls.MetroComboBox enhanceComboBox;
        private MetroFramework.Controls.MetroLabel qualLabel;
        private MetroFramework.Controls.MetroComboBox qualityComboBox;
        private MetroFramework.Controls.MetroLabel itemClassLabel;
        private MetroFramework.Controls.MetroTextBox itemClassBox;
    }
}