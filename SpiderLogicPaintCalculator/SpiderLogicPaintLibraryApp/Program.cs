using SpiderLogicPaintLibrary;
using SpiderLogicPaintLibraryCommon.Enum;
using SpiderLogicPaintLibraryCommon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderLogicPaintLibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RoomModel roomModel = new RoomModel() { WallPaintType = TypeOfWallPaint.WallPaint1, CeilingPaintType = TypeOfCeilingPaint.CeilingPaint2, GrillPaintType = TypeOfGrillPaint.GrillPaint1, NumberOfRooms = 2};
            roomModel.RoomList = new List<SpiderLogicPaintLibraryCommon.Dtos.RoomDto>();
            roomModel.RoomList.Add(new SpiderLogicPaintLibraryCommon.Dtos.RoomDto() {Length = 10, NumberOfDoors = 2, NumberOfWindows = 4, Width= 1 });
            roomModel.RoomList.Add(new SpiderLogicPaintLibraryCommon.Dtos.RoomDto() { Length = 10, NumberOfDoors = 2, NumberOfWindows = 2, Width = 1 });


            CalculatePaintCost(roomModel);

            Console.ReadLine();
        }

        public static void CalculatePaintCost(RoomModel roomModel) {

            double totalwallarea = 0;
            double totalceilingarea = 0;
            double totalgrillarea = 0;

            double totalwallareapaint = 0;
            double totalceilingareapaint = 0;
            double totalgrillareapaint = 0;

            if (roomModel != null)
            {
                for (int index = 0; index < roomModel.RoomList.Count; index++)
                {
                    IPlace place = new Room(roomModel.RoomList[index]);
                    double currentwallarea = place.calculateArea();
                    totalwallarea += currentwallarea;
                    
                    double currentwallpaintcost = place.calculateCost(totalwallarea, roomModel.WallPaintType);
                    totalwallareapaint += currentwallpaintcost;
                    
                }

                Console.WriteLine("The Wall Area is {0}.", totalwallarea);
                Console.WriteLine("The Wall Paint Cost is {0}.", totalwallareapaint);
            }
        }

    }
}
