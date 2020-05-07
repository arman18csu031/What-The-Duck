using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    Slider slider;
    //public float maxtime = 60f;
    float timeLeft;
    public GameObject timeup;
    public GameObject Spawner;
    public GameObject reload;
    void Start()
    {
        timeup.SetActive(false);
        reload.SetActive(false);
        slider = GetComponent<Slider>();
        timeLeft = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft < 30f)
        {
            timeLeft += Time.deltaTime;
            slider.value = timeLeft;

        }
        else
        {
            timeup.SetActive(true);
            reload.SetActive(true);
            Spawner.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
