using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector2 _moveDir;
    void Start()
    {
        InputManager.Init(myPlayer: this);
        InputManager.Gamemode();
    }

    
    void Update()
    {
        
    }

    public void SetMovementDirection(Vector2 newDirection)
    {
        Debug.Log("its working");
        _moveDir = newDirection;


    }

    
}
