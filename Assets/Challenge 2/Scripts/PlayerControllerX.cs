using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float timerToAllowInstantiate = 2;

    // Update is called once per frame
    void Update()
    {
        timerToAllowInstantiate += Time.deltaTime;
        Debug.Log("timeToAllowInstatiate: " + timerToAllowInstantiate);

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timerToAllowInstantiate > 2)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timerToAllowInstantiate = 0;
            }
        }
    }
}
