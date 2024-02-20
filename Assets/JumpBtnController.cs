using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpBtnController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public GameObject player;

    public void OnPointerDown(PointerEventData eventData)
    {
        player.GetComponent<PlayerManager>().Jump();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Nut Jump duoc nha ra");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
