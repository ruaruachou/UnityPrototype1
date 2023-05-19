using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectileOutOfBoundey : MonoBehaviour
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
        PlayerHealthControl playerHealth = FindObjectOfType<PlayerHealthControl>();
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);

        }
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);

        }
    }
}
