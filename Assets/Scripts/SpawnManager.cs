using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] trashPrefabs;
    private float _randomX;
    private Vector3 _spawnPosition;
    public float spawnDelay;

    void Start()
    {
        StartCoroutine(SpawnBall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator SpawnBall()
    {

        for (int i = 0; i < 30; i++)
        {
            _randomX = Random.Range(-35, 45);
            _spawnPosition = new Vector2(_randomX, transform.position.y);
            int index = Random.Range(0, trashPrefabs.Length);
            GameObject ball = Instantiate(trashPrefabs[index], _spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
