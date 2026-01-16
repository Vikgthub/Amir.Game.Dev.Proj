using UnityEngine;


/* create coding to display a victory message once the user has complete the last level  */

public class VictoryTrigger : MonoBehaviour
{

    public GameObject victoryCanvas;

    // detect when the object collider enters this object trigger zone
    private void OnTriggerEnter2D(Collider2D other)

    {

        // check if the player touches the tree
        if (other.CompareTag("Player"))

        {
            // cctivates the hidden ui  canvas (is hidden so it can be shown once user touched the tree to display the victory message)
            victoryCanvas.SetActive(true);

            // freeze the gameplay once the user wins and finished the last level and touches the tree
            Time.timeScale = 0f;
            Debug.Log("Victory Triggered!");
        }


    }

}