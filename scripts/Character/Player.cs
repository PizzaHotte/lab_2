using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
    private Vector3 _moveDirection;
    private bool isRunning;

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        InputManager.SetGameControls();
        isRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * _moveDirection;
    }

    public void SetMovementDirection(Vector3 currentDirection)
    {
        _moveDirection = currentDirection;
    }

    public void Run()
    {
        if(isRunning == false)
        {
            speed *= 2;
            isRunning = true;
        }
        else
        {
            speed /= 2;
            isRunning = false;
        }
    }
}
