using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    public Transform feetpos;
    private bool ig;
    public float cr;
    public float jf;
    public LayerMask wig;
    public Rigidbody rb;
    public int jumps;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0.0f, z);

        transform.position += move * speed;
    }

    public void Jump()
    {
        ig = Physics2D.OverlapCircle(feetpos.position, cr, wig);
        if(jumps > 0 && ig)
        {
            rb.velocity = Vector3.up * jf;
        }

    }
}