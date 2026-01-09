using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace NostalG
{
    public static class Helpers
    {
        public static int GetTotalFolders(string path)
        {
            return Directory.EnumerateDirectories(path).Count();
        }
        public static int GetTotalFiles(string path)
        {
            return Directory.GetFiles(path).Length;
        }

        //Bitmap Pixelate(Image source, int pixelSize)
        //{
        //    int w = source.Width / pixelSize;
        //    int h = source.Height / pixelSize;

        //    Bitmap small = new Bitmap(w, h);
        //    using (Graphics g = Graphics.FromImage(small))
        //    {
        //        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
        //        g.DrawImage(source, 0, 0, w, h);
        //    }

        //    Bitmap result = new Bitmap(source.Width, source.Height);
        //    using (Graphics g = Graphics.FromImage(result))
        //    {
        //        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
        //        g.DrawImage(small, 0, 0, result.Width, result.Height);
        //    }

        //    return result;
        //}


    }
}
