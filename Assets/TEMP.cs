using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TEMP : MonoBehaviour
{
    public GameObject canvas;
    public GameObject textBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        canvas.SetActive(true);
        StartCoroutine(ShowText());
    }

    public void OnClick2()
    {
        SceneManager.LoadScene("TalkingTEmp");
    }

    IEnumerator ShowText()
    {
        yield return new WaitForSeconds(1.5f);
        textBox.SetActive(true);
    }

    public void OnClick3()
    {
        canvas.SetActive(false);
        textBox.SetActive(false);
    }
}
