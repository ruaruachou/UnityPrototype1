using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthControl : MonoBehaviour
{
    public int playerHP = 3;
    public Slider HPslider;
    // Start is called before the first frame update
    void Start()
    {
        //这里不需要GetComponent<Slider>，因为本身没有Slider组件
    }

    // Update is called once per frame
    void Update()
    {

        HPslider.value = playerHP;
        if (playerHP == 0) { Debug.Log("Game Over!"); }
    }
    private void OnTriggerEnter(Collider other)
    {
        playerHP -= 1;
    }
}
