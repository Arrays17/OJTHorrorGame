using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public void Interact()
    {
        try
        {
            Debug.Log("Object Interacted");
            gameObject.GetComponent<lightSwitch>().Interact();
        } catch { }
    }

}
