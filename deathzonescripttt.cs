using UnityEngine;
using UnityEngine.SceneManagement;


/* create a zone below the ground so the game will reset once the user falls */
public class Hazard : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        // here, check if the player touches the white rectangle below ground tiles 
        if (other.CompareTag("Player"))
        {
            // then reset the level
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


    }
}