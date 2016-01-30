using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katonk.RealEstate
{

    [Serializable]
    public class CsillowException : Exception
    {
        public CsillowException()
        {
        }

        public CsillowException(string message, string resolution) : base(message)
        {
            this.Resolution = resolution;
        }

        public CsillowException(string message, string resolution, Exception inner) : base(message, inner)
        {
            this.Resolution = resolution;
        }

        protected CsillowException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public string Resolution
        {
            get;
            private set;
        }
    }
}
