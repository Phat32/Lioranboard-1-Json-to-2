using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Lioranboard_1_Json_to_2.Helper
{
    public static class Parser
    {
        public static int GetInt(JToken token)
        {
            try
            {
                return int.Parse(token.Value<string>());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static bool GetBool(JToken token)
        {
            try
            {
                return bool.Parse(token.Value<string>());
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
