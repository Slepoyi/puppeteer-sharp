// * MIT License
//  *
//  * Copyright (c) Microsoft Corporation.
//  *
//  * Permission is hereby granted, free of charge, to any person obtaining a copy
//  * of this software and associated documentation files (the "Software"), to deal
//  * in the Software without restriction, including without limitation the rights
//  * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  * copies of the Software, and to permit persons to whom the Software is
//  * furnished to do so, subject to the following conditions:
//  *
//  * The above copyright notice and this permission notice shall be included in all
//  * copies or substantial portions of the Software.
//  *
//  * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  * SOFTWARE.

using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace PuppeteerSharp
{
    /// <summary>
    /// Screen recorder.
    /// </summary>
    public class ScreenRecorder(Page page, decimal width, decimal height, ScreenRecorderOptions options) : IScreenRecorder, IDisposable
    {
        private StreamWriter _output = null;
        private bool _isDisposed;

        /// <summary>
        /// Page instance.
        /// </summary>
        public Page Page { get; } = page;

        /// <summary>
        /// Width.
        /// </summary>
        public decimal Width { get; } = width;

        /// <summary>
        /// Height.
        /// </summary>
        public decimal Height { get; } = height;

        /// <summary>
        /// Options.
        /// </summary>
        internal ScreenRecorderOptions Options { get; } = options;

        /// <inheritdoc />
        public Task StopAsync() => throw new System.NotImplementedException();

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        internal void Pipe(string file) => _output = new StreamWriter(file);

        /// <summary>
        /// Dispose the screen recorder.
        /// </summary>
        /// <param name="disposing">Indicates whether disposal was initiated by <see cref="Dispose()"/> operation.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed)
            {
                return;
            }

            _output?.Dispose();

            _isDisposed = true;
        }
    }
}
