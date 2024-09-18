using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    new Light light;
    CameraMechanics cam;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        cam = GameObject.Find("Weapon").GetComponent<CameraMechanics>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            light.enabled = !light.enabled;
        }
    }
    private void FixedUpdate()
    {
        if (light.enabled)
        {
            counter++;
            if (counter == 50)
            {
                cam.battery -= 1;
                counter = 0;
            }
        }
        if (light.intensity > 1)
        {
            light.intensity -= 0.15f;
        }
    }
}
