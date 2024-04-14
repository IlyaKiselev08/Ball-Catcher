using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreText;
    private float _points;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int points)
    {
        _points += points;
        UpdateText();
    }
    public void RemoveScore(int points)
    {
        _points -= points;
        UpdateText();
    }
    private void UpdateText()
    {
        _scoreText.text = "Score: " + _points;
    }
}
