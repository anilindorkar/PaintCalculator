using NUnit.Framework;
using SpiderLogicPaintLibraryCommon.Dtos;
using SpiderLogicPaintLibraryCommon.Enum;
using SpiderLogicPaintLibraryCommon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderLogicPaintLibrary.Tests
{
    [TestFixture]
    public class PaintCalculatorTests
    {
        [TestCase]
        public void Confirm()
        {
            Assert.That(1 == 1);
        }


        #region Wall Paints
        [TestCase]
        public void WallPaintCostPaint1()
        {
            Room room = new Room(new RoomDto() { Length = 10, NumberOfDoors = 2, NumberOfWindows = 4, Width = 1, CeilingLength = 10, CeilingWidth = 9 });
            double currentWallArea = room.calculateArea();
            double currentWallPaintCost = room.calculateCost(currentWallArea, TypeOfWallPaint.WallPaint1);
            Assert.AreEqual(currentWallPaintCost, 1414);
        }

        [TestCase]
        public void WallPaintCostPaint2()
        {
            Room room = new Room(new RoomDto() { Length = 10, NumberOfDoors = 2, NumberOfWindows = 2, Width = 1, CeilingLength = 10, CeilingWidth = 9 });
            double currentWallArea = room.calculateArea();
            double currentWallPaintCost = room.calculateCost(currentWallArea, TypeOfWallPaint.WallPaint2);
            Assert.AreEqual(currentWallPaintCost, 2000);
        }
        #endregion


        #region Grill Paints

        [TestCase]
        public void GrillPaintCostPaint1()
        {
            IPlace window = new Window();
            double currentWindowArea = window.calculateArea();
            double currentGrillPaintCost = window.calculateCost(currentWindowArea, TypeOfGrillPaint.GrillPaint1);
            Assert.AreEqual(currentGrillPaintCost, 14.4);
        }

        [TestCase]
        public void GrillPaintCostPaint2()
        {
            IPlace window = new Window();
            double currentWindowArea = window.calculateArea();
            double currentGrillPaintCost = window.calculateCost(currentWindowArea, TypeOfGrillPaint.GrillPaint2);
            Assert.AreEqual(currentGrillPaintCost, 18);
        }

        #endregion


        #region Ceiling Paints

        [TestCase]
        public void CeilingPaintCostPaint1()
        {
            IPlace ceiling = new Ceiling(10, 9);
            double currentCeilingArea = ceiling.calculateArea();
            double currentCeilingPaintCost = ceiling.calculateCost(currentCeilingArea, TypeOfCeilingPaint.CeilingPaint1);
            Assert.AreEqual(currentCeilingPaintCost, 900);
        }

        [TestCase]
        public void CeilingPaintCostPaint2()
        {
            IPlace ceiling = new Ceiling(10, 9);
            double currentCeilingArea = ceiling.calculateArea();
            double currentCeilingPaintCost = ceiling.calculateCost(currentCeilingArea, TypeOfCeilingPaint.CeilingPaint2);
            Assert.AreEqual(currentCeilingPaintCost, 1080);
        }

        #endregion
    }
}
