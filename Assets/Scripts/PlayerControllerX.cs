using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogDelay = 1f;
    private bool _dogReady = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && _dogReady)
        {
            _dogReady = false;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Invoke("getDogReady", dogDelay);
        }
    }

    private void getDogReady()
    {
        _dogReady = true;
    }
}
