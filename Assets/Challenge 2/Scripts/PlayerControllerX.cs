using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float attackInterval = 3;
    private float lastTime = 0;

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&&(currentTime-lastTime)>attackInterval)
        {
            lastTime = currentTime;
            Debug.Log("Attack time ="+lastTime);
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
