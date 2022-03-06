using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lioranboard_1_Json_to_2.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lioranboard_1_Json_to_2.Classes.LB2
{
    public class Lb2Button : BindableBase
    {
        private int _color;
        private int _persistent;
        private string _text;
        private int _releaseDuration;
        private int _queueable;
        private List<Command> _commandList;
        private int _pressType;
        private double _x;
        private int _border;
        private string _image;
        private List<Lb2Trigger> _triggers;
        private string _groupId;
        private int _overlappable;
        private string _initVariable;
        private double _width;
        private object _buttonId;
        private int _buttonDuration;
        private double _y;
        private string _switchDeck;
        private double _height;
        private List<Command> _releaseList;
        private int _functions;
        private int _stretch;

        public Lb2Button()
        {
            command_list = new List<Command>();
            triggers = new List<Lb2Trigger>();
            release_list = new List<Command>();

            image = "";
            group_id = "";
            switch_deck = "";
            width = 0.1;
            height = 0.1;
            x = 0.1;
            y = 0.1;
            persistent = 1;
            border = 2;
            functions = 64;
            init_variable = "";
        }

        public Lb2Button(JObject lb1JObject)
        {
            command_list = new List<Command>();
            triggers = new List<Lb2Trigger>();
            release_list = new List<Command>();

            image = "";
            group_id = "";
            switch_deck = "";
            width = 0.1;
            height = 0.1;
            x = 0.1;
            y = 0.1;
            persistent = 1;
            border = 2;
            functions = 64;
            init_variable = "";


            color = lb1JObject.GetValue("color").Value<int>();
            text = lb1JObject.GetValue("text").Value<string>().Replace(@"\#", "<hash>").Replace("#", "\n").Replace("<hash>", @"\#");
            border = lb1JObject.GetValue("border_size").Value<int>();
            button_id = lb1JObject.GetValue("button_id").Value<string>();
            group_id = lb1JObject.GetValue("group_id").Value<string>();
            image = lb1JObject.GetValue("picture").Value<string>();
            queueable = Parser.GetInt(lb1JObject.GetValue("pubsubqueue"));
        }

        public int color
        {
            get => _color;
            set => SetProperty(ref _color, value);
        }

        public int persistent
        {
            get => _persistent;
            set => SetProperty(ref _persistent, value);
        }

        public string text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public int release_duration
        {
            get => _releaseDuration;
            set => SetProperty(ref _releaseDuration, value);
        }

        public int queueable
        {
            get => _queueable;
            set => SetProperty(ref _queueable, value);
        }

        public List<Command> command_list
        {
            get => _commandList;
            set => SetProperty(ref _commandList, value);
        }

        public int press_type
        {
            get => _pressType;
            set => SetProperty(ref _pressType, value);
        }

        public double x
        {
            get => _x;
            set => SetProperty(ref _x, value);
        }

        public int border
        {
            get => _border;
            set => SetProperty(ref _border, value);
        }

        public string image
        {
            get => _image;
            set => SetProperty(ref _image, value);
        }

        public List<Lb2Trigger> triggers
        {
            get => _triggers;
            set => SetProperty(ref _triggers, value);
        }

        public string group_id
        {
            get => _groupId;
            set => SetProperty(ref _groupId, value);
        }

        public int overlappable
        {
            get => _overlappable;
            set => SetProperty(ref _overlappable, value);
        }

        public string init_variable
        {
            get => _initVariable;
            set => SetProperty(ref _initVariable, value);
        }

        public double width
        {
            get => _width;
            set => SetProperty(ref _width, value);
        }

        public object button_id
        {
            get => _buttonId;
            set => SetProperty(ref _buttonId, value);
        }

        public int button_duration
        {
            get => _buttonDuration;
            set => SetProperty(ref _buttonDuration, value);
        }

        public double y
        {
            get => _y;
            set => SetProperty(ref _y, value);
        }

        public string switch_deck
        {
            get => _switchDeck;
            set => SetProperty(ref _switchDeck, value);
        }

        public double height
        {
            get => _height;
            set => SetProperty(ref _height, value);
        }

        public List<Command> release_list
        {
            get => _releaseList;
            set => SetProperty(ref _releaseList, value);
        }

        public int functions
        {
            get => _functions;
            set => SetProperty(ref _functions, value);
        }

        public int stretch
        {
            get => _stretch;
            set => SetProperty(ref _stretch, value);
        }
    }
}
