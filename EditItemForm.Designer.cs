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
            this.colorLabel1 = new MetroFramework.Controls.MetroLabel();
            this.colorLabel2 = new MetroFramework.Controls.MetroLabel();
            this.colorLabel3 = new MetroFramework.Controls.MetroLabel();
            this.color1Box = new MetroFramework.Controls.MetroTextBox();
            this.color2Box = new MetroFramework.Controls.MetroTextBox();
            this.color3Box = new MetroFramework.Controls.MetroTextBox();
            this.color1Picture = new System.Windows.Forms.PictureBox();
            this.color3Picture = new System.Windows.Forms.PictureBox();
            this.color2Picture = new System.Windows.Forms.PictureBox();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.color1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2Picture)).BeginInit();
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
            // colorLabel1
            // 
            this.colorLabel1.AutoSize = true;
            this.colorLabel1.Location = new System.Drawing.Point(260, 125);
            this.colorLabel1.Name = "colorLabel1";
            this.colorLabel1.Size = new System.Drawing.Size(51, 19);
            this.colorLabel1.TabIndex = 15;
            this.colorLabel1.Text = "Color 1";
            // 
            // colorLabel2
            // 
            this.colorLabel2.AutoSize = true;
            this.colorLabel2.Location = new System.Drawing.Point(260, 160);
            this.colorLabel2.Name = "colorLabel2";
            this.colorLabel2.Size = new System.Drawing.Size(53, 19);
            this.colorLabel2.TabIndex = 16;
            this.colorLabel2.Text = "Color 2";
            // 
            // colorLabel3
            // 
            this.colorLabel3.AutoSize = true;
            this.colorLabel3.Location = new System.Drawing.Point(260, 195);
            this.colorLabel3.Name = "colorLabel3";
            this.colorLabel3.Size = new System.Drawing.Size(53, 19);
            this.colorLabel3.TabIndex = 17;
            this.colorLabel3.Text = "Color 3";
            // 
            // color1Box
            // 
            this.color1Box.BackColor = System.Drawing.Color.White;
            this.color1Box.Lines = new string[0];
            this.color1Box.Location = new System.Drawing.Point(334, 120);
            this.color1Box.MaxLength = 32767;
            this.color1Box.Name = "color1Box";
            this.color1Box.PasswordChar = '\0';
            this.color1Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.color1Box.SelectedText = "";
            this.color1Box.Size = new System.Drawing.Size(103, 24);
            this.color1Box.TabIndex = 18;
            this.color1Box.UseSelectable = true;
            this.color1Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Color1BoxKeyDown);
            // 
            // color2Box
            // 
            this.color2Box.Lines = new string[0];
            this.color2Box.Location = new System.Drawing.Point(334, 155);
            this.color2Box.MaxLength = 32767;
            this.color2Box.Name = "color2Box";
            this.color2Box.PasswordChar = '\0';
            this.color2Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.color2Box.SelectedText = "";
            this.color2Box.Size = new System.Drawing.Size(103, 24);
            this.color2Box.TabIndex = 19;
            this.color2Box.UseSelectable = true;
            this.color2Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Color2BoxKeyDown);
            // 
            // color3Box
            // 
            this.color3Box.Lines = new string[0];
            this.color3Box.Location = new System.Drawing.Point(334, 190);
            this.color3Box.MaxLength = 32767;
            this.color3Box.Name = "color3Box";
            this.color3Box.PasswordChar = '\0';
            this.color3Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.color3Box.SelectedText = "";
            this.color3Box.Size = new System.Drawing.Size(103, 24);
            this.color3Box.TabIndex = 20;
            this.color3Box.UseSelectable = true;
            this.color3Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Color3BoxKeyDown);
            // 
            // color1Picture
            // 
            this.color1Picture.BackColor = System.Drawing.Color.Transparent;
            this.color1Picture.Location = new System.Drawing.Point(443, 120);
            this.color1Picture.Name = "color1Picture";
            this.color1Picture.Size = new System.Drawing.Size(53, 24);
            this.color1Picture.TabIndex = 24;
            this.color1Picture.TabStop = false;
            this.color1Picture.DoubleClick += new System.EventHandler(this.Color1PictureDoubleClick);
            // 
            // color3Picture
            // 
            this.color3Picture.BackColor = System.Drawing.Color.Transparent;
            this.color3Picture.Location = new System.Drawing.Point(443, 190);
            this.color3Picture.Name = "color3Picture";
            this.color3Picture.Size = new System.Drawing.Size(53, 24);
            this.color3Picture.TabIndex = 25;
            this.color3Picture.TabStop = false;
            this.color3Picture.DoubleClick += new System.EventHandler(this.Color3PictureDoubleClick);
            // 
            // color2Picture
            // 
            this.color2Picture.BackColor = System.Drawing.Color.Transparent;
            this.color2Picture.Location = new System.Drawing.Point(443, 155);
            this.color2Picture.Name = "color2Picture";
            this.color2Picture.Size = new System.Drawing.Size(53, 24);
            this.color2Picture.TabIndex = 26;
            this.color2Picture.TabStop = false;
            this.color2Picture.DoubleClick += new System.EventHandler(this.Color2PictureDoubleClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(512, 481);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 48);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Save";
            this.saveButton.UseSelectable = true;
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 609);
            this.ControlBox = false;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.color2Picture);
            this.Controls.Add(this.color3Picture);
            this.Controls.Add(this.color1Picture);
            this.Controls.Add(this.color3Box);
            this.Controls.Add(this.color2Box);
            this.Controls.Add(this.color1Box);
            this.Controls.Add(this.colorLabel3);
            this.Controls.Add(this.colorLabel2);
            this.Controls.Add(this.colorLabel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.color1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2Picture)).EndInit();
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
        private MetroFramework.Controls.MetroLabel colorLabel1;
        private MetroFramework.Controls.MetroLabel colorLabel2;
        private MetroFramework.Controls.MetroLabel colorLabel3;
        private MetroFramework.Controls.MetroTextBox color1Box;
        private MetroFramework.Controls.MetroTextBox color2Box;
        private MetroFramework.Controls.MetroTextBox color3Box;
        private System.Windows.Forms.PictureBox color1Picture;
        private System.Windows.Forms.PictureBox color3Picture;
        private System.Windows.Forms.PictureBox color2Picture;
        private MetroFramework.Controls.MetroButton saveButton;
    }
}