using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;
using System;


public class grab : MonoBehaviour
{
    public GameObject prefab;
    public Stack boxes;
    public Text countdown;
    public Text countBox;
    [Range(0, 1000)]
    public int timeCount = 200;
    public bool IsControl = true;
    private int boxCount=0;
    private Timer myTimer;
    // Use this for initialization
    void Start()
    {
        myTimer = new Timer();
        // Tell the timer what to do when it elapses
        myTimer.Elapsed += new ElapsedEventHandler(myEvent);
        // Set it to go off every five seconds
        myTimer.Interval = 1000;
        // And start it        
        myTimer.Enabled = true;

    }

    private void myEvent(object sender, ElapsedEventArgs e)
    {
        timeCount--;
        if (timeCount == 0)
            IsControl = false;
    }

    
    public float force = 200;
    [Range(0f, 1f)]
    public float direction = 0.5f;
    // Update is called once per frame
    void Update()
    {
        if (IsControl == true)
        {
            countdown.text = "Countdown: " + timeCount;
            if (Input.GetMouseButtonUp(0))
            {
                GameObject obj = Instantiate(prefab);
                Vector3 pos = transform.position + (transform.forward * 2);
                obj.transform.position = pos;
                // Direction to throe the box
                //Direction between forward and up
                //vector3.lerp interpolates two vectors
                //So 0.5f is the direction between forward and up (45degree)
                Rigidbody rigidbody = obj.AddComponent<Rigidbody>();
                Vector3 dir = Vector3.Lerp(transform.forward, Vector3.up, direction);
                rigidbody.AddForce(dir * force);

                UpdateBoxLabel();
            }
        }
        else
            countdown.text = "Game over box";
    }

    void OnTriggerEnter(Collider collider)
    {
        Box box = collider.GetComponent<Box>();

        if (box == null)
        {
            return;
        }
        boxCount++;
        box.PickUp();
        
    }


    private void UpdateBoxLabel() {
        countBox.text = boxes.Count.ToString();
    }
}

