using System;
using Xunit;
using Tyuiu.ObsushnoyMA.Lab2.V1.lib;

namespace Tyuiu.ObsushnoyMA.Lab2.V1.Test
{
    public class DataServiceTests
    {
        [Fact]
        public void CheckGetMassFunction()
        {
            string[] expected = { "0.30", "0.47", "0.63" };

            DataService tabulator = new DataService();
            string[] actual = tabulator.GetMassFunction(1, 3);

            Assert.Equal(expected, actual);
        }
    }
}
