namespace Singleton
{
    public class Singleton
    {
        private static Singleton INSTANCE = new Singleton();

        public int Value = 0;

        private Singleton() { }

        public static Singleton Instance { get { return INSTANCE; } }
    }
}
