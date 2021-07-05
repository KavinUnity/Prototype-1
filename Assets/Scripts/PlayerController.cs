using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public float speed;
    public float turnSpeed;
    private float horizontalInput;
    private float forwardInput;
    public string inputId;
    public Vector3 pos;
    public Quaternion rot;
    public GameObject player1;
    public GameObject player2;
    public GameObject canvas;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Axis setup
        horizontalInput = Input.GetAxis("Horizontal" + inputId);
        forwardInput = Input.GetAxis("Vertical" + inputId);


        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Turn the vehicle right or left
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(switchKey)){

            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    
        if(Input.GetKeyDown(KeyCode.R)){
            player1.transform.SetPositionAndRotation(pos, rot);
        }

        if(Input.GetKeyDown(KeyCode.L)){
            player2.transform.SetPositionAndRotation(pos, rot);
        }

    }

    
}
