namespace Drive_Extender
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        void ButtonAddMapping_Click(object sender, EventArgs e)
        {
            // Logic to add a new mapping
            using var sourceDialog = new FolderBrowserDialog();
            using var destinationDialog = new FolderBrowserDialog();
            if (sourceDialog.ShowDialog() == DialogResult.OK && destinationDialog.ShowDialog() == DialogResult.OK)
            {
                var item = new ListViewItem([sourceDialog.SelectedPath, destinationDialog.SelectedPath]);
                listViewMappings.Items.Add(item);
            }
        }

        void ButtonRemoveMapping_Click(object sender, EventArgs e)
        {
            // Logic to remove the selected mapping
            if (listViewMappings.SelectedItems.Count > 0)
            {
                listViewMappings.Items.Remove(listViewMappings.SelectedItems[0]);
            }
        }

        void ButtonSelectDriveFolder_Click(object sender, EventArgs e)
        {
            using var folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDriveFolder.Text = folderDialog.SelectedPath;
            }
        }

        // void ButtonSelectConfigJsonPath_Click(object sender, EventArgs e)
        // {
        //     using var folderDialog = new OpenFileDialog();
        //     folderDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
        //     if (folderDialog.ShowDialog() == DialogResult.OK)
        //     {
        //         textBoxConfigJsonPath.Text = folderDialog.FileName;
        //     }
        // }

        void ButtonSaveOpenTab_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    SaveMappings();
                    break;
                case 1:
                    SaveDriveSettings();
                    break;
            }
        }

        void SaveDriveSettings()
        {
            List<string> errors = [];
            // if (!File.Exists(textBoxConfigJsonPath.Text))
            //     errors.Add(InvalidPath("JSON Configuration file"));
            if (!Directory.Exists(textBoxDriveFolder.Text))
                errors.Add(InvalidPath("drive folder"));
            if (errors.Count > 0)
            {
                ShowErrorBox(string.join("\n", errors));
                return;
            }
            SaveSuccess();
        }

        string InvalidPath(string pathName) =>
            $"Invalid {pathName} path. Please enter a valid path.";
        
        void ShowErrorBox(string message)
        {
            SaveFail();
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void SaveMappings()
        {
            throw new NotImplementedException();
        }

        void SaveFail()
        {
            pictureBoxPathStatus.Image = Image.FromFile("Assets/cross.png");
        }

        void SaveSuccess()
        {
            pictureBoxPathStatus.Image = Image.FromFile("Assets/tick.jpg");
        }

        void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPathStatus.Image = null;
        }

        // void ButtonCreateDefaultConfig_Click(object sender, EventArgs e)
        // {
        //     using var folderDialog = new FolderBrowserDialog();
        //     if (folderDialog.ShowDialog() == DialogResult.OK)
        //     {
        //         var defaultConfigPath = Path.Combine(folderDialog.SelectedPath, "defaultConfig.json");
        //         File.WriteAllText(defaultConfigPath, "{ \"default\": \"config\" }");
        //         textBoxConfigJsonPath.Text = defaultConfigPath;
        //         MessageBox.Show("Default configuration created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //     }
        // }
    }
}
