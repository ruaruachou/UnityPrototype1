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
        //���ﲻ��ҪGetComponent<Slider>����Ϊ����û��Slider���
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
