using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderLogicPaintLibraryCommon.Dtos
{
    public class RoomDto
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public int NumberOfDoors { get; set; }

        public int NumberOfWindows { get; set; }
    }
}
