using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI _scoreText;
    
    // Update is called once per frame
    void Update()
    {
        _scoreText.text = GameManager.Score.ToString();
    }
}
