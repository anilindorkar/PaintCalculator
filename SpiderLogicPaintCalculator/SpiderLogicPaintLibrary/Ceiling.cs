using SpiderLogicPaintLibraryCommon;
using SpiderLogicPaintLibraryCommon.Enum;
using SpiderLogicPaintLibraryCommon.Interface;
using System;

namespace SpiderLogicPaintLibrary
{
    /// <summary>
    /// It holds the Ceiling.
    /// </summary>
    public class Ceiling : IPlace
    {
        /// <summary>
        /// The Length of the Ceiling.
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// The Width of the Ceiling.
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// To Initialize defaul values.
        /// </summary>
        public Ceiling(double length, double width)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// Calculate Area Of Ceiling.
        /// </summary>
        /// <returns></returns>
        public double calculateArea()
        {
            return Length * Width;
        }

        /// <summary>
        /// Calculate Cost of the Ceiling Paint.
        /// </summary>
        /// <param name="area">The total area to paint.</param>
        /// <param name="typeofpaint">The Type of Paint to be done on Ceiling.</param>
        /// <returns></returns>
        public double calculateCost(double area, System.Enum typeofpaint)
        {
            double cost = 0;
            double paintrate = 0;
            if (TypeOfCeilingPaint.CeilingPaint1 == (TypeOfCeilingPaint)typeofpaint)
            {
                paintrate = Constants.CEILING_PAINT1;
            }
            else if (TypeOfCeilingPaint.CeilingPaint2 == (TypeOfCeilingPaint)typeofpaint)
            {
                paintrate = Constants.CEILING_PAINT2;
            }
            
            cost = area * paintrate;
            //Console.WriteLine("Ceiling Cost : {0}", cost);
            return cost;

        }
    }
}
