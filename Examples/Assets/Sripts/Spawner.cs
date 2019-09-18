using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wallPrefab;
    public float interval;

    IEnumerator Start() {
        while (true) {
            Instantiate(wallPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
