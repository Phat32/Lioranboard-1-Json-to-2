using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Lioranboard_1_Json_to_2.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prism.Mvvm;

namespace Lioranboard_1_Json_to_2.Classes.LB2
{
    public partial class Command : BindableBase
    {
        private int _cmd;
        private string _obsid;
        private int _pos;
        private object _vis;
        private int _ms;
        private int _sel;
        private int _dis;
        private int _xpan;
        private object _b0;
        private object _b1;
        private object _b2;
        private object _b3;
        private object _b4;
        private object _b5;
        private object _b6;
        private object _b7;
        private object _b8;
        private object _b9;
        private object _b10;
        private object _b11;
        private object _b12;
        private object _b13;
        private object _b14;
        private object _b15;
        private object _b16;
        private object _b17;
        private object _b18;
        private object _b19;
        private object _b20;
        private object _b21;
        private object _b22;
        private object _b23;
        private object _b24;
        private object _b25;
        private object _b26;
        private object _b27;
        private object _b28;
        private object _b29;
        private object _b30;
        private object _b31;
        private object _b32;
        private object _b33;
        private object _b34;
        private object _b35;
        private object _b36;
        private object _b37;
        private object _b38;
        private object _b39;
        private object _b40;
        private object _b41;
        private object _b42;
        private object _b43;
        private object _b44;
        private object _b45;
        private object _b46;
        private object _b47;
        private object _b48;
        private object _b49;
        private object _b50;
        private object _b51;
        private object _b52;
        private object _b53;
        private object _b54;
        private object _b55;
        private object _b56;
        private object _b57;
        private object _b58;
        private object _b59;
        private object _v0;
        private object _v1;
        private object _v2;
        private object _v3;
        private object _v4;
        private object _v5;
        private object _v6;
        private object _v7;
        private object _v8;
        private object _v9;
        private object _v10;
        private object _v11;
        private object _v12;
        private object _v13;
        private object _v14;
        private object _v15;
        private object _v16;
        private object _v17;
        private object _v18;
        private object _v19;
        private object _v20;
        private object _v21;
        private object _v22;

        public Command()
        {
            obsid = "Main";
            vis = 1;
            ms = 0;
            sel = 0;
            dis = 0;
            xpan = 0;
        }

        public Command(JObject lb1JObject, int position)
        {
            obsid = "Main";
            vis = 1;
            ms = lb1JObject.GetValue($"websocketdelay{position}").Value<int>();
            sel = 0;
            dis = 0;
            xpan = 0;
            cmd = LB1Converters.CommandId(lb1JObject.GetValue($"websocketaction{position}").Value<int>());
            pos = position;

            InitializeCommand(lb1JObject, position);
        }

        public void KeyboardCommand(JObject lb1JObject, int index, int position)
        {
            cmd = 3;
            ms = Parser.GetInt(lb1JObject.GetValue($"pressdelay{index}"));
            pos = position;
            InitializeCommand(lb1JObject, index);
        }

        public void SoundCommand(JObject lb1JObject, int index, int position)
        {
            cmd = 2;
            ms = Parser.GetInt(lb1JObject.GetValue($"sounddelay{index}"));
            pos = position;
            InitializeCommand(lb1JObject, index);
        }

        public void SoundSpeedCommand(JObject lb1JObject, int index, int position)
        {
            cmd = 191;
            ms = Parser.GetInt(lb1JObject.GetValue($"sounddelay{index}"));
            pos = position;
            InitializeCommand(lb1JObject, index);
        }

        public void SoundStopCommand(JObject lb1JObject, int position)
        {
            cmd = 146;
            ms = Parser.GetInt(lb1JObject.GetValue("stopsoundfade"));
            pos = position;
            InitializeCommand(lb1JObject, 0);
        }

        public void CommentCommand(JObject lb1JObject, int position, string comment)
        {
            Initialize();

            cmd = 4;
            pos = position;
            b0 = comment;
            v0 = 0;
        }

