using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour
{
    [Header("SpawnLeft")]
    [SerializeField] Transform[] spawnLeft;
    [Header("SpawnRight")]
    [SerializeField] Transform[] spawnRight;

    public float swinSpeed = 1f;
    public float destX = 0;
    public bool toRight = false;

    private void Start()
    {
        swinSpeed = Random.Range(0.5f, 3f);
        Transform[] spawn = new Transform[2];
        if (Random.Range(0, 10) < 5)
        {
            spawn = spawnLeft;
            transform.rotation = Quaternion.identity;
            destX = 12f;
            toRight = true;
        }
            
        else
        {
            spawn = spawnRight;
            transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
            destX = -12f;
            toRight = false;
        }

        transform.position = new Vector3(spawn[0].position.x,
                                        Random.Range(spawn[1].position.y, spawn[0].position.y),
                                        0);
            
    }

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * swinSpeed);
        
        if(toRight)
            if (transform.position.x > destX)
            {
                Instantiate(gameObject, new Vector3(10, 10, 0), Quaternion.identity);
                Destroy(gameObject);
            }
        if(!toRight)
            if (transform.position.x < destX)
            {
                Instantiate(gameObject, new Vector3(10, 10, 0), Quaternion.identity);
                Destroy(gameObject);
            }
        
    }

}
