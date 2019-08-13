using SpiderLogicPaintLibraryCommon;
using SpiderLogicPaintLibraryCommon.Enum;
using SpiderLogicPaintLibraryCommon.Interface;

namespace SpiderLogicPaintLibrary
{
    /// <summary>
    /// It  holds the Window.
    /// </summary>
    public class Window : IPlace
    {
        /// <summary>
        /// The Height of the window.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// This width of the window.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// To initialize the default variables.
        /// </summary>
        public Window()
        {
            Height = 3;
            Width = 4;
        }

        /// <summary>
        /// Calculate Area Of Window.
        /// </summary>
        /// <returns></returns>
        public double calculateArea()
        {
            return Height * Width;
        }

        /// <summary>
        /// Calculate Cost of the Grill Paint.
        /// </summary>
        /// <param name="area">The total area to paint.</param>
        /// <param name="typeofpaint">The Type of Paint to be done on Grill.</param>
        /// <returns></returns>
        public double calculateCost(double area, System.Enum typeofpaint)
        {
            double cost = 0;
            double paintrate = 0;
            if (TypeOfGrillPaint.GrillPaint1 == (TypeOfGrillPaint)typeofpaint)
            {
                paintrate = Constants.GRILL_PAINT1;
            }
            else if (TypeOfGrillPaint.GrillPaint2 == (TypeOfGrillPaint)typeofpaint)
            {
                paintrate = Constants.GRILL_PAINT2;
            }
            //The grill area is 15% of the Windo size.
            cost = (area*0.15) * paintrate;
            return cost;
        }
    }
}
