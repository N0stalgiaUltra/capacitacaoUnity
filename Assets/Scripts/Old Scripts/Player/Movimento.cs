using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade;
    public Rigidbody2D rb;
    public Vector2 mov;
    public SpriteRenderer sr;

    public bool estaChao;

    [SerializeField] private PlayerManager playerManager;

    private void Start()
    {
        velocidade = 5f;
    }

    void Update()
    {
        mov.x = Input.GetAxisRaw("Horizontal");
        mov.y = Input.GetAxisRaw("Vertical");

        if(mov.x == -1)
            sr.flipX = true;
        if(mov.x == 1)
            sr.flipX = false;

    }

    private void FixedUpdate()
    {
        // rb.MovePosition(rb.position + new Vector2(mov.x, 0) * velocidade * Time.deltaTime);
        rb.velocity = new Vector2(mov.x * velocidade, rb.velocity.y);
        
        if(estaChao)
            rb.velocity = new Vector2(rb.velocity.x , mov.y * velocidade * 1.5f);
            
    }

    public void Attack()
    {
        //rb.AddForce(new Vector2(0f, 1.5f), ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Chao")
            estaChao = true;

        if (other.gameObject.tag == "Coin")
        { 
            playerManager.Points += 10;
            Destroy(other.gameObject);
        }
        /*
        if (other.gameObject.tag == "Enemy")
            //Destroy(gameObject);
            Debug.Log("colidiu");*/
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Chao")
            estaChao = false;
    }

}

