using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungryMonster : MonoBehaviour
{
    private Rigidbody2D _monsterRb;
    [SerializeField] private float enemySpeed;
    void Start()
    {
        _monsterRb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _monsterRb.velocity = new Vector2(enemySpeed, 0);
    }
    private void FlipHungryMonster()
    {
        transform.localScale = new Vector2(-(Mathf.Sign(_monsterRb.velocity.x)), 1);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        FlipHungryMonster();
        enemySpeed = -enemySpeed;
    }
}
