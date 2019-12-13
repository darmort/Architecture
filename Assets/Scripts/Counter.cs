using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int Count = 0;
    // Start is called before the first frame update
    void Start()
    {
        Count = GameObject.FindGameObjectsWithTag("Point").Length;
        GameObject.Find("Point").GetComponent<UnityEngine.UI.Text>().text = "0/" + Count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
