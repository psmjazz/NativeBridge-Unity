using System.Collections;
using System.Collections.Generic;
using PJ.Native.Proto;
using UnityEngine;

namespace PJ.Native.PubSub
{
    public interface MessageHolder
    {
        Message Message {get;}
        void Reply(Message message);
    }    
}
