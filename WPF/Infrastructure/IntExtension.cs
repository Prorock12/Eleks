namespace Infrastructure
{
    public static class IntExtension
    {
        public static int Clamp(this int value, int min, int max)
        {
            int result = value < min ? min : value > max ? max : value;
            return result;
        }
    }
}