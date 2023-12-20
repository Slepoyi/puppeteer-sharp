namespace PuppeteerSharp
{
    /// <summary>
    /// Options for <see cref="IPage.ScreencastAsync(ScreencastOptions)"/>
    /// </summary>
    public class ScreencastOptions
    {
        /// <summary>
        /// Specifies the region of the viewport to crop.
        /// </summary>
        public BoundingBox Crop { get; set; }

        /// <summary>
        /// File path to save the screencast to.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Path to the ffmpeg. Required if ffmpeg is not in your PATH.
        /// </summary>
        public string FfmpegPath { get; set; }

        /// <summary>
        /// Scales the output video. For example, 0.5 will shrink the width and height of the output video by half.
        /// 2 will double the width and height of the output video.
        /// </summary>
        public decimal Scale { get; set; } = 1;
    }
}
