namespace DesignPatterns.Patterns.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private static object lockSingleton = new object();

        private Singleton()
        {
        }

        public string Name { get; set; }

        public static Singleton GetInstance()
        {
            lock (lockSingleton)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }

            return instance;
        }
    }
}