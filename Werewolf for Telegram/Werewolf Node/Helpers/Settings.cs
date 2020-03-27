using System.Collections.Generic;

namespace Werewolf_Node
{
    static class Settings
    {
#if DEBUG
        public static string ServerIP = "127.0.0.1";
#else
        public static string ServerIP = "127.0.0.1";

#endif
#if DEBUG
        public static int Port = 9049;
#elif RELEASE
        public static int Port = 9050;
#elif RELEASE2
        public static int Port = 9051;
#elif BETA
        public static int Port = 9052;
#endif


#if RELEASE2
        internal static List<string> VillagerDieImages = new List<string> { "CgACAgQAAxkBAAIHuV59qRwjBtHHc9MLVhCo-z8IbOAHAAICAgACC2_1Ul_0q924vLyJGAQ", "CgACAgQAAxkBAAIHu159qSjIkJQ5H02sQCA9OSMqUXAvAAIUAgACPwbtU85h3VluRyxfGAQ", "CgACAgQAAxkBAAIHvV59qTk45cEr3E8LgdmZZF8BMRR6AAJrAgACQ5jsUuxGSBtZ_TKUGAQ" }; //1
        internal static List<string> WolfWin = new List<string> { "CgACAgQAAxkBAAIHv159qYy0Bzo6GwjEMOsAAee01fJIoQACZwIAAoHR7FKSKvOd74DPThgE", "CgACAgQAAxkBAAIHwV59qY9MtGoosOcCnceVzRzDoJsYAAIvAgAC8n7sUgycwY5AhB8DGAQ", "CgACAgQAAxkBAAIHw159qZL6f5zfnFYUu2Vve0LHAcbOAAI8AgACzyDtUlzzX-_9PoYrGAQ" };
        internal static List<string> WolvesWin = new List<string> { "CgACAgQAAxkBAAIHxV59qa9VdBcMbnynxqgCkwkQN-J3AAJxAgACL1HsUn-pZ-_zZvqoGAQ" };
        internal static List<string> VillagersWin = new List<string> { "CgACAgQAAxkBAAIHy159qc7wdF70ErZ_3QHpc3L4kc3HAAIIAgACK1f0UqEm6SNWYfKzGAQ", "CgACAgQAAxkBAAIHzV59qdtntaRXMbmO9EZspd9Gtl6lAAIfAgACLTb9Ui51vgJ6AVH4GAQ" };
        internal static List<string> NoWinner = new List<string> { "CgACAgQAAxkBAAIHz159qeysI1hJRb0ya_hp_1dsIU38AAI5AgAC4d_0UhQFMRPeDImSGAQ", "CgACAgQAAxkBAAIH0V59qfDwakvkmXhctl_pOS5rmhf8AAJBAgACtSztUk7ZMJqxpfO_GAQ" };
        internal static List<string> StartGame = new List<string> { "CgACAgQAAxkBAAIH0159qgGK4qoogaYVMbfUpZj8aPz_AAIiAgACe6z0UmgzdtkYFzWcGAQ" };
        internal static List<string> StartChaosGame = new List<string> { "CgACAgQAAxkBAAIH1V59qhWYm9lBSBW_ohgjKoeilqXDAALkAQACG0X9UuvIjsE62etEGAQ" }; //2
        internal static List<string> TannerWin = new List<string> { "CgACAgQAAxkBAAIH2V59qh_73rczIBTlQfMRAplXSUkpAAIyAgACbPH0UpPYTjQgqgbZGAQ", "CgACAgQAAxkBAAIH1159qhyhjpPJS8FHvfcHvVBDmaCNAAJNAgAC68LsUtyvM5YSz3aeGAQ" };
        internal static List<string> CultWins = new List<string> { "CgACAgQAAxkBAAIH2159qjL_QTqdhv1nhSvsVw4QrE8mAAIUAgACbGPkU-lHbuiVmdQaGAQ", "CgACAgQAAxkBAAIH3V59qjYDUo7DeWmhKN7C7cXGRfVNAAIlAgAC7v_tU6KSZGA_VP2QGAQ" };
        internal static List<string> SerialKillerWins = new List<string> { "CgACAgQAAxkBAAIH4V59qlCrRz1rsoyG2ceDEKEZ5rXXAAJAAgAC9CjtUsHm90K8SZdFGAQ", "CgACAgQAAxkBAAIH4159qlFzvr1QqOniOZEFH0qxTaOzAAJLAgACSBXsUvVQum_dGE79GAQ", "CgACAgQAAxkBAAIH3159qk0enwjFHD3UJmydEolEwSPUAAJzAgACwhTsUnvzE-sQEqrkGAQ" };
        internal static List<string> LoversWin = new List<string> { "CgACAgQAAxkBAAIH5V59qoVIDd8vvnwStWtv2PIl934tAAIIAgAC6Z_1Uk87hpoiUU-sGAQ", "CgACAgQAAxkBAAIH5159qrwNLC1iKC3VAAEefs0woN8TBAACDgIAAmwa7FJ23lcYXiyhThgE" };
#else
        internal static List<string> VillagerDieImages = new List<string> { "CgACAgQAAxkBAAIHuV59qRwjBtHHc9MLVhCo-z8IbOAHAAICAgACC2_1Ul_0q924vLyJGAQ", "CgACAgQAAxkBAAIHu159qSjIkJQ5H02sQCA9OSMqUXAvAAIUAgACPwbtU85h3VluRyxfGAQ", "CgACAgQAAxkBAAIHvV59qTk45cEr3E8LgdmZZF8BMRR6AAJrAgACQ5jsUuxGSBtZ_TKUGAQ" }; //1
        internal static List<string> WolfWin = new List<string> { "CgACAgQAAxkBAAIHv159qYy0Bzo6GwjEMOsAAee01fJIoQACZwIAAoHR7FKSKvOd74DPThgE", "CgACAgQAAxkBAAIHwV59qY9MtGoosOcCnceVzRzDoJsYAAIvAgAC8n7sUgycwY5AhB8DGAQ", "CgACAgQAAxkBAAIHw159qZL6f5zfnFYUu2Vve0LHAcbOAAI8AgACzyDtUlzzX-_9PoYrGAQ" };
        internal static List<string> WolvesWin = new List<string> { "CgACAgQAAxkBAAIHxV59qa9VdBcMbnynxqgCkwkQN-J3AAJxAgACL1HsUn-pZ-_zZvqoGAQ" };
        internal static List<string> VillagersWin = new List<string> { "CgACAgQAAxkBAAIHy159qc7wdF70ErZ_3QHpc3L4kc3HAAIIAgACK1f0UqEm6SNWYfKzGAQ", "CgACAgQAAxkBAAIHzV59qdtntaRXMbmO9EZspd9Gtl6lAAIfAgACLTb9Ui51vgJ6AVH4GAQ" };
        internal static List<string> NoWinner = new List<string> { "CgACAgQAAxkBAAIHz159qeysI1hJRb0ya_hp_1dsIU38AAI5AgAC4d_0UhQFMRPeDImSGAQ", "CgACAgQAAxkBAAIH0V59qfDwakvkmXhctl_pOS5rmhf8AAJBAgACtSztUk7ZMJqxpfO_GAQ" };
        internal static List<string> StartGame = new List<string> { "CgACAgQAAxkBAAIH0159qgGK4qoogaYVMbfUpZj8aPz_AAIiAgACe6z0UmgzdtkYFzWcGAQ" };
        internal static List<string> StartChaosGame = new List<string> { "CgACAgQAAxkBAAIH1V59qhWYm9lBSBW_ohgjKoeilqXDAALkAQACG0X9UuvIjsE62etEGAQ" }; //2
        internal static List<string> TannerWin = new List<string> { "CgACAgQAAxkBAAIH2V59qh_73rczIBTlQfMRAplXSUkpAAIyAgACbPH0UpPYTjQgqgbZGAQ", "CgACAgQAAxkBAAIH1159qhyhjpPJS8FHvfcHvVBDmaCNAAJNAgAC68LsUtyvM5YSz3aeGAQ" };
        internal static List<string> CultWins = new List<string> { "CgACAgQAAxkBAAIH2159qjL_QTqdhv1nhSvsVw4QrE8mAAIUAgACbGPkU-lHbuiVmdQaGAQ", "CgACAgQAAxkBAAIH3V59qjYDUo7DeWmhKN7C7cXGRfVNAAIlAgAC7v_tU6KSZGA_VP2QGAQ" };
        internal static List<string> SerialKillerWins = new List<string> { "CgACAgQAAxkBAAIH4V59qlCrRz1rsoyG2ceDEKEZ5rXXAAJAAgAC9CjtUsHm90K8SZdFGAQ", "CgACAgQAAxkBAAIH4159qlFzvr1QqOniOZEFH0qxTaOzAAJLAgACSBXsUvVQum_dGE79GAQ", "CgACAgQAAxkBAAIH3159qk0enwjFHD3UJmydEolEwSPUAAJzAgACwhTsUnvzE-sQEqrkGAQ" };
        internal static List<string> LoversWin = new List<string> { "CgACAgQAAxkBAAIH5V59qoVIDd8vvnwStWtv2PIl934tAAIIAgAC6Z_1Uk87hpoiUU-sGAQ", "CgACAgQAAxkBAAIH5159qrwNLC1iKC3VAAEefs0woN8TBAACDgIAAmwa7FJ23lcYXiyhThgE" };
        internal static List<string> SKKilled = new List<string> { "CgACAgQAAxkBAAIH4V59qlCrRz1rsoyG2ceDEKEZ5rXXAAJAAgAC9CjtUsHm90K8SZdFGAQ", "CgACAgQAAxkBAAIH4159qlFzvr1QqOniOZEFH0qxTaOzAAJLAgACSBXsUvVQum_dGE79GAQ", "CgACAgQAAxkBAAIH3159qk0enwjFHD3UJmydEolEwSPUAAJzAgACwhTsUnvzE-sQEqrkGAQ" };
        public static List<string> ArsonistWins = new List<string> { "CgACAgQAAxkBAAIH7V59qyQpDk0VwGwM9M-8HgLEuq12AAIRAgACB4T1UrrTc8OLi7TaGAQ" };
        public static List<string> BurnToDeath = new List<string> { "CgACAgQAAxkBAAIH7159qzGN_LyGvqtLZtHyxkDXfOMtAALlAQACa77kU9Pr83gxp247GAQ" };

#endif
        /* beta
        public static List<string> VillagerDieImages = new List<string> { "BQADAwADggADdBexBxVNNy-rt--bAg", "BQADBAADWAMAAt4cZAfbY0WobzNPwAI", "BQADBAADKgMAAoMbZAc7Ldme4T3DKQI" };
        public static List<string> WolfWin = new List<string> { "BQADAwADgQADdBexBzrFBt-CBlhbAg", "BQADAwADgAADdBexB88vVl1RuLb3Ag" };
        public static List<string> WolvesWin = new List<string> { "BQADBAADcAMAAn8ZZAfjilsAAeijzEAC", "BQADBAADlwMAAtgaZAcKX7eF4AgXCAI" };
        public static List<string> VillagersWin = new List<string> { "BQADAwADgwADdBexB5XubJT7w_zDAg" };
        public static List<string> NoWinner = new List<string> { "BQADBAAD8QgAAqIeZAdO5PeO55YsOQI", "BQADBAADuAMAAlUXZAePrr-YU3PDJwI" };
        public static List<string> StartGame = new List<string> { "BQADBAADwg0AAu0XZAdw1sAIIH6xQQI", "BQADAwADhAADdBexByVGjSOQUSx_Ag" };
        public static List<string> StartChaosGame = new List<string> { "BQADBAAD7wYAAgcYZAfk95HeMjOEfgI", "BQADBAAD_wcAAiUYZAcehPF7vHGFXAI" };
        public static List<string> TannerWin = new List<string> { "BQADBAAD_gMAAtgaZAeTCzBjKyXi6wI", "BQADBAADQwgAAuQaZAcBXBZ1bAUmwQI" };
        public static List<string> CultWins = new List<string> { "BQADBAADWAMAAosYZAfwfixffVnZywI", "BQADBAADHwsAAgUYZAfm4J7Dr5HpJQI" };
        public static List<string> SerialKillerWins = new List<string> { "BQADBAADdQMAAsEcZAf2I8Sj2kPcNQI", "BQADBAADmgMAArgcZAebNN10T84w9AI", "BQADBAADKwMAAsQZZAflRhJNO_knQAI", "BQADBAADOAQAAqUXZAcKgmVLwfIHvAI" };
        public static List<string> LoversWin = new List<string> { "BQADBAADYAMAAkMdZAf0_rs89KCyDAI", "BQADBAAD8hUAAhYYZAcV2T0l7f-lJQI" };
        public static List<string> SKKilled = new List<string> { "CgADBAADNZ8AAu0XZAd3o6VVV4IvLQI", "CgADBAADfvgAAtUaZAfmDpy1f5hnRwI" };
        public static List<string> ArsonistWins = new List<string> { "CgADBAADuwADTz49UzDYA8zEWtN0Ag" };
        public static List<string> BurnToDeath = new List<string> { "CgADBAADqwADa589U9Z936jXmRz4Ag" };
#endif
    */

