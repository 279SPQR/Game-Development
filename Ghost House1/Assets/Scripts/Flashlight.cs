﻿// ToggleLight.cs
// Turns the light component of this object on/off when the user presses and released the 'L' key

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour {

    // Flashlight on/off
    public bool lightOn = true;
    // Flashlight power capacity
    public int maxPower = 4;
    // Useable flashlight power
    public int currentPower;
    // Flashlight drain amount
    public int batDrainAmt;
    // Flashlight drain delay
    public float batDrainDelay;
    // Stores light object
    Light light;
    // Batery drain on/off
    bool draining = false;
    // Count integer
    long count = 0;
    // Battery UI text
    public Text batteryText;

    // Use this for initialization
    void Start () {
        // Add power to flashlight
        currentPower = maxPower;
        print("power = " + currentPower);
        // Get light
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

    else if (Input.GetKeyUp (KeyCode.L) && !lightOn && currentPower > 0){
            print("Light on");
            lightOn = true;
            light.enabled = true;
        }
        // Update battery UI text
        batteryText.text = currentPower.ToString();

        // Drain battery life
        if(currentPower > 0 && lightOn){

            if(!draining){
                StartCoroutine(BatteryDrain(batDrainDelay, batDrainAmt));
            }
            else if(currentPower <= 0){
                lightOn = false;
                light.enabled = false;
            }

        }
        
    }

    // Turns light on when called
    public void setLightOn(){
        lightOn = true;
    }
    // Returns if light is on
    public bool isLightOn(){
        return lightOn;
    }
    // Drain Battery Life
    IEnumerator BatteryDrain(float delay, int amount){

        if(lightOn){
            draining = true;
            yield return new WaitForSeconds(delay);
            print(currentPower);
            currentPower -= amount;
        }

        if(currentPower <= 0){
            currentPower = 0;
            print("Battery is dead!");
            light.enabled = false;
        }

        draining = false;

    }

}
