using log4net;

namespace DemoLog4net.Helper
{
    public class LogHelper()
    {
        private readonly ILog _logger = LogManager.GetLogger("Common");

        public void Info(string msg)
        {
            _logger.Info(msg);
        }

        public void Error(string msg)
        {
            _logger.Error(msg);
        }

    }
}