        private void Initialize()
        {
            obsid = "Main";
            vis = 1;
            ms = 0;
            sel = 0;
            dis = 0;
            xpan = 0;
            cmd = 0;
            pos = 0;
            b0 = null;
            b1 = null;
            b2 = null;
            b3 = null;
            b4 = null;
            b4 = null;
            b5 = null;
            b6 = null;
            b7 = null;
            b8 = null;
            b9 = null;
            b10 = null;
            b11 = null;
            b12 = null;
            b13 = null;
            b14 = null;
            b15 = null;
            b16 = null;
            b17 = null;
            b18 = null;
            b19 = null;
            b20 = null;
            b21 = null;
            b22 = null;
            b23 = null;
            b24 = null;
            b25 = null;
            b26 = null;
            b27 = null;
            b28 = null;
            b29 = null;
            b30 = null;
            b31 = null;
            b32 = null;
            b33 = null;
            b34 = null;
            b35 = null;
            b36 = null;
            b37 = null;
            b38 = null;
            b39 = null;
            b40 = null;
            b41 = null;
            b42 = null;
            b43 = null;
            b44 = null;
            b45 = null;
            b46 = null;
            b47 = null;
            b48 = null;
            b49 = null;
            b50 = null;
            b51 = null;
            b52 = null;
            b53 = null;
            b54 = null;
            b55 = null;
            b56 = null;
            b57 = null;
            b58 = null;
            b59 = null;
            v0 = null;
            v1 = null;
            v2 = null;
            v3 = null;
            v4 = null;
            v4 = null;
            v5 = null;
            v6 = null;
            v7 = null;
            v8 = null;
            v9 = null;
            v10 = null;
            v11 = null;
            v12 = null;
            v13 = null;
            v14 = null;
            v15 = null;
            v16 = null;
            v17 = null;
            v18 = null;
            v19 = null;
            v20 = null;
            v21 = null;
            v22 = null;
        }

