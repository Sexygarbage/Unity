using UnityEngine;
using UnityEngine.UI;
using System.Timers;
using System;

public class Countdown : MonoBehaviour {

    public Text countdown;
    public int timeCount = 200;
    public bool IsControl = true;
    private Timer myTimer;
    // Use this for initialization
    void Start () {
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

    // Update is called once per frame
    void Update () {
        countdown.text = "Countdown: " + timeCount;
    }
}
