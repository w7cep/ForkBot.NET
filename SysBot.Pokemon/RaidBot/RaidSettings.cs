using System.ComponentModel;
using PKHeX.Core;

namespace SysBot.Pokemon
{
    public class RaidSettings
    {
        private const string FeatureToggle = nameof(FeatureToggle);
        private const string Hosting = nameof(Hosting);
        public override string ToString() => "Raid Bot Settings";

        [Category(FeatureToggle), Description("When set, the bot will assume that ldn_mitm sysmodule is running on your system. Better stability")]
        public bool UseLdnMitm { get; set; } = true;

        [Category(FeatureToggle), Description("When set, the bot will create a text file with current Raid Code for OBS.")]
        public bool RaidLog { get; set; } = false;

        [Category(Hosting), Description("Used with RaidLog. Will display your Friend Code for OBS.")]
        public string FriendCode { get; set; } = string.Empty;

        [Category(FeatureToggle), Description("When set, the bot will roll species and set date to 2000, resetting it once it reaches 2060.")]
        public bool AutoRoll { get; set; } = false;

        [Category(FeatureToggle), Description("Specify the amount of friends to remove and add. Use either this or FriendAdd.")]
        public int FriendCombined { get; set; } = 0;

        [Category(FeatureToggle), Description("Specify the amount of friends to add. Use either this or Combined.")]
        public int FriendAdd { get; set; } = 0;

        [Category(Hosting), Description("Specify the amount of friends to purge. Will reset itself back to zero after the purge.")]
        public int FriendPurge { get; set; } = 0;

        [Category(Hosting), Description("After how many raid hosts should we be adding or removing friends. Non-zero, positive value.")]
        public int FriendInterval { get; set; } = 1;

        [Category(Hosting), Description("Minimum amount of seconds to wait before starting a raid. Ranges from 0 to 180 seconds.")]
        public int MinTimeToWait { get; set; } = 90;

        [Category(Hosting), Description("Extra time in milliseconds to wait before closing the game to reset the raid.")]
        public int ExtraTimeEndRaid { get; set; } = 0;

        [Category(Hosting), Description("Minimum Link Code to host the raid with. Set this to -1 to host with no code.")]
        public int MinRaidCode { get; set; } = 8180;

        [Category(Hosting), Description("Maximum Link Code to host the raid with. Set this to -1 to host with no code.")]
        public int MaxRaidCode { get; set; } = 8199;

        /// <summary>
        /// Gets a random trade code based on the range settings.
        /// </summary>
        public int GetRandomRaidCode() => Util.Rand.Next(MinRaidCode, MaxRaidCode + 1);
    }
}