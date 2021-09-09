using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f))
            {
                if (hit.transform != null)
                {
                    try
                    {
                        GameObject thing = hit.transform.gameObject;
                        Interactable interactable = thing.GetComponent<Interactable>();
                        if (interactable != null)
                        {
                            Debug.Log("Interactable");
                            interactable.Interact();
                        }
                    } catch { }
                }
            }
        }
    }
}
