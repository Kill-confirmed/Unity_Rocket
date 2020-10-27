using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour{
    Rigidbody rigidBody;


    // Start is called before the first frame update
    void Start() {
        rigidBody=GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update() {
        ProcessInput();
    }

    private void ProcessInput(){
       // GetKey applies all the time and will report tge status of the named key.
        if (Input.GetKey(KeyCode.Space)){
            print("Thrust");
            rigidBody.AddRelativeForce(Vector3.up);
          
        }
        // Rotate left or right
        if (Input.GetKey(KeyCode.A)){
            // print("Rotate Left");
            transform.Rotate(Vector3.forward);
        }

        else if (Input.GetKey(KeyCode.D)){
            // print("Rotate Right");
            transform.Rotate(-Vector3.forward);
        }
        

    }
}
