using ExSharpBase.Modules;

namespace ExSharpBase.Game
{
    internal class OffsetManager
    {
        private static readonly int BaseAddress = Utils.GetLeagueProcess().MainModule.BaseAddress.ToInt32();

        public class Instances
        {
            public const int SPELL_BOOK = 0x2720;

            //Version 10.25 //
            public static readonly int
                LocalPlayer = BaseAddress + 0x2f792b8;

            public static readonly int
                Renderer = BaseAddress +
                           0x2f9e33c; /

            public static readonly int
                ViewMatrix =
                    BaseAddress +
                    0x2f9b4e0;

            public static readonly int UnderMouseObject = BaseAddress + 0x232A7C0;
        }

        public class Object
        {
            private const int CHAMPION_NAME = 0x3134;
            public const int POS = 0x1D8;
            public const int NAME = 0x6C;
            public const int VISIBILITY = 0x270;
            public const int ATTACK_RANGE = 0x12B8;
        }
    }
}
