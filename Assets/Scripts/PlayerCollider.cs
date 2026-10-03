using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private GameManager gameManager;
    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }// Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("coin"))
        {
           
            gameManager.congdiem(1);
            Destroy(collision.gameObject);
            //Debug.Log("Hit coin");
        }
    }
}
