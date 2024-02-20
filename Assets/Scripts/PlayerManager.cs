using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody2D;
    //SpriteRenderer spriteRenderer;
    public GameObject panelEndGame;

    public GameObject effectPartical;

    public GameObject banana;

    public GameObject weapon;

    public AudioClip jump;
    public AudioClip collectFruit;
    private AudioSource audioSource;

    public TextMeshProUGUI scoreTxt;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        //    spriteRenderer = GetComponent<SpriteRenderer>();

        Instantiate(weapon, gameObject.transform);

        audioSource = GetComponent<AudioSource>();

        //Instantiate(effectPartical, gameObject.transform);

    }

    float movePrefix = 6;

    public void Jump()
    {
        rigidbody2D.AddForce(Vector2.up * movePrefix, ForceMode2D.Impulse);
    }

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

    public static int currentScore = 0;

    public static string TXT_SCORE_PREFIX = "Điểm số: ";

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "fruits")
        {


            audioSource.PlayOneShot(collectFruit);

            Destroy(collider.gameObject);

            currentScore += 5;

            scoreTxt.SetText(TXT_SCORE_PREFIX + currentScore.ToString());

            //Instantiate(effectPartical, new Vector3(0, 0, 0), Quaternion.identity);




        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        Jump();
    //    }
    //}
}
