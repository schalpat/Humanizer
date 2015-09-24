//The MIT License (MIT)

//Copyright (c) 2013-2014 Omar Khudeira (http://omar.io)

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in
//all copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//THE SOFTWARE.

using Humanizer.Bytes;
using Xunit;

namespace Humanizer.Tests.Bytes
{
    public class CreatingTests
    {
        [Fact]
        public void Constructor()
        {
            var result = new ByteSize(1L << 50);
            
            Assert.Equal((1L << 50) * 8L, result.Bits);
            Assert.Equal(1L << 50, result.Bytes);
            Assert.Equal(1L << 40, result.Kilobytes);
            Assert.Equal(1L << 30, result.Megabytes);
            Assert.Equal(1L << 20, result.Gigabytes);
            Assert.Equal(1L << 10, result.Terabytes);
            Assert.Equal(1L, result.Petabytes);
        }

        [Fact]
        public void FromBits()
        {
            var result = ByteSize.FromBits(8);

            Assert.Equal(8, result.Bits);
            Assert.Equal(1, result.Bytes);
        }

        [Fact]
        public void FromBytes()
        {
            var result = ByteSize.FromBytes(1.5);

            Assert.Equal(12, result.Bits);
            Assert.Equal(1.5, result.Bytes);
        }

        [Fact]
        public void FromKilobytes()
        {
            var result = ByteSize.FromKilobytes(1.5);

            Assert.Equal(1536, result.Bytes);
            Assert.Equal(1.5, result.Kilobytes);
        }

        [Fact]
        public void FromMegabytes()
        {
            var result = ByteSize.FromMegabytes(1.5);

            Assert.Equal(1572864, result.Bytes);
            Assert.Equal(1.5, result.Megabytes);
        }

        [Fact]
        public void FromGigabytes()
        {
            var result = ByteSize.FromGigabytes(1.5);

            Assert.Equal(1610612736, result.Bytes);
            Assert.Equal(1.5, result.Gigabytes);
        }

        [Fact]
        public void FromTerabytes()
        {
            var result = ByteSize.FromTerabytes(1.5);

            Assert.Equal(1649267441664, result.Bytes);
            Assert.Equal(1.5, result.Terabytes);
        }

        [Fact]
        public void FromPetabytes()
        {
            var result = ByteSize.FromPetabytes(1.5);

            Assert.Equal(1688849860263936, result.Bytes);
            Assert.Equal(1.5, result.Petabytes);
        }
    }
}
