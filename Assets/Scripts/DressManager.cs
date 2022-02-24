using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressManager : MonoBehaviour
{
    public List<Color> forbiddenColors;
    
    public bool CheckColor(Color _color)
    {
        foreach(Color color in forbiddenColors)
        {
            if(_color == color)
            {
                return true;
            }
        }

        return false;
    }
}
