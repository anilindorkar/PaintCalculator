using SpiderLogicPaintLibraryCommon.Dtos;
using SpiderLogicPaintLibraryCommon.Enum;
using System.Collections.Generic;

namespace SpiderLogicPaintLibrary
{
    /// <summary>
    /// This class is used to get the inputs from the user regarding the Room.
    /// </summary>
    public class RoomModel
    {
        /// <summary>
        /// No Need of it as we can use list directly.
        /// </summary>
        public int NumberOfRooms { get; set; }

        /// <summary>
        /// The Wall paint type.
        /// </summary>
        public TypeOfWallPaint   WallPaintType { get; set; }

        /// <summary>
        /// The Ceiling paint type.
        /// </summary>
        public TypeOfCeilingPaint CeilingPaintType { get; set; }

        /// <summary>
        /// The Grill paint type.
        /// </summary>
        public TypeOfGrillPaint GrillPaintType { get; set; }

        /// <summary>
        /// The list of rooms need to be process for paint cost.
        /// </summary>
        public List<RoomDto> RoomList { get; set; }
    }
}