        public static int
#if DEBUG
            MinPlayers = 1,

#else
            MinPlayers = 5,
#endif
            MaxPlayers = 35,
            TimeDay = 60,
            TimeNight = 90,
            TimeLynch = 90,
#if !DEBUG
            TannerChance = 40,
            FoolChance = 20,
            BeholderChance = 50,
            SeerConversionChance = 40,
            GuardianAngelConversionChance = 60,
            DetectiveConversionChance = 70,
            CursedConversionChance = 60,
            HarlotConversionChance = 70,
            HarlotDiscoverCultChance = 50,
            ChanceDetectiveCaught = 40,
            HunterConversionChance = 50,
            HunterKillCultChance = 50,
            HunterKillWolfChanceBase = 30,
            SerialKillerConversionChance = 20,
            AlphaWolfConversionChance = 20,
            SorcererConversionChance = 40,
            BlacksmithConversionChance = 75,
            OracleConversionChance = 50,
            SandmanConversionChance = 60,
            WiseElderConversionChance = 30,
            PacifistConversionChance = 80,
            ThiefStealChance = 50,
            ChemistSuccessChance = 50,
            GraveDiggerConversionChance = 30,
            AugurConversionChance = 40,
#else
            TannerChance = 40,
            FoolChance = 20,
            BeholderChance = 50,
            SeerConversionChance = 40,
            GuardianAngelConversionChance = 60,
            DetectiveConversionChance = 70,
            CursedConversionChance = 60,
            HarlotConversionChance = 70,
            HarlotDiscoverCultChance = 50,
            ChanceDetectiveCaught = 40,
            HunterConversionChance = 50,
            HunterKillCultChance = 50,
            HunterKillWolfChanceBase = 30,
            SerialKillerConversionChance = 20,
            AlphaWolfConversionChance = 20,
            SorcererConversionChance = 40,
            BlacksmithConversionChance = 75,
            OracleConversionChance = 50,
            SandmanConversionChance = 60,
            WiseElderConversionChance = 30,
            PacifistConversionChance = 80,
            ThiefStealChance = 100,
            ChemistSuccessChance = 50,
            GraveDiggerConversionChance = 30,
            AugurConversionChance = 40,
#endif

            GameJoinTime = 180,
            MaxJoinTime = 300;


#if DEBUG
        //public static long MainChatId = -134703013;
        public static long MainChatId = -1001049529775; //Beta group
#else
        public static long MainChatId = -1001030085238;
#endif
        public static long VeteranChatId = -1001322721489;
        public static string VeteranChatLink = "werewolfvets";

        public static bool RandomLynch = false;
    }
}
