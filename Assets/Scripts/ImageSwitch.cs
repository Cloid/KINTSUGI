using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class ImageSwitch : MonoBehaviour
{
    public Sprite[] newImg;
    private Image curImage;
    public int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        //Background.enabled = false;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (count > 7)
            {
                SceneManager.LoadScene("Level");
            }

            curImage = this.GetComponent<Image>();
            curImage.sprite = newImg[count];
            count++;


        }
    }
}
