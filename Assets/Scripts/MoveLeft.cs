using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playerControllerScripts;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.Find("Player");
        if (playerObject != null)
        {
            playerControllerScripts = playerObject.GetComponent<PlayerController>();
        }
        else
        {
            Debug.LogError("Player object not found!");
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (playerControllerScripts.gameOver == false)
        {  
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) { Destroy(gameObject); }
    }
    }
}
