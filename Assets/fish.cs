using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour
{
    [Header("Original scale")]
    [SerializeField] Vector3 originalScale;
    [Header("SpawnLeft")]
    [SerializeField] Transform[] spawnLeft;
    [Header("SpawnRight")]
    [SerializeField] Transform[] spawnRight;
    [Header("Swim Speed Range")]
    [SerializeField] float speedMin = 0.5f;
    [SerializeField] float speedMax = 3f;
    [SerializeField] float scaleMin = 1f;
    [SerializeField] float scaleMax = 1f;

    [SerializeField] Transform fishPool;

    public float swinSpeed = 1f;
    public float destX = 0;
    public bool toRight = false;

    private void Start()
    {
        swinSpeed = Random.Range(speedMin, speedMax);
        transform.localScale = originalScale * Random.Range(scaleMin, scaleMax);
        Transform[] spawn = new Transform[2];
        if (Random.Range(0, 10) < 5)
        {
            spawn = spawnLeft;
            transform.rotation = Quaternion.identity;
            destX = spawnRight[0].position.x;
            toRight = true;
        }
            
        else
        {
            spawn = spawnRight;
            transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
            destX = spawnLeft[0].position.x;
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
                transform.localScale = originalScale;
                 GameObject _fish = Instantiate(gameObject, new Vector3(10, 10, 0), Quaternion.identity, fishPool);
                _fish.name = gameObject.name;
                Destroy(gameObject);
            }
        if(!toRight)
            if (transform.position.x < destX)
            {
                transform.localScale = originalScale;
                GameObject _fish = Instantiate(gameObject, new Vector3(10, 10, 0), Quaternion.identity, fishPool);
                _fish.name = gameObject.name;
                Destroy(gameObject);
            }
        
    }

}
