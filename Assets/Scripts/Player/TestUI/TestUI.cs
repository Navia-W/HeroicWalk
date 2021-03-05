using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUI : MonoBehaviour
{
    public void ShirtNext(int i)
    {
        AvatarManager.avatarManager.SelectShirt(i);
    } 
    public void HatNext(int i)
    {
        AvatarManager.avatarManager.SelectHat(i);
    }
}
