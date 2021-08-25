using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalker : MonoBehaviour
{
    public AudioClip scare;

    Transform Player;
    Vector3 PlayerLooking;
    float dotProd;
    float speed = 2f;
    float counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        transform.position = Player.TransformPoint(0,0,-3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Player.TransformPoint(0, 0, -3f), step);

        PlayerLooking = (transform.position - Player.position).normalized;
        dotProd = Vector3.Dot(PlayerLooking, Player.transform.forward);

        if (dotProd > 0.75)
        {
            if (counter < 1)
            {
                counter++;
                StartCoroutine(FadeAway());
            }
        }
    }


    IEnumerator FadeAway()
    {
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = scare;
        audioSource.time = 0;
        audioSource.Play();
        yield return new WaitForSeconds(1f);

        Destroy(gameObject);
    }

}
