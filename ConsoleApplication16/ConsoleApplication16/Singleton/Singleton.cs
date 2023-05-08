namespace ConsoleApplication16.Singleton
{
    public class Singleton
    {
        private static Singleton _singleton;
        public static Singleton GetSingleton
        {
            get
            {
                if (_singleton == null)
                    _singleton = new Singleton();

                return _singleton;
            }
        }

        private Singleton(){}
    }
}