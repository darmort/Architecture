using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        var currentScale = GameObject.FindWithTag("Player").transform.localScale;

        GameObject.FindWithTag("Player").transform.localScale = new Vector3(
            currentScale.x + 5,
            currentScale.y + 5,
            currentScale.z + 5
        );
        GameObject.FindWithTag("Player").transform.position = new Vector3(
            GameObject.FindWithTag("Player").transform.position.x,
            GameObject.FindWithTag("Player").transform.position.y + 5,
            GameObject.FindWithTag("Player").transform.position.z
        );

        GameObject.Find("Point").GetComponent<UnityEngine.UI.Text>().text =
            (GameObject.Find("Point").GetComponent<Counter>().Count - (GameObject.FindGameObjectsWithTag("Point").Length - 1)).ToString()
            + "/" +  GameObject.Find("Point").GetComponent<Counter>().Count;

        Destroy(this.gameObject);
    }
}
