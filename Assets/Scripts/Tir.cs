using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tir : MonoBehaviour
{
    [SerializeField]
    private GameObject EnnemiPrefab;

    [SerializeField]
    private float EnnemiInterval = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(EnnemiInterval, EnnemiPrefab));
     
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator spawnEnemy( float interval, GameObject Ennemi)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnnemi = Instantiate(Ennemi, new Vector3(Random.Range(-5f, 5f), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, Ennemi));
    }
}
