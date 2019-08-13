using SpiderLogicPaintLibraryCommon.Dtos;
using SpiderLogicPaintLibraryCommon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderLogicPaintLibrary
{
    public class RoomModel
    {
        //No Need of it as we can use list directly.
        public int NumberOfRooms { get; set; }

        public TypeOfWallPaint   WallPaintType { get; set; }

        public TypeOfCeilingPaint CeilingPaintType { get; set; }

        public TypeOfGrillPaint GrillPaintType { get; set; }

        public List<RoomDto> RoomList { get; set; }
    }
}
