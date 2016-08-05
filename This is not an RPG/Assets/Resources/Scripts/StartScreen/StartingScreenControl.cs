using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartingScreenControl : MonoBehaviour {

    GameObject[] objs=new GameObject[6];
    public GameObject options;
    public AudioClip click;

    void Awake()
    {
        for (int i = 0; i < 6; i++)
        {

            objs[i] = gameObject.transform.GetChild(i).gameObject;
            objs[i].GetComponent<CanvasRenderer>().SetAlpha(0f);

        }

        objs[1].GetComponent<CanvasRenderer>().SetAlpha(-1f);

    }

	// Use this for initialization
	void Start () {



        

    }

    // Update is called once per frame
    void Update()
    {
        FadeOutTitle();
        FadeInGameMenu();
        TouchHandle();

        if (Time.realtimeSinceStartup >= 10f)
        {
            ActivateButtons();
        }


    }

    	
    void FadeOutTitle()
    {
        if (Time.realtimeSinceStartup >= 7f)
        {
            for (int i = 0; i < 2; i++)
            {
                objs[i].GetComponent<FadeOutUI>().isFadeOut = true;
            }
        }
    }

    void FadeInGameMenu()
    {
        if (objs[0].GetComponent<CanvasRenderer>().GetAlpha()<0)
        {
            for (int i = 2; i < 6; i++)
            {

                objs[i].GetComponent<FadeInUI>().isFadeIn = true;

            }
        }
    }

    void TouchHandle()
    {

        
    }

    void LoadNewGame()
    {
        SceneManager.LoadScene("NewCharacter");
    }

    void ActivateButtons()
    {
        if (GameObject.Find("Mask")!=null)
        {
            GameObject.Find("Mask").SetActive(false);
        }
        
    }


    // PUBLIC METHODS

    public void StartNewGame()
    {
        Invoke("LoadNewGame", 2f);
        ClickSound();
        for (int i = 2; i < 6; i++)
        {
            objs[i].GetComponent<FadeOutUI>().isFadeOut = true;
        }

    }

    public void SkipIn()
    {
        for (int i = 0; i < 2; i++)
        {
            objs[i] = gameObject.transform.GetChild(i).gameObject;
            objs[i].SetActive(false);
        }

        for (int i = 2; i < 6; i++)
        {
            objs[i] = gameObject.transform.GetChild(i).gameObject;
            objs[i].GetComponent<CanvasRenderer>().SetAlpha(1f);
        }
        GameObject.Find("Mask").SetActive(false);
    }

    public void Countinue()
    {
        ClickSound();

    }

    public void Options()
    {
        ClickSound();
        options.SetActive(true);
    }

    public void Credits()
    {
        ClickSound();

    }

    public void ClickSound()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(click);
    }

}
