using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundColor : MonoBehaviour
{
    public GameObject soundOnImg;
    public GameObject soundOffImg;

    void Start()
    {
        soundOffImg.GetComponent<Image>().color = new Color32(120, 120, 120, 255);
    }

    public void SoundOnImg()
    {
        soundOnImg.GetComponent<Image>().color = new Color32(0, 250, 250, 255);
        soundOffImg.GetComponent<Image>().color = new Color32(120, 120, 120, 255);
    }

    public void SoundOffImg()
    {
        soundOnImg.GetComponent<Image>().color = new Color32(120, 120, 120, 255);
        soundOffImg.GetComponent<Image>().color = new Color32(0, 250, 250, 255);
       
    }
}
