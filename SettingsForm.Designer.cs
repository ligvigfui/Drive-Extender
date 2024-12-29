namespace Drive_Extender
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage tabPageMappings;
        private TabPage tabDriveSettings;
        private ListView listViewMappings;
        private Button buttonAddMapping;
        private Button buttonRemoveMapping;
        private Button buttonSelectDriveFolder;
        private TextBox textBoxDriveFolder;
        private Button buttonSaveOpenTab;
        private PictureBox pictureBoxPathStatus;
        private Label labelDrivePath;
        private Label labelConfigJsonPath;
        private TextBox textBoxConfigJsonPath;
        private Button buttonSelectConfigJsonPath;
        private Panel panelSeparator;
        private Button buttonCreateDefaultConfig;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            topPanel = new Panel();
            buttonSaveOpenTab = new Button();
            pictureBoxPathStatus = new PictureBox();
            tabControl = new TabControl();
            tabPageMappings = new TabPage();
            listViewMappings = new ListView();
            buttonAddMapping = new Button();
            buttonRemoveMapping = new Button();
            tabDriveSettings = new TabPage();
            panelSeparator = new Panel();
            labelConfigJsonPath = new Label();
            textBoxConfigJsonPath = new TextBox();
            buttonSelectConfigJsonPath = new Button();
            labelDrivePath = new Label();
            textBoxDriveFolder = new TextBox();
            buttonSelectDriveFolder = new Button();
            savePanel = new Panel();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPathStatus).BeginInit();
            tabControl.SuspendLayout();
            tabPageMappings.SuspendLayout();
            tabDriveSettings.SuspendLayout();
            savePanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(buttonSaveOpenTab);
            topPanel.Controls.Add(pictureBoxPathStatus);
            topPanel.Dock = DockStyle.Bottom;
            topPanel.Location = new Point(0, 420);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(800, 40);
            topPanel.TabIndex = 0;
            // 
            // buttonSaveOpenTab
            // 
            buttonSaveOpenTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSaveOpenTab.Location = new Point(610, 7);
            buttonSaveOpenTab.Name = "buttonSaveOpenTab";
            buttonSaveOpenTab.Size = new Size(150, 30);
            buttonSaveOpenTab.TabIndex = 2;
            buttonSaveOpenTab.Text = "Save";
            buttonSaveOpenTab.UseVisualStyleBackColor = true;
            buttonSaveOpenTab.Click += ButtonSaveOpenTab_Click;
            // 
            // pictureBoxPathStatus
            // 
            pictureBoxPathStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxPathStatus.Location = new Point(766, 6);
            pictureBoxPathStatus.Name = "pictureBoxPathStatus";
            pictureBoxPathStatus.Size = new Size(30, 30);
            pictureBoxPathStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPathStatus.TabIndex = 3;
            pictureBoxPathStatus.TabStop = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageMappings);
            tabControl.Controls.Add(tabDriveSettings);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 420);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // tabPageMappings
            // 
            tabPageMappings.Controls.Add(listViewMappings);
            tabPageMappings.Controls.Add(buttonAddMapping);
            tabPageMappings.Controls.Add(buttonRemoveMapping);
            tabPageMappings.Location = new Point(4, 24);
            tabPageMappings.Name = "tabPageMappings";
            tabPageMappings.Padding = new Padding(3);
            tabPageMappings.Size = new Size(792, 392);
            tabPageMappings.TabIndex = 0;
            tabPageMappings.Text = "Mappings";
            tabPageMappings.UseVisualStyleBackColor = true;
            // 
            // listViewMappings
            // 
            listViewMappings.Location = new Point(8, 8);
            listViewMappings.Name = "listViewMappings";
            listViewMappings.Size = new Size(776, 341);
            listViewMappings.TabIndex = 0;
            listViewMappings.UseCompatibleStateImageBehavior = false;
            listViewMappings.View = View.Details;
            // 
            // buttonAddMapping
            // 
            buttonAddMapping.Location = new Point(8, 356);
            buttonAddMapping.Name = "buttonAddMapping";
            buttonAddMapping.Size = new Size(100, 30);
            buttonAddMapping.TabIndex = 1;
            buttonAddMapping.Text = "Add Mapping";
            buttonAddMapping.UseVisualStyleBackColor = true;
            buttonAddMapping.Click += ButtonAddMapping_Click;
            // 
            // buttonRemoveMapping
            // 
            buttonRemoveMapping.Location = new Point(114, 356);
            buttonRemoveMapping.Name = "buttonRemoveMapping";
            buttonRemoveMapping.Size = new Size(120, 30);
            buttonRemoveMapping.TabIndex = 2;
            buttonRemoveMapping.Text = "Remove Mapping";
            buttonRemoveMapping.UseVisualStyleBackColor = true;
            buttonRemoveMapping.Click += ButtonRemoveMapping_Click;
            // 
            // tabDriveSettings
            // 
            tabDriveSettings.Controls.Add(panelSeparator);
            tabDriveSettings.Controls.Add(labelConfigJsonPath);
            tabDriveSettings.Controls.Add(textBoxConfigJsonPath);
            tabDriveSettings.Controls.Add(buttonSelectConfigJsonPath);
            tabDriveSettings.Controls.Add(labelDrivePath);
            tabDriveSettings.Controls.Add(textBoxDriveFolder);
            tabDriveSettings.Controls.Add(buttonSelectDriveFolder);
            tabDriveSettings.Controls.Add(buttonCreateDefaultConfig);
            tabDriveSettings.Location = new Point(4, 24);
            tabDriveSettings.Name = "tabDriveSettings";
            tabDriveSettings.Padding = new Padding(3);
            tabDriveSettings.Size = new Size(792, 392);
            tabDriveSettings.TabIndex = 1;
            tabDriveSettings.Text = "Configuration";
            tabDriveSettings.UseVisualStyleBackColor = true;
            // 
            // panelSeparator
            // 
            panelSeparator.BorderStyle = BorderStyle.FixedSingle;
            panelSeparator.Location = new Point(8, 55);
            panelSeparator.Name = "panelSeparator";
            panelSeparator.Size = new Size(762, 1);
            panelSeparator.TabIndex = 6;
            // 
            // labelConfigJsonPath
            // 
            labelConfigJsonPath.AutoSize = true;
            labelConfigJsonPath.Location = new Point(8, 8);
            labelConfigJsonPath.Name = "labelConfigJsonPath";
            labelConfigJsonPath.Size = new Size(142, 15);
            labelConfigJsonPath.TabIndex = 3;
            labelConfigJsonPath.Text = "Configuration JSON Path:";
            // 
            // textBoxConfigJsonPath
            // 
            textBoxConfigJsonPath.Location = new Point(8, 26);
            textBoxConfigJsonPath.Name = "textBoxConfigJsonPath";
            textBoxConfigJsonPath.Size = new Size(464, 23);
            textBoxConfigJsonPath.TabIndex = 4;
            // 
            // buttonSelectConfigJsonPath
            // 
            buttonSelectConfigJsonPath.Location = new Point(478, 21);
            buttonSelectConfigJsonPath.Name = "buttonSelectConfigJsonPath";
            buttonSelectConfigJsonPath.Size = new Size(150, 30);
            buttonSelectConfigJsonPath.TabIndex = 5;
            buttonSelectConfigJsonPath.Text = "Select JSON Path";
            buttonSelectConfigJsonPath.UseVisualStyleBackColor = true;
            buttonSelectConfigJsonPath.Click += ButtonSelectConfigJsonPath_Click;
            // 
            // labelDrivePath
            // 
            labelDrivePath.AutoSize = true;
            labelDrivePath.Location = new Point(8, 59);
            labelDrivePath.Name = "labelDrivePath";
            labelDrivePath.Size = new Size(64, 15);
            labelDrivePath.TabIndex = 2;
            labelDrivePath.Text = "Drive Path:";
            // 
            // textBoxDriveFolder
            // 
            textBoxDriveFolder.Location = new Point(8, 77);
            textBoxDriveFolder.Name = "textBoxDriveFolder";
            textBoxDriveFolder.Size = new Size(464, 23);
            textBoxDriveFolder.TabIndex = 0;
            // 
            // buttonSelectDriveFolder
            // 
            buttonSelectDriveFolder.Location = new Point(478, 72);
            buttonSelectDriveFolder.Name = "buttonSelectDriveFolder";
            buttonSelectDriveFolder.Size = new Size(150, 30);
            buttonSelectDriveFolder.TabIndex = 1;
            buttonSelectDriveFolder.Text = "Select Drive Folder";
            buttonSelectDriveFolder.UseVisualStyleBackColor = true;
            buttonSelectDriveFolder.Click += ButtonSelectDriveFolder_Click;
            // 
            // savePanel
            // 
            savePanel.Controls.Add(tabControl);
            savePanel.Dock = DockStyle.Fill;
            savePanel.Location = new Point(0, 0);
            savePanel.Name = "savePanel";
            savePanel.Size = new Size(800, 420);
            savePanel.TabIndex = 4;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(savePanel);
            Controls.Add(topPanel);
            Name = "SettingsForm";
            Text = "Settings";
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPathStatus).EndInit();
            tabControl.ResumeLayout(false);
            tabPageMappings.ResumeLayout(false);
            tabDriveSettings.ResumeLayout(false);
            tabDriveSettings.PerformLayout();
            savePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel topPanel;
        private Panel savePanel;
    }
}