        private void InitializeCommand(JObject lb1JObject, int position)
        {
            switch (cmd)
            {
                case -15:
                    CommentCommand(lb1JObject, position, "Extensions have been redone and this does not import easily. Please remake this command.");
                    break;

                case -14:
                    CommentCommand(lb1JObject, position, "Save Replay Buffer was removed as command in LB2 but is still useable via the Custom Packet Command");
                    break;

                case -13:
                    CommentCommand(lb1JObject, position, "Stop Replay Buffer was removed as command in LB2 but is still useable via the Custom Packet Command");
                    break;

                case -12:
                    CommentCommand(lb1JObject, position, "Start Replay Buffer was removed as command in LB2 but is still useable via the Custom Packet Command");
                    break;

                case -11:
                    CommentCommand(lb1JObject, position, "Toggle Replay Buffer was removed as command in LB2 but is still useable via the Custom Packet Command");
                    break;

                case -10:
                    CommentCommand(lb1JObject, position, "OBS Pull Filer Visibility was removed as command in LB2 but is still useable via the Custom Packet Command");
                    break;

                case -9:
                    CommentCommand(lb1JObject, position, "Set Transition Bar Position was removed as command in LB2 but is still useable via the Custom Packet Command");
                    break;

                case -8:
                    CommentCommand(lb1JObject, position, "Release Transition was removed as command in LB2 but is still useable via the Custom Packet Command");
                    break;

                case -7:
                    cmd = 161;
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();

                    switch (b1)
                    {
                        case "= String":
                            b1 = "=";
                            break;
                        case "+= String":
                            b1 = "+=";
                            break;
                        case "Multiply":
                            b1 = "*=";
                            break;
                        case "Divide":
                            b1 = "/=";
                            break;
                        case "DIV":
                            b1 = "div";
                            break;
                        case "MOD":
                            b1 = "mod";
                            break;
                        case "bottom":
                            b1 = "0";
                            break;
                        case "cos":
                            CommentCommand(lb1JObject, position, "cos has been removed and is not supposed by LB2");
                            break;
                        case "sin":
                            CommentCommand(lb1JObject, position, "sin has been removed and is not supposed by LB2");
                            break;
                        case "tan":
                            CommentCommand(lb1JObject, position, "tan has been removed and is not supposed by LB2");
                            break;
                    }
                    break;

                case -6:
                    CommentCommand(lb1JObject, position, "Compare: Redo Previous If is deperated in LB1 and there for not importable to LB2");
                    break;


                case 166:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>(); 
                    b2 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    break;


                case 68:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = Parser.GetRemoveVariableSign(lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>());
                    break;

                case -2:
                case -3:
                case 33:
                case 76:
                case 96:
                case 98:
                case 99:
                case 101:
                case 161:
                case 162:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    
                    if (!Parser.GetBool(lb1JObject.GetValue($"websocketvalue4_{position}")) && b1.ToString().Contains("String"))
                    {
                        b2 = $"\"{b2}\"";
                    }

                    switch (b1)
                    {
                        case "= String":
                            b1 = "=";
                            break;
                        case "+= String":
                            b1 = "+=";
                            break;
                        case "Multiply":
                            b1 = "*=";
                            break;
                        case "Divide":
                            b1 = "/=";
                            break;
                        case "DIV":
                            b1 = "div";
                            break;
                        case "MOD":
                            b1 = "mod";
                            break;
                        case "bottom":
                            b1 = "0";
                            break;
                        case "cos":
                            CommentCommand(lb1JObject, position, "cos has been removed and is not supposed by LB2");
                            break;
                        case "sin":
                            CommentCommand(lb1JObject, position, "sin has been removed and is not supposed by LB2");
                            break;
                        case "tan":
                            CommentCommand(lb1JObject, position, "tan has been removed and is not supposed by LB2");
                            break;
                    }
                    break;

                case 1:
                case 17:
                case 43:
                case 45:
                case 52:
                case 53:
                case 54:
                case 55:
                case 69:
                case 70:
                case 71:
                case 73:
                case 78:
                case 106:
                case 107:
                case 109:
                case 134:
                case 135:
                case 136:
                case 142:
                case 150:
                case 151:
                case 170:
                case 190:
                case 227:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    break;
                case 137:
                    b0 = Parser.GetRemoveVariableSign(lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>());
                    break;

                case 146:
                    b0 = "all";
                    break;

                case 2:
                    b0 = lb1JObject.GetValue($"sound_path{position}").Value<string>();
                    b1 = $"sound{position}";
                    v0 = Parser.GetDouble(lb1JObject.GetValue($"volume{position}"));
                    break;

                case 191:
                    b0 = $"sound{position}";
                    b1 = lb1JObject.GetValue($"soundpitch{position}").Value<string>();
                    break;

                case 3:
                    
                    b0 = lb1JObject.GetValue($"pressduration{position}").Value<string>();
                    v0 = Parser.GetInt(lb1JObject.GetValue($"press{position}"));
                    v1 = false;
                    v2 = false;
                    v3 = false;
                    break;

                case 6:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    v0 = 0;
                    break;

                case 7:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b3 = "";
                    b4 = "==";
                    b5 = "";
                    b6 = "";
                    b7 = "==";
                    b8 = "";
                    b9 = "";
                    b10 = "==";
                    b11 = "";
                    b12 = "";
                    b13 = "==";
                    b14 = "";
                    b15 = "";
                    b16 = "==";
                    b17 = "";
                    b18 = "";
                    b19 = "==";
                    b20 = "";
                    b21 = "";
                    b22 = "==";
                    b23 = "";
                    b24 = "";
                    b25 = "==";
                    b26 = "";
                    b27 = "";
                    b28 = "==";
                    b29 = "";
                    b30 = "";
                    b31 = "==";
                    b32 = "";
                    b33 = "";
                    b34 = "==";
                    b35 = "";
                    b36 = "";
                    b37 = "==";
                    b38 = "";
                    b39 = "";
                    b40 = "==";
                    b41 = "";
                    b42 = "";
                    b43 = "==";
                    b44 = "";
                    b45 = "";
                    b46 = "==";
                    b47 = "";
                    b48 = "";
                    b49 = "==";
                    b50 = "";
                    b51 = "";
                    b52 = "==";
                    b53 = "";
                    b54 = "";
                    b55 = "==";
                    b56 = "";
                    b57 = "";
                    b58 = "==";
                    b59 = "";

                    v0 = Parser.GetInt(lb1JObject.GetValue($"websocketvalue4_{position}"));
                    v1 = Parser.GetInt(lb1JObject.GetValue($"websocketvalue5_{position}"));
                    v2 = 1;
                    v3 = 0;
                    v4 = 0;
                    v5 = 0;
                    v6 = 0;
                    v7 = 0;
                    v8 = 0;
                    v9 = 0;
                    v10 = 0;
                    v11 = 0;
                    v12 = 0;
                    v13 = 0;
                    v14 = 0;
                    v15 = 0;
                    v16 = 0;
                    v17 = 0;
                    v18 = 0;
                    v19 = 0;
                    v20 = 0;
                    v21 = 0;
                    v22 = 0;
                    break;

                case 11:
                case 12:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b3 = "";
                    b4 = "==";
                    b5 = "";
                    b6 = "";
                    b7 = "==";
                    b8 = "";
                    b9 = "";
                    b10 = "==";
                    b11 = "";
                    b12 = "";
                    b13 = "==";
                    b14 = "";
                    b15 = "";
                    b16 = "==";
                    b17 = "";
                    b18 = "";
                    b19 = "==";
                    b20 = "";
                    b21 = "";
                    b22 = "==";
                    b23 = "";
                    b24 = "";
                    b25 = "==";
                    b26 = "";
                    b27 = "";
                    b28 = "==";
                    b29 = "";
                    b30 = "";
                    b31 = "==";
                    b32 = "";
                    b33 = "";
                    b34 = "==";
                    b35 = "";
                    b36 = "";
                    b37 = "==";
                    b38 = "";
                    b39 = "";
                    b40 = "==";
                    b41 = "";
                    b42 = "";
                    b43 = "==";
                    b44 = "";
                    b45 = "";
                    b46 = "==";
                    b47 = "";
                    b48 = "";
                    b49 = "==";
                    b50 = "";
                    b51 = "";
                    b52 = "==";
                    b53 = "";
                    b54 = "";
                    b55 = "==";
                    b56 = "";
                    b57 = "";
                    b58 = "==";
                    b59 = "";

                    v2 = 1;
                    v3 = 0;
                    v4 = 1;
                    v5 = 0;
                    v6 = 0;
                    v7 = 0;
                    v8 = 0;
                    v9 = 0;
                    v10 = 0;
                    v11 = 0;
                    v12 = 0;
                    v13 = 0;
                    v14 = 0;
                    v15 = 0;
                    v16 = 0;
                    v17 = 0;
                    v18 = 0;
                    v19 = 0;
                    v20 = 0;
                    v21 = 0;
                    v22 = 0;
                    break;

                case 8:
                    b0 = Parser.GetRemoveVariableSign(lb1JObject.GetValue($"websocketvalue5_{position}").Value<string>());
                    b1 = Parser.GetRemoveVariableSign(lb1JObject.GetValue($"websocketvalue6_{position}"));

                    if (string.IsNullOrWhiteSpace(b0.ToString()))
                    {
                        b0 = "-1";
                    }

                    if (string.IsNullOrWhiteSpace(b1.ToString()))
                    {
                        b1 = "-1";
                    }

                    v0 = Parser.GetInt(lb1JObject.GetValue($"websocketvalue4_{position}"));
                    break;

                case 9:
                    b0 = Parser.GetRemoveVariableSign(lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>());
                    b1 = "";
                    v0 = Parser.GetInt(lb1JObject.GetValue($"websocketvalue4_{position}").Value<string>());
                    break;

                case 19:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b3 = lb1JObject.GetValue($"websocketvalue5_{position}").Value<string>();
                    v0 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue4_{position}"));
                    v1 = 0;
                    break;

                case 20:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    v0 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue3_{position}"));
                    break;

                case 23:
                case 38:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b3 = lb1JObject.GetValue($"websocketvalue4_{position}").Value<string>();
                    b4 = lb1JObject.GetValue($"websocketvalue5_{position}").Value<string>();
                    b5 = lb1JObject.GetValue($"websocketvalue6_{position}").Value<string>();
                    b6 = lb1JObject.GetValue($"websocketvalue7_{position}").Value<string>();
                    switch (lb1JObject.GetValue($"websocketvalue8_{position}").Value<string>())
                    {
                        case "None":
                            v0 = 0;
                            break;
                        case "Out":
                            v0 = 1;
                            break;
                        case "In":
                            v0 = 2;
                            break;
                        case "In/Out":
                            v0 = 3;
                            break;
                    }
                    break;

                case 24:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b3 = lb1JObject.GetValue($"websocketvalue4_{position}").Value<string>();
                    b4 = lb1JObject.GetValue($"websocketvalue5_{position}").Value<string>();
                    b5 = lb1JObject.GetValue($"websocketvalue6_{position}").Value<string>();
                    b6 = lb1JObject.GetValue($"websocketvalue7_{position}").Value<string>();
                    b7 = Parser.GetInt(lb1JObject.GetValue($"websocketvalue8_{position}"));
                    v0 = 0;
                    break;

                case 28:
                    dis = 1;
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue5_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue6_{position}").Value<string>();

                    var border = lb1JObject.GetValue($"websocketvalue7_{position}").Value<string>();

                    if (string.IsNullOrWhiteSpace(border))
                    {
                        border = "0";
                    }

                    v0 = int.Parse(border);
                    v1 = true;

                    var red = Parser.GetInt(lb1JObject.GetValue($"websocketvalue2_{position}"));
                    var green = Parser.GetInt(lb1JObject.GetValue($"websocketvalue3_{position}"));
                    var blue = Parser.GetInt(lb1JObject.GetValue($"websocketvalue4_{position}"));

                    var color = Color.FromRgb((byte)red, (byte)green, (byte)blue);
                    v2 = color.B * 256 * 256 + color.G * 256 + color.R;

                    break;

                case 56:
                case 80:
                case 147:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = Parser.GetRemoveVariableSign(lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>());
                    break;

                case 34:
                case 35:
                case 36:
                case 46:
                case 48:
                case 50:
                case 57:
                case 58:
                case 59:
                case 66:
                case 72:
                case 79:
                case 82:
                case 83:
                case 86:
                case 95:
                case 97:
                case 100:
                case 102:
                case 110:
                case 111:
                case 112:
                case 113:
                case 114:
                case 115:
                case 116:
                case 123:
                case 128:
                case 140:
                case 148:
                case 153:
                case 158:
                case 163:
                case 167:
                case 168:
                case 220:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    break;

                case 118:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = Parser.GetAddVariableSign(lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>());
                    break;

                case 81:
                case 139:
                    b0 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>(); 
                    b1 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    break;

                case -5:
                    cmd = 66;
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = "trigger_type";
                    break;


                case 84:
                case 85:
                case 89:
                case 90:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = $"/${b0}$/";
                    break;

                case 31:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = (Parser.GetDouble(lb1JObject.GetValue($"websocketvalue2_{position}")) / 100).ToString();
                    break;

                case 39:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = (Parser.GetDouble(lb1JObject.GetValue($"websocketvalue2_{position}")) / 100).ToString();
                    b2 = (Parser.GetDouble(lb1JObject.GetValue($"websocketvalue3_{position}")) / 100).ToString(); 
                    b3 = lb1JObject.GetValue($"websocketvalue4_{position}").Value<string>();
                    v0 = 0;
                    break;

                case 40:
                case 41:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b3 = lb1JObject.GetValue($"websocketvalue4_{position}").Value<string>();
                    b4 = lb1JObject.GetValue($"websocketvalue5_{position}").Value<string>();

                    switch (lb1JObject.GetValue($"websocketvalue6_{position}").Value<string>())
                    {
                        case "None":
                            v0 = 0;
                            break;
                        case "Out":
                            v0 = 1;
                            break;
                        case "In":
                            v0 = 2;
                            break;
                        case "In/Out":
                            v0 = 3;
                            break;
                        default:
                            v0 = 0;
                            break;
                    }
                    break;

                case 44:
                case 51:
                case 103:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    v0 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue2_{position}"));
                    break;

                case 47:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b3 = lb1JObject.GetValue($"websocketvalue4_{position}").Value<string>();
                    v0 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue5_{position}"));
                    break;

                case 37:
                case 65:
                case 92:
                case 129:
                case 130:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    break;

                case 67:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b3 = lb1JObject.GetValue($"websocketvalue4_{position}").Value<string>();
                    b4 = lb1JObject.GetValue($"websocketvalue5_{position}").Value<string>();
                    b5 = lb1JObject.GetValue($"websocketvalue6_{position}").Value<string>();
                    b6 = lb1JObject.GetValue($"websocketvalue7_{position}").Value<string>();
                    b7 = lb1JObject.GetValue($"websocketvalue8_{position}").Value<string>();
                    v0 = 0;
                    break;

                case 74:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    v0 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue4_{position}"));
                    v1 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue3_{position}"));
                    v2 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue2_{position}"));
                    break;

                case 77:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    v0 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue4_{position}"));
                    break;

                case 108:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = Parser.GetRemoveVariableSign(lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>());
                    switch (lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>())
                    {
                        case "Fixed":
                            v0 = 0;
                            break;
                        case "Grow":
                            v0 = 1;
                            break;
                        case "Wrap":
                            v0 = 2;
                            break;
                    }
                    break;

                case 121:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    switch (lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>())
                    {
                        case "Fixed":
                            v0 = 0;
                            break;
                        case "Grow":
                            v0 = 1;
                            break;
                        case "Wrap":
                            v0 = 2;
                            break;
                    }
                    break;

                case 119:
                case 120:
                case 122:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue4_{position}").Value<string>();

                    switch (lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>())
                    {
                        case "Unigned 8bits":
                            v0 = 1;
                            break;
                        case "Signed 8bits":
                            v0 = 2;
                            break;
                        case "Unsigned 16bits":
                            v0 = 3;
                            break;
                        case "Signed 16bits":
                            v0 = 4;
                            break;
                        case "Unsigned 32bits":
                            v0 = 5;
                            break;
                        case "Signed 32bits":
                            v0 = 6;
                            break;
                        case "Float 32bits":
                            v0 = 8;
                            break;
                        case "Float 64bits":
                            v0 = 9;
                            break;
                        case "Boolean":
                            v0 = 10;
                            break;
                        case "String":
                            v0 = 11;
                            break;
                        case "Text":
                            v0 = 13;
                            break;
                    }
                    break;

                case 29:
                case 30:
                case 49:
                case 104:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();

                    var change = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    v0 = change == "true";

                    if (change == "Toggle")
                    {
                        CommentCommand(lb1JObject, position, "Toggle is not longer supported in LB2 for Source and Filter Visibility Changes");
                    }

                    break;

                case 132:
                    dis = 1;
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = Parser.GetRemoveVariableSign(lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>());
                    v0 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>() == "true";

                    if (string.IsNullOrWhiteSpace(b1.ToString()))
                    {
                        b1 = "0";
                    }

                    break;

                case 133:
                    dis = 1;
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    v0 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue2_{position}"));
                    v1 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue3_{position}"));
                    v2 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue4_{position}"));
                    break;

                case 138:
                    b0 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue1_{position}"));
                    v0 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue2_{position}"));
                    v1 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue3_{position}"));
                    v2 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue4_{position}"));
                    v3 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue5_{position}"));
                    v4 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue6_{position}"));
                    v5 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue7_{position}"));
                    v6 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue8_{position}"));
                    v7 = false;
                    break;

                case 141:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    v0 = false;
                    break;

                case 143:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    switch (lb1JObject.GetValue($"websocketvalue4_{position}").Value<string>())
                    {
                        case "Volume":
                            v0 = 0;
                            break;
                        case "Muted":
                            v0 = 1;
                            break;
                        case "Visible":
                            v0 = 2;
                            break;
                        case "X Position":
                            v0 = 3;
                            break;
                        case "Y Position":
                            v0 = 4;
                            break;
                        case "X Scale":
                            v0 = 5;
                            break;
                        case "Y Scale":
                            v0 = 6;
                            break;
                        case "Rotation":
                            v0 = 11;
                            break;
                    }
                    break;

                case 22:
                case 32:
                case 94:
                case 124:
                case 125:
                case 127:
                case 131:
                case 156:
                case 215:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b3 = lb1JObject.GetValue($"websocketvalue4_{position}").Value<string>();
                    break;

                case 126:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b3 = Parser.GetAddVariableSign(lb1JObject.GetValue($"websocketvalue4_{position}").Value<string>());
                    break;

                case 117:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = "";
                    b2 = "";
                    b3 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    break;

                case 91:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b3 = "0";
                    break;

                case 87:
                case 88:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = $"/${b0}$/";
                    b2 = Parser.GetRemoveVariableSign(lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>());
                    b3 = Parser.GetRemoveVariableSign(lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>());
                    break;

                case 93:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = $"/${b0}$/";
                    b2 = Parser.GetRemoveVariableSign(lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>());
                    b3 = Parser.GetRemoveVariableSign(lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>());
                    break;

                case 144:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b2 = lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>();
                    b3 = lb1JObject.GetValue($"websocketvalue4_{position}").Value<string>();
                    b4 = lb1JObject.GetValue($"websocketvalue5_{position}").Value<string>();
                    b5 = lb1JObject.GetValue($"websocketvalue6_{position}").Value<string>();
                    break;

                case 149:
                    v0 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue1_{position}"));
                    break;

                case 75:
                case 159:
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    b1 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    v0 = Parser.GetInt(lb1JObject.GetValue($"websocketvalue3_{position}"));
                    break;

                case 105:
                    b0 = "Twitch Name Here"; 
                    b1 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();

                    switch (lb1JObject.GetValue($"websocketvalue3_{position}").Value<string>())
                    {
                        case "Channel ID":
                            v0 = 0;
                            break;
                        case "Login Name":
                            v0 = 2;
                            break;
                        case "Oauth token":
                            v0 = 1;
                            break;
                        default:
                            v0 = 0;
                            break;
                    }
                    break;

                case 189:
                    dis = 1;
                    b0 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    v0 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue2_{position}"));
                    v1 = Parser.GetBool(lb1JObject.GetValue($"websocketvalue3_{position}"));
                    break;

                case 217:
                case 218:
                    b0 = lb1JObject.GetValue($"websocketvalue2_{position}").Value<string>();
                    b1 = ",";
                    b2 = lb1JObject.GetValue($"websocketvalue1_{position}").Value<string>();
                    break;
            }
        }

