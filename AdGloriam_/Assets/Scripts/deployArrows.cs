using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployArrows : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float respawnTime = 1.0f;
    public float yLb = 1.36f;
    public float yUb = 4.15f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(arrowWawe());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(arrowPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 8, Random.Range(yLb, yUb));

    }

    IEnumerator arrowWawe()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }

    }

    
}
