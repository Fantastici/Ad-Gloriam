using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    private AudioSource audioFreccia;
    public float speed = -3f;
    private Rigidbody2D rb;

    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        audioFreccia = GetComponent<AudioSource>();
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
    public void setSpeedAZero()
    {
        speed = 0;
    }
    public AudioSource getAudio()
    {
        return audioFreccia;
    }
    
}

