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
        float currentTime = Time.time;//实时记录当前时间
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&&(currentTime-lastTime)>attackInterval)//（当前时间-上次攻击时间）大于CD时，才允许攻击
        {
            lastTime = currentTime;//把实施攻击的当前时间赋值给上次攻击时间
            Debug.Log("Attack time ="+lastTime);
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
