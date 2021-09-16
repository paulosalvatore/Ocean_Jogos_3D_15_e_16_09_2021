using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public Rigidbody rb;

    public float velocidade = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var v = Input.GetAxis("Vertical") * velocidade;
        var h = Input.GetAxis("Horizontal") * velocidade;

        rb.velocity = new Vector3(h, rb.velocity.y, v);
    }
}
