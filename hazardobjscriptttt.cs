using UnityEngine;
using UnityEngine.SceneManagement;


/* make coding so if the user touches the red flowers, the game restarts   */
public class RedFlower : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {


        // check if the player touch the flowers 
        if (other.CompareTag("Player"))
        {
            // if so then restart game
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

}