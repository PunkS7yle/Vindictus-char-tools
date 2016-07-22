using System.Windows.Forms;

namespace Vindictus_Tools
{
   

    partial class MainForm
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
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.charInfoTab = new MetroFramework.Controls.MetroTabPage();
            this.guildBox = new MetroFramework.Controls.MetroTextBox();
            this.guildLabel = new MetroFramework.Controls.MetroLabel();
            this.craftTypeBox = new MetroFramework.Controls.MetroTextBox();
            this.craftExpBox = new MetroFramework.Controls.MetroTextBox();
            this.craftComboBox = new MetroFramework.Controls.MetroComboBox();
            this.craftExpLabel = new MetroFramework.Controls.MetroLabel();
            this.craftLevelLabel = new MetroFramework.Controls.MetroLabel();
            this.pathLevelBox = new MetroFramework.Controls.MetroTextBox();
            this.pathLevelLabel = new MetroFramework.Controls.MetroLabel();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.craftLabel = new MetroFramework.Controls.MetroLabel();
            this.pathComboBox = new MetroFramework.Controls.MetroComboBox();
            this.pathLabel = new MetroFramework.Controls.MetroLabel();
            this.searchBox = new MetroFramework.Controls.MetroTextBox();
            this.classComboBox = new MetroFramework.Controls.MetroComboBox();
            this.classLabel = new MetroFramework.Controls.MetroLabel();
            this.expBox = new MetroFramework.Controls.MetroTextBox();
            this.expLabel = new MetroFramework.Controls.MetroLabel();
            this.nameBox = new MetroFramework.Controls.MetroTextBox();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.searchButton = new MetroFramework.Controls.MetroButton();
            this.searchComboBox = new MetroFramework.Controls.MetroComboBox();
            this.searchLabel = new MetroFramework.Controls.MetroLabel();
            this.cidLabel = new MetroFramework.Controls.MetroLabel();
            this.cidBox = new MetroFramework.Controls.MetroTextBox();
            this.apBox = new MetroFramework.Controls.MetroTextBox();
            this.apLabel = new MetroFramework.Controls.MetroLabel();
            this.levelLabel = new MetroFramework.Controls.MetroLabel();
            this.levelBox = new MetroFramework.Controls.MetroTextBox();
            this.objectListTab = new MetroFramework.Controls.MetroTabPage();
            this.itemListView = new BrightIdeasSoftware.FastObjectListView();
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.classColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.countColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.idColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.slotColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tradeableColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.expirationColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.editColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.deleteColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.settingsButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.charInfoTab.SuspendLayout();
            this.objectListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemListView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl.Controls.Add(this.charInfoTab);
            this.tabControl.Controls.Add(this.objectListTab);
            this.tabControl.Location = new System.Drawing.Point(23, 63);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1020, 639);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            this.tabControl.UseStyleColors = true;
            // 
            // charInfoTab
            // 
            this.charInfoTab.Controls.Add(this.guildBox);
            this.charInfoTab.Controls.Add(this.guildLabel);
            this.charInfoTab.Controls.Add(this.craftTypeBox);
            this.charInfoTab.Controls.Add(this.craftExpBox);
            this.charInfoTab.Controls.Add(this.craftComboBox);
            this.charInfoTab.Controls.Add(this.craftExpLabel);
            this.charInfoTab.Controls.Add(this.craftLevelLabel);
            this.charInfoTab.Controls.Add(this.pathLevelBox);
            this.charInfoTab.Controls.Add(this.pathLevelLabel);
            this.charInfoTab.Controls.Add(this.updateButton);
            this.charInfoTab.Controls.Add(this.craftLabel);
            this.charInfoTab.Controls.Add(this.pathComboBox);
            this.charInfoTab.Controls.Add(this.pathLabel);
            this.charInfoTab.Controls.Add(this.searchBox);
            this.charInfoTab.Controls.Add(this.classComboBox);
            this.charInfoTab.Controls.Add(this.classLabel);
            this.charInfoTab.Controls.Add(this.expBox);
            this.charInfoTab.Controls.Add(this.expLabel);
            this.charInfoTab.Controls.Add(this.nameBox);
            this.charInfoTab.Controls.Add(this.nameLabel);
            this.charInfoTab.Controls.Add(this.searchButton);
            this.charInfoTab.Controls.Add(this.searchComboBox);
            this.charInfoTab.Controls.Add(this.searchLabel);
            this.charInfoTab.Controls.Add(this.cidLabel);
            this.charInfoTab.Controls.Add(this.cidBox);
            this.charInfoTab.Controls.Add(this.apBox);
            this.charInfoTab.Controls.Add(this.apLabel);
            this.charInfoTab.Controls.Add(this.levelLabel);
            this.charInfoTab.Controls.Add(this.levelBox);
            this.charInfoTab.HorizontalScrollbarBarColor = true;
            this.charInfoTab.HorizontalScrollbarHighlightOnWheel = false;
            this.charInfoTab.HorizontalScrollbarSize = 10;
            this.charInfoTab.Location = new System.Drawing.Point(4, 38);
            this.charInfoTab.Name = "charInfoTab";
            this.charInfoTab.Size = new System.Drawing.Size(1012, 597);
            this.charInfoTab.TabIndex = 0;
            this.charInfoTab.Text = "Character";
            this.charInfoTab.VerticalScrollbarBarColor = true;
            this.charInfoTab.VerticalScrollbarHighlightOnWheel = false;
            this.charInfoTab.VerticalScrollbarSize = 10;
            // 
            // guildBox
            // 
            this.guildBox.Lines = new string[0];
            this.guildBox.Location = new System.Drawing.Point(308, 253);
            this.guildBox.MaxLength = 32767;
            this.guildBox.Name = "guildBox";
            this.guildBox.PasswordChar = '\0';
            this.guildBox.ReadOnly = true;
            this.guildBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.guildBox.SelectedText = "";
            this.guildBox.Size = new System.Drawing.Size(134, 23);
            this.guildBox.TabIndex = 33;
            this.guildBox.UseSelectable = true;
            // 
            // guildLabel
            // 
            this.guildLabel.AutoSize = true;
            this.guildLabel.Location = new System.Drawing.Point(223, 257);
            this.guildLabel.Name = "guildLabel";
            this.guildLabel.Size = new System.Drawing.Size(39, 19);
            this.guildLabel.TabIndex = 32;
            this.guildLabel.Text = "Guild";
            // 
            // craftTypeBox
            // 
            this.craftTypeBox.Lines = new string[0];
            this.craftTypeBox.Location = new System.Drawing.Point(71, 215);
            this.craftTypeBox.MaxLength = 32767;
            this.craftTypeBox.Name = "craftTypeBox";
            this.craftTypeBox.PasswordChar = '\0';
            this.craftTypeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.craftTypeBox.SelectedText = "";
            this.craftTypeBox.Size = new System.Drawing.Size(121, 23);
            this.craftTypeBox.TabIndex = 31;
            this.craftTypeBox.UseSelectable = true;
            // 
            // craftExpBox
            // 
            this.craftExpBox.Lines = new string[0];
            this.craftExpBox.Location = new System.Drawing.Point(71, 253);
            this.craftExpBox.MaxLength = 32767;
            this.craftExpBox.Name = "craftExpBox";
            this.craftExpBox.PasswordChar = '\0';
            this.craftExpBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.craftExpBox.SelectedText = "";
            this.craftExpBox.Size = new System.Drawing.Size(121, 23);
            this.craftExpBox.TabIndex = 30;
            this.craftExpBox.UseSelectable = true;
            // 
            // craftComboBox
            // 
            this.craftComboBox.FormattingEnabled = true;
            this.craftComboBox.ItemHeight = 23;
            this.craftComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.craftComboBox.Location = new System.Drawing.Point(308, 209);
            this.craftComboBox.Name = "craftComboBox";
            this.craftComboBox.Size = new System.Drawing.Size(134, 29);
            this.craftComboBox.TabIndex = 29;
            this.craftComboBox.UseSelectable = true;
            // 
            // craftExpLabel
            // 
            this.craftExpLabel.AutoSize = true;
            this.craftExpLabel.Location = new System.Drawing.Point(-4, 257);
            this.craftExpLabel.Name = "craftExpLabel";
            this.craftExpLabel.Size = new System.Drawing.Size(63, 19);
            this.craftExpLabel.TabIndex = 28;
            this.craftExpLabel.Text = "Craft Exp";
            // 
            // craftLevelLabel
            // 
            this.craftLevelLabel.AutoSize = true;
            this.craftLevelLabel.Location = new System.Drawing.Point(223, 219);
            this.craftLevelLabel.Name = "craftLevelLabel";
            this.craftLevelLabel.Size = new System.Drawing.Size(71, 19);
            this.craftLevelLabel.TabIndex = 27;
            this.craftLevelLabel.Text = "Craft Level";
            // 
            // pathLevelBox
            // 
            this.pathLevelBox.Lines = new string[0];
            this.pathLevelBox.Location = new System.Drawing.Point(308, 180);
            this.pathLevelBox.MaxLength = 32767;
            this.pathLevelBox.Name = "pathLevelBox";
            this.pathLevelBox.PasswordChar = '\0';
            this.pathLevelBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pathLevelBox.SelectedText = "";
            this.pathLevelBox.Size = new System.Drawing.Size(134, 23);
            this.pathLevelBox.TabIndex = 26;
            this.pathLevelBox.UseSelectable = true;
            // 
            // pathLevelLabel
            // 
            this.pathLevelLabel.AutoSize = true;
            this.pathLevelLabel.Location = new System.Drawing.Point(223, 184);
            this.pathLevelLabel.Name = "pathLevelLabel";
            this.pathLevelLabel.Size = new System.Drawing.Size(67, 19);
            this.pathLevelLabel.TabIndex = 25;
            this.pathLevelLabel.Text = "Path Level";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(466, 247);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(87, 29);
            this.updateButton.TabIndex = 24;
            this.updateButton.Text = "Update";
            this.updateButton.UseSelectable = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateDataButtonClick);
            // 
            // craftLabel
            // 
            this.craftLabel.AutoSize = true;
            this.craftLabel.Location = new System.Drawing.Point(-4, 219);
            this.craftLabel.Name = "craftLabel";
            this.craftLabel.Size = new System.Drawing.Size(69, 19);
            this.craftLabel.TabIndex = 23;
            this.craftLabel.Text = "Craft Type";
            // 
            // pathComboBox
            // 
            this.pathComboBox.FormattingEnabled = true;
            this.pathComboBox.ItemHeight = 23;
            this.pathComboBox.Items.AddRange(new object[] {
            "Paladin",
            "Dark Knight",
            "None"});
            this.pathComboBox.Location = new System.Drawing.Point(71, 174);
            this.pathComboBox.Name = "pathComboBox";
            this.pathComboBox.Size = new System.Drawing.Size(121, 29);
            this.pathComboBox.TabIndex = 21;
            this.pathComboBox.UseSelectable = true;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(-4, 184);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(34, 19);
            this.pathLabel.TabIndex = 20;
            this.pathLabel.Text = "Path";
            // 
            // searchBox
            // 
            this.searchBox.Lines = new string[0];
            this.searchBox.Location = new System.Drawing.Point(223, 12);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(219, 29);
            this.searchBox.TabIndex = 19;
            this.searchBox.UseSelectable = true;
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.ItemHeight = 23;
            this.classComboBox.Location = new System.Drawing.Point(71, 135);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 29);
            this.classComboBox.TabIndex = 18;
            this.classComboBox.UseSelectable = true;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(-4, 145);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(38, 19);
            this.classLabel.TabIndex = 17;
            this.classLabel.Text = "Class";
            // 
            // expBox
            // 
            this.expBox.Lines = new string[0];
            this.expBox.Location = new System.Drawing.Point(308, 104);
            this.expBox.MaxLength = 32767;
            this.expBox.Name = "expBox";
            this.expBox.PasswordChar = '\0';
            this.expBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.expBox.SelectedText = "";
            this.expBox.Size = new System.Drawing.Size(134, 23);
            this.expBox.TabIndex = 16;
            this.expBox.UseSelectable = true;
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Location = new System.Drawing.Point(223, 104);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(30, 19);
            this.expLabel.TabIndex = 15;
            this.expLabel.Text = "Exp";
            // 
            // nameBox
            // 
            this.nameBox.Lines = new string[0];
            this.nameBox.Location = new System.Drawing.Point(71, 75);
            this.nameBox.MaxLength = 32767;
            this.nameBox.Name = "nameBox";
            this.nameBox.PasswordChar = '\0';
            this.nameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameBox.SelectedText = "";
            this.nameBox.Size = new System.Drawing.Size(121, 23);
            this.nameBox.TabIndex = 14;
            this.nameBox.UseSelectable = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(-4, 79);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 19);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(466, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(87, 29);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseSelectable = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.ItemHeight = 23;
            this.searchComboBox.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.searchComboBox.Location = new System.Drawing.Point(71, 12);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(77, 29);
            this.searchComboBox.TabIndex = 11;
            this.searchComboBox.UseSelectable = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(0, 17);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(70, 19);
            this.searchLabel.TabIndex = 10;
            this.searchLabel.Text = "Search By ";
            // 
            // cidLabel
            // 
            this.cidLabel.AutoSize = true;
            this.cidLabel.Location = new System.Drawing.Point(220, 75);
            this.cidLabel.Name = "cidLabel";
            this.cidLabel.Size = new System.Drawing.Size(82, 19);
            this.cidLabel.TabIndex = 9;
            this.cidLabel.Text = "Character ID";
            // 
            // cidBox
            // 
            this.cidBox.Lines = new string[0];
            this.cidBox.Location = new System.Drawing.Point(308, 75);
            this.cidBox.MaxLength = 32767;
            this.cidBox.Name = "cidBox";
            this.cidBox.PasswordChar = '\0';
            this.cidBox.ReadOnly = true;
            this.cidBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cidBox.SelectedText = "";
            this.cidBox.Size = new System.Drawing.Size(134, 23);
            this.cidBox.TabIndex = 8;
            this.cidBox.UseSelectable = true;
            // 
            // apBox
            // 
            this.apBox.Lines = new string[0];
            this.apBox.Location = new System.Drawing.Point(308, 133);
            this.apBox.MaxLength = 32767;
            this.apBox.Name = "apBox";
            this.apBox.PasswordChar = '\0';
            this.apBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apBox.SelectedText = "";
            this.apBox.Size = new System.Drawing.Size(134, 23);
            this.apBox.TabIndex = 7;
            this.apBox.UseSelectable = true;
            // 
            // apLabel
            // 
            this.apLabel.AutoSize = true;
            this.apLabel.Location = new System.Drawing.Point(223, 137);
            this.apLabel.Name = "apLabel";
            this.apLabel.Size = new System.Drawing.Size(26, 19);
            this.apLabel.TabIndex = 6;
            this.apLabel.Text = "AP";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(-4, 108);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(38, 19);
            this.levelLabel.TabIndex = 5;
            this.levelLabel.Text = "Level";
            // 
            // levelBox
            // 
            this.levelBox.Lines = new string[0];
            this.levelBox.Location = new System.Drawing.Point(71, 104);
            this.levelBox.MaxLength = 32767;
            this.levelBox.Name = "levelBox";
            this.levelBox.PasswordChar = '\0';
            this.levelBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.levelBox.SelectedText = "";
            this.levelBox.Size = new System.Drawing.Size(121, 23);
            this.levelBox.TabIndex = 4;
            this.levelBox.UseSelectable = true;
            // 
            // objectListTab
            // 
            this.objectListTab.Controls.Add(this.itemListView);
            this.objectListTab.HorizontalScrollbarBarColor = true;
            this.objectListTab.HorizontalScrollbarHighlightOnWheel = false;
            this.objectListTab.HorizontalScrollbarSize = 10;
            this.objectListTab.Location = new System.Drawing.Point(4, 38);
            this.objectListTab.Name = "objectListTab";
            this.objectListTab.Size = new System.Drawing.Size(1012, 597);
            this.objectListTab.TabIndex = 3;
            this.objectListTab.Text = "Item Manager";
            this.objectListTab.VerticalScrollbarBarColor = true;
            this.objectListTab.VerticalScrollbarHighlightOnWheel = false;
            this.objectListTab.VerticalScrollbarSize = 10;
            // 
            // itemListView
            // 
            this.itemListView.AllColumns.Add(this.nameColumn);
            this.itemListView.AllColumns.Add(this.classColumn);
            this.itemListView.AllColumns.Add(this.countColumn);
            this.itemListView.AllColumns.Add(this.idColumn);
            this.itemListView.AllColumns.Add(this.slotColumn);
            this.itemListView.AllColumns.Add(this.tradeableColumn);
            this.itemListView.AllColumns.Add(this.expirationColumn);
            this.itemListView.AllColumns.Add(this.editColumn);
            this.itemListView.AllColumns.Add(this.deleteColumn);
            this.itemListView.CellEditUseWholeCell = false;
            this.itemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.classColumn,
            this.countColumn,
            this.idColumn,
            this.slotColumn,
            this.tradeableColumn,
            this.expirationColumn,
            this.editColumn,
            this.deleteColumn});
            this.itemListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.itemListView.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemListView.Location = new System.Drawing.Point(1, 0);
            this.itemListView.Name = "itemListView";
            this.itemListView.ShowGroups = false;
            this.itemListView.Size = new System.Drawing.Size(1012, 594);
            this.itemListView.TabIndex = 2;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.UseHotItem = true;
            this.itemListView.View = System.Windows.Forms.View.Details;
            this.itemListView.VirtualMode = true;
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "Name";
            this.nameColumn.IsEditable = false;
            this.nameColumn.Text = "Name";
            this.nameColumn.UseFiltering = false;
            // 
            // classColumn
            // 
            this.classColumn.AspectName = "Class";
            this.classColumn.Text = "ItemClass";
            this.classColumn.UseFiltering = false;
            // 
            // countColumn
            // 
            this.countColumn.AspectName = "Amount";
            this.countColumn.Text = "Amount";
            this.countColumn.UseFiltering = false;
            // 
            // idColumn
            // 
            this.idColumn.AspectName = "Id";
            this.idColumn.Text = "ItemId";
            this.idColumn.UseFiltering = false;
            // 
            // slotColumn
            // 
            this.slotColumn.AspectName = "SlotId";
            this.slotColumn.Text = "Slot";
            this.slotColumn.UseFiltering = false;
            // 
            // tradeableColumn
            // 
            this.tradeableColumn.AspectName = "Tradeable";
            this.tradeableColumn.Text = "Tradeable";
            this.tradeableColumn.UseFiltering = false;
            // 
            // expirationColumn
            // 
            this.expirationColumn.AspectName = "Date";
            this.expirationColumn.Text = "ExpireDate";
            this.expirationColumn.UseFiltering = false;
            // 
            // editColumn
            // 
            this.editColumn.AspectName = "Edit";
            this.editColumn.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.editColumn.IsButton = true;
            this.editColumn.Text = "EDIT";
            // 
            // deleteColumn
            // 
            this.deleteColumn.AspectName = "Delete";
            this.deleteColumn.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.deleteColumn.IsButton = true;
            this.deleteColumn.Text = "Delete";
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = global::Vindictus_Tools.Properties.Resources._1468631696_Streamline_75;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(951, 7);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(15, 16);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.TabStop = false;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 711);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Vindictus Character Management Tool";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.tabControl.ResumeLayout(false);
            this.charInfoTab.ResumeLayout(false);
            this.charInfoTab.PerformLayout();
            this.objectListTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage charInfoTab;
        private MetroFramework.Controls.MetroComboBox searchComboBox;
        private MetroFramework.Controls.MetroLabel searchLabel;
        private MetroFramework.Controls.MetroLabel cidLabel;
        private MetroFramework.Controls.MetroTextBox cidBox;
        private MetroFramework.Controls.MetroTextBox apBox;
        private MetroFramework.Controls.MetroLabel apLabel;
        private MetroFramework.Controls.MetroLabel levelLabel;
        private MetroFramework.Controls.MetroTextBox levelBox;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroTextBox expBox;
        private MetroFramework.Controls.MetroLabel expLabel;
        private MetroFramework.Controls.MetroTextBox nameBox;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroComboBox classComboBox;
        private MetroFramework.Controls.MetroLabel classLabel;
        private MetroFramework.Controls.MetroTextBox searchBox;
        private MetroFramework.Controls.MetroLabel craftLabel;
        private MetroFramework.Controls.MetroComboBox pathComboBox;
        private MetroFramework.Controls.MetroLabel pathLabel;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroTextBox pathLevelBox;
        private MetroFramework.Controls.MetroLabel pathLevelLabel;
        private MetroFramework.Controls.MetroTextBox craftTypeBox;
        private MetroFramework.Controls.MetroTextBox craftExpBox;
        private MetroFramework.Controls.MetroComboBox craftComboBox;
        private MetroFramework.Controls.MetroLabel craftExpLabel;
        private MetroFramework.Controls.MetroLabel craftLevelLabel;
        private MetroFramework.Controls.MetroTextBox guildBox;
        private MetroFramework.Controls.MetroLabel guildLabel;
        private Button settingsButton;
        private MetroFramework.Controls.MetroTabPage objectListTab;
        private BrightIdeasSoftware.FastObjectListView itemListView;
        private BrightIdeasSoftware.OLVColumn nameColumn;
        private BrightIdeasSoftware.OLVColumn classColumn;
        private BrightIdeasSoftware.OLVColumn countColumn;
        private BrightIdeasSoftware.OLVColumn idColumn;
        private BrightIdeasSoftware.OLVColumn slotColumn;
        private BrightIdeasSoftware.OLVColumn tradeableColumn;
        private BrightIdeasSoftware.OLVColumn expirationColumn;
        private BrightIdeasSoftware.OLVColumn editColumn;
        private BrightIdeasSoftware.OLVColumn deleteColumn;
    }
}

