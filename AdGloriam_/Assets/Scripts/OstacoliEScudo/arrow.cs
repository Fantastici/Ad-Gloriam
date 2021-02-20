using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{

    public float speed = -3f;
    private Rigidbody2D rb;

    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, 0);

        if (transform.position.x < screenBounds.x * -300)
        {
            Destroy(this.gameObject);
        }
    }
    /*Metodo che decrementa la vita del player*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameControl.health -= 1;
    }
}

