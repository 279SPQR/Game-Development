﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Flashlight : MonoBehaviour {

    public bool lightOn = true;

    Light light;

    // Use this for initialization
    void Start () {
        light = GetComponent<Light> ();
        // Set Light default to ON
        lightOn = true;
        print("Turn light on when Flashlight is initiated");
        light.enabled = true;
    }
    
    // Update is called once per frame
    void Update () {
        // Toggle light on/off when l key is pressed.
        if (Input.GetKeyUp (KeyCode.L) && lightOn) {
            print("Light off");
            lightOn = false;
            light.enabled = false;
        
    }

    else if (Input.GetKeyUp (KeyCode.L) && !lightOn){
            print("Light on");
            lightOn = true;
            light.enabled = true;
        }
        
    }

    public void setLightOn(){
        lightOn = true;
    }

    public bool isLightOn(){
        return lightOn;
    }

}
