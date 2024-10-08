using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialogueBuilder : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI tmpro;
    public string[] text;
    private string currentText;
    private int x = 0;

    // Start is called before the first frame update
    private void Start()
    {
        currentText = text[x];
        Invoke("BuildText", 0.05f);
    }


    void BuildText()
    {
        StopAllCoroutines();

        string targetText = currentText;
        StartCoroutine(BuildingText(targetText));
    }

    IEnumerator BuildingText(string targetText)
    {
        tmpro.text = " ";
        foreach(char c in targetText)
        {
            tmpro.text += c;
            yield return new WaitForSeconds(0.01f);
        }
        Debug.Log(x);
    }

    public void OnClick()
    {
        if(x < text.Length-1)
        {
            x++;
            currentText = text[x];
            Invoke("BuildText", 0.02f);
        }
    }
}
