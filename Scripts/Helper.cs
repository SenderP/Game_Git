using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public static  class Helper
{
    public static GameObject target;
    public static void Send()
    {
        ExecuteEvents.Execute<IMyMessage>(target, null,Send);
    }

    private static void Send(IMyMessage x,BaseEventData y)
    {
        x.Message1();
        Debug.Log("From Sender");
    }
    
}
