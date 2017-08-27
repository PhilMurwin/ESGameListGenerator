using ESGameListGenerator.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ESGameListGenerator
{
    public partial class frmGameListGen : Form
    {
        List<string> extensions = new List<string>();

        public frmGameListGen()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click( object sender, EventArgs e )
        {
            if ( folderBrowserDialog1.ShowDialog() == DialogResult.OK )
            {
                txtRomFolder.Text = folderBrowserDialog1.SelectedPath;
                UpdateExtensionList();
            }
        }

        private void UpdateExtensionList()
        {
            extensions.Clear();
            extensions = DirectoryScanner.GetFileExtensionsInDirectory( txtRomFolder.Text );
            cboRomExt.DataSource = new BindingSource( extensions, null );
        }

        private void btnGenPreview_Click( object sender, EventArgs e )
        {
            GeneratePreviewXML();
        }

        private void GeneratePreviewXML()
        {
            var files = DirectoryScanner.FindFilesMatching( txtRomFolder.Text, cboRomExt.SelectedText );

            var games = files.Select( f => new Game {
                Name = Path.GetFileNameWithoutExtension( f.Name ),
                Path = string.Format( "./{0}", f.Name )
            } ).ToList();

            var shortList = games.Take( 1 ).ToList();
            SetGameImages( shortList );

            var gameList = new GameList { Game = shortList };

            var xml = ProcessXML.SaveModelToXML( gameList );

            txtXmlPreview.Text = xml;
        }

        private void SetGameImages(List<Game> gamelist)
        {
            if ( chkImagefield.Checked )
            {
                var imgDir = txtRomFolder.Text;
                imgDir = chkImgUseSubfolder.Checked ? Path.Combine( imgDir, txtImgSubfolder.Text ) : imgDir;

                var imageFiles = DirectoryScanner.FindImageFiles( imgDir );

                foreach ( var imgFile in imageFiles )
                {
                    var game = gamelist.FirstOrDefault( g => g.Name == Path.GetFileNameWithoutExtension( imgFile.Name ) );

                    if ( game != null )
                    {
                        game.Image = string.Format( "./{0}", imgFile.Name);
                    }
                }
            }
        }

        private void btnGenerate_Click( object sender, EventArgs e )
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                var files = DirectoryScanner.FindFilesMatching( txtRomFolder.Text, cboRomExt.SelectedText );

                var games = files.Select( f => new Game
                {
                    Name = Path.GetFileNameWithoutExtension( f.Name ),
                    Path = string.Format( "./{0}", f.Name )
                } ).ToList();

                SetGameImages( games );

                var gameList = new GameList { Game = games };

                var xml = ProcessXML.SaveModelToXML( gameList );

                System.IO.File.WriteAllText( Path.Combine( txtRomFolder.Text, "gamelist.xml" ), xml );
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void chkImgUseSubfolder_CheckedChanged( object sender, EventArgs e )
        {
            lblImgSubfolder.Enabled = txtImgSubfolder.Enabled = chkImgUseSubfolder.Checked;
        }

        private void chkImagefield_CheckedChanged( object sender, EventArgs e )
        {
            chkImgUseSubfolder.Enabled = chkImagefield.Checked;

            if (!chkImagefield.Checked)
            {
                lblImgSubfolder.Enabled = txtImgSubfolder.Enabled = chkImagefield.Checked;
            }
            else
            {
                lblImgSubfolder.Enabled = txtImgSubfolder.Enabled = chkImgUseSubfolder.Checked;
            }
        }
    }
}
