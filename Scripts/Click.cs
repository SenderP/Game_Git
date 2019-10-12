using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonUp(0))
            .Subscribe(_ =>
            {
                Debug.Log("Clicked!" + _);
            });
    }

}
