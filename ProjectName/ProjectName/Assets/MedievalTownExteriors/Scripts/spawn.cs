using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class spawn : MonoBehaviour
{
    /*  private GameObject obj;
      private Timer myTimer;
      private bool boo = true;
      // Use this for initialization
      void Start()
      {
          myTimer = new Timer();
          // Tell the timer what to do when it elapses
          myTimer.Elapsed += new ElapsedEventHandler((s, e) => gameObject.SetActive(!boo));
          // Set it to go off every five seconds
          myTimer.Interval = 4000;
          // And start it        
          myTimer.Enabled = true;
      }*/
    public float minSpawnTime = 3;
    public float maxSpawnTime = 10;

    public GameObject prefab;

    private float spawnTime = 5;
    private float lastSpawnTime = 0;

    private Box box;

    void Start()
    {
        CalculateSpawnTime();
    }

    void Update()
    {
        if(box != null)
        {
            return;
        }

        float timePassed = Time.time - lastSpawnTime;

        if(timePassed > spawnTime)
        {
            box = Instantiate(prefab).GetComponent<Box>();
            box.transform.position = transform.position;

            box.OnPickUp += OnBoxPickUp;

            //lastSpawnTime = Time.time;

            //CalculateSpawnTime();
        }
    }

    private void OnBoxPickUp()
    {
        box = null;
        lastSpawnTime = Time.time;
        CalculateSpawnTime();
    }

    private void CalculateSpawnTime()
    {
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }
}