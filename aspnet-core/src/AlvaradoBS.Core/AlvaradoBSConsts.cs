using AlvaradoBS.Debugging;

namespace AlvaradoBS
{
    public class AlvaradoBSConsts
    {
        public const string LocalizationSourceName = "AlvaradoBS";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "0cf140b1624245f8a21a2981629a43b4";
    }
}
