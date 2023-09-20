using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallOfDoom : MonoBehaviour
{
    float speedanonymousultiplier = 0.3f;

    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speedanonymousultiplier);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
