using Newtonsoft.Json;
using Prism.Mvvm;

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
    }
}
