using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject enemyParent, player;
    public Movimento playerRef;
    [SerializeField] private PlayerManager playerManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.tag == "EnemyHead")
        {
            if (collision.gameObject.tag == "Player")
            {
                //playerRef.Attack();
                StartCoroutine(DestroyEnemy());
            }
        }

        if(this.gameObject.tag == "Enemy")
        {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(player);        
            }
        }
    }

    public IEnumerator DestroyEnemy()
    {
        Rigidbody2D player_rb = player.GetComponent<Rigidbody2D>();
        player_rb.AddForce(new Vector2(0, 5f), ForceMode2D.Impulse);
        playerManager.Points += 15;
        Destroy(enemyParent);
        yield return new WaitForSeconds(.1f);
    }

}
