using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBalas : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;
    public Vector3 direction = Vector3.forward;
    public int damage = 3;
    public float livetime = 3f;
    void Start()
    {
        Invoke("destruirBala", livetime);
    }

    // Update is called once per frame
    void Update()
    {
        move(direction);
    }
    void move(Vector3 direccion)
    {
        transform.position += direccion * speed * Time.deltaTime;
    }
    private void destruirBala()
    {
        Destroy(gameObject);
    }
}
