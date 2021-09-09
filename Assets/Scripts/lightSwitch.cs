using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    Light[] lights;
    bool onSwitch;
    void Start()
    {
        lights = gameObject.GetComponentsInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        onSwitch = true;
    }

    private void OnTriggerExit(Collider other)
    {
        onSwitch = false;
    }

    private void OnGUI()
    {
        
    }

    public void Interact()
    {
        if (onSwitch)
        {
            foreach (Light light in lights)
            {
                if (light.gameObject.activeSelf == true)
                {
                    light.gameObject.SetActive(false);
                } else
                {
                    light.gameObject.SetActive(true);
                }
            }
        }
    }
}
