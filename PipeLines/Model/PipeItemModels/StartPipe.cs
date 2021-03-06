// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PipeLines.Model.PipeItemModels
{
    class StartPipe : PipeItem
    {
        public StartPipe(int posX, int posY):base(posX,posY)
        {
            this.uriSource = new Uri("Assets/start.png", UriKind.Relative);
            this.waterBackgroundSource = new Uri("Assets/start.png", UriKind.Relative);
        }
        public override int[] possibleDirectionByPipeType(int x, int y)
        {
            int[] nextXY;

            return (nextXY = new int[] { this.Posx, this.PosY - 1 });
        }
    }
}