        public int cmd
        {
            get => _cmd;
            set => SetProperty(ref _cmd, value);
        }

        public string obsid
        {
            get => _obsid;
            set => SetProperty(ref _obsid, value);
        }

        public int pos
        {
            get => _pos;
            set => SetProperty(ref _pos, value);
        }

        public object vis
        {
            get => _vis;
            set => SetProperty(ref _vis, value);
        }

        public int ms
        {
            get => _ms;
            set => SetProperty(ref _ms, value);
        }

        public int sel
        {
            get => _sel;
            set => SetProperty(ref _sel, value);
        }

        public int dis
        {
            get => _dis;
            set => SetProperty(ref _dis, value);
        }

        public int xpan
        {
            get => _xpan;
            set => SetProperty(ref _xpan, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b0
        {
            get => _b0;
            set => SetProperty(ref _b0, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b1
        {
            get => _b1;
            set => SetProperty(ref _b1, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b2
        {
            get => _b2;
            set => SetProperty(ref _b2, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b3
        {
            get => _b3;
            set => SetProperty(ref _b3, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b4
        {
            get => _b4;
            set => SetProperty(ref _b4, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b5
        {
            get => _b5;
            set => SetProperty(ref _b5, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b6
        {
            get => _b6;
            set => SetProperty(ref _b6, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b7
        {
            get => _b7;
            set => SetProperty(ref _b7, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b8
        {
            get => _b8;
            set => SetProperty(ref _b8, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b9
        {
            get => _b9;
            set => SetProperty(ref _b9, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b10
        {
            get => _b10;
            set => SetProperty(ref _b10, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b11
        {
            get => _b11;
            set => SetProperty(ref _b11, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b12
        {
            get => _b12;
            set => SetProperty(ref _b12, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b13
        {
            get => _b13;
            set => SetProperty(ref _b13, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b14
        {
            get => _b14;
            set => SetProperty(ref _b14, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b15
        {
            get => _b15;
            set => SetProperty(ref _b15, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b16
        {
            get => _b16;
            set => SetProperty(ref _b16, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b17
        {
            get => _b17;
            set => SetProperty(ref _b17, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b18
        {
            get => _b18;
            set => SetProperty(ref _b18, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b19
        {
            get => _b19;
            set => SetProperty(ref _b19, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b20
        {
            get => _b20;
            set => SetProperty(ref _b20, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b21
        {
            get => _b21;
            set => SetProperty(ref _b21, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b22
        {
            get => _b22;
            set => SetProperty(ref _b22, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b23
        {
            get => _b23;
            set => SetProperty(ref _b23, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b24
        {
            get => _b24;
            set => SetProperty(ref _b24, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b25
        {
            get => _b25;
            set => SetProperty(ref _b25, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b26
        {
            get => _b26;
            set => SetProperty(ref _b26, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b27
        {
            get => _b27;
            set => SetProperty(ref _b27, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b28
        {
            get => _b28;
            set => SetProperty(ref _b28, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b29
        {
            get => _b29;
            set => SetProperty(ref _b29, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b30
        {
            get => _b30;
            set => SetProperty(ref _b30, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b31
        {
            get => _b31;
            set => SetProperty(ref _b31, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b32
        {
            get => _b32;
            set => SetProperty(ref _b32, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b33
        {
            get => _b33;
            set => SetProperty(ref _b33, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b34
        {
            get => _b34;
            set => SetProperty(ref _b34, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b35
        {
            get => _b35;
            set => SetProperty(ref _b35, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b36
        {
            get => _b36;
            set => SetProperty(ref _b36, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b37
        {
            get => _b37;
            set => SetProperty(ref _b37, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b38
        {
            get => _b38;
            set => SetProperty(ref _b38, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b39
        {
            get => _b39;
            set => SetProperty(ref _b39, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b40
        {
            get => _b40;
            set => SetProperty(ref _b40, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b41
        {
            get => _b41;
            set => SetProperty(ref _b41, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b42
        {
            get => _b42;
            set => SetProperty(ref _b42, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b43
        {
            get => _b43;
            set => SetProperty(ref _b43, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b44
        {
            get => _b44;
            set => SetProperty(ref _b44, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b45
        {
            get => _b45;
            set => SetProperty(ref _b45, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b46
        {
            get => _b46;
            set => SetProperty(ref _b46, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b47
        {
            get => _b47;
            set => SetProperty(ref _b47, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b48
        {
            get => _b48;
            set => SetProperty(ref _b48, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b49
        {
            get => _b49;
            set => SetProperty(ref _b49, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b50
        {
            get => _b50;
            set => SetProperty(ref _b50, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b51
        {
            get => _b51;
            set => SetProperty(ref _b51, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b52
        {
            get => _b52;
            set => SetProperty(ref _b52, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b53
        {
            get => _b53;
            set => SetProperty(ref _b53, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b54
        {
            get => _b54;
            set => SetProperty(ref _b54, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b55
        {
            get => _b55;
            set => SetProperty(ref _b55, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b56
        {
            get => _b56;
            set => SetProperty(ref _b56, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b57
        {
            get => _b57;
            set => SetProperty(ref _b57, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b58
        {
            get => _b58;
            set => SetProperty(ref _b58, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object b59
        {
            get => _b59;
            set => SetProperty(ref _b59, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v0
        {
            get => _v0;
            set => SetProperty(ref _v0, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v1
        {
            get => _v1;
            set => SetProperty(ref _v1, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v2
        {
            get => _v2;
            set => SetProperty(ref _v2, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v3
        {
            get => _v3;
            set => SetProperty(ref _v3, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v4
        {
            get => _v4;
            set => SetProperty(ref _v4, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v5
        {
            get => _v5;
            set => SetProperty(ref _v5, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v6
        {
            get => _v6;
            set => SetProperty(ref _v6, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v7
        {
            get => _v7;
            set => SetProperty(ref _v7, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v8
        {
            get => _v8;
            set => SetProperty(ref _v8, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v9
        {
            get => _v9;
            set => SetProperty(ref _v9, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v10
        {
            get => _v10;
            set => SetProperty(ref _v10, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v11
        {
            get => _v11;
            set => SetProperty(ref _v11, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v12
        {
            get => _v12;
            set => SetProperty(ref _v12, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v13
        {
            get => _v13;
            set => SetProperty(ref _v13, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v14
        {
            get => _v14;
            set => SetProperty(ref _v14, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v15
        {
            get => _v15;
            set => SetProperty(ref _v15, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v16
        {
            get => _v16;
            set => SetProperty(ref _v16, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v17
        {
            get => _v17;
            set => SetProperty(ref _v17, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v18
        {
            get => _v18;
            set => SetProperty(ref _v18, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v19
        {
            get => _v19;
            set => SetProperty(ref _v19, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v20
        {
            get => _v20;
            set => SetProperty(ref _v20, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v21
        {
            get => _v21;
            set => SetProperty(ref _v21, value);
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object v22
        {
            get => _v22;
            set => SetProperty(ref _v22, value);
        }
    }
}

