using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lioranboard_1_Json_to_2.Helper
{
    public static class LB1Converters
    {
        public static int CommandId(int id)
        {
            switch (id)
            {
                //Custom Packet
                case 0:
                    return 1;

                //Toggle Streaming
                case 1:
                    return 57;

                //Start Streaming
                case 2:
                    return 58;

                //Stop Streaming
                case 3:
                    return 59;

                //Toggle Recording
                case 4:
                    return 60;

                //Start Recording
                case 5:
                    return 61;

                //Stop Recording
                case 6:
                    return 62;

                //Source Volume Change
                case 7:
                    return 31;

                //Source Mute
                case 8:
                    return 44;

                //Source Toggle Mute
                case 9:
                    return 45;

                //Filter Change Visibility
                case 10:
                    return 29;

                //Change Source Visibility
                case 11:
                    return 30;

                //Scene Switch
                case 12:
                    return 43;

                //Toggle Replay Buffer
                case 13:
                    //Removed from LB2
                    return -1;

                //Start Replay Buffer
                case 14:
                    //Removed from LB2
                    return -1;

                //Stop Replay Buffer
                case 15:
                    //Removed from LB2
                    return -1;

                //Pause Recording
                case 16:
                    return 64;

                //Resume Recording
                case 17:
                    return 63;

                //Motion: Position
                case 18:
                    return 23;

                //Motion: Volume
                case 19:
                    return 39;

                //Motion: Scale
                case 20:
                    return 38;

                //Motion: Alpha Filter
                case 21:
                    return 40;

                //Math: Change Variable (old)
                case 22:
                    //Maybe?
                    return 161;

                //Compare: Skip if
                case 23:
                    //Logic gate?
                    return 0;

                //Change Source Position
                case 24:
                    return 22;

                //Source Change Scale
                case 25:
                    return 32;

                //Source Change Rotation
                case 26:
                    return 33;

                //Motion: Rotation
                case 27:
                    return 41;

                //Filter Change Settings
                case 28:
                    return 37;

                //Math: Random
                case 30:
                    return 77;

                //TODO: Identify
                case 32:
                    return 0;

                //TODO: Identify
                case 33:
                    return 0;

                //Trigger Button
                case 34:
                    return 132;

                //Math: Trigger Pull
                case 35:
                    return 66;

                //Twitch: Send Chat Message
                case 36:
                    return 148;

                //File: Save Number
                case 37:
                    return 124;

                //File: Load Number
                case 38:
                    return 125;

                //File: Save Text
                case 39:
                    return 126;

                //File: Load Text
                case 40:
                    return 127;

                //String: Sound Name Pull
                case 41:
                    //Removed from LB2
                    return -1;

                //Text GDI+ Change Text
                case 42:
                    return 35;

                //String: Replace
                case 43:
                    return 87;

                //TODO: Identify
                case 44:
                    return 0;

                //TODO: Identify
                case 45:
                    return 0;

                //TODO: Identify
                case 46:

                    return 0;
                //TODO: Identify
                case 47:
                    return 0;

                //String: Length
                case 48:
                    return 83;

                //String: Digits
                case 49:
                    return 84;

                //String: Lower Case
                case 50:
                    return 90;

                //String: Upper Case
                case 51:
                    return 89;

                //String: Clamp
                case 52:
                    return 93;

                //String: Number to Text
                case 53:
                    return 95;

                //Math: Text to Number
                case 54:
                    return 79;

                //Execute Program
                case 55:
                    return 134;

                //Motion: Position Curve
                case 56:
                    return 67;

                //Math: Variable Transition
                case 57:
                    return 19;

                //Command Line
                case 58:
                    return 135;

                //TODO: Identify
                case 59:
                    return 0;

                //Math: Clear Variable
                case 60:
                    return 78;

                //Overtime
                case 61:
                    return 137;

                //Source Change Settings
                case 62:
                    return 34;

                //Modify Button
                case 63:
                    return 28;

                //OBS Pull Source Value
                case 64:
                    return 143;

                //OBS Pull Filter Visibility
                case 65:
                    //Removed, replace with logic using Fetch OBS Data
                    return 0;

                //String: Position
                case 66:
                    return 91;

                //Open URL
                case 67:
                    return 136;

                //Set Clipboard
                case 68:
                    return 106;

                //Load Clipboard
                case 69:
                    return 107;

                //Fetch OBS Data
                case 70:
                    return 65;

                //Send To Extension
                case 71:
                    return 0;

                //TODO: Identify
                case 72:
                    return 0;

                //Stack: Add(old)
                case 73:
                    return 96;

                //Stack: Replace(old)
                case 74:
                    return 99;

                //Stack: Pull
                case 75:
                    return 0;

                //Stack: Peek
                case 76:
                    //Removed from LB2
                    return -1;

                //Stack: Get Size
                case 77:
                    return 100;

                //Stack: Random
                case 78:
                    return 101;

                //Stack: Shuffle
                case 79:
                    return 102;

                //Stack: Clear
                case 80:
                    //TODO: Logic to clear array, probably just re-create array
                    return 0;

                //Stack: Find(old)
                case 81:
                    return 166;

                //Stack: Stringify
                case 82:
                    return 167;

                //Stack: Parse String
                case 83:
                    return 168;

                //Change Scene Transition
                case 84:
                    return 68;

                //Remove Scene Transition
                case 85:
                    return 69;

                //Change Audio Monitor Type
                case 86:
                    return 46;

                //FreeType2 Change Text
                case 87:
                    return 36;

                //Math: Hex to Number
                case 88:
                    return 80;

                //Save Replay Buffer
                case 89:
                    //Removed from LB2
                    return -1;

                //String: Count
                case 90:
                    return 92;

                //Clear Button
                case 91:
                    return 133;

                //Comment
                case 92:
                    return 6;

                //String: Format
                case 93:
                    return 215;

                //String: Letters
                case 94:
                    return 85;

                //Compare: Redo Previous if
                case 95:
                    return 0;

                //TODO: Identify
                case 96:
                    return 0;

                //Math: Clamp
                case 97:
                    return 76;

                //String: Wildcard Pull
                case 98:
                    return 147;

                //String: Get Trigger Type
                case 99:
                    //Replaced by 66
                    return 66;

                //String: Escape
                case 100:
                    //Removed from LB2
                    return -1;

                //Twitch: Open Whispers
                case 101:
                    return 149;

                //Twitch: Join Channel
                case 102:
                    return 150;

                //Twitch: Leave Channel
                case 103:
                    return 151;

                //Trigger OBS Hotkey Name
                case 104:
                    return 73;

                //Play/Pause Media
                case 105:
                    return 51;

                //Restart Media
                case 106:
                    return 52;

                //Stop Media
                case 107:
                    return 53;

                //Next Media
                case 108:
                    return 54;

                //Previous Media
                case 109:
                    return 55;

                //Set Media Time
                case 110:
                    return 56;

                //Create Source
                case 111:
                    return 47;

                //Create Scene
                case 112:
                    return 50;

                //Set Transition Settings
                case 113:
                    return 72;

                //Set Transition Bar Position
                case 114:
                    //Removed from LB2, replaced by Transition Duration
                    return -1;

                //Release Transition Bar
                case 115:
                    //Removed from LB2, replaced by Transition Duration
                    return -1;

                //Trigger OBS Hotkey Sequence
                case 116:
                    return 74;

                //Alert Message
                case 117:
                    return 142;

                //Popup Message
                case 118:
                    return 141;

                //Copy Local File
                case 119:
                    return 140;

                //Stack: Sort8
                case 120:
                    return 103;

                //If Statement
                case 121:
                    return 7;

                //Or Statement
                case 122:
                    //Combined into the button logic of the If
                    return -2;

                //And Statement
                case 123:
                    //Combined into the button logic of the If
                    return -3;

                //Re-enable If
                case 31:
                case 124:
                    return 8;

                //Repeat
                case 125:
                    return 9;

                //Statement: Exit If
                case 29:
                case 126:
                    return 12;

                //Math: Change Variable (new)
                case 127:
                    //Using Global Variable Set
                    return 161;

                //Statement: Break If
                case 128:
                    return 11;

                //Stack: Add (new)
                case 129:
                    return 96;

                //Stack: Replace (new)
                case 130:
                    return 99;

                //Stack: Find (new)
                case 131:
                    return 166;

                //File: Delete Section
                case 132:
                    return 128;

                //File: Delete Key
                case 133:
                    return 129;

                //File: Section Exists
                case 134:
                    return 130;

                //File: Key Exists
                case 135:
                    return 131;

                //Block Button
                case 136:
                    return 189;

                //Get File SHA1 Hash
                case 137:
                    return 139;

                //Buffer: Create
                case 138:
                    return 108;

                //Buffer: Delete
                case 139:
                    return 109;

                //Buffer: Load
                case 140:
                    return 110;

                //Buffer: Save
                case 141:
                    return 111;

                //Buffer: Write
                case 142:
                    return 119;

                //Buffer: Read
                case 143:
                    return 120;

                //Buffer: Set Position
                case 144:
                    return 114;

                //Buffer: Get Position
                case 145:
                    return 115;

                //Buffer: Set Size
                case 146:
                    return 112;

                //Buffer: Get Size
                case 147:
                    return 113;

                //Buffer: Base64 Encode
                case 148:
                    return 117;

                //Buffer: Base64 Decode
                case 149:
                    return 118;

                //Buffer: Peek
                case 150:
                    return 122;

                //Buffer: SHA1 Hash
                case 151:
                    return 123;

                //Get Date
                case 152:
                    return 138;

                //Math: Get Variable Type
                case 153:
                    return 81;

                //Buffer: Exists
                case 154:
                    return 116;

                //Stack: Concat
                case 155:
                    return 104;

                //Get Alternate Account Info
                case 156:
                    return 0;

                //Unknown
                default:
                    return 0;
            }
        }
    }
}
