using UnityEngine;


/* create the script so thr user can collect the flowers */

public class Flower : MonoBehaviour


{
    // here the player will touch the flower and the code will help the game react
    private void OnTriggerEnter2D(Collider2D other)


    {



        // here the player can trigger the collectiob
        if (other.CompareTag("Player"))
        {

            // find the player controller script on the player object and then and execute the pickup flower logic to increment the scores
            other.GetComponent<PlayerController>().PickupFlower();

            // after flower is collected, remove the flower from the scene 
            Destroy(gameObject);
        }

    }


}