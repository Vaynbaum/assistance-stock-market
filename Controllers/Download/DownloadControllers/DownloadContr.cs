using System.Threading.Tasks;

namespace coursework.Controllers.Download.DownloadControllers
{
    public abstract class DownloadController<T>
    {
        public abstract Task<T> AllDownloadAsync(params object[] values);
    }
}
