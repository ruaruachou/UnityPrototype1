using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InvokeMethodInRndTime());
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

    }
    private IEnumerator InvokeMethodInRndTime()
    //每隔一定随机时间调用方法的方法
    {
        while (true)
        {
            float intervalLow = 3;
            float intervalUp = 6;
            float intervalTime = Random.Range(intervalLow, intervalUp);
            Debug.Log("Is interval time ="+intervalTime);
            yield return new WaitForSeconds(intervalTime);

            SpawnRandomBall();//调用生成球的方法
        }

    }

}
