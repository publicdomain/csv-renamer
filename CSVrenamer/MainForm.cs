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
                // Add dropped items
                foreach (var item in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    this.itemsListView.Items.Add(item);
                }

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
            // TODO Add code
        }

        /// <summary>
        /// Handles the items list view mouse move.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnItemsListViewMouseMove(object sender, MouseEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the items list view mouse up.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnItemsListViewMouseUp(object sender, MouseEventArgs e)
        {
            // TODO Add code
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
            // TODO Add code
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
            // TODO Add code
        }

        /// <summary>
        /// Handles the underscore button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnUnderscoreButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the separator combo box text changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSeparatorComboBoxTextChanged(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the spaced check box checked changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSpacedCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the rename button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRenameButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
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

            // Resume drawing
            this.itemsListView.EndUpdate();
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
