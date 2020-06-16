using LeetCodeTest.Algo;
using System.Collections.Generic;
using Xunit;

namespace LeetCodeTest.AlgoTest
{
    public class ValidateIPAddressTest
    {
        [Theory]
        [InlineData("172.16.254.1", "IPv4")]
        [InlineData("0.0.0.-0", "Neither")]
        [InlineData("2001:0db8:85a3:0:0:8A2E:0370:7334", "IPv6")]
        [InlineData("256.256.256.256", "Neither")]
        public void CourseScheduleTest1(string ip, string result)
        {
            var p = new Solution468();
            Assert.Equal(p.ValidIPAddress(ip), result);
        }
    }
}
