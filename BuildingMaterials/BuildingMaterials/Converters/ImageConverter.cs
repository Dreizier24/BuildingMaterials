using System;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Data;

namespace BuildingMaterials.Converters
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imagePath = "";
            if (value != null)
            {
                string imageName = value.ToString();
                string imageFolderPath = Directory.GetCurrentDirectory() + @"\Images\";
                string imageFilePath = imageFolderPath + imageName;
                if (File.Exists(imageFilePath))
                {
                    imagePath = imageFilePath;
                }
                else
                {
                    imagePath = imageFolderPath + "picture.png";
                }
            }
            else
            {
                imagePath = Directory.GetCurrentDirectory() + @"\Images\picture.png";
            }

            return imagePath;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}