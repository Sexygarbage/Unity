using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public Text label;

    private int num = 0;

    public void Increase()
    {
        num++;
        Debug.Log(num);
        label.text = num.ToString();
    }

    public void Decrease()
    {
        num--;
        Debug.Log(num);
        label.text = num.ToString();
    }
}
