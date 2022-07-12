using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace PictureBox
{
    class FileOpener
    {
        private List<Image> imageList = new List<Image>();

        private List<string> imageNames = new List<string>();

        private int indexOfImage;

        public List<Image> GetListOFAllImages(string openFileName, out bool fileOpened, out int indexOfImage)
        {
            imageList.Clear();
            imageNames.Clear();
            var fileNameIndex = openFileName.LastIndexOf('\\');
            var directoryPath = openFileName.Substring(0, fileNameIndex);
            var filesInDirectory = Directory.EnumerateFiles(directoryPath);

            if (filesInDirectory != null)
            {
                foreach (var item in filesInDirectory)
                {
                    if (item.ToLower().EndsWith("jpg") || item.ToLower().EndsWith("png") || item.ToLower().EndsWith("bmp") || item.ToLower().EndsWith("gif"))
                    {
                        imageNames.Add(item.ToString());
                    }
                }
            }

            fileOpened = LoadAllImagesToList(openFileName);
            indexOfImage = this.indexOfImage;
            imageNames.Clear();
            return imageList;
        }

        private bool LoadAllImagesToList(string fileName)
        {

            foreach (var name in imageNames)
            {
                using (FileStream source = File.OpenRead(name))
                {
                    imageList.Add(Image.FromStream(source));
                    if (name.Equals(fileName))
                        indexOfImage = imageList.Count();
                    source.Close();
                }
            }

            return  imageList != null ? true : false;
        }

    }
}
