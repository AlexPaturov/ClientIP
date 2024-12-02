using System.Collections.Generic;

namespace ClientIP.UDPservices
{
    public class ControllerMessage
    {
        public Dictionary<string, string> setOfValues { get; set; } = new Dictionary<string, string>();    

        public bool wasError { get; set; } = false; 
    }
}
