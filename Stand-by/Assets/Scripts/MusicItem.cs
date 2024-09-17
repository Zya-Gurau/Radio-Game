using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicItem
{
    public String musicName;
    public String genre;
    public String format;
    public Sprite sprite;
    public String getDescription()
    {
        return "genre: " + genre + "\n" + "format: " + format + "\n";
    }
}
