using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryScript : MonoBehaviour
{
    CameraMechanics cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Weapon").GetComponent<CameraMechanics>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cam.Reload();
            Destroy(gameObject);
        }
    }

}
