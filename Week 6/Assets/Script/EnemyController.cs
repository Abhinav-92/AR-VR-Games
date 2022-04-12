using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyController : GazePointer
{
    public GameObject particleEffect;
    // public GameObject player;
    public Animator enemyModel;
    public float speed;

    // BulletSpawner bulletSpawner;
    Vector3 endPosition;
    // Start is called before the first frame update
    void Start()
    {
        endPosition = 1.5f * (transform.position - Vector3.zero).normalized;
        // bulletSpawner = GameObject.FindObjectOfType<BulletSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, endPosition, speed * Time.deltaTime);
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        // bulletSpawner.ShootBullet();
        Death();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            Attack();
        }
        else if(other.CompareTag("Enemy"))
        {
            Death();
        }
    }

    public void Death()
    {
        particleEffect.SetActive(true);
        particleEffect.transform.SetParent(null);
        Destroy(gameObject);
        PlayerManager.currentScore += 100;

    }

    public void Attack()
    {
        enemyModel.SetTrigger("attack");
        PlayerManager.playerHealth -= 0.2f;
    }
}
