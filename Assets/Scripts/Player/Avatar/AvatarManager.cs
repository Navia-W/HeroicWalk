using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarManager : MonoBehaviour
{
    public static AvatarManager avatarManager;

    [SerializeField]
    private GameObject _avatar;
    [SerializeField]
    private List<GameObject> _hats, _shirts;
    [SerializeField]
    private GameObject _shirt, _hat;
    [SerializeField]
    private int _currentShirt, _currentHat;

    private void Awake()
    {
        if (avatarManager != null)
            return;

        avatarManager = this;
    }

    void Start()
    {
        //load avatar customization as saved previosly.
        LoadData.loadData.GetVariables();
        _currentHat = StaticManager.currentHat;
        _currentShirt = StaticManager.currentShirt;
    }

    //Adds shirt to shirts list.
    public void AddToShirts(GameObject newShirt)
    {
        _shirts.Add(newShirt);
    }

    //Adds hat to hats list.
    public void AddToHats(GameObject newHats)
    {
        _shirts.Add(newHats);
    }

    //Cycles through the shirt list.
    public void SelectShirt(int next)
    {
        if (_currentShirt + next > _shirts.Count - 1)
        {
            _currentShirt = 0;
            _shirt = _shirts[_currentShirt];
        }
        else if(_currentShirt + next < 0)
        {
            _currentShirt = _shirts.Count - 1;
            _shirt = _shirts[_currentShirt];
        }
        else
        {
            _currentShirt += next;
            _shirt = _shirts[_currentShirt];
        }
    }
    
    //Cycles through the hat list
    public void SelectHat(int next)
    {
        if (_currentHat + next > _hats.Count - 1)
        {
            _currentHat = 0;
            _hat = _hats[_currentHat];
        }
        else if(_currentHat + next < 0)
        {
            _currentHat = _hats.Count - 1;
            _hat = _hats[_currentHat];
        }
        else
        {
            _currentHat += next;
            _hat = _hats[_currentHat];
        }
    }

    /// <summary>
    /// Saves current avatar settings.
    /// </summary>
    public void SaveAvatar()
    {
        StaticManager.currentHat = _currentHat;
        StaticManager.currentShirt = _currentShirt;
        SaveData.saveData.GetVariables();
    }
}
