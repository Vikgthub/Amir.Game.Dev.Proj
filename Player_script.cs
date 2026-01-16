using UnityEngine;
using TMPro;



/* create coding so user can move and jump */
public class PlayerController : MonoBehaviour
{
    [Header("Physics Settings")]
    public float moveSpeed = 10f;
    public float jumpForce = 15f;




    /* ------------------------------------------------------------------------------------------------------------ */


    [Header("UI References")]
    public TextMeshProUGUI flowerText;

    public int flowersCollected = 0;


    private Rigidbody2D rb;
    private float moveInput;







    /* ------------------------------------------------------------------------------------------- */

    void Start()
    {
        // store the rigidbod reference to save processing power in tje update
        rb = GetComponent<Rigidbody2D>();

        if (flowerText != null)
        {
            flowerText.text = "Flowers: 0 / 3";
        }
    }







    /* ------------------------------------------------------------------------------- */


    void Update()
    {
        // read the horixontal axis (a or d)
        moveInput = Input.GetAxisRaw("Horizontal");

        // update the physics and the movement 
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);


        if (moveInput > 0) transform.localScale = new Vector3(-1, 1, 1);  //since my player sprite asset is fliped backward by defualt, i changed it so face foeward
        else if (moveInput < 0) transform.localScale = new Vector3(1, 1, 1);



        // use the linearvelocity y check to  prevent infinite jumping
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.linearVelocity.y) < 0.01f)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    /* --------------------------------------------------------------------------------------------- */







    public void PickupFlower()
    {
        flowersCollected++;

        // change and save the score to a text mesh pro string
        if (flowerText != null)
        {
            flowerText.text = flowersCollected + " / 3";
        }

        // once the player collected all the collectable flowers, then display a green message and the flower count 3/3
        if (flowersCollected >= 3)
        {
            flowerText.text = "3 / 3";
            flowerText.color = Color.green;
        }
    }
}





/* ------------------------------------------------------------------------- */