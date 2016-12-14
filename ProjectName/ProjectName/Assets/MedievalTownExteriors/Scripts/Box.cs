using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Box : MonoBehaviour {


    public event Action OnPickUp = delegate { };
    public int points;
    public bool canPickUp = true;

    private Collider collider;

	// Use this for initialization
	void Start () {
        points = UnityEngine.Random.Range(5, 20);

        collider = GetComponent<Collider>();
        collider.isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PickUp()
    {
        OnPickUp();
        collider.isTrigger = false;
        gameObject.SetActive(false);
    }
}
