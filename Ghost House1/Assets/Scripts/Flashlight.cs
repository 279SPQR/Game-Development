// ToggleLight.cs
// Turns the light component of this object on/off when the user presses and released the 'L' key

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {

    public bool lightOn = true;

    public int maxPower = 4;
    public int currentPower;

    public Light light;

    // Use this for initialization
    void Start () {
        currentPower = maxPower;
        print("power = " + currentPower);
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
