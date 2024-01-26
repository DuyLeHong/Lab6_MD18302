using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    //Rigidbody2D rigidbody2D;
    //SpriteRenderer spriteRenderer;
    public GameObject panelEndGame;

    public GameObject effectPartical;

    void Start()
    {
    //    rigidbody2D = GetComponent<Rigidbody2D>();
    //    spriteRenderer = GetComponent<SpriteRenderer>();

        // Instantiate(effectPartical, 
        //             gameObject.transform);

    }

    //float movePrefix = 6;

    //public void Jump()
    //{
    //    rigidbody2D.AddForce(Vector2.up * movePrefix, ForceMode2D.Impulse);
    //}

    //public void moveLeft ()
    //{
    //    spriteRenderer.flipX = true;
    //    rigidbody2D.AddForce(Vector2.left * movePrefix, ForceMode2D.Impulse);
    //}

    //public void moveRight()
    //{
    //    spriteRenderer.flipX = false;
    //    rigidbody2D.AddForce(Vector2.right * movePrefix, ForceMode2D.Impulse);
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstacles")
        {
            Time.timeScale = 0;
            panelEndGame.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "fruits")
        {
            

            Transform tempTransform = collider.gameObject.transform;
            
            Vector2 pos = tempTransform.position;

            Debug.Log("an diem " + pos);

            Instantiate(effectPartical, pos, Quaternion.identity);

            Destroy(collider.gameObject, 1);

            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
