namespace MovementToImage
{
    public static class Helper
    {
        public static MovementData GetLongerMovement(MovementData movement1Pre, MovementData movement2Pre)
        {
            if (movement1Pre.doubleDataX.Count > movement2Pre.doubleDataX.Count)
                return movement1Pre;

            return movement2Pre;
        }

        public static MovementData GetShorterMovement(MovementData movement1Pre, MovementData movement2Pre)
        {
            if (movement1Pre.doubleDataX.Count <= movement2Pre.doubleDataX.Count)
                return movement1Pre;

            return movement2Pre;
        }
    }
}
