using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    public Sprite[] Bg;
    public SpriteRenderer Ren;
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        index = PlayerPrefs.GetInt("Stage");
        Ren = GetComponent<SpriteRenderer>();
        Ren.sprite = Bg[index];
    }
}
