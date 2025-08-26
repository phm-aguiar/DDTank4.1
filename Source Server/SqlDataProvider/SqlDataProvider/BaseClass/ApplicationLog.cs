using log4net;
using System.Reflection;

namespace SqlDataProvider.BaseClass
{
    public static class ApplicationLog
    {
        // 1. Cria uma instância estática do logger do log4net.
        // Ele vai usar o nome desta classe ("ApplicationLog") como o nome do logger.
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void WriteError(string message)
        {
            // 2. Em vez de chamar o método antigo, agora chamamos o método Error do log4net.
            log.Error(message);
        }

        // 3. Podemos remover completamente o método antigo WriteLog,
        // pois ele só continha o código do EventLog que não funciona no Linux.
        // A biblioteca log4net já lida com os diferentes níveis de log (Error, Info, Warn, etc.).
    }
}