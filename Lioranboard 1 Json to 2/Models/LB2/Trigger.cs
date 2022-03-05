using Lioranboard_1_Json_to_2.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Prism.Mvvm;
// ReSharper disable InconsistentNaming

namespace Lioranboard_1_Json_to_2.Classes.LB2
{
    public class Lb2Trigger : BindableBase
    {
        private bool _anonsubgift;
        private bool _tier2;
        private bool _subgift;
        private bool _normalsub;
        private int _monthmax;
        private bool _prime;
        private bool _allowcommunity;
        private bool _tier3;
        private bool _tier1;
        private string _trigger_type;
        private int _trg;
        private bool _monthrange;
        private int _monthmin;
        private int _minimum;
        private int _maximum;
        private bool _requireinput;
        private bool _caseSensitive;
        private string _message;
        private string _redeemname;
        private bool _allowEmptyWildcard;
        private bool _sub;
        private bool _founder;
        private bool _moderator;
        private bool _vip;
        private bool _broadcaster;

        public Lb2Trigger(JObject lb1JObject, int index)
        {
            switch (Parser.GetInt(lb1JObject.GetValue($"pubsubaction{index}")))
            {
                case 0:
                    trg = 5;
                    minimum = Parser.GetInt(lb1JObject.GetValue($"pubsubbitsmin{index}"));
                    maximum = Parser.GetInt(lb1JObject.GetValue($"pubsubbitsmax{index}"));
                    break;
                case 1:
                    trg = 1;

                    var subId = Parser.GetInt(lb1JObject.GetValue($"pubsubsubs{index}"));

                    tier1 = subId == 1 || subId == 17 || subId == 33;
                    tier2 = subId == 2 || subId == 18 || subId == 34;
                    tier3 = subId == 3 || subId == 20 || subId == 36;
                    prime = subId == 8;
                    subgift = subId == 17 || subId == 18 || subId == 20;
                    anonsubgift = subId == 33 || subId == 34 || subId == 36;
                    minimum = 1;
                    maximum = 2;
                    break;
                case 2:
                    trg = 3;
                    redeemname = lb1JObject.GetValue($"pubsubredeem{index}").Value<string>();
                    message = "*";
                    requireinput = false;
                    allow_empty_wildcard = false;
                    case_sensitive = false;
                    break;
                case 3:
                    trg = 0;
                    var chatTypeId = Parser.GetInt(lb1JObject.GetValue($"pubsubchattype{index}").Value<int>());

                    sub = chatTypeId == 4;
                    case_sensitive = chatTypeId == 32 || chatTypeId == 40 || chatTypeId == 48;
                    founder = chatTypeId == 2;
                    message = "*";
                    moderator = chatTypeId == 1;
                    vip = chatTypeId == 8 || chatTypeId == 40;
                    broadcaster = chatTypeId == 16 || chatTypeId == 48;
                    allow_empty_wildcard = false;
                    message = lb1JObject.GetValue($"pubsubchat{index}").Value<string>();
                    break;
                case 4:
                    trg = 14;
                    minimum = Parser.GetInt(lb1JObject.GetValue($"pubsubhostmin{index}").Value<int>());
                    maximum = Parser.GetInt(lb1JObject.GetValue($"pubsubhostmax{index}").Value<int>());
                    break;
                case 5:
                    trg = 4;
                    minimum = Parser.GetInt(lb1JObject.GetValue($"pubsubraidmin{index}").Value<int>());
                    maximum = Parser.GetInt(lb1JObject.GetValue($"pubsubraidmax{index}").Value<int>());
                    break;
                case 6:
                    trg = 3;
                    redeemname = lb1JObject.GetValue($"pubsubredeem{index}").Value<string>();
                    message = lb1JObject.GetValue($"pubsubredeemmessage{index}").Value<string>();
                    requireinput = true;
                    allow_empty_wildcard = false;
                    case_sensitive = false;
                    break;
                case 7:
                    var trigger = lb1JObject.GetValue($"extensiontrigger{index}").Value<string>();
                    switch (trigger)
                    {
                        case "!initlioranboard":
                            trg = 10;
                            trigger_type = "Lioranboard Startup";
                            break;
                        case "!reinitializing":
                            trg = 10;
                            trigger_type = "Lioranboard Deck Reload";
                            break;
                        case "!resetlioranboard":
                            trg = 10;
                            trigger_type = "Lioranboard Reset";
                            break;
                        case "!obsalways":
                        case "!obsconnected":
                            trg = 10;
                            trigger_type = "OBS Connected";
                            break;
                        case "!twitchalways":
                        case "!twitchconnected":
                            trg = 10;
                            trigger_type = "Twitch Connected";
                            break;
                        case "!transmitteralways":
                        case "!transmitterconnected":
                            trg = 10;
                            trigger_type = "Streamdeck/Transmitter Connected";
                            break;
                        case "!ban":
                        case "!unban":
                        case "!timeout":
                        case "!untimedout":
                        case "!clearchat":
                            trg = 0;
                            break;
                        default:
                            trg = 12;
                            case_sensitive = false;
                            allow_empty_wildcard = false;
                            message = trigger;
                            break;
                    }
                    break;
                case 8:
                    trg = 2;
                    tier1 = true;
                    tier2 = true;
                    tier3 = true;
                    minimum = Parser.GetInt(lb1JObject.GetValue($"pubsubsubsmin{index}").Value<int>());
                    maximum = Parser.GetInt(lb1JObject.GetValue($"pubsubsubsmax{index}").Value<int>());
                    break;
            }
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool anonsubgift
        {
            get => _anonsubgift;
            set => SetProperty(ref _anonsubgift, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool tier2
        {
            get => _tier2;
            set => SetProperty(ref _tier2, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool subgift
        {
            get => _subgift;
            set => SetProperty(ref _subgift, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool normalsub
        {
            get => _normalsub;
            set => SetProperty(ref _normalsub, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int monthmax
        {
            get => _monthmax;
            set => SetProperty(ref _monthmax, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool prime
        {
            get => _prime;
            set => SetProperty(ref _prime, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool allowcommunity
        {
            get => _allowcommunity;
            set => SetProperty(ref _allowcommunity, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool tier3
        {
            get => _tier3;
            set => SetProperty(ref _tier3, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool tier1
        {
            get => _tier1;
            set => SetProperty(ref _tier1, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string trigger_type
        {
            get => _trigger_type;
            set => SetProperty(ref _trigger_type, value);
        }

        public int trg
        {
            get => _trg;
            set => SetProperty(ref _trg, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool monthrange
        {
            get => _monthrange;
            set => SetProperty(ref _monthrange, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int monthmin
        {
            get => _monthmin;
            set => SetProperty(ref _monthmin, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int minimum
        {
            get => _minimum;
            set => SetProperty(ref _minimum, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int maximum
        {
            get => _maximum;
            set => SetProperty(ref _maximum, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool requireinput
        {
            get => _requireinput;
            set => SetProperty(ref _requireinput, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool case_sensitive
        {
            get => _caseSensitive;
            set => SetProperty(ref _caseSensitive, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string redeemname
        {
            get => _redeemname;
            set => SetProperty(ref _redeemname, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool allow_empty_wildcard
        {
            get => _allowEmptyWildcard;
            set => SetProperty(ref _allowEmptyWildcard, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool sub
        {
            get => _sub;
            set => SetProperty(ref _sub, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool founder
        {
            get => _founder;
            set => SetProperty(ref _founder, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool moderator
        {
            get => _moderator;
            set => SetProperty(ref _moderator, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool vip
        {
            get => _vip;
            set => SetProperty(ref _vip, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool broadcaster
        {
            get => _broadcaster;
            set => SetProperty(ref _broadcaster, value);
        }

        public override bool Equals(object obj)
        {
            var testTrig = obj as Lb2Trigger;

            if (testTrig.trg == 10)
            {
                return testTrig.trg == trg && testTrig.trigger_type == trigger_type;
            }

            return base.Equals(obj);
        }
    }
}
