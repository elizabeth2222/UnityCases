using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float JumpHeight = 4.0f;
    //protected float jump_speed = 12.0f;
    public bool is_landing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.is_landing) {
            if (Input.GetMouseButtonDown(0))
            {
                this.is_landing = false;

                // v^2 = 2*g*h;
                float y_speed = Mathf.Sqrt(2.0f * Mathf.Abs(Physics.gravity.y) * this.JumpHeight);

                this.GetComponent<Rigidbody>().velocity = Vector3.up * y_speed;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor") {
            this.is_landing = true;
        }
    }
}
