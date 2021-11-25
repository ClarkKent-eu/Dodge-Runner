using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 40.0f;
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;


    // Start is called before the first frame update
    void Start()

    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }


        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }


    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}

