using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrash : MonoBehaviour
{
    public GameManager _gameManager;
    [SerializeField]
    private int _points;
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            _gameManager.RemoveScore(_points);
            Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag("Bin"))
        {
            _gameManager.AddScore(_points);
            Destroy(gameObject);
        }
    }
}
