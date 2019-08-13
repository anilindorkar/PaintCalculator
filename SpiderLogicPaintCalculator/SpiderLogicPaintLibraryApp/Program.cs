using SpiderLogicPaintLibrary;
using SpiderLogicPaintLibraryCommon.Enum;
using SpiderLogicPaintLibraryCommon.Interface;
using System;
using System.Collections.Generic;

namespace SpiderLogicPaintLibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Room Input for Paint Cost.
            RoomModel roomModel = new RoomModel() { WallPaintType = TypeOfWallPaint.WallPaint1, CeilingPaintType = TypeOfCeilingPaint.CeilingPaint2, GrillPaintType = TypeOfGrillPaint.GrillPaint1, NumberOfRooms = 2 };
            roomModel.RoomList = new List<SpiderLogicPaintLibraryCommon.Dtos.RoomDto>();
            roomModel.RoomList.Add(new SpiderLogicPaintLibraryCommon.Dtos.RoomDto() { Length = 10, NumberOfDoors = 2, NumberOfWindows = 4, Width = 1, CeilingLength = 10, CeilingWidth = 9 });
            roomModel.RoomList.Add(new SpiderLogicPaintLibraryCommon.Dtos.RoomDto() { Length = 10, NumberOfDoors = 2, NumberOfWindows = 2, Width = 1, CeilingLength = 10, CeilingWidth = 9 });


            CalculatePaintCost(roomModel);

            Console.ReadLine();
        }

        /// <summary>
        /// This function used to call the calculator to calculate the paint cost.
        /// </summary>
        /// <param name="roomModel"></param>
        public static void CalculatePaintCost(RoomModel roomModel)
        {

            double totalWallArea = 0;
            double totalCeilingArea = 0;
            double totalGrillArea = 0;

            double totalWallAreaPaintCost = 0;
            double totalCeilingAreaPaintCost = 0;
            double totalGrillAreaPaint = 0;

            if (roomModel != null)
            {
                for (int index = 0; index < roomModel.RoomList.Count; index++)
                {

                    #region Room

                    // To get Wall
                    IPlace room = new Room(roomModel.RoomList[index]);
                    double currentWallArea = room.calculateArea();
                    totalWallArea += currentWallArea;
                    double currentWallPaintCost = room.calculateCost(currentWallArea, roomModel.WallPaintType);
                    totalWallAreaPaintCost += currentWallPaintCost;

                    #endregion


                    #region Grill

                    // To get Grill/Window
                    int numberOfWindow = ((Room)room).NumberOfWindows;
                    if (numberOfWindow > 0)
                    {
                        for (int windiex = 0; windiex < numberOfWindow; windiex++)
                        {
                            IPlace window = new Window();
                            double currentWindowArea = window.calculateArea();
                            totalGrillArea += currentWindowArea;
                            double currentGrillPaintCost = window.calculateCost(currentWindowArea, roomModel.GrillPaintType);
                            totalGrillAreaPaint += currentGrillPaintCost;
                        }
                    }

                    #endregion


                    #region Ceiling
                    // To get Ceiling
                    Room currentroom = ((Room)room);
                    if (currentroom != null)
                    {
                        IPlace ceiling = new Ceiling(roomModel.RoomList[index].CeilingLength, roomModel.RoomList[index].CeilingWidth);
                        double currentCeilingArea = ceiling.calculateArea();
                        totalCeilingArea += currentCeilingArea;
                        double currentCeilingPaintCost = ceiling.calculateCost(currentCeilingArea, roomModel.CeilingPaintType);
                        totalCeilingAreaPaintCost += currentCeilingPaintCost;
                    }

                    #endregion
                }



                #region Output-Result 
                Console.WriteLine("The Wall Area is {0}.", totalWallArea);
                Console.WriteLine("The Wall Paint Cost is ₹{0}.", totalWallAreaPaintCost);

                Console.WriteLine("The Grill Area is {0}.", totalGrillArea);
                Console.WriteLine("The Grill Paint Cost is ₹{0}.", totalGrillAreaPaint);

                Console.WriteLine("The Ceiling Area is {0}.", totalCeilingArea);
                Console.WriteLine("The Ceiling Paint Cost is ₹{0}.", totalCeilingAreaPaintCost);

                Console.WriteLine("===================================");
                Console.WriteLine("Total Paint Cost : ₹{0}", (totalWallAreaPaintCost + totalGrillAreaPaint + totalCeilingAreaPaintCost));
                Console.WriteLine("===================================");
                #endregion             

            }
        }

    }
}
