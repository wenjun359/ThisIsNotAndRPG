using UnityEngine;
using System.Collections;

public class FadeOutUI : MonoBehaviour {

    public GameObject obj;
    public bool isFadeOut = false;
    public float a=1f;

    // Use this for initialization
    void Start()
    {
        if (obj == null)
        {
            obj = gameObject;
           
        }
    }
    // Update is called once per frame
    void Update()
    {

        if (obj != null && a >= 0f && isFadeOut)
        {
            a -= 0.01f;
            obj.GetComponent<CanvasRenderer>().SetAlpha(a);
            
        }


    }
}
