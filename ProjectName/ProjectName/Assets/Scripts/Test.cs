using UnityEngine;

public class Test : MonoBehaviour {

    public float moveSpeed = 2;
    public float rotateSpeed = 20;
    public float jumpingForce = 1;

    private Rigidbody rigidbody;

    public Light light;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update() {
        // Move
        Vector3 move = Vector3.forward * 
            Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(move);
        
        // Rotate
        Vector3 rotate = Vector3.up *
            Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;

        transform.Rotate(rotate, Space.World);

        // Jump
        if (Input.GetKeyUp(KeyCode.Space)) {
            rigidbody.AddForce(Vector3.up * jumpingForce);
        }
    }

    void OnTriggerEnter(Collider collider) {
        light.enabled = !light.enabled;
    }

    public void WhateverWeWant() {
        transform.localScale *= 1.10f;
    }
}
