using System;

namespace TsunaCan.HelloWorld
{
    /// <summary>
    ///  Hello World のアスキーアートを echo する機能を提供します。
    /// </summary>
    public static class Echo
    {
        /// <summary>
        ///  Hello のアスキーアートをコンソールに出力します。
        /// </summary>
        public static void Hello()
        {
            const string hello =
                " ###  ###            ###   ###             ## \r\n" +
                "  ##  ##              ##    ##             ## \r\n" +
                "  ##  ##    ######    ##    ##    ######   ## \r\n" +
                "  ######   ##    ##   ##    ##   ##    ##  ## \r\n" +
                "  ##  ##   #######    ##    ##   ##    ##  ## \r\n" +
                "  ##  ##   ##     #   ##    ##   ##    ##     \r\n" +
                " ###  ###   ######   ####  ####   ######   ## \r\n";
            Console.WriteLine(hello)
        }

        /// <summary>
        ///  World のアスキーアートをコンソールに出力します。
        /// </summary>
        public static void World()
        {
            const string world =
                " ##    ##                     ###        ###  \r\n" +
                " ##    ##                      ##         ##  \r\n" +
                " ##    ##   ######   ###  ##   ##    #### ##  \r\n" +
                " ## ## ##  ##    ##   ####     ##   ##   ###  \r\n" +
                " ########  ##    ##   ##       ##   ##    ##  \r\n" +
                " ###  ###  ##    ##   ##       ##   ##   ###  \r\n" +
                " ##    ##   ######   ####     ####   ##### ## \r\n";
            Console.WriteLine(world);
        }
    }
}
