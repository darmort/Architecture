using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button restartButton;
    public Button exitButton;

	void Start () {
		restartButton.GetComponent<Button>().onClick.AddListener(Restat);
		exitButton.GetComponent<Button>().onClick.AddListener(Exit);
	}

	void Restat(){
        SceneManager.LoadScene(0);
		 //GameObject.FindWithTag("Player").transform.position = new Vector3(341, 100, -211);
	}

    void Exit () {
        Application.Quit();
    }
}
