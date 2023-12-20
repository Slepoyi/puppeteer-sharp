using PuppeteerSharp.Media;

namespace PuppeteerSharp
{
    /// <summary>
    /// Bounding box data returned by <see cref="IElementHandle.BoundingBoxAsync"/>.
    /// </summary>
    public record BoundingBox
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox"/> class.
        /// </summary>
        public BoundingBox()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox"/> class.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="width">Width.</param>
        /// <param name="height">Height.</param>
        public BoundingBox(decimal x, decimal y, decimal width, decimal height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// The x coordinate of the element in pixels.
        /// </summary>
        /// <value>The x.</value>
        public decimal X { get; set; }

        /// <summary>
        /// The y coordinate of the element in pixels.
        /// </summary>
        /// <value>The y.</value>
        public decimal Y { get; set; }

        /// <summary>
        /// The width of the element in pixels.
        /// </summary>
        /// <value>The width.</value>
        public decimal Width { get; set; }

        /// <summary>
        /// The height of the element in pixels.
        /// </summary>
        /// <value>The height.</value>
        public decimal Height { get; set; }

        internal Clip ToClip()
        {
            return new Clip
            {
                X = X,
                Y = Y,
                Width = Width,
                Height = Height,
            };
        }
    }
}
