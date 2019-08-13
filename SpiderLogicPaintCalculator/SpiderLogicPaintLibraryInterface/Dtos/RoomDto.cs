namespace SpiderLogicPaintLibraryCommon.Dtos
{
    /// <summary>
    /// This used to get input from the user and send same to the Calculator per Room.
    /// </summary>
    public class RoomDto
    {
        /// <summary>
        /// Length of Wall
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Width of Wall
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Length of Ceiling
        /// </summary>
        public double CeilingLength { get; set; }

        /// <summary>
        /// Width of Ceiling
        /// </summary>
        public double CeilingWidth { get; set; }

        /// <summary>
        /// Numbers of Doors in a room.
        /// </summary>
        public int NumberOfDoors { get; set; }

        /// <summary>
        /// Number of windows in a room.
        /// </summary>
        public int NumberOfWindows { get; set; }
    }
}
