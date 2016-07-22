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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.combiClassesBox = new MetroFramework.Controls.MetroTextBox();
            this.part1Box = new MetroFramework.Controls.MetroTextBox();
            this.part2Box = new MetroFramework.Controls.MetroTextBox();
            this.part3Box = new MetroFramework.Controls.MetroTextBox();
            this.part4Box = new MetroFramework.Controls.MetroTextBox();
            this.combiSkillBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.part5Box = new MetroFramework.Controls.MetroTextBox();
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
            this.prefixComboBox.SelectedIndexChanged += new System.EventHandler(this.PrefixComboBoxSelectedIndexChanged);
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
            this.suffixComboBox.SelectedIndexChanged += new System.EventHandler(this.SuffixComboBoxSelectedIndexChanged);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 339);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Part 2";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 306);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Part 1";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 401);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Part 4";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(9, 278);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Classes";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(9, 369);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(44, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Part 3";
            // 
            // combiClassesBox
            // 
            this.combiClassesBox.BackColor = System.Drawing.Color.White;
            this.combiClassesBox.Lines = new string[0];
            this.combiClassesBox.Location = new System.Drawing.Point(76, 273);
            this.combiClassesBox.MaxLength = 32767;
            this.combiClassesBox.Name = "combiClassesBox";
            this.combiClassesBox.PasswordChar = '\0';
            this.combiClassesBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.combiClassesBox.SelectedText = "";
            this.combiClassesBox.Size = new System.Drawing.Size(121, 24);
            this.combiClassesBox.TabIndex = 30;
            this.combiClassesBox.UseSelectable = true;
            // 
            // part1Box
            // 
            this.part1Box.BackColor = System.Drawing.Color.White;
            this.part1Box.Lines = new string[0];
            this.part1Box.Location = new System.Drawing.Point(76, 306);
            this.part1Box.MaxLength = 32767;
            this.part1Box.Name = "part1Box";
            this.part1Box.PasswordChar = '\0';
            this.part1Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.part1Box.SelectedText = "";
            this.part1Box.Size = new System.Drawing.Size(121, 24);
            this.part1Box.TabIndex = 30;
            this.part1Box.UseSelectable = true;
            // 
            // part2Box
            // 
            this.part2Box.BackColor = System.Drawing.Color.White;
            this.part2Box.Lines = new string[0];
            this.part2Box.Location = new System.Drawing.Point(76, 339);
            this.part2Box.MaxLength = 32767;
            this.part2Box.Name = "part2Box";
            this.part2Box.PasswordChar = '\0';
            this.part2Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.part2Box.SelectedText = "";
            this.part2Box.Size = new System.Drawing.Size(121, 24);
            this.part2Box.TabIndex = 30;
            this.part2Box.UseSelectable = true;
            // 
            // part3Box
            // 
            this.part3Box.BackColor = System.Drawing.Color.White;
            this.part3Box.Lines = new string[0];
            this.part3Box.Location = new System.Drawing.Point(76, 369);
            this.part3Box.MaxLength = 32767;
            this.part3Box.Name = "part3Box";
            this.part3Box.PasswordChar = '\0';
            this.part3Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.part3Box.SelectedText = "";
            this.part3Box.Size = new System.Drawing.Size(121, 24);
            this.part3Box.TabIndex = 30;
            this.part3Box.UseSelectable = true;
            // 
            // part4Box
            // 
            this.part4Box.BackColor = System.Drawing.Color.White;
            this.part4Box.Lines = new string[0];
            this.part4Box.Location = new System.Drawing.Point(76, 401);
            this.part4Box.MaxLength = 32767;
            this.part4Box.Name = "part4Box";
            this.part4Box.PasswordChar = '\0';
            this.part4Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.part4Box.SelectedText = "";
            this.part4Box.Size = new System.Drawing.Size(121, 24);
            this.part4Box.TabIndex = 30;
            this.part4Box.UseSelectable = true;
            // 
            // combiSkillBox
            // 
            this.combiSkillBox.BackColor = System.Drawing.Color.White;
            this.combiSkillBox.Lines = new string[0];
            this.combiSkillBox.Location = new System.Drawing.Point(76, 464);
            this.combiSkillBox.MaxLength = 32767;
            this.combiSkillBox.Name = "combiSkillBox";
            this.combiSkillBox.PasswordChar = '\0';
            this.combiSkillBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.combiSkillBox.SelectedText = "";
            this.combiSkillBox.Size = new System.Drawing.Size(121, 24);
            this.combiSkillBox.TabIndex = 31;
            this.combiSkillBox.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 464);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(31, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Skill";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(512, 496);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 32);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Update";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(9, 433);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(44, 19);
            this.metroLabel7.TabIndex = 34;
            this.metroLabel7.Text = "Part 5";
            // 
            // part5Box
            // 
            this.part5Box.BackColor = System.Drawing.Color.White;
            this.part5Box.Lines = new string[0];
            this.part5Box.Location = new System.Drawing.Point(76, 433);
            this.part5Box.MaxLength = 32767;
            this.part5Box.Name = "part5Box";
            this.part5Box.PasswordChar = '\0';
            this.part5Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.part5Box.SelectedText = "";
            this.part5Box.Size = new System.Drawing.Size(121, 24);
            this.part5Box.TabIndex = 33;
            this.part5Box.UseSelectable = true;
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 609);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.part5Box);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.combiSkillBox);
            this.Controls.Add(this.part4Box);
            this.Controls.Add(this.part3Box);
            this.Controls.Add(this.part2Box);
            this.Controls.Add(this.part1Box);
            this.Controls.Add(this.combiClassesBox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
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
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox combiClassesBox;
        private MetroFramework.Controls.MetroTextBox part1Box;
        private MetroFramework.Controls.MetroTextBox part2Box;
        private MetroFramework.Controls.MetroTextBox part3Box;
        private MetroFramework.Controls.MetroTextBox part4Box;
        private MetroFramework.Controls.MetroTextBox combiSkillBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox part5Box;
    }
}