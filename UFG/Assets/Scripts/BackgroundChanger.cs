/*
    As name said this script help tu chande the sprites of the bakcground
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    // Variables
        //Array of sprites
    public Sprite[] Bg;
    public SpriteRenderer Ren;
    // identifier of the sprite background
    public int index;

    // Start is called before the first frame update
    void Start()
    {

        index = PlayerPrefs.GetInt("Stage");
        Ren = GetComponent<SpriteRenderer>();
        Ren.sprite = Bg[index];
    }
}
