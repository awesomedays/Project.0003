using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int att = 10;
    Animator animator;
    float Curtime = 0;
    GameObject Mon = null;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        Curtime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.isPlay)
        {
            animator.SetBool("attack", false);
        }
        else
        {
            //0.5f초마다 갱신되는 if문
            if(Curtime + 0.5f < Time.time)
            {
                Curtime = Time.time;
                animator.SetBool("attack", true);
                Mon.GetComponent<Monster>().Damage(att);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "monster")
        {
            GameManager.instance.isPlay = false;
            Mon = col.gameObject;
        }
    }
}
