using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Lioranboard_1_Json_to_2.Classes.LB2;
using Lioranboard_1_Json_to_2.Helper;
using Newtonsoft.Json.Linq;
using Notifications.Wpf;
using Prism.Commands;
using Prism.Mvvm;

namespace Lioranboard_1_Json_to_2.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private Lb2Button _lb2Button;
        private string _lb1Json;
        private string _lb2Json;
        private bool _showConvertedPopup;
        private bool _isLocalVariable;

        public MainWindowViewModel()
        {
            ConvertJsonCommand = new DelegateCommand(OnConvertJson);
            ClearJsonCommand = new DelegateCommand(OnClearJson);
            notificationManager = new NotificationManager();

                Lb2Button = new Lb2Button();
            ShowConvertedPopup = true;
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

        public bool ShowConvertedPopup
        {
            get => _showConvertedPopup;
            set
            {
                SetProperty(ref _showConvertedPopup, value);

                if (_showConvertedPopup == false)
                {
                    ToastAlert("Keep in mind","Please remember to double check your buttons in LB2 after importing them", NotificationType.Warning);
                }
            } 
        }

        public bool IsLocalVariable
        {
            get => _isLocalVariable;
            set
            {
                SetProperty(ref _isLocalVariable, value);

                if (_isLocalVariable)
                {
                    ToastAlert("Keep in mind", "LB1 used Global variables, just be aware of this fact when importing");
                }
            }
        }

        public DelegateCommand ConvertJsonCommand { get; }

        public DelegateCommand ClearJsonCommand { get; }

        private NotificationManager notificationManager;

        private void ToastAlert(string title, string message, NotificationType type  = NotificationType.Information)
        {
            notificationManager.Show(
                new NotificationContent { Title = title, Message = message, Type = type},
                areaName: "WindowArea");
        }

        private void OnConvertJson()
        {
            try
            {
                var lb1JObject = JObject.Parse(Lb1Json);

                Lb2Button = new Lb2Button(lb1JObject);

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

                for (var i = 0; i < commandCount; i++)
                {
                    var command = new Command(lb1JObject, i);

                    if (command.cmd > 0)
                    {
                        if (command.cmd == 161 && IsLocalVariable)
                        {
                            command.cmd = 15;
                        }

                        Lb2Button.command_list.Add(command);
                    }
                    else if (command.cmd == -2 || command.cmd == -3)
                    {
                        var previousCommand = Lb2Button.command_list.LastOrDefault();

                        if (previousCommand == null)
                        {
                            continue;
                        }

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

                        previousCommand.v2 = (int) previousCommand.v2 + 1;

                        if (previousCommand.cmd == 7)
                        {
                            previousCommand.v0 = (int) previousCommand.v0 - 1;
                        }


                        previousCommand.xpan += 25;
                    }
                    else
                    {
                        command.CommentCommand(lb1JObject, i, "This function from LB1 does not exist in LB2... Or it was a lot of work to make the import and I am lazy.");
                        Lb2Button.command_list.Add(command);
                    }
                }

                if (Lb2Button.command_list.Count > 0)
                {
                    Lb2Button.functions = 65;
                }

                for (var i = 0; i < triggerCount; i++)
                {
                    var trigger = new Lb2Trigger(lb1JObject, i);
                    if (trigger.trg >= 0 && !Lb2Button.triggers.Contains(trigger))
                    {
                        Lb2Button.triggers.Add(trigger);
                    }
                }

                for (var i = 1; i < keyPressCount; i++)
                {
                    var command = new Command();
                    command.KeyboardCommand(lb1JObject, i, Lb2Button.command_list.Count);

                    Lb2Button.command_list.Add(command);
                }

                for (var i = 1; i < soundCount; i++)
                {
                    var command = new Command();
                    command.SoundCommand(lb1JObject, i, Lb2Button.command_list.Count);
                    Lb2Button.command_list.Add(command);

                    if (Parser.GetInt(lb1JObject.GetValue($"soundpitch{i}")) == 100)
                    {
                        continue;
                    }

                    var speedCommand = new Command();
                    speedCommand.SoundSpeedCommand(lb1JObject, i, Lb2Button.command_list.Count);
                    Lb2Button.command_list.Add(speedCommand);
                }

                if (lb1JObject.ContainsKey("stopsoundfade"))
                {
                    var command = new Command();
                    command.SoundStopCommand(lb1JObject, Lb2Button.command_list.Count);
                    Lb2Button.command_list.Add(command);
                }

                if (lb1JObject.ContainsKey("switchdeck"))
                {
                    if (Parser.GetInt(lb1JObject.GetValue("switchdeck")) == -1)
                    {
                        Lb2Button.switch_deck = "Next Deck";
                    }
                    else if (Parser.GetInt(lb1JObject.GetValue("switchdeck")) == -2)
                    {
                        Lb2Button.switch_deck = "Previous Deck";
                    }
                }

                Lb2Button.press_type = Parser.GetInt(lb1JObject.GetValue("activepress"));

                Lb2Json = JObject.FromObject(Lb2Button).ToString();

                ToastAlert("Success", "JSON Successfully Converted", NotificationType.Success);

                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(Lb2Json, TextDataFormat.Text);
                    ToastAlert("FYI", "LB2 JSON copied to Clipboard");
                }
                catch (Exception)
                {
                    ToastAlert("Uh-oh...","There was an error copying the LB2 JSON to the Clipboard. Please highlight and copy the LB2 JSON manually.", NotificationType.Error);
                }

                if (ShowConvertedPopup)
                {
                    MessageBox.Show("Button converted! (not all functions are supported, please double check the button once imported).\r\n\r\n Please be aware that the Button ID will not import and will take whatever the next available ID is. Please go into the button to edit the ID as needed.", "LB1 to LB2 Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception)
            {
                ToastAlert("Something is wrong","Error occurred during the Conversion", NotificationType.Error);
                MessageBox.Show("There was an error processing the LB1 JSON. Please check the export and try again",
                    "Error Parsing LB1 JSON", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OnClearJson()
        {
            Lb1Json = string.Empty;
            Lb2Json = string.Empty;
            Lb2Button = new Lb2Button();
            IsLocalVariable = false;
        }
    }
}
