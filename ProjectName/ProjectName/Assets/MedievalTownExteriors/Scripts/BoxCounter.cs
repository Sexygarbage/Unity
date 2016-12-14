using UnityEngine;
using UnityEngine.UI;

public class BoxCounter : MonoBehaviour {

    private int count = 0;
    public Text label;
    
    void OnTriggerEnter(Collider collider)
    {
        Box thrower = collider.GetComponent<Box>();
        if (thrower ==null)
        {
            return;
        }

        count++;
        label.text = "Score: " + count;
        //Debug.Log(count + " boxes");
    }
    void OnTriggerExit(Collider collider)
    {
        Box thrower = collider.GetComponent<Box>();
        if (thrower == null)
        {
            return;
        }
        count--;
        label.text = "Score: " + count;
        //Debug.Log(count + " boxes");
    }


    // Update is called once per frame

   }

