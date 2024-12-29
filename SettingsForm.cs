namespace Drive_Extender;

public partial class SettingsForm : Form
{
    public SettingsForm()
    {
        InitializeComponent();
        FillUIFromConfiguration();
    }

    public void FillUIFromConfiguration()
    {
        textBoxDriveFolder.Text = Configuration.configuration.DriveFolderPath;
        textBoxConfigJsonPath.Text = Configuration.ConfigPath;
        listViewMappings.Items.Clear();
        foreach (var mapping in Configuration.configuration.Mappings)
        {
            var item = new ListViewItem([mapping.DevicePath, mapping.InDrivePath]);
            listViewMappings.Items.Add(item);
        }
    }

    void ButtonAddMapping_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxDriveFolder.Text))
        {
            ShowErrorBox("Please set the drive path before adding a new mapping.");
            return;
        }

        using var sourceDialog = new FolderBrowserDialog();
        using var destinationDialog = new FolderBrowserDialog
        {
            SelectedPath = Configuration.configuration.DriveFolderPath
        };
        if (sourceDialog.ShowDialog() == DialogResult.OK && destinationDialog.ShowDialog() == DialogResult.OK)
        {
            var relativeDestinationPath = Path.GetRelativePath(Configuration.configuration.DriveFolderPath, destinationDialog.SelectedPath);
            if (Configuration.configuration.Mappings.Any(m => m.DevicePath == sourceDialog.SelectedPath))
            {
                ShowErrorBox("Mapping already exists for this source path.");
                return;
            }
            if (Configuration.configuration.Mappings.Any(m => m.InDrivePath == relativeDestinationPath))
            {
                ShowErrorBox("Mapping already exists for this destination path.");
                return;
            }
            var item = new ListViewItem([sourceDialog.SelectedPath, relativeDestinationPath]);
            listViewMappings.Items.Add(item);

            // Add to configuration
            Configuration.configuration.Mappings.Add(new PathMapping
            {
                DevicePath = sourceDialog.SelectedPath,
                InDrivePath = relativeDestinationPath
            });
        }
    }

    void ButtonRemoveMapping_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem selectedItem in listViewMappings.SelectedItems)
        {
            listViewMappings.Items.Remove(selectedItem);

            // Remove from configuration
            var mappingToRemove = Configuration.configuration.Mappings.FirstOrDefault(m =>
                m.DevicePath == selectedItem.SubItems[0].Text);
            if (mappingToRemove != null)
            {
                Configuration.configuration.Mappings.Remove(mappingToRemove);
            }
        }
    }

    void ButtonSelectDriveFolder_Click(object sender, EventArgs e)
    {
        using var folderDialog = new FolderBrowserDialog();
        if (folderDialog.ShowDialog() == DialogResult.OK)
        {
            textBoxDriveFolder.Text = folderDialog.SelectedPath;
            Configuration.configuration.DriveFolderPath = folderDialog.SelectedPath;
        }
    }

    void ButtonSelectConfigJsonPath_Click(object sender, EventArgs e)
    {
        using var folderDialog = new OpenFileDialog();
        folderDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
        if (folderDialog.ShowDialog() == DialogResult.OK)
        {
            textBoxConfigJsonPath.Text = folderDialog.FileName;
            Configuration.configuration.ConfigJsonPath = folderDialog.FileName;
        }
    }

    void ButtonSaveOpenTab_Click(object sender, EventArgs e)
    {
        List<string> errors = tabControl.SelectedIndex switch
        {
            0 => [],
            1 => ValidateConfigurations(),
            _ => [],
        };
        if (errors.Count > 0)
        {
            ShowErrorBox(string.Join("\n", errors));
            return;
        }

        try
        {
            Configuration.Save();
            ShowSaveSuccess();
        }
        catch (Exception ex)
        {
            ShowErrorBox($"Error saving configuration file:\n{ex.Message}");
        }

    }

    List<string> ValidateConfigurations()
    {
        List<string> errors = [];
        if (!File.Exists(textBoxConfigJsonPath.Text))
            errors.Add(InvalidPath("JSON Configuration file"));
        if (!Directory.Exists(textBoxDriveFolder.Text))
            errors.Add(InvalidPath("drive folder"));
        return errors;
    }

    string InvalidPath(string pathName) =>
        $"Invalid {pathName} path. Please enter a valid path.";
    
    void ShowErrorBox(string message)
    {
        ShowSaveFail();
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    void ShowSaveFail() =>
        pictureBoxPathStatus.Image = Image.FromFile("Assets/cross.png");

    void ShowSaveSuccess() =>
        pictureBoxPathStatus.Image = Image.FromFile("Assets/tick.jpg");

    void TabControl_SelectedIndexChanged(object sender, EventArgs e) =>
        pictureBoxPathStatus.Image = null;
}
