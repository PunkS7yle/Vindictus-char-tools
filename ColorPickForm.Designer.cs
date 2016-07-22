namespace Vindictus_Tools
{
    partial class ColorPickForm
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
            this.colorEditor1 = new Cyotek.Windows.Forms.ColorEditor();
            this.colorEditorManager1 = new Cyotek.Windows.Forms.ColorEditorManager();
            this.colorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // colorEditor1
            // 
            this.colorEditor1.Location = new System.Drawing.Point(6, 9);
            this.colorEditor1.Name = "colorEditor1";
            this.colorEditor1.Size = new System.Drawing.Size(201, 90);
            this.colorEditor1.TabIndex = 1;
            // 
            // colorEditorManager1
            // 
            this.colorEditorManager1.ColorEditor = this.colorEditor1;
            this.colorEditorManager1.ColorWheel = this.colorWheel1;
            // 
            // colorWheel1
            // 
            this.colorWheel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel1.Location = new System.Drawing.Point(6, 120);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(209, 134);
            this.colorWheel1.TabIndex = 2;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(221, 239);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(70, 48);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "OK";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1Click);
            // 
            // ColorPickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.colorWheel1);
            this.Controls.Add(this.colorEditor1);
            this.Name = "ColorPickForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Cyotek.Windows.Forms.ColorEditor colorEditor1;
        private Cyotek.Windows.Forms.ColorEditorManager colorEditorManager1;
        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}