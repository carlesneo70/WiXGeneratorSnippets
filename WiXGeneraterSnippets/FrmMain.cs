using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WiXGeneraterSnippets
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    txtDirectory.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string directoryPath = txtDirectory.Text;
            if (!Directory.Exists(directoryPath))
            {
                MessageBox.Show("Invalid directory path!");
                return;
            }

            string[] fileNames = Directory.GetFiles(directoryPath, "*.ppl");

            var snippetXml = new System.Xml.Linq.XDocument(
                new System.Xml.Linq.XElement("Snippets"));

            foreach (string filePath in fileNames)
            {
                string fileName = Path.GetFileName(filePath);
                string sanitizedId = SanitizeIdentifier(fileName);
                string sourcePath = chkCustomSource.Checked ? directoryPath : @"Distribution\Songs\";
                string keyPathValue = checkBoxKeyPath.Checked ? "yes" : "no";

                var fileElement = new System.Xml.Linq.XElement("File");
                fileElement.SetAttributeValue("Id", sanitizedId);
                fileElement.SetAttributeValue("Name", fileName);
                fileElement.SetAttributeValue("Source", Path.Combine(sourcePath, fileName));
                if (checkBoxKeyPath.Checked)
                    fileElement.SetAttributeValue("KeyPath", keyPathValue);

                snippetXml.Root.Add(fileElement);
            }

            string outputXml = snippetXml.ToString();

            // Save the XML to a file
            string outputPath = Path.Combine(directoryPath, "snippets.xml");
            File.WriteAllText(outputPath, outputXml);

            // Show the XML in the text box
            txtOutput.Text = outputXml;

            MessageBox.Show("Snippet generation completed!");
        }

        private string SanitizeIdentifier(string fileName)
        {
            // Remove illegal characters from the file name and replace spaces with underscores
            string sanitized = Regex.Replace(fileName, @"[^\w.]", "").Replace(" ", "_");

            // Ensure the identifier starts with a letter or underscore
            if (!char.IsLetter(sanitized, 0) && sanitized[0] != '_')
            {
                sanitized = "_" + sanitized;
            }

            return sanitized;
        }

        private void btnBrowseBg_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    txtDirectoryBg.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnBrowseVideo_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    txtDirectoryVid.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnGenerateBg_Click(object sender, EventArgs e)
        {
            string directoryPath = txtDirectoryBg.Text;
            if (!Directory.Exists(directoryPath))
            {
                MessageBox.Show("Invalid directory path!");
                return;
            }

            string[] fileNames = Directory.GetFiles(directoryPath, "*.jpg");

            var snippetXml = new System.Xml.Linq.XDocument(
                new System.Xml.Linq.XElement("Snippets"));

            foreach (string filePath in fileNames)
            {
                string fileName = Path.GetFileName(filePath);
                string sanitizedId = SanitizeIdentifier(fileName);
                string sourcePath = chkCustomSourceBg.Checked ? directoryPath : @"Distribution\Backgrounds\Sample\";

                var fileElement = new System.Xml.Linq.XElement("File");
                fileElement.SetAttributeValue("Id", sanitizedId);
                fileElement.SetAttributeValue("Name", fileName);
                fileElement.SetAttributeValue("Source", Path.Combine(sourcePath, fileName));

                snippetXml.Root.Add(fileElement);
            }

            string outputXml = snippetXml.ToString();

            // Save the XML to a file
            string outputPath = Path.Combine(directoryPath, "snippets_background.xml");
            File.WriteAllText(outputPath, outputXml);

            // Show the XML in the text box
            txtOutputBg.Text = outputXml;

            MessageBox.Show("Snippet generation completed!");
        }

        private void btnGenerateVid_Click(object sender, EventArgs e)
        {
            string directoryPath = txtDirectoryVid.Text;
            if (!Directory.Exists(directoryPath))
            {
                MessageBox.Show("Invalid directory path!");
                return;
            }

            string[] fileNames = Directory.GetFiles(directoryPath, "*.avi");

            var snippetXml = new System.Xml.Linq.XDocument(
                new System.Xml.Linq.XElement("Snippets"));

            foreach (string filePath in fileNames)
            {
                string fileName = Path.GetFileName(filePath);
                string sanitizedId = SanitizeIdentifier(fileName);
                string sourcePath = chkCustomSourceVid.Checked ? directoryPath : @"Distribution\Video\";

                var fileElement = new System.Xml.Linq.XElement("File");
                fileElement.SetAttributeValue("Id", sanitizedId);
                fileElement.SetAttributeValue("Name", fileName);
                fileElement.SetAttributeValue("Source", Path.Combine(sourcePath, fileName));

                snippetXml.Root.Add(fileElement);
            }

            string outputXml = snippetXml.ToString();

            // Save the XML to a file
            string outputPath = Path.Combine(directoryPath, "snippets_video.xml");
            File.WriteAllText(outputPath, outputXml);

            // Show the XML in the text box
            txtOutputVid.Text = outputXml;

            MessageBox.Show("Snippet generation completed!");
        }
    }
}
