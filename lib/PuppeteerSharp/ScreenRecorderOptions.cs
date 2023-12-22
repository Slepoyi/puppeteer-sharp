namespace PuppeteerSharp
{
    internal record ScreenRecorderOptions
    {
        public BoundingBox Crop { get; set; }

        public string Path { get; set; }

        public decimal Scale { get; set; } = 1;

        public decimal Speed { get; set; } = 1;

        public ScreenRecorderFormat Format { get; set; } = ScreenRecorderFormat.Webm;
    }
}
