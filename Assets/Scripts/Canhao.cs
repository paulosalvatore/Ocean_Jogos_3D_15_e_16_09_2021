using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canhao : MonoBehaviour
{
    public GameObject balaDeCanhaoPrefab;

    public float delayInicial = 1f;

    public float delayEntreObjetos = 1f;

    public float forca = 100f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GerarBalaDeCanhao", delayInicial, delayEntreObjetos);
    }

    void GerarBalaDeCanhao()
    {
        var balaDeCanhao = Instantiate(balaDeCanhaoPrefab, transform.position, transform.rotation);

        var rb = balaDeCanhao.GetComponent<Rigidbody>();

        rb.AddRelativeForce(Vector3.up * forca);
    }
}
