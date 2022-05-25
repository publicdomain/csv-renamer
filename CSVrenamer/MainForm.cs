// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace CSVrenamer
{
    // Durectives
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using PublicDomain;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        // The list view item
        private ListViewItem listViewItem = null;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CSVrenamer.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the items list view drag drop.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnItemsListViewDragDrop(object sender, DragEventArgs e)
        {
            // Files or directories
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Prevent drawing
                this.itemsListView.BeginUpdate();

                // Add dropped items
                foreach (string item in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    this.itemsListView.Items.Add(item);
                }

                // Adjust column width
                this.itemsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                // Resume drawing
                this.itemsListView.EndUpdate();

                // Update count
                this.itemsCountToolStripStatusLabel.Text = this.itemsListView.Items.Count.ToString();
            }
        }

        /// <summary>
        /// Handles the items list view drag enter.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnItemsListViewDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        /// <summary>
        /// Handles the items list view mouse down.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnItemsListViewMouseDown(object sender, MouseEventArgs e)
        {
            listViewItem = this.itemsListView.GetItemAt(e.X, e.Y);
        }

        /// <summary>
        /// Handles the items list view mouse move.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnItemsListViewMouseMove(object sender, MouseEventArgs e)
        {
            if (listViewItem != null)
            {
                // Change cursor
                Cursor = Cursors.Hand;

                try
                {
                    ListViewItem destinationListViewItem = this.itemsListView.GetItemAt(0, Math.Min(e.Y, this.itemsListView.Items[this.itemsListView.Items.Count - 1].GetBounds(ItemBoundsPortion.Entire).Bottom - 1));

                    if (destinationListViewItem != null)
                    {
                        Rectangle rectangle = destinationListViewItem.GetBounds(ItemBoundsPortion.Entire);

                        bool insertBefore = (e.Y < rectangle.Top + (rectangle.Height / 2));

                        // Check if must scroll up
                        if (destinationListViewItem.Index == this.itemsListView.TopItem.Index && insertBefore && this.itemsListView.TopItem.Index > 0)
                        {
                            this.itemsListView.EnsureVisible(this.itemsListView.TopItem.Index - 1);
                        }
                        else // Check if must scroll down
                        {
                            ListViewItem bottomItem = this.itemsListView.TopItem;

                            for (int i = this.itemsListView.TopItem.Index + 1; i < this.itemsListView.Items.Count; i++)
                            {
                                if (this.itemsListView.ClientRectangle.Contains(this.itemsListView.Items[i].Bounds))
                                {
                                    bottomItem = this.itemsListView.Items[i];
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (destinationListViewItem.Index == bottomItem.Index && !insertBefore && bottomItem.Index < this.itemsListView.Items.Count - 1)
                            {
                                this.itemsListView.EnsureVisible(bottomItem.Index + 1);
                            }
                        }
                    }
                }
                catch {; }
            }
        }

        /// <summary>
        /// Handles the items list view mouse up.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnItemsListViewMouseUp(object sender, MouseEventArgs e)
        {
            if (listViewItem != null)
            {
                try
                {
                    ListViewItem destinationListViewItem = this.itemsListView.GetItemAt(0, Math.Min(e.Y, this.itemsListView.Items[this.itemsListView.Items.Count - 1].GetBounds(ItemBoundsPortion.Entire).Bottom - 1));

                    if (destinationListViewItem != null)
                    {
                        Rectangle rectangle = destinationListViewItem.GetBounds(ItemBoundsPortion.Entire);

                        bool insertBefore = (e.Y < rectangle.Top + (rectangle.Height / 2));

                        if (listViewItem != destinationListViewItem)
                        {
                            this.itemsListView.Items.Remove(listViewItem);

                            this.itemsListView.Items.Insert(destinationListViewItem.Index + (insertBefore ? 0 : 1), listViewItem);
                        }

                        this.itemsListView.Invalidate();
                    }
                }
                finally
                {
                    listViewItem = null;

                    Cursor = Cursors.Default;
                }
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item1 click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItem1Click(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the reset tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnResetToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the hyphen button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnHyphenButtonClick(object sender, EventArgs e)
        {
            // Set hyphen
            this.separatorComboBox.Text = "-";
        }

        /// <summary>
        /// Handles the underscore button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnUnderscoreButtonClick(object sender, EventArgs e)
        {
            // Set underscore
            this.separatorComboBox.Text = "_";
        }

        /// <summary>
        /// Handles the separator combo box text changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSeparatorComboBoxTextChanged(object sender, EventArgs e)
        {
            // Update status
            this.separatorToolStripStatusLabel.Text = this.separatorComboBox.Text;
        }

        /// <summary>
        /// Handles the spaced check box checked changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSpacedCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            // Check if must add spaces
            if (this.spacedCheckBox.Checked)
            {
                // Add spaces
                this.separatorComboBox.Text = $" {this.separatorComboBox.Text} ";
            }
            else
            {
                // Remove spaces
                this.separatorComboBox.Text = this.separatorComboBox.Text.Trim(' ');
            }
        }

        /// <summary>
        /// Handles the rename button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRenameButtonClick(object sender, EventArgs e)
        {
            /* Checks */

            // Constant
            if (this.constantComboBox.Text.Length == 0)
            {
                // Advise user
                MessageBox.Show("Please enter constant value", "Constant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Focus
                this.constantComboBox.Focus();

                // Halt flow
                return;
            }

            // Separator
            if (this.separatorComboBox.Text.Length == 0)
            {
                // Advise user
                MessageBox.Show("Please enter separator value", "Separator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Focus
                this.separatorComboBox.Focus();

                // Halt flow
                return;
            }

            // Variable
            if (this.variableNumericUpDown.Value < this.variableNumericUpDown.Minimum || this.variableNumericUpDown.Value > this.variableNumericUpDown.Maximum)
            {
                // Advise user
                MessageBox.Show("Please enter variable value", "Variable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Focus
                this.separatorComboBox.Focus();

                // Halt flow
                return;
            }

            // Files and directories
            if (this.itemsListView.Items.Count == 0)
            {
                // Advise user
                MessageBox.Show("Please add items to process", "Items", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Halt flow
                return;
            }

            /* Rename */

            // Prevent drawing
            this.itemsListView.BeginUpdate();

            // Success indexes
            List<int> successIndexesList = new List<int>();

            // Error count
            int errorCount = 0;

            // Error log
            StringBuilder errorLog = new StringBuilder();

            // Iterate listview 
            for (int i = 0; i < this.itemsListView.Items.Count; i++)
            {
                // Set item path
                string itemPath = this.itemsListView.Items[i].Text;

                // Set new name
                string newName = $"{this.constantComboBox.Text}{this.separatorComboBox.Text}{this.variableNumericUpDown.Value}";

                try
                {
                    // Rename
                    if (File.GetAttributes(itemPath).HasFlag(FileAttributes.Directory))
                    {
                        // Directory
                        Directory.Move(itemPath, Path.Combine(Directory.GetParent(itemPath).FullName, newName));
                    }
                    else
                    {
                        // File
                        File.Move(itemPath, Path.Combine(Directory.GetParent(itemPath).FullName, $"{newName}{Path.GetExtension(itemPath)}"));
                    }

                    // Add index for removal from list
                    successIndexesList.Add(i);
                }
                catch (Exception ex)
                {
                    // Raise error count
                    errorCount++;

                    // Add to error log
                    errorLog.AppendLine($"{Environment.NewLine}{Environment.NewLine}{itemPath}{Environment.NewLine}{ex.Message}{Environment.NewLine}{Path.Combine(Directory.GetParent(itemPath).FullName, newName, Path.GetExtension(itemPath))}");
                }

                // Process "variable" field
                if (this.subtractCheckBox.Checked)
                {
                    // Decrement
                    if (this.variableNumericUpDown.Value > this.variableNumericUpDown.Minimum)
                    {
                        this.variableNumericUpDown.Value = this.variableNumericUpDown.Value - 1;
                    }
                }
                else
                {
                    // Raise
                    if (this.variableNumericUpDown.Value < this.variableNumericUpDown.Maximum)
                    {
                        this.variableNumericUpDown.Value = this.variableNumericUpDown.Value + 1;
                    }
                }
            }

            // Iterate listview backwards
            for (int ii = this.itemsListView.Items.Count - 1; ii >= 0; ii--)
            {
                // Check if it's on success indexes list
                if (successIndexesList.Contains(ii))
                {
                    // Remove frmo list 
                    this.itemsListView.Items.RemoveAt(ii);
                }
            }

            // Resume drawing
            this.itemsListView.EndUpdate();

            // Update count
            this.itemsCountToolStripStatusLabel.Text = this.itemsListView.Items.Count.ToString();

            // Check if most write error file to disk
            if (errorLog.Length > 0)
            {
                // Write 
                File.AppendAllText("CSVrenamer-ErrorLog.txt", errorLog.ToString());
            }

            // Advise user
            MessageBox.Show($"Rename finished.{Environment.NewLine}{(errorCount == 0 ? "No" : errorCount.ToString())} errors.", "Renamed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Loads the settings file.
        /// </summary>
        /// <returns>The settings file.</returns>
        /// <param name="settingsFilePath">Settings file path.</param>
        private SettingsData LoadSettingsFile(string settingsFilePath)
        {
            // Use file stream
            using (FileStream fileStream = File.OpenRead(settingsFilePath))
            {
                // Set xml serialzer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                // Return populated settings data
                return xmlSerializer.Deserialize(fileStream) as SettingsData;
            }
        }

        /// <summary>
        /// Saves the settings file.
        /// </summary>
        /// <param name="settingsFilePath">Settings file path.</param>
        /// <param name="settingsDataParam">Settings data parameter.</param>
        private void SaveSettingsFile(string settingsFilePath, SettingsData settingsDataParam)
        {
            try
            {
                // Use stream writer
                using (StreamWriter streamWriter = new StreamWriter(settingsFilePath, false))
                {
                    // Set xml serialzer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                    // Serialize settings data
                    xmlSerializer.Serialize(streamWriter, settingsDataParam);
                }
            }
            catch (Exception exception)
            {
                // Advise user
                MessageBox.Show($"Error saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ons the remove tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnRemoveToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Prevent drawing
            this.itemsListView.BeginUpdate();

            // Remove selected items
            foreach (ListViewItem item in this.itemsListView.SelectedItems)
            {
                this.itemsListView.Items.Remove(item);
            }

            // Adjust column width^M
            this.itemsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            // Resume drawing
            this.itemsListView.EndUpdate();

            // Update count
            this.itemsCountToolStripStatusLabel.Text = this.itemsListView.Items.Count.ToString();
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }
    }
}
