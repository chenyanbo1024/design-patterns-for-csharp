namespace Core.Singleton
{
    public class Singleton
    {
        private static readonly Singleton instance = new();

        static Singleton()
        {
        }

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}