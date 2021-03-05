using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject finito;
    // Update is called once per frame
    void Update()
    {

            if (FindObjectOfType<Gladiatore>().isDead)
            {
            _ = WaitTime();
            finito.SetActive(true);
            }
      
    }
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(5);
    }
}
