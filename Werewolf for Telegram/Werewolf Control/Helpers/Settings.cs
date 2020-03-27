using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werewolf_Control.Helpers
{
    internal static class Settings
    {

        //By the way, these admin ports will have IP whitelisting.  Don't even bother trying to connect to them :P
        //The regular ports are not even open on the firewall
#if DEBUG
        public static int Port = 9049;
        public static int AdminPort = 9059;
#elif RELEASE
        public static int Port = 9050;  //9050-@werewolfbot 
        public static int AdminPort = 9060;
#elif RELEASE2
        public static int Port = 9051;  //9051-@werewolfIIbot
        public static int AdminPort = 9063; //9061 not responding
#elif BETA
        public static int Port = 9052;
        public static int AdminPort = 9062;
#endif



        public static string TcpSecret => Environment.MachineName.GetHashCode().ToString();
        public static readonly long PersianSupportChatId = -1001398432551;
        public static readonly long MainChatId = -1001049529775; //Beta group
        public static readonly long SupportChatId = -1001060486754; //@werewolfsupport
        public static readonly long PrimaryChatId = -1001268085464; //@werewolfgame
        public static readonly string DevChannelId = "@greywolfdev"; //@greywolfdev
        public static readonly long VeteranChatId = -1001322721489;
        public static readonly string VeteranChatLink = "werewolfvets";
        public static readonly string VeteranChatUrl = $"https://t.me/{VeteranChatLink}";
        public static readonly long TranslationChatId = -1001074012132;
        public static readonly long AdminChatId = -1001094155678;
        public static readonly long ErrorGroup = -1001098399855;
        public static readonly long BetaReportingChatId = -1001235990177;

        public static readonly string GifStoragePath = @"C:/inetpub/gifs";

#if RELEASE2
        public static List<string> VillagerDieImages = new List<string> { "CgACAgQAAxkBAAIHuV59qRwjBtHHc9MLVhCo-z8IbOAHAAICAgACC2_1Ul_0q924vLyJGAQ", "CgACAgQAAxkBAAIHu159qSjIkJQ5H02sQCA9OSMqUXAvAAIUAgACPwbtU85h3VluRyxfGAQ", "CgACAgQAAxkBAAIHvV59qTk45cEr3E8LgdmZZF8BMRR6AAJrAgACQ5jsUuxGSBtZ_TKUGAQ" }; //1
        public static List<string> WolfWin = new List<string> { "CgACAgQAAxkBAAIHv159qYy0Bzo6GwjEMOsAAee01fJIoQACZwIAAoHR7FKSKvOd74DPThgE", "CgACAgQAAxkBAAIHwV59qY9MtGoosOcCnceVzRzDoJsYAAIvAgAC8n7sUgycwY5AhB8DGAQ", "CgACAgQAAxkBAAIHw159qZL6f5zfnFYUu2Vve0LHAcbOAAI8AgACzyDtUlzzX-_9PoYrGAQ" };
        public static List<string> WolvesWin = new List<string> { "CgACAgQAAxkBAAIHxV59qa9VdBcMbnynxqgCkwkQN-J3AAJxAgACL1HsUn-pZ-_zZvqoGAQ" };
        public static List<string> VillagersWin = new List<string> { "CgACAgQAAxkBAAIHy159qc7wdF70ErZ_3QHpc3L4kc3HAAIIAgACK1f0UqEm6SNWYfKzGAQ", "CgACAgQAAxkBAAIHzV59qdtntaRXMbmO9EZspd9Gtl6lAAIfAgACLTb9Ui51vgJ6AVH4GAQ" };
        public static List<string> NoWinner = new List<string> { "CgACAgQAAxkBAAIHz159qeysI1hJRb0ya_hp_1dsIU38AAI5AgAC4d_0UhQFMRPeDImSGAQ", "CgACAgQAAxkBAAIH0V59qfDwakvkmXhctl_pOS5rmhf8AAJBAgACtSztUk7ZMJqxpfO_GAQ" };
        public static List<string> StartGame = new List<string> { "CgACAgQAAxkBAAIH0159qgGK4qoogaYVMbfUpZj8aPz_AAIiAgACe6z0UmgzdtkYFzWcGAQ" };
        public static List<string> StartChaosGame = new List<string> { "CgACAgQAAxkBAAIH1V59qhWYm9lBSBW_ohgjKoeilqXDAALkAQACG0X9UuvIjsE62etEGAQ" }; //2
        public static List<string> TannerWin = new List<string> { "CgACAgQAAxkBAAIH2V59qh_73rczIBTlQfMRAplXSUkpAAIyAgACbPH0UpPYTjQgqgbZGAQ", "CgACAgQAAxkBAAIH1159qhyhjpPJS8FHvfcHvVBDmaCNAAJNAgAC68LsUtyvM5YSz3aeGAQ" };
        public static List<string> CultWins = new List<string> { "CgACAgQAAxkBAAIH2159qjL_QTqdhv1nhSvsVw4QrE8mAAIUAgACbGPkU-lHbuiVmdQaGAQ", "CgACAgQAAxkBAAIH3V59qjYDUo7DeWmhKN7C7cXGRfVNAAIlAgAC7v_tU6KSZGA_VP2QGAQ" };
        public static List<string> SerialKillerWins = new List<string> { "CgACAgQAAxkBAAIH4V59qlCrRz1rsoyG2ceDEKEZ5rXXAAJAAgAC9CjtUsHm90K8SZdFGAQ", "CgACAgQAAxkBAAIH4159qlFzvr1QqOniOZEFH0qxTaOzAAJLAgACSBXsUvVQum_dGE79GAQ", "CgACAgQAAxkBAAIH3159qk0enwjFHD3UJmydEolEwSPUAAJzAgACwhTsUnvzE-sQEqrkGAQ" };
        public static List<string> LoversWin = new List<string> { "CgACAgQAAxkBAAIH5V59qoVIDd8vvnwStWtv2PIl934tAAIIAgAC6Z_1Uk87hpoiUU-sGAQ", "CgACAgQAAxkBAAIH5159qrwNLC1iKC3VAAEefs0woN8TBAACDgIAAmwa7FJ23lcYXiyhThgE" };
#elif RELEASE
        public static List<string> VillagerDieImages = new List<string> { "CgACAgQAAxkBAAIHuV59qRwjBtHHc9MLVhCo-z8IbOAHAAICAgACC2_1Ul_0q924vLyJGAQ", "CgACAgQAAxkBAAIHu159qSjIkJQ5H02sQCA9OSMqUXAvAAIUAgACPwbtU85h3VluRyxfGAQ", "CgACAgQAAxkBAAIHvV59qTk45cEr3E8LgdmZZF8BMRR6AAJrAgACQ5jsUuxGSBtZ_TKUGAQ" }; //1
        public static List<string> WolfWin = new List<string> { "CgACAgQAAxkBAAIHv159qYy0Bzo6GwjEMOsAAee01fJIoQACZwIAAoHR7FKSKvOd74DPThgE", "CgACAgQAAxkBAAIHwV59qY9MtGoosOcCnceVzRzDoJsYAAIvAgAC8n7sUgycwY5AhB8DGAQ", "CgACAgQAAxkBAAIHw159qZL6f5zfnFYUu2Vve0LHAcbOAAI8AgACzyDtUlzzX-_9PoYrGAQ" };
        public static List<string> WolvesWin = new List<string> { "CgACAgQAAxkBAAIHxV59qa9VdBcMbnynxqgCkwkQN-J3AAJxAgACL1HsUn-pZ-_zZvqoGAQ" };
        public static List<string> VillagersWin = new List<string> { "CgACAgQAAxkBAAIHy159qc7wdF70ErZ_3QHpc3L4kc3HAAIIAgACK1f0UqEm6SNWYfKzGAQ", "CgACAgQAAxkBAAIHzV59qdtntaRXMbmO9EZspd9Gtl6lAAIfAgACLTb9Ui51vgJ6AVH4GAQ" };
        public static List<string> NoWinner = new List<string> { "CgACAgQAAxkBAAIHz159qeysI1hJRb0ya_hp_1dsIU38AAI5AgAC4d_0UhQFMRPeDImSGAQ", "CgACAgQAAxkBAAIH0V59qfDwakvkmXhctl_pOS5rmhf8AAJBAgACtSztUk7ZMJqxpfO_GAQ" };
        public static List<string> StartGame = new List<string> { "CgACAgQAAxkBAAIH0159qgGK4qoogaYVMbfUpZj8aPz_AAIiAgACe6z0UmgzdtkYFzWcGAQ" };
        public static List<string> StartChaosGame = new List<string> { "CgACAgQAAxkBAAIH1V59qhWYm9lBSBW_ohgjKoeilqXDAALkAQACG0X9UuvIjsE62etEGAQ" }; //2
        public static List<string> TannerWin = new List<string> { "CgACAgQAAxkBAAIH2V59qh_73rczIBTlQfMRAplXSUkpAAIyAgACbPH0UpPYTjQgqgbZGAQ", "CgACAgQAAxkBAAIH1159qhyhjpPJS8FHvfcHvVBDmaCNAAJNAgAC68LsUtyvM5YSz3aeGAQ" };
        public static List<string> CultWins = new List<string> { "CgACAgQAAxkBAAIH2159qjL_QTqdhv1nhSvsVw4QrE8mAAIUAgACbGPkU-lHbuiVmdQaGAQ", "CgACAgQAAxkBAAIH3V59qjYDUo7DeWmhKN7C7cXGRfVNAAIlAgAC7v_tU6KSZGA_VP2QGAQ" };
        public static List<string> SerialKillerWins = new List<string> { "CgACAgQAAxkBAAIH4V59qlCrRz1rsoyG2ceDEKEZ5rXXAAJAAgAC9CjtUsHm90K8SZdFGAQ", "CgACAgQAAxkBAAIH4159qlFzvr1QqOniOZEFH0qxTaOzAAJLAgACSBXsUvVQum_dGE79GAQ", "CgACAgQAAxkBAAIH3159qk0enwjFHD3UJmydEolEwSPUAAJzAgACwhTsUnvzE-sQEqrkGAQ" };
        public static List<string> LoversWin = new List<string> { "CgACAgQAAxkBAAIH5V59qoVIDd8vvnwStWtv2PIl934tAAIIAgAC6Z_1Uk87hpoiUU-sGAQ", "CgACAgQAAxkBAAIH5159qrwNLC1iKC3VAAEefs0woN8TBAACDgIAAmwa7FJ23lcYXiyhThgE" };
        public static List<string> SKKilled = new List<string> { "CgACAgQAAxkBAAIH4V59qlCrRz1rsoyG2ceDEKEZ5rXXAAJAAgAC9CjtUsHm90K8SZdFGAQ", "CgACAgQAAxkBAAIH4159qlFzvr1QqOniOZEFH0qxTaOzAAJLAgACSBXsUvVQum_dGE79GAQ", "CgACAgQAAxkBAAIH3159qk0enwjFHD3UJmydEolEwSPUAAJzAgACwhTsUnvzE-sQEqrkGAQ" };
        public static List<string> ArsonistWins = new List<string> { "CgACAgQAAxkBAAIH7V59qyQpDk0VwGwM9M-8HgLEuq12AAIRAgACB4T1UrrTc8OLi7TaGAQ" };
        public static List<string> BurnToDeath = new List<string> { "CgACAgQAAxkBAAIH7159qzGN_LyGvqtLZtHyxkDXfOMtAALlAQACa77kU9Pr83gxp247GAQ" };
#else
        public static List<string> VillagerDieImages = new List<string> { "CgACAgQAAxkBAAIHuV59qRwjBtHHc9MLVhCo-z8IbOAHAAICAgACC2_1Ul_0q924vLyJGAQ", "CgACAgQAAxkBAAIHu159qSjIkJQ5H02sQCA9OSMqUXAvAAIUAgACPwbtU85h3VluRyxfGAQ", "CgACAgQAAxkBAAIHvV59qTk45cEr3E8LgdmZZF8BMRR6AAJrAgACQ5jsUuxGSBtZ_TKUGAQ" }; //1
        public static List<string> WolfWin = new List<string> { "CgACAgQAAxkBAAIHv159qYy0Bzo6GwjEMOsAAee01fJIoQACZwIAAoHR7FKSKvOd74DPThgE", "CgACAgQAAxkBAAIHwV59qY9MtGoosOcCnceVzRzDoJsYAAIvAgAC8n7sUgycwY5AhB8DGAQ", "CgACAgQAAxkBAAIHw159qZL6f5zfnFYUu2Vve0LHAcbOAAI8AgACzyDtUlzzX-_9PoYrGAQ" };
        public static List<string> WolvesWin = new List<string> { "CgACAgQAAxkBAAIHxV59qa9VdBcMbnynxqgCkwkQN-J3AAJxAgACL1HsUn-pZ-_zZvqoGAQ" };
        public static List<string> VillagersWin = new List<string> { "CgACAgQAAxkBAAIHy159qc7wdF70ErZ_3QHpc3L4kc3HAAIIAgACK1f0UqEm6SNWYfKzGAQ", "CgACAgQAAxkBAAIHzV59qdtntaRXMbmO9EZspd9Gtl6lAAIfAgACLTb9Ui51vgJ6AVH4GAQ" };
        public static List<string> NoWinner = new List<string> { "CgACAgQAAxkBAAIHz159qeysI1hJRb0ya_hp_1dsIU38AAI5AgAC4d_0UhQFMRPeDImSGAQ", "CgACAgQAAxkBAAIH0V59qfDwakvkmXhctl_pOS5rmhf8AAJBAgACtSztUk7ZMJqxpfO_GAQ" };
        public static List<string> StartGame = new List<string> { "CgACAgQAAxkBAAIH0159qgGK4qoogaYVMbfUpZj8aPz_AAIiAgACe6z0UmgzdtkYFzWcGAQ" };
        public static List<string> StartChaosGame = new List<string> { "CgACAgQAAxkBAAIH1V59qhWYm9lBSBW_ohgjKoeilqXDAALkAQACG0X9UuvIjsE62etEGAQ" }; //2
        public static List<string> TannerWin = new List<string> { "CgACAgQAAxkBAAIH2V59qh_73rczIBTlQfMRAplXSUkpAAIyAgACbPH0UpPYTjQgqgbZGAQ", "CgACAgQAAxkBAAIH1159qhyhjpPJS8FHvfcHvVBDmaCNAAJNAgAC68LsUtyvM5YSz3aeGAQ" };
        public static List<string> CultWins = new List<string> { "CgACAgQAAxkBAAIH2159qjL_QTqdhv1nhSvsVw4QrE8mAAIUAgACbGPkU-lHbuiVmdQaGAQ", "CgACAgQAAxkBAAIH3V59qjYDUo7DeWmhKN7C7cXGRfVNAAIlAgAC7v_tU6KSZGA_VP2QGAQ" };
        public static List<string> SerialKillerWins = new List<string> { "CgACAgQAAxkBAAIH4V59qlCrRz1rsoyG2ceDEKEZ5rXXAAJAAgAC9CjtUsHm90K8SZdFGAQ", "CgACAgQAAxkBAAIH4159qlFzvr1QqOniOZEFH0qxTaOzAAJLAgACSBXsUvVQum_dGE79GAQ", "CgACAgQAAxkBAAIH3159qk0enwjFHD3UJmydEolEwSPUAAJzAgACwhTsUnvzE-sQEqrkGAQ" };
        public static List<string> LoversWin = new List<string> { "CgACAgQAAxkBAAIH5V59qoVIDd8vvnwStWtv2PIl934tAAIIAgAC6Z_1Uk87hpoiUU-sGAQ", "CgACAgQAAxkBAAIH5159qrwNLC1iKC3VAAEefs0woN8TBAACDgIAAmwa7FJ23lcYXiyhThgE" };
        public static List<string> SKKilled = new List<string> { "CgACAgQAAxkBAAIH4V59qlCrRz1rsoyG2ceDEKEZ5rXXAAJAAgAC9CjtUsHm90K8SZdFGAQ", "CgACAgQAAxkBAAIH4159qlFzvr1QqOniOZEFH0qxTaOzAAJLAgACSBXsUvVQum_dGE79GAQ", "CgACAgQAAxkBAAIH3159qk0enwjFHD3UJmydEolEwSPUAAJzAgACwhTsUnvzE-sQEqrkGAQ" };
        public static List<string> ArsonistWins = new List<string> { "CgACAgQAAxkBAAIH7V59qyQpDk0VwGwM9M-8HgLEuq12AAIRAgACB4T1UrrTc8OLi7TaGAQ" };
        public static List<string> BurnToDeath = new List<string> { "CgACAgQAAxkBAAIH7159qzGN_LyGvqtLZtHyxkDXfOMtAALlAQACa77kU9Pr83gxp247GAQ" };
#endif

        /// <summary>
        /// How many games are allowed for any given node
        /// </summary>
        public static int MaxGamesPerNode = 60;

        /// <summary>
        /// How many games on each node before starting a new node (to be added later)
        /// </summary>
#if DEBUG
        public static int NewNodeThreshhold = 10;
#else
        public static int NewNodeThreshhold = 30;
#endif
        public static int ShutDownNodesAt = 15;

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
#if DEBUG
            PlayerCountSeerCursed = 6,
            PlayerCountHarlot = 7,
            PlayerCountBeholderChance = 8,
            PlayerCountSecondWolf = 9,
            PlayerCountGunner = 9,
            PlayerCountTraitor = 10,
            PlayerCountGuardianAngel = 11,
            PlayerCountDetective = 12,
            PlayerCountApprenticeSeer = 13,
            PlayerCountCultist = 15,
            PlayerCountThirdWolf = 16,
            PlayerCountWildChild = 17,
            PlayerCountFoolChance = 18,
            PlayerCountMasons = 21,
            PlayerCountSecondCultist = 22,
            MaxGames = 80,
            TannerChance = 40,
            FoolChance = 20,
            BeholderChance = 50,
            SeerConversionChance = 40,
            GuardianAngelConversionChance = 60,
            DetectiveConversionChance = 70,
            CursedConversionChance = 60,
            HarlotConversionChance = 70,
            SorcererConversionChance = 40,
            BlacksmithConversionChance = 75,
            HarlotDiscoverCultChance = 50,
            ChanceDetectiveCaught = 40,
            ChemistSuccessChance = 50,

#else
            PlayerCountSeerCursed = 6,
            PlayerCountHarlot = 7,
            PlayerCountBeholderChance = 8,
            PlayerCountSecondWolf = 9,
            PlayerCountGunner = 9,
            PlayerCountTraitor = 10,
            PlayerCountGuardianAngel = 11,
            PlayerCountDetective = 12,
            PlayerCountApprenticeSeer = 13,
            PlayerCountCultist = 15,
            PlayerCountThirdWolf = 16,
            PlayerCountWildChild = 17,
            PlayerCountFoolChance = 18,
            PlayerCountMasons = 21,
            PlayerCountSecondCultist = 22,
            MaxGames = 80,
            TannerChance = 40,
            FoolChance = 20,
            BeholderChance = 50,
            SeerConversionChance = 40,
            GuardianAngelConversionChance = 60,
            DetectiveConversionChance = 70,
            CursedConversionChance = 60,
            HarlotConversionChance = 70,
            SorcererConversionChance = 40,
            BlacksmithConversionChance = 75,
            HarlotDiscoverCultChance = 50,
            ChanceDetectiveCaught = 40,
            ChemistSuccessChance = 50,
#endif

            GameJoinTime = 180,
            MaxExtend = 60;
    }
}
