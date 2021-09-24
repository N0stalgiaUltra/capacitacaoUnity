using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 movimento;
    public float velocidade;

    public bool estaChao;
    void Start()
    {
        estaChao = false;
    }

    void Update()
    {

        /*** Movimento do Player ***/ 
        
        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movimento.x * velocidade, rb.velocity.y);

        if(estaChao)
            rb.velocity = new Vector2(rb.velocity.x, movimento.y * velocidade);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Chao")
            estaChao = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Chao")
            estaChao = false;
    }
}


//movimento.y * velocidade