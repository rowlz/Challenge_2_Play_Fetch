using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    /// a Flag to check if a dog has been spawned
    private bool hasDogSpawned = false;

    
    // Update is called once per frame
    void Update()
    {
        //this checks if space button has been pressed and no dog has been spawned
        if (Input.GetKeyDown(KeyCode.Space) && hasDogSpawned == false)
        {
            StartCoroutine(SpawnDogs());
        }
    }

    private IEnumerator SpawnDogs()
    {
        //this will set the flag to true once the dog has been spawned
        hasDogSpawned = true;
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        //wait for 2 secs before the dog can be spawned again
        yield return new WaitForSeconds(2.0f);
        hasDogSpawned = false;

    }
}
