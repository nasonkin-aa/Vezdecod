using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private GameObject Character;
    private float Speed = 0.01f;
    private bool IsFloar;
    private float JumpForce = 5;
    private Rigidbody2D CharRb;
    [SerializeField]
    SceneManagerKey sceneManager;

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floar" || collision.gameObject.tag == "Wall")
        {
            IsFloar = true;
        }
        if (collision.gameObject.tag == "Wall")
        {
            Speed *= -1;
        }
        if (collision.gameObject.tag == "Spike")
        {
            Destroy(Character);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex)
        }
        if (collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
            sceneManager.AddKey();
        }
    }
 
    void Start()
    {
        CharRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && IsFloar )
        {
            Debug.Log("dsa");
            CharRb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            IsFloar = false;
        }
        Character.transform.Translate(Speed, 0, 0);
    }
    
}
