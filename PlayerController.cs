using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    new Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Four lines of code that denote the types of movement players will be able to make
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        Debug.Log("Right");
        

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        Debug.Log("Left");
        playerPos = transform.position;
        playerPos.position.x--;
        transform.position = position;
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        Debug.Log("Down");
        if (Input.GetKeyDown(KeyCode.UpArrow))
        Debug.Log("Up");
        if (Input.GetKeyDown(KeyCode.Space))
        Debug.Log("Space");
    }
}
