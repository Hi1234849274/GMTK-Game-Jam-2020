﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Image fillImage; //Add an image to UI
    private Slider slider; //Add a slider to UI

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update() 
    {
        if(slider.value <= slider.minValue){
            fillImage.enabled = false;  
		}
        if(slider.value > slider.minValue && !fillImage.enabled){
            fillImage.enabled = true;  
		}
        float fillValue = playerHealth.currentHealth / playerHealth.maxHealth;
        if(fillValue <= slider.maxValue / 3){
            fillImage.color = Color.white;  
		}
        else if(fillValue >slider.maxValue / 3){
            fillImage.color = Color.red;  
		}

        slider.value = fillValue;
       
    }
}