using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
public class Controller : MonoBehaviour
{
    Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = transform.Find("Button").GetComponent<Button>();
        btn.OnClickAsObservable()
            .First()
            .Subscribe(_ =>
            {
                
                Debug.Log("Clicked!" + _.ToString());
            });
    }

}
