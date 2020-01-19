using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bhojarajsahu88.Assembly_Info.Forms
{
    public partial class Assembly_Info : Form
    {
        string filePath = string.Empty;
        public Assembly_Info()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogBrowse.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFileDialogBrowse.FileName;
                labelFileName.Text = "File Name: " + openFileDialogBrowse.SafeFileName;
                labelFilePath.Text = "File Directory: " + openFileDialogBrowse.FileName.Replace(openFileDialogBrowse.SafeFileName, "");
                getAssemblyInfo();
            }
        }
        public void getAssemblyInfo()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                dataGridViewInfo.Rows.Clear();
                dataGridViewInfo.Columns.Clear();
                dataGridViewInfo.Columns.Add("Info", "Info");
                dataGridViewInfo.Columns.Add("Value", "Value");

                int count = 1;
                var DLL = Assembly.LoadFile(filePath);
                foreach (Type type in DLL.GetExportedTypes())
                {
                    byte[] pk;
                    string publicKey = string.Empty;
                    pk = DLL.GetName().GetPublicKey();
                    for (int i = 0; i < pk.GetLength(0); i++)
                        publicKey = publicKey + pk[i];

                    dataGridViewInfo.Rows.Add("Assembly Number", count);
                    dataGridViewInfo.Rows.Add("Full Name", type.FullName);
                    dataGridViewInfo.Rows.Add("Qualified Name", type.AssemblyQualifiedName);
                    dataGridViewInfo.Rows.Add("Attributes", type.Attributes);
                    dataGridViewInfo.Rows.Add("Namespace", type.Namespace);
                    dataGridViewInfo.Rows.Add("GUID", type.GUID);
                    dataGridViewInfo.Rows.Add("Public Key", publicKey);
                    dataGridViewInfo.Rows.Add("Runtime Version", type.Assembly.ImageRuntimeVersion);
                    dataGridViewInfo.Rows.Add("Location", type.Assembly.Location);
                    dataGridViewInfo.Rows.Add("Menifest Module", type.Assembly.ManifestModule);
                    dataGridViewInfo.Rows.Add("Security RuleSet", type.Assembly.SecurityRuleSet);
                    dataGridViewInfo.Rows.Add("Permission Set", type.Assembly.PermissionSet);
                    count++;
                }

            }
            catch { }
            this.Cursor = Cursors.Default;
        }

        private void Assembly_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
