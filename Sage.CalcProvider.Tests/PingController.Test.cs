using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Sage.CalcProvider
{
    
    public class PingControllerTest
    {
        [Fact]
        public void Pass()
        {
            Console.WriteLine("Running the test");
            Assert.Equal(4, 4);
        }
    }

}
