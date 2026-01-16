using UnityEngine;
using UnityEngine.SceneManagement;


/* make script so that th e user moves from level 1 to leverl 2  */
public class LevelLoader : MonoBehaviour
{

    [Header("Transition Settings")]

    public string nextLevelName;

    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.CompareTag("Player"))
        {
            // request the engine to load a new scene by string name
            SceneManager.LoadScene(nextLevelName);
        }

    }

}