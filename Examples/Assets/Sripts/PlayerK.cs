using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerK : MonoBehaviour
{
    public float jumpPower;
    Rigidbody r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            r.velocity = new Vector3(0, jumpPower, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Application.loadedLevel(Application.loadedLevel);
        //
        SceneManager.GetActiveScene();
    }
}
