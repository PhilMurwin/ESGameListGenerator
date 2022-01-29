using ESGameListGenerator2.Models;
using ESGameListGenerator2.Utility;

namespace ESGameListGenerator2.Forms
{
    public partial class MainView : Form
    {
        private MainViewModel Model { get; set; }

        public MainView()
        {
            Model = new MainViewModel();
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRomFolder.Text = folderBrowserDialog1.SelectedPath;
                Model.UpdateExtensionList(txtRomFolder.Text);
                cboRomExt.DataSource = new BindingSource(Model.Extensions, null);
            }
        }

        private void chkImageField_CheckedChanged(object sender, EventArgs e)
        {
            chkImgUseSubfolder.Enabled = chkImageField.Checked;

            if (!chkImageField.Checked)
            {
                lblImgSubfolder.Enabled = txtImgSubfolder.Enabled = chkImageField.Checked;
            }
            else
            {
                lblImgSubfolder.Enabled = txtImgSubfolder.Enabled = chkImgUseSubfolder.Checked;
            }
        }

        private void chkImgUseSubfolder_CheckedChanged(object sender, EventArgs e)
        {
            lblImgSubfolder.Enabled = txtImgSubfolder.Enabled = chkImgUseSubfolder.Checked;
        }

        private void btnGenPreview_Click(object sender, EventArgs e)
        {
            var romFolder = txtRomFolder.Text;
            if (Directory.Exists(romFolder) == false)
            {
                MessageBox.Show("The Rom Folder does not exist, please check the rom folder and try again!");
                return;
            }

            var gameList = GameListHelper.GetEmuStationGameList(romFolder, cboRomExt.SelectedText, true);
            if (chkImageField.Checked)
            {
                gameList.SetGameImages(txtRomFolder.Text, chkImgUseSubfolder.Checked, txtImgSubfolder.Text);
            }
            var xmlString = gameList.GetXMLString();
            txtXmlPreview.Text = xmlString;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                var romFolder = txtRomFolder.Text;
                var romExtension = cboRomExt.SelectedText;

                var gameList = GameListHelper.GetEmuStationGameList(romFolder, romExtension);

                if (chkImageField.Checked)
                {
                    gameList.SetGameImages(txtRomFolder.Text, chkImgUseSubfolder.Checked, txtImgSubfolder.Text);
                }

                var xmlString = gameList.GetXMLString();

                System.IO.File.WriteAllText(Path.Combine(romFolder, "gamelist.xml"), xmlString);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
