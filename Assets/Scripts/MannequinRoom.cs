using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MannequinRoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            var mannequins = GameObject.FindGameObjectsWithTag("Mannequin");
            foreach (GameObject mannequin in mannequins)
            {
                Animator animator = mannequin.GetComponent<Animator>();
                animator.SetBool("PlayerDetected", true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            var mannequins = GameObject.FindGameObjectsWithTag("Mannequin");
            foreach (GameObject mannequin in mannequins)
            {
                Animator animator = mannequin.GetComponent<Animator>();
                animator.SetBool("PlayerDetected", false);
            }
        }
    }
}
