using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEVELLOADER : MonoBehaviour
{
    public void StartPlaying() {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    public void lev(int level) {
        Application.LoadLevel(level);
    }
   public void Mainback()
    {
        Application.LoadLevel(0);
    }
}
