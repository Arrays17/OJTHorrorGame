using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayPasser : MonoBehaviour
{
    public GameObject ghost;
    public GameObject peekingGhost;
    public Transform spawn;
    public Transform despawn;
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
            Instantiate(ghost, spawn.position, spawn.rotation, this.transform);
            ghost.GetComponent<GhostMovement>().despawn = despawn;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(peekingGhost, despawn.position, despawn.rotation, this.transform);
        }
    }
}
