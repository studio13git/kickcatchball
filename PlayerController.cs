using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    
    public float speed = 7;
    private bool hasPosession = false;
    public Vector3 playerOrientation;
    Rigidbody ballRb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        ballRb = GameObject.Find("Ball").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Four lines of code that denote the types of movement players will be able to make
        float horizontalInput = Input.GetAxis("Horizontal");
        float forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * forwardInput * speed * Time.deltaTime);


      
        if (Input.GetKeyDown(KeyCode.Space) && hasPosession == true){
                Debug.Log(playerOrientation.x - ballRb.transform.position.x);
                //ballRb.MoveRotation(new Vector3 )
                playerOrientation.x = transform.position.x;
                ballRb.AddForce(transform.position * -2, ForceMode.Impulse);
            }
        /*if (hasPosession == true)
        {
                ballRb.transform.position = Vector3.MoveTowards(ballRb.transform.position*-1, transform.position*-1, 5*Time.deltaTime );
                
        }
        */
        


       
    }
        void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.CompareTag("Ball"))
            {
                Debug.Log("Has posession is" + hasPosession);
                hasPosession  = true;
            }
            
        }

        void OnCollisionExit(Collision collision) {
            if (collision.gameObject.CompareTag("Ball"))
            {
                Debug.Log("Has posession is" + hasPosession);
                hasPosession = false;
            }
            
        }
}
