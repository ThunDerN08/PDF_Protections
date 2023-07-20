using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Security;
using System.Xml;
using System.Threading;

namespace WebBrows6
{
    public partial class Form1 : Form
    {
        private Version myVersion;
        private const string AppTitleVersion = "PDF file Password Protection";
        private bool isEncrypt = false;

        public Form1()
        {
            InitializeComponent();
            btnOpen.Enabled = false;
            StartForm();
        }
        public static Version GetPublishedVersion()
        {
            XmlDocument xmlDoc = new XmlDocument();
            Assembly asmCurrent = System.Reflection.Assembly.GetExecutingAssembly();
            string executePath = new Uri(asmCurrent.GetName().CodeBase).LocalPath;

            xmlDoc.Load(executePath + ".manifest");
            string retval = string.Empty;
            if (xmlDoc.HasChildNodes)
            {
                retval = xmlDoc.ChildNodes[1].ChildNodes[0].Attributes.GetNamedItem("version").Value.ToString();
            }
            return new Version(retval);
        }
        private void StartForm()
        {

            myVersion = GetPublishedVersion();
            this.Text = AppTitleVersion + "  v." +myVersion.Major.ToString() + "." + myVersion.Minor.ToString() + "." + myVersion.Build.ToString() + "." + myVersion.Revision.ToString();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {

                lblSelectPDFFile.Visible = true;
                //txtPath.Text = Path.GetDirectoryName(op.FileName) + "\\" + Path.GetFileName(op.FileName);
                lblSelectPDFFile.Text = Path.GetDirectoryName(op.FileName) + "\\" + Path.GetFileName(op.FileName);
                string destinationFilePath = op.FileName;
                axAcroPDF1.src = destinationFilePath + "#navpanes=0";
                //axAcroPDF1.setShowScrollbars(true);
                axAcroPDF1.setShowToolbar(false);
            }
            //reset all data
            btnSave.Text = "Encrypt";
            txtPass.Text = "";
            lblDestonationPath.Text = "";
            txtPass.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Encrypt" && string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                MessageBox.Show("Please input Password. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Select();
                return;
            }

            if (!isEncrypt)
            {
                btnSave.Text = "waiting...";
                btnSave.Enabled = false;
                Thread.Sleep(2000);

                // string sourceFilePath = txtPath.Text;
                string sourceFilePath = lblSelectPDFFile.Text;
                string destinationFolderPath = Path.GetDirectoryName(sourceFilePath);

                if (string.IsNullOrEmpty(sourceFilePath) || string.IsNullOrEmpty(destinationFolderPath))
                {
                    MessageBox.Show("Please select file path and destination folder path.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (File.Exists(sourceFilePath))
                    {
                        try
                        {
                            using (PdfDocument doc = PdfReader.Open(sourceFilePath, PdfDocumentOpenMode.Modify))
                            {

                                PdfSecuritySettings secSet = doc.SecuritySettings;

                                secSet.UserPassword = txtPass.Text;
                                secSet.OwnerPassword = "passOwner";
                                secSet.PermitAccessibilityExtractContent = false;
                                secSet.PermitAnnotations = false;
                                secSet.PermitAssembleDocument = false;
                                secSet.PermitExtractContent = false;
                                secSet.PermitFormsFill = true;
                                secSet.PermitFullQualityPrint = false;
                                secSet.PermitModifyDocument = true;
                                secSet.PermitPrint = false;

                                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(sourceFilePath);
                                string newFileName = fileNameWithoutExtension + "_protected" + Path.GetExtension(sourceFilePath);
                                string destinationFilePath = Path.Combine(destinationFolderPath, newFileName);
                                doc.Save(destinationFilePath);
                                lblDestonationPath.Text = "Your file is saved in : " + destinationFilePath.ToString();
                            }

                            MessageBox.Show("File has been protected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnOpen.Enabled = true;
                            lblDestonationPath.Visible = true;
                            btnSave.Text = "Open Folder >>";
                            isEncrypt = true;
                            btnSave.Enabled = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while save the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected source file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               // txtPass.Text = "";
            }
            else if (isEncrypt && btnSave.Text == "Open Folder >>")
            {
                string sourceFilePath = lblSelectPDFFile.Text; ;
                string destinationFolderPath = Path.GetDirectoryName(sourceFilePath);

                if (System.IO.Directory.Exists(destinationFolderPath))
                {
                    Process.Start(destinationFolderPath);
                }
                else
                {
                    MessageBox.Show("Folder does not exist.", "Infomation.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else {
                isEncrypt = false;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //string sourceFilePath = txtPath.Text;
            //string destinationFolderPath = Path.GetDirectoryName(sourceFilePath);

            //if (!System.IO.Directory.Exists(destinationFolderPath))
            //{
            //    Console.WriteLine("Folder does not exist.");
            //    return;
            //}
            //else
            //{
            //    Process.Start(destinationFolderPath);
            //}
        }

        static void CopyTextToClipboard(string text)
        {
            // Set the text to the clipboard
            Clipboard.SetText(text);
        }

        private void btnCopyText_Click(object sender, EventArgs e)
        {
            CopyTextToClipboard(txtPass.Text);
        }
    }
}
