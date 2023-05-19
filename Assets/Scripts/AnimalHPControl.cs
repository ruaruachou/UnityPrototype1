using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHPControl : MonoBehaviour
{
    public int animalHP = 3;
    public Slider HPslider;
    // Start is called before the first frame update
    void Start()
    {
        //这里不需要GetComponent<Slider>，因为本身没有Slider组件
    }

    // Update is called once per frame
    void Update()
    {

        HPslider.value = animalHP;
        if (animalHP == 0) { Destroy(gameObject); }
    }
    private void OnTriggerEnter(Collider other)
    {
        animalHP -= 1;
    }
}
