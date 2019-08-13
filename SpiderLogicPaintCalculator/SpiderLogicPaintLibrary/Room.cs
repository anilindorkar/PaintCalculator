using SpiderLogicPaintLibraryCommon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderLogicPaintLibrary
{
    /// <summary>
    /// To implement the interface to calculate the area and its painting cost based on it.
    /// </summary>
    public class Room : IPlace
    {
        public Room(float length, float width, float windowscount, float doorscount)
        {

        }
        /// <summary>
        /// Wall Lenth
        /// </summary>
        public float Lenth { get; set; }

        /// <summary>
        /// Wall Width
        /// </summary>
        public float Width { get; set; }

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
            area = ((2 * Lenth +2 * Width) * 9) - (NumberOfWindows * 3 * 4) -(NumberOfDoors * 7 * 3.5);
            return area;
        }

        /// <summary>
        /// Calculate Painting Cost of Room
        /// </summary>
        /// <returns></returns>
        public float calculateCost()
        {
            throw new NotImplementedException();
        }
    }
}
