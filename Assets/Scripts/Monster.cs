using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int HP = 100;
    int oriHP;
    public float monSpeed = 8;
    public Vector2 StartPositon;

    // 동전
    public ItemFx prefabItem;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Damage(int att)
    {
        HP -= att;

        if(HP<=0)
        {
            gameObject.SetActive(false);
            transform.position = StartPositon;
            HP = 100;
            GameManager.instance.isPlay = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.isPlay)
        {
            transform.Translate(Vector2.left * Time.deltaTime * GameManager.instance.gameSpeed);

            if(transform.position.x < -33)
            {
                gameObject.SetActive(false);
                transform.position = StartPositon;
            }
        }
    }
}
