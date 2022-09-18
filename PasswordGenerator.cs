using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCrafters_OTP
{
    public class PasswordGenerator
    {
        public int Generate(int userId, DateTime dateTime)
        {
            var seed = userId + (int)dateTime.Ticks;
            var rand = new Random(seed);
            return rand.Next(10000,99999);
        }
        
    }
}
