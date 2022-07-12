using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureBox
{
    public partial class Main : Form
    {
        private MainMenu mainMenu1;
        private MenuItem fileMenuItem, openMenuItem;
        private MenuItem folderMenuItem, closeMenuItem;

        private string openFileName, folderName;

        private bool fileOpened = false;

        private List<Image> imageList = new List<Image>();

        private int indexOfImage;

        private ButtonsManager buttonsManager;

        private FileOpener fileOpener = new FileOpener();

        

        public Main()
        {
            InitializeComponent();
            buttonsManager = new ButtonsManager(btPrevious, btNext, pbMainPicture);
            InitializeMainMenu();
        }


        public void InitializeMainMenu()
        {
            this.mainMenu1 = new MainMenu();
            this.fileMenuItem = new MenuItem();
            this.openMenuItem = new MenuItem();
            this.folderMenuItem = new MenuItem();
            this.closeMenuItem = new MenuItem();

            this.mainMenu1.MenuItems.Add(this.fileMenuItem);
            this.fileMenuItem.MenuItems.AddRange(new MenuItem[] { this.openMenuItem, this.closeMenuItem, this.folderMenuItem });

            this.fileMenuItem.Text = "File";

            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new EventHandler(this.openMenuItem_Click);

            this.folderMenuItem.Text = "Select Directory..";
            this.folderMenuItem.Click += new EventHandler(this.folderMenuItem_Click);

            this.closeMenuItem.Text = "Close";
            this.closeMenuItem.Click += new EventHandler(this.closeMenuItem_Click);
            this.closeMenuItem.Enabled = false;

            this.openFileDialog1.DefaultExt = "jpg, png, gif";
            this.openFileDialog1.Filter = "Image Files (*.JPG;*.PNG;*.BMP;*.GIF)|*.JPG;*.PNG;*.BMP;*.GIF";

            this.folderBrowserDialog1.Description = "Select Default Directory";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyPictures;

            this.Controls.Add(pbMainPicture);
            this.Menu = this.mainMenu1;

            buttonsManager.ButtonsStatusSet(fileOpened);
        }


        private void folderMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                if (!fileOpened)
                {
                    openFileDialog1.InitialDirectory = folderName;
                    openFileDialog1.FileName = null;
                    openMenuItem.PerformClick();
                }
            }
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            pbMainPicture.Image = null;
            pbxImageViewre.Image = null;
            fileOpened = false;
            imageList.Clear();
            buttonsManager.ButtonsStatusSet(fileOpened);
            closeMenuItem.Enabled = false;
            System.GC.Collect();
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            if (fileOpened)
            {
                indexOfImage--;
                if (indexOfImage < 0)
                    indexOfImage = imageList.Count - 1;
                   
                    pbMainPicture.Image = imageList[indexOfImage];
                ImageResize();
            }
            Invalidate();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (fileOpened)
            {
                indexOfImage++;
                if (indexOfImage >= imageList.Count)
                    indexOfImage = 0;

                pbMainPicture.Image = imageList[indexOfImage];
                ImageResize();
            }
            Invalidate();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            closeMenuItem.PerformClick();

            if (!fileOpened)
            {
                openFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;
                openFileDialog1.FileName = null;
            }

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                openFileName = openFileDialog1.FileName;
                folderName = openFileDialog1.InitialDirectory;

            }

            else if (result == DialogResult.Cancel)
                return;

            imageList = fileOpener.GetListOFAllImages(openFileName, out fileOpened, out indexOfImage);
            
            if (imageList == null)
                return;

            pbMainPicture.Image = imageList[--indexOfImage];

            if (pbMainPicture.Image == null)
                fileOpened = false;

            Invalidate();

            buttonsManager.ButtonsStatusSet(fileOpened);
            closeMenuItem.Enabled = fileOpened;

            ImageResize();
        }

        private void ImageResize()
        {
            var offset = pbxImageViewre.Width / 3;
            var prevIndex = (indexOfImage - 1) < 0 ? (imageList.Count -1) : indexOfImage-1;
            var nextIndex = (indexOfImage + 1) >= imageList.Count ? 0 : indexOfImage+1;
            Bitmap bitmapImage1 = new Bitmap(imageList[prevIndex], offset, pbxImageViewre.Height);
            Bitmap bitmapImage2 = new Bitmap(imageList[indexOfImage], offset, pbxImageViewre.Height);
            Bitmap bitmapImage3 = new Bitmap(imageList[nextIndex], offset, pbxImageViewre.Height);

            Bitmap pbBitmap = new Bitmap(pbxImageViewre.Width, pbxImageViewre.Height);
            using(Graphics g = Graphics.FromImage(pbBitmap))
            {
                g.Clear(Color.Black);
                g.DrawImage(bitmapImage1, 0, 0);
                g.DrawImage(bitmapImage2, offset, 0);
                g.DrawImage(bitmapImage3, 2*offset, 0);
               
            }

            Image img = pbBitmap;

            pbxImageViewre.Image = img;
        }
    }
}
