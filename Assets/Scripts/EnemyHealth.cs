using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float maxHitPoints = 5f;
    [SerializeField] int difficultyramp = 1;
    float currentHitPoint = 0f;

    Enemy enemy;
    void OnEnable()
    {
        currentHitPoint = maxHitPoints;
    }

    void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }
    void ProcessHit()
    {
        currentHitPoint--;

        if (currentHitPoint <= 0)
        {
            gameObject.SetActive(false);
            maxHitPoints += difficultyramp;
            enemy.RewardGold();
        }
    }
}
