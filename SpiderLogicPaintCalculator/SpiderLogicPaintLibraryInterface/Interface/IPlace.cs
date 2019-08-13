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
