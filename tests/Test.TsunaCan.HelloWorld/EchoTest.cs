using System;
using System.IO;
using TsunaCan.HelloWorld;
using Xunit;

namespace Test.TsunaCan.HelloWorld
{
    public class EchoTest
    {
        [Fact]
        public void HelloTest()
        {
            using (var stream = new MemoryStream())
            using (var writer = new StreamWriter(stream))
            {
                Console.SetOut(writer);

                Echo.Hello();

                writer.Flush();
                stream.Position = 0;
                using (var reader = new StreamReader(stream))
                {
                    Assert.Equal(" ###  ###            ###   ###             ##", reader.ReadLine());
                    Assert.Equal("  ##  ##              ##    ##             ## ", reader.ReadLine());
                    Assert.Equal("  ##  ##    ######    ##    ##    ######   ## ", reader.ReadLine());
                    Assert.Equal("  ######   ##    ##   ##    ##   ##    ##  ## ", reader.ReadLine());
                    Assert.Equal("  ##  ##   #######    ##    ##   ##    ##  ## ", reader.ReadLine());
                    Assert.Equal("  ##  ##   ##     #   ##    ##   ##    ##     ", reader.ReadLine());
                    Assert.Equal(" ###  ###   ######   ####  ####   ######   ## ", reader.ReadLine());
                    Assert.Equal(string.Empty, reader.ReadLine());
                    Assert.True(reader.EndOfStream);
                }
            }
        }

        [Fact]
        public void WorldTest()
        {
            using (var stream = new MemoryStream())
            using (var writer = new StreamWriter(stream))
            {
                Console.SetOut(writer);

                Echo.World();

                writer.Flush();
                stream.Position = 0;
                using (var reader = new StreamReader(stream))
                {
                    Assert.Equal(" ##    ##                     ###        ###  ", reader.ReadLine());
                    Assert.Equal(" ##    ##                      ##         ##  ", reader.ReadLine());
                    Assert.Equal(" ##    ##   ######   ###  ##   ##    #### ##  ", reader.ReadLine());
                    Assert.Equal(" ## ## ##  ##    ##   ####     ##   ##   ###  ", reader.ReadLine());
                    Assert.Equal(" ########  ##    ##   ##       ##   ##    ##  ", reader.ReadLine());
                    Assert.Equal(" ###  ###  ##    ##   ##       ##   ##   ###  ", reader.ReadLine());
                    Assert.Equal(" ##    ##   ######   ####     ####   ##### ## ", reader.ReadLine());
                    Assert.Equal(string.Empty, reader.ReadLine());
                    Assert.True(reader.EndOfStream);
                }
            }
        }
    }
}
