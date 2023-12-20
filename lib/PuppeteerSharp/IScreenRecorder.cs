using System.Threading.Tasks;

namespace PuppeteerSharp
{
    /// <summary>
    /// Screen recorder.
    /// </summary>
    public interface IScreenRecorder
    {
        /// <summary>
        /// Stops the recorder.
        /// </summary>
        /// <returns>A <see cref="Task"/> that completes when the recorder stops.</returns>
        Task StopAsync();
    }
}
