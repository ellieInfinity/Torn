using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(FindObjectOfType<NoLoad>().gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}