﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PipeLines.Model.PipeItemModels
{
    class FinishPipe : PipeItem
    {
        public FinishPipe(int posX, int posY):base(posX,posY)
        {
            this.uriSource = new Uri("Assets/finish2.png", UriKind.Relative);
            this.waterBackgroundSource = new Uri("Assets/finish2_water.png", UriKind.Relative);
        }
        public override int[] possibleDirectionByPipeType(int x, int y)
        {
            return null;
        }
    }
}
