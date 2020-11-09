using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour{
    [SerializeField] float rcsThrust=100f;
    
    Rigidbody rigidBody;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start() {
        rigidBody=GetComponent<Rigidbody>();
        audioSource=GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update() {
        Rotate();


        // GetKey applies all the time and will report tge status of the named key.
        if (Input.GetKey(KeyCode.Space)){
            Thrust();            
            
        }
        else{
            audioSource.Stop();

        }
    }

    private void Rotate(){
        
        float rotaionThisFrame=rcsThrust * Time.deltaTime;
        // freeze rotation before we take manual control of rotation
        rigidBody.freezeRotation=true;
        // Rotate left or right
        if (Input.GetKey(KeyCode.A)){
            // rotate left about the Z-axis
            transform.Rotate(Vector3.forward * rotaionThisFrame);
        }

        else if (Input.GetKey(KeyCode.D)){
            // rotat right about the Z-axis
            transform.Rotate(-Vector3.forward * rotaionThisFrame);
        }
        // resume physics control
        rigidBody.freezeRotation=false;
        

    }

    private void Thrust(){
        // Adding force to rocket
        rigidBody.AddRelativeForce(Vector3.up);
           
        // so audio doesnt layer
        if(!audioSource.isPlaying){
                audioSource.Play();
         } 
    }
}
