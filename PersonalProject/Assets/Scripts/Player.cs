using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.DefaultInputActions;

public class Player : MonoBehaviour
{
    public Rigidbody rigidBody;
    public static Player _Playerinstance;


    public InputAction PlayerControls;
    

    public int playerHealth = 5;
    public int playerDamage = 1;
    public float moveSpeed = 5f;

    
    Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Awake()
    {
        
        PlayerControls.Enable();
        
        //sets up the singleton for the gameManager
        if (_Playerinstance == null)
        {
            _Playerinstance = this;
            DontDestroyOnLoad(this);
        }

        else if (_Playerinstance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Vector3 myPos = _Playerinstance.transform.position;

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        moveDirection = PlayerControls.ReadValue<Vector3>();

        rigidBody.velocity = new Vector3(moveDirection.x * moveSpeed, 0, moveDirection.z * moveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Door")
        {
            //from what I believe the error is, 
           Vector3 myPos  = GetComponent<GameManager>().newSpawn;
        }
    }
}
