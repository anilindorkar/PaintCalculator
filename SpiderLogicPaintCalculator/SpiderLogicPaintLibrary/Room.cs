using SpiderLogicPaintLibraryCommon;
using SpiderLogicPaintLibraryCommon.Dtos;
using SpiderLogicPaintLibraryCommon.Enum;
using SpiderLogicPaintLibraryCommon.Interface;

namespace SpiderLogicPaintLibrary
{
    /// <summary>
    /// To implement the interface to calculate the area and its painting cost based on it.
    /// </summary>
    public class Room : IPlace
    {

        public Room(RoomDto roomDto)
        {
            Length = roomDto.Length;
            Width = roomDto.Width;
            NumberOfWindows = roomDto.NumberOfWindows;
            NumberOfDoors = roomDto.NumberOfDoors;
        }
        /// <summary>
        /// Wall Lenth
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Wall Width
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Number Of Windows      
        /// </summary>
        public int NumberOfWindows { get; set; }

        /// <summary>
        /// Number Of Doors
        /// </summary>
        public int NumberOfDoors { get; set; }

        /// <summary>
        /// Calculate Area Of Room.
        /// </summary>
        /// <returns></returns>
        public double calculateArea()
        {
            double area = 0;
            area = ((2 * Length +2 * Width) * 9) - (NumberOfWindows * 3 * 4) -(NumberOfDoors * 7 * 3.5);
            return area;
        }

        /// <summary>
        /// Calculate Painting Cost of Room
        /// </summary>
        /// <returns></returns>
        public double calculateCost(double area, System.Enum typeofpaint)
        {
            double cost = 0;
            double paintrate = 0;
            if (TypeOfWallPaint.WallPaint1 == (TypeOfWallPaint)typeofpaint) {
                paintrate = Constants.WALL_PAINT1;
            } else if (TypeOfWallPaint.WallPaint2 == (TypeOfWallPaint)typeofpaint)
            {
                paintrate = Constants.WALL_PAINT2;
            }
            cost = area * paintrate;
            return cost;
            
        }
    }
}
