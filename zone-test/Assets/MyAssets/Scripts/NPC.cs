using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{

    [SerializeField] private Text _canvasText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D Collision)
    {
        Debug.Log("Hit by -" + Collision.gameObject.name);
       // _canvasText.SetActive(true);
    }
}
