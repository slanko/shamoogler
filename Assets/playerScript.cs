using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    [SerializeField] float moveSpeed, turnSpeed;
    [SerializeField] KeyCode upKey, downKey, leftKey, rightKey;
    Animator anim;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(0, 0, v * moveSpeed * Time.deltaTime);
        transform.Rotate(0, h * turnSpeed * Time.deltaTime, 0);
        anim.SetFloat("walkey", v);
    }
}
