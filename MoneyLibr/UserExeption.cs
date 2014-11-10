using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLibr
{
    public class UserExeption : Exception
    {
        public UserExeption() : base() { }
        public UserExeption(string message) : base(message) { }
        public UserExeption(string message, Exception inner) : base(message, inner) { }
        protected UserExeption(
            System.Runtime.Serialization.SerializationInfo si,
            System.Runtime.Serialization.StreamingContext sc)
            : base(si, sc) { }

        public override string ToString()
        {
            return Message;
        }
    }
}
