using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApexGoalTrackerAPI.ApexApiDataObjects
{

    public class ApexApiDataObject
    {
        public Global global { get; set; }
        public Realtime realtime { get; set; }
        public Legends legends { get; set; }
        public MozambiquehereInternal mozambiquehere_internal { get; set; }
        public Total total { get; set; }
    }
    public class Bans
    {
        public bool isActive { get; set; }
        public int remainingSeconds { get; set; }
        public string last_banReason { get; set; }
    }

    public class Rank
    {
        public int rankScore { get; set; }
        public string rankName { get; set; }
        public int rankDiv { get; set; }
        public int ladderPosPlatform { get; set; }
        public string rankImg { get; set; }
        public string rankedSeason { get; set; }
    }

    public class Arena
    {
        public string rankName { get; set; }
        public int rankDiv { get; set; }
        public int ladderPosPlatform { get; set; }
        public string rankImg { get; set; }
        public string rankedSeason { get; set; }
    }

    public class History
    {
        public int season1 { get; set; }
        public int season2 { get; set; }
        public int season3 { get; set; }
        public int season4 { get; set; }
        public int season5 { get; set; }
        public int season6 { get; set; }
        public int season7 { get; set; }
        public int season8 { get; set; }
        public int season9 { get; set; }
    }

    public class Battlepass
    {
        public string level { get; set; }
        public History history { get; set; }
    }

    public class Global
    {
        public string name { get; set; }
        public long uid { get; set; }
        public string avatar { get; set; }
        public string platform { get; set; }
        public int level { get; set; }
        public int toNextLevelPercent { get; set; }
        public int internalUpdateCount { get; set; }
        public Bans bans { get; set; }
        public Rank rank { get; set; }
        public Arena arena { get; set; }
        public Battlepass battlepass { get; set; }
    }

    public class Realtime
    {
        public string lobbyState { get; set; }
        public int isOnline { get; set; }
        public int isInGame { get; set; }
        public int canJoin { get; set; }
        public int partyFull { get; set; }
        public string selectedLegend { get; set; }
    }

    public class ImgAssets
    {
        public string icon { get; set; }
        public string banner { get; set; }
    }

    public class Selected
    {
        public string LegendName { get; set; }
        public List<object> data { get; set; }
        public ImgAssets ImgAssets { get; set; }
    }

    public class Revenant
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Crypto
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Horizon
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Gibraltar
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Wattson
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Fuse
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Bangalore
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Datum
    {
        public string name { get; set; }
        public int value { get; set; }
        public string key { get; set; }
    }

    public class Wraith
    {
        public List<Datum> data { get; set; }
        public ImgAssets ImgAssets { get; set; }
    }

    public class Octane
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Bloodhound
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Caustic
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Lifeline
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Pathfinder
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Loba
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Mirage
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Rampart
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Valkyrie
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Seer
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class Ash
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class MadMaggie
    {
        public ImgAssets ImgAssets { get; set; }
    }

    public class All
    {
        public Revenant Revenant { get; set; }
        public Crypto Crypto { get; set; }
        public Horizon Horizon { get; set; }
        public Gibraltar Gibraltar { get; set; }
        public Wattson Wattson { get; set; }
        public Fuse Fuse { get; set; }
        public Bangalore Bangalore { get; set; }
        public Wraith Wraith { get; set; }
        public Octane Octane { get; set; }
        public Bloodhound Bloodhound { get; set; }
        public Caustic Caustic { get; set; }
        public Lifeline Lifeline { get; set; }
        public Pathfinder Pathfinder { get; set; }
        public Loba Loba { get; set; }
        public Mirage Mirage { get; set; }
        public Rampart Rampart { get; set; }
        public Valkyrie Valkyrie { get; set; }
        public Seer Seer { get; set; }
        public Ash Ash { get; set; }

        [JsonProperty("Mad Maggie")]
        public MadMaggie MadMaggie { get; set; }
    }

    public class Legends
    {
        public Selected selected { get; set; }
        public All all { get; set; }
    }

    public class RateLimit
    {
        public int max_per_second { get; set; }
        public string current_req { get; set; }
    }

    public class MozambiquehereInternal
    {
        public bool isNewToDB { get; set; }
        public string claimedBy { get; set; }
        public string APIAccessType { get; set; }
        public string ClusterID { get; set; }
        public RateLimit rate_limit { get; set; }
        public string clusterSrv { get; set; }
    }

    public class WinningKills
    {
        public string name { get; set; }
        public int value { get; set; }
    }

    public class Kd
    {
        public string value { get; set; }
        public string name { get; set; }
    }

    public class Total
    {
        public WinningKills winning_kills { get; set; }
        public Kd kd { get; set; }
    }

    

    public class Root
    {
        public ApexApiDataObject apexApiDataObject { get; set; }
    }
}
