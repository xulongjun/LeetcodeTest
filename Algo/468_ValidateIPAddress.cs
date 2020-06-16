using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeTest.Algo
{
    public class Solution468
    {
        public string ValidIPAddress(string IP)
        {
            if (CheckIpv4(IP)) return "IPv4";

            if (CheckIpv6(IP)) return "IPv6";

            return "Neither";
        }

        private bool CheckIpv4(string ip)
        {
            string[] segments = ip.Split(".");

            if (segments.Length != 4) return false;

            foreach (var segment in segments)
            {
                if ((segment.StartsWith("0") && segment != "0")
                    || string.IsNullOrWhiteSpace(segment)
                    || !int.TryParse(segment, out int a)
                    || (a < 0 || a > 255
                    || !segment.All(char.IsDigit))
                    )
                    return false;
            }

            return true;
        }

        private bool CheckIpv6(string ip)
        {
            string[] segments = ip.Split(":");

            if (segments.Length != 8) return false;

            foreach (var segment in segments)
            {
                if (segment.Length > 4 || !int.TryParse(segment, System.Globalization.NumberStyles.HexNumber,System.Globalization.CultureInfo.InvariantCulture,out int x))
                    return false;
            }

            return true;
        }
    }
}
