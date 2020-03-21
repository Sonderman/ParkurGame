using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement pMovement;
    //public GameManager gameManager;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Duvar")
        {
            Debug.Log("Duvara Çarptın Usta");
            pMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
