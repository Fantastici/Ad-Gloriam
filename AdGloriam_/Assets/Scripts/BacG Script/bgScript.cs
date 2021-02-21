using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgScript : MonoBehaviour
{
    Material material;
    Vector2 offset;

    public float xVelocity;
    public float yVelocity;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector2(xVelocity, yVelocity);

    }

    // Update is called once per frame
    void Update()
    {

        material.mainTextureOffset += offset * Time.deltaTime;
    }
    public void SetVelocity(float x, float y)
    {
        offset = new Vector2(x, y);
    }
}

