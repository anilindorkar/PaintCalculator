using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderLogicPaintLibraryCommon.Interface
{
    /// <summary>
    /// Place interface to find the Area and Paiting Cost declaration.
    /// </summary>
    public interface IPlace
    {
        double calculateArea();
        double calculateCost(double area, System.Enum typeofpaint);
    }
}
