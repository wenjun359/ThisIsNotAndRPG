using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueContorl : MonoBehaviour {

    public float waitTime=0.1f;
    public string speakerName;
    public string[] text;
    public string currentLine;
    public char[] textToLoad;
    public string textToView;
    public bool isLoading=false;
    public bool startLoading = false;
 

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	    

        
        if (startLoading == true && isLoading == false)
        {
            StartCoroutine(LoadText(currentLine));
        }

        


        
	}

    IEnumerator LoadText(string textToDisplay)
    {
        textToView = "";
        textToLoad = textToDisplay.ToCharArray();
        startLoading = false;
        isLoading = true;
        for (int i=0;i<text.Length;i++)
        {
            textToView += textToLoad[i];
            gameObject.GetComponent<Text>().text = textToView;
            yield return new WaitForSeconds(waitTime);
        }
        isLoading = false;
    }

    
}
