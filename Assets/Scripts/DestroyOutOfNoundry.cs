using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfNoundry : MonoBehaviour
{
    private float topBound = 25;
    private float lowerBound = -25;
    
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHealthControl playerHealth = FindObjectOfType<PlayerHealthControl>();//获取玩家生命值，动物漏掉时减血
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
            playerHealth.playerHP -= 1;
            
        }
         if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            playerHealth.playerHP -= 1;
            
        }
        if (transform.position.x > topBound)
        {
            Destroy(gameObject);
            playerHealth.playerHP -= 1;

        }
        if (transform.position.x < lowerBound)
        {
            Destroy(gameObject);
            playerHealth.playerHP -= 1;
        }
    }
}
