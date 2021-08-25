using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MannequinController : MonoBehaviour
{
    public float speed = 0.1f;
    Animator m_animator;
    GameObject Player;

    Vector3 PlayerLooking;
    float dotProd;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = gameObject.GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player");

        m_animator.SetBool("LookedAt", true);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerLooking = (transform.position - Player.transform.position).normalized;
        dotProd = Vector3.Dot(PlayerLooking, Player.transform.forward);

        Vector3 tmpPos = transform.position;
        tmpPos.y = 0;
        transform.position = tmpPos;

        if (dotProd > 0.9)
        {
            m_animator.SetBool("LookedAt", true);
        } else
        {
            m_animator.SetBool("LookedAt", false);
        }

        if (m_animator.GetCurrentAnimatorStateInfo(0).IsName("DummyChase"))
        {
            transform.LookAt(Player.transform);

            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
