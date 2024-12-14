using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _distanceText;
    [SerializeField] private Transform _playerTrans;

    private Vector2 _startPosotion;
    
    private void Start()
    {
        _startPosotion = _playerTrans.position;
    }

    private void Update()
    {
        Vector2 distance = (Vector2)_playerTrans.position - _startPosotion;
        distance.y = 0f;

        if (distance.x <0)
        {
            distance.x = 0;
        }
        
        _distanceText.text = distance.x.ToString("F0") + "m";
    }
}
