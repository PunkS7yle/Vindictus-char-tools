namespace Vindictus_Tools
{
    partial class ConfigForm
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
            this.ipBox = new MetroFramework.Controls.MetroTextBox();
            this.closeFormButton = new MetroFramework.Controls.MetroButton();
            this.userBox = new MetroFramework.Controls.MetroTextBox();
            this.passBox = new MetroFramework.Controls.MetroTextBox();
            this.ipLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ipBox
            // 
            this.ipBox.Lines = new string[0];
            this.ipBox.Location = new System.Drawing.Point(94, 73);
            this.ipBox.MaxLength = 32767;
            this.ipBox.Name = "ipBox";
            this.ipBox.PasswordChar = '\0';
            this.ipBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ipBox.SelectedText = "";
            this.ipBox.Size = new System.Drawing.Size(135, 23);
            this.ipBox.TabIndex = 0;
            this.ipBox.UseSelectable = true;
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(190, 301);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(61, 39);
            this.closeFormButton.TabIndex = 3;
            this.closeFormButton.Text = "OK";
            this.closeFormButton.UseSelectable = true;
            this.closeFormButton.Click += new System.EventHandler(this.CloseFormButtonClick);
            // 
            // userBox
            // 
            this.userBox.Lines = new string[0];
            this.userBox.Location = new System.Drawing.Point(94, 117);
            this.userBox.MaxLength = 32767;
            this.userBox.Name = "userBox";
            this.userBox.PasswordChar = '\0';
            this.userBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userBox.SelectedText = "";
            this.userBox.Size = new System.Drawing.Size(135, 23);
            this.userBox.TabIndex = 1;
            this.userBox.UseSelectable = true;
            // 
            // passBox
            // 
            this.passBox.Lines = new string[0];
            this.passBox.Location = new System.Drawing.Point(94, 161);
            this.passBox.MaxLength = 32767;
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '\0';
            this.passBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passBox.SelectedText = "";
            this.passBox.Size = new System.Drawing.Size(135, 23);
            this.passBox.TabIndex = 2;
            this.passBox.UseSelectable = true;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(7, 77);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(20, 19);
            this.ipLabel.TabIndex = 4;
            this.ipLabel.Text = "IP";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "User";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 165);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Pass";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 347);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.ipBox);
            this.Name = "ConfigForm";
            this.Text = "Connection Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox ipBox;
        private MetroFramework.Controls.MetroButton closeFormButton;
        private MetroFramework.Controls.MetroTextBox userBox;
        private MetroFramework.Controls.MetroTextBox passBox;
        private MetroFramework.Controls.MetroLabel ipLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}