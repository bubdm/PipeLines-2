// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PipeLines
{
    /// <summary>
    /// Base class for different Pipe types. It contains the x and y coordinates for a pipeitem.
    /// Urisource is the source of an image of the PipeItem, which is used in an Image object on the main canvas.
    /// Each PipeItem object contains an image source (waterBackgroundSource) for the final animation. 
    /// At the end of the game, this water image will be added and placed under the original PipeItem image.
    /// Each PipeItem needs different start and end point coordinate for the animation, depending on its shape.
    /// </summary>
    abstract class PipeItem
    {
        protected int posX;
        protected int posY;
        protected Uri uriSource;
        protected Uri waterBackgroundSource;
        protected Point animationStartPoint;
        protected Point animationEndPoint;

        /// <summary>
        /// The dictionary is conneceting Image objects (on the canvas) to Pipeitem objects.
        /// This will identify the Pipeitem, which is currently moved on the canvas.
        /// </summary>
        private static Dictionary<Image, PipeItem> dictionary = new Dictionary<Image, PipeItem>();

        public static Dictionary<Image,PipeItem> Dictionary { set { dictionary = value; } }

        public Uri WaterBackgroundSource
        {
            get { return waterBackgroundSource; }
            set { waterBackgroundSource = value; }
        }
        public Uri UriSource
        {
            get { return uriSource; }
            set { uriSource = value; }
        }
        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }
        public int Posx
        {
            get { return posX; }
            set { posX = value; }
        }

        public Point AnimationStartPoint { get; set; }
        public Point AnimationEndPoint { get; set; }

        public PipeItem(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }       

        public void setImageSource(Image i)
        {
            i.Source = new BitmapImage(this.uriSource);
            dictionary.Add(i, this);
        }
        /// <summary>
        /// This method will return an int array.
        /// If the x and y parameters matches on of the possible input directions of the item, it will return the possible output direction.
        /// If the input directions doesn't match, it will return null.
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public abstract int[] possibleDirectionByPipeType(int x, int y);



    }
}
