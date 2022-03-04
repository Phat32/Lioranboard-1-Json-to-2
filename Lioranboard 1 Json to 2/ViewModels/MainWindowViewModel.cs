using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Lioranboard_1_Json_to_2.Classes.LB2;
using Newtonsoft.Json.Linq;
using Prism.Commands;
using Prism.Mvvm;

namespace Lioranboard_1_Json_to_2.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private Lb2Button _lb2Button;
        private string _lb1Json;
        private string _lb2Json;

        public MainWindowViewModel()
        {
            ConvertJsonCommand = new DelegateCommand(OnConvertJson);

            Lb2Button = new Lb2Button();
        }

        public string Lb1Json
        {
            get => _lb1Json;
            set => SetProperty(ref _lb1Json, value);
        }

        public string Lb2Json
        {
            get => _lb2Json;
            set => SetProperty(ref _lb2Json, value);
        }

        public Lb2Button Lb2Button
        {
            get => _lb2Button;
            set => SetProperty(ref _lb2Button, value);
        }

        public DelegateCommand ConvertJsonCommand { get; }

        private void OnConvertJson()
        {
            try
            {
                Lb2Button = new Lb2Button();
                var lb1JObject = JObject.Parse(Lb1Json);

                Lb2Button.color = lb1JObject.GetValue("color").Value<int>();
                Lb2Button.text = lb1JObject.GetValue("text").Value<string>();
                Lb2Button.border = lb1JObject.GetValue("border_size").Value<int>();
                Lb2Button.button_id = lb1JObject.GetValue("button_id").Value<string>();
                Lb2Button.group_id = lb1JObject.GetValue("group_id").Value<string>();
                Lb2Button.image = lb1JObject.GetValue("picture").Value<string>();

                var commandCount = 0;
                while (lb1JObject.ContainsKey($"websocketaction{commandCount}"))
                {
                    commandCount++;
                }

                var triggerCount = 0;
                while (lb1JObject.ContainsKey($"pubsubaction{triggerCount}"))
                {
                    triggerCount++;
                }

                var keyPressCount = 1;
                while (lb1JObject.ContainsKey($"press{keyPressCount}"))
                {
                    keyPressCount++;
                }

                var soundCount = 1;
                while (lb1JObject.ContainsKey($"sound_path{soundCount}"))
                {
                    soundCount++;
                }

                for (int i = 0; i < commandCount; i++)
                {
                    var command = new Command(lb1JObject, i);

                    if (command.cmd > 0)
                    {
                        Lb2Button.command_list.Add(command);
                    }
                    else if (command.cmd == -2 || command.cmd == -3)
                    {
                        var previousCommand = Lb2Button.command_list.LastOrDefault();

                        switch (previousCommand.v2)
                        {
                            case 1:
                                previousCommand.b3 = command.b0;
                                previousCommand.b4 = command.b1;
                                previousCommand.b5 = command.b2;
                                previousCommand.v4 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 2:
                                previousCommand.b6 = command.b0;
                                previousCommand.b7 = command.b1;
                                previousCommand.b8 = command.b2;
                                previousCommand.v5 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 3:
                                previousCommand.b9 = command.b0;
                                previousCommand.b10 = command.b1;
                                previousCommand.b11 = command.b2;
                                previousCommand.v6 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 4:
                                previousCommand.b12 = command.b0;
                                previousCommand.b13 = command.b1;
                                previousCommand.b14 = command.b2;
                                previousCommand.v7 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 5:
                                previousCommand.b15 = command.b0;
                                previousCommand.b16 = command.b1;
                                previousCommand.b17 = command.b2;
                                previousCommand.v8 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 6:
                                previousCommand.b18 = command.b0;
                                previousCommand.b19 = command.b1;
                                previousCommand.b20 = command.b2;
                                previousCommand.v9 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 7:
                                previousCommand.b21 = command.b0;
                                previousCommand.b22 = command.b1;
                                previousCommand.b23 = command.b2;
                                previousCommand.v10 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 8:
                                previousCommand.b24 = command.b0;
                                previousCommand.b25 = command.b1;
                                previousCommand.b26 = command.b2;
                                previousCommand.v11 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 9:
                                previousCommand.b27 = command.b0;
                                previousCommand.b28 = command.b1;
                                previousCommand.b29 = command.b2;
                                previousCommand.v12 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 10:
                                previousCommand.b30 = command.b0;
                                previousCommand.b31 = command.b1;
                                previousCommand.b32 = command.b2;
                                previousCommand.v13 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 11:
                                previousCommand.b33 = command.b0;
                                previousCommand.b34 = command.b1;
                                previousCommand.b35 = command.b2;
                                previousCommand.v14 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 12:
                                previousCommand.b36 = command.b0;
                                previousCommand.b37 = command.b1;
                                previousCommand.b38 = command.b2;
                                previousCommand.v15 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 13:
                                previousCommand.b39 = command.b0;
                                previousCommand.b40 = command.b1;
                                previousCommand.b41 = command.b2;
                                previousCommand.v16 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 14:
                                previousCommand.b42 = command.b0;
                                previousCommand.b43 = command.b1;
                                previousCommand.b44 = command.b2;
                                previousCommand.v17 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 15:
                                previousCommand.b45 = command.b0;
                                previousCommand.b46 = command.b1;
                                previousCommand.b47 = command.b2;
                                previousCommand.v18 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 16:
                                previousCommand.b48 = command.b0;
                                previousCommand.b49 = command.b1;
                                previousCommand.b50 = command.b2;
                                previousCommand.v19 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 17:
                                previousCommand.b51 = command.b0;
                                previousCommand.b52 = command.b1;
                                previousCommand.b53 = command.b2;
                                previousCommand.v20 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 18:
                                previousCommand.b54 = command.b0;
                                previousCommand.b55 = command.b1;
                                previousCommand.b56 = command.b2;
                                previousCommand.v21 = command.cmd == -2 ? 2 : 1;
                                break;
                            case 19:
                                previousCommand.b57 = command.b0;
                                previousCommand.b58 = command.b1;
                                previousCommand.b59 = command.b2;
                                previousCommand.v22 = command.cmd == -2 ? 2 : 1;
                                break;
                        }
                        previousCommand.v2 = (int)previousCommand.v2 + 1;
                        previousCommand.v0 = (int) previousCommand.v0 - 1;
                        previousCommand.xpan += 25;
                    }
                    else
                    {
                        Lb2Button.command_list.Add(new Command
                        {
                            cmd = 4,
                            pos = i,
                            b0 = "This function from LB1 does not exist in LB2... Or it was a lot of work to make the import and I am lazy.",
                            v0 = 0
                        });
                    }
                }

                if (Lb2Button.command_list.Count > 0)
                {
                    Lb2Button.functions = 65;
                }

                for (int i = 0; i < triggerCount; i++)
                {
                    var trigger = new Lb2Trigger();

                    switch (lb1JObject.GetValue($"pubsubaction{i}").Value<int>())
                    {
                        case 0:
                            trigger.trg = 5;
                            trigger.minimum = lb1JObject.GetValue($"pubsubbitsmin{i}").Value<int>();
                            trigger.maximum = lb1JObject.GetValue($"pubsubbitsmax{i}").Value<int>();
                            break;
                        case 1:
                            trigger.trg = 1;
                            trigger.tier1 = lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 1 || lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 17 || lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 33;
                            trigger.tier2 = lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 2 || lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 18 || lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 34;
                            trigger.tier3 = lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 3 || lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 20 || lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 36;
                            trigger.prime = lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 8;
                            trigger.subgift = lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 17 || lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 18 || lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 20;
                            trigger.anonsubgift = lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 33 || lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 34 || lb1JObject.GetValue($"pubsubsubs{i}").Value<int>() == 36;
                            trigger.minimum = 1;
                            trigger.maximum = 2;
                            break;
                        case 2:
                            trigger.trg = 3;
                            trigger.redeemname = lb1JObject.GetValue($"pubsubredeem{i}").Value<string>();
                            trigger.message = "*";
                            trigger.requireinput = false;
                            trigger.allow_empty_wildcard = false;
                            trigger.case_sensitive = false;
                            break;
                        case 3:
                            trigger.trg = 0;
                            trigger.sub = lb1JObject.GetValue($"pubsubchattype{i}").Value<int>() == 4;
                            trigger.case_sensitive = lb1JObject.GetValue($"pubsubchattype{i}").Value<int>() == 32 || lb1JObject.GetValue($"pubsubchattype{i}").Value<int>() == 40 || lb1JObject.GetValue($"pubsubchattype{i}").Value<int>() == 48;
                            trigger.founder = lb1JObject.GetValue($"pubsubchattype{i}").Value<int>() == 2;
                            trigger.message = "*";
                            trigger.moderator = lb1JObject.GetValue($"pubsubchattype{i}").Value<int>() == 1;
                            trigger.vip = lb1JObject.GetValue($"pubsubchattype{i}").Value<int>() == 8 || lb1JObject.GetValue($"pubsubchattype{i}").Value<int>() == 40;
                            trigger.broadcaster = lb1JObject.GetValue($"pubsubchattype{i}").Value<int>() == 16 || lb1JObject.GetValue($"pubsubchattype{i}").Value<int>() == 48;
                            trigger.allow_empty_wildcard = false;
                            break;
                        case 4:
                            trigger.trg = 3;
                            trigger.minimum = lb1JObject.GetValue($"pubsubhostmin{i}").Value<int>();
                            trigger.maximum = lb1JObject.GetValue($"pubsubhostmax{i}").Value<int>();
                            break;
                        case 5:
                            trigger.trg = 3;
                            trigger.minimum = lb1JObject.GetValue($"pubsubhostmin{i}").Value<int>();
                            trigger.maximum = lb1JObject.GetValue($"pubsubhostmax{i}").Value<int>();
                            break;
                        case 6:
                            trigger.trg = 3;
                            trigger.redeemname = lb1JObject.GetValue($"pubsubredeem{i}").Value<string>();
                            trigger.message = lb1JObject.GetValue($"pubsubredeemmessage{i}").Value<string>();
                            trigger.requireinput = true;
                            trigger.allow_empty_wildcard = false;
                            trigger.case_sensitive = false;
                            break;
                        case 8:
                            trigger.trg = 2;
                            trigger.tier1 = true;
                            trigger.tier2 = true;
                            trigger.tier3 = true;
                            trigger.minimum = lb1JObject.GetValue($"pubsubsubsmin{i}").Value<int>();
                            trigger.maximum = lb1JObject.GetValue($"pubsubsubsmax{i}").Value<int>();
                            break;
                    }

                    Lb2Button.triggers.Add(trigger);
                }

                for (int i = 1; i < keyPressCount; i++)
                {
                    var command = new Command();
                    command.KeyboardCommand(lb1JObject, i, Lb2Button.command_list.Count);

                    Lb2Button.command_list.Add(command);
                }

                for (int i = 1; i < soundCount; i++)
                {
                    var command = new Command();
                    command.SoundCommand(lb1JObject, i, Lb2Button.command_list.Count);
                    Lb2Button.command_list.Add(command);

                    if (lb1JObject.GetValue($"soundpitch{i}").Value<int>() != 100)
                    {
                        var speedCommand = new Command();
                        speedCommand.SoundSpeedCommand(lb1JObject, i, Lb2Button.command_list.Count);
                        Lb2Button.command_list.Add(speedCommand);
                    }
                }

                if (lb1JObject.ContainsKey("stopsoundfade"))
                {
                    var command = new Command();
                    command.SoundStopCommand(lb1JObject, Lb2Button.command_list.Count);
                    Lb2Button.command_list.Add(command);
                }

                Lb2Json = JObject.FromObject(Lb2Button).ToString();

                MessageBox.Show("Button converted! (not all functions are supported, please double check the button once imported).\r\n\r\n Please be aware that the Button ID will not import and will take whatever the next available ID is. Please go into the button to edit the ID as needed.", "LB1 to LB2 Success!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error processing the LB1 JSON. Please check the export and try again",
                    "Error Parsing LB1 JSON", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
