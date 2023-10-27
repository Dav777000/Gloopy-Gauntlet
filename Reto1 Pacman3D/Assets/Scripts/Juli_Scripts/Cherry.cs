using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cherry : MonoBehaviour
{
    public GameObject pantallaVictoria;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pantallaVictoria.SetActive(true);
            Destroy(gameObject);
        }
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
