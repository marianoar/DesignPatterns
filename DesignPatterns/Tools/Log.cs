namespace Tools
{
    public sealed class Log
    {
        private static Log? _instance = null;

        private readonly string _path;

        private static readonly object _protect = new();

        public static Log GetInstance(string path)
        {
            //lock bloquea el hilo. protejo que coincidan dos hilos simultaneamente, el segundo hilo queda en la cola
            lock (_protect)
            {
                if (_instance is null)
                {
                    _instance = new Log(path);
                }
                return _instance;
            }
        }

        private Log(string path)
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, DateTime.Now + ": " + message + Environment.NewLine);
        }
    }
}