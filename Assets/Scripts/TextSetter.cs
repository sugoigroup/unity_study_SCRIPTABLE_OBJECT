using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSetter : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(UISetting.Instance.name);
        text.font = UISetting.Instance.defaultFont;
        text.fontSize = UISetting.Instance.defaultFontSize;
        text.color = UISetting.Instance.defaultFontColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
