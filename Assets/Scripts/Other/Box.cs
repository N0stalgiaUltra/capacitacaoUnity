using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sr;

    [SerializeField] private Color colorBefore;
    [SerializeField] private Color colorAfter;

    public PlayerManager playerManager;
    public int hits;
    public int limite;
    public bool finished;

    private void Start()
    {
        this.sr.color = colorBefore;
    }
    private void Update()
    {
        /*
        if (this.hits >= 3)
            finished = true;
        else
            finished = false;*/

        finished = hits >= limite ? true : false;
        
        if (finished)
        {
            sr.color = colorAfter; 
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(!finished)
            {
                hits++;
                playerManager.Points += 10;
            }
        }
    }
}
