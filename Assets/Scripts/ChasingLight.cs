using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingLight : MonoBehaviour
{
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    public Light light5;
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
        if (other.tag == "Player")
        {
            StartCoroutine(LightChase());
        }
    }

    IEnumerator LightChase()
    {
        yield return new WaitForSeconds(1f);
        light1.enabled = false;
        light1.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);
        light2.enabled = false;
        light2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);
        light3.enabled = false;
        light3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);
        light4.enabled = false;
        light4.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);
        light5.enabled = false;
        light5.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(2f);
        light1.enabled = true;
        light2.enabled = true;
        light3.enabled = true;
        light4.enabled = true;
        light5.enabled = true;
        yield return new WaitForSeconds(0.2f);
        light1.enabled = false;
        light2.enabled = false;
        light3.enabled = false;
        light4.enabled = false;
        light5.enabled = false;
        yield return new WaitForSeconds(0.2f);
        light1.enabled = true;
        light2.enabled = true;
        light3.enabled = true;
        light4.enabled = true;
        light5.enabled = true;
    }
}
