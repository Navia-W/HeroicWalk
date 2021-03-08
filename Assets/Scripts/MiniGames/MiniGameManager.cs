using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameManager : MonoBehaviour
{
    public static MiniGameManager miniGameManager;

    [SerializeField]
    private List<GameObject> _miniGames;
    [SerializeField]
    private List<int> _scores;
    private int _rOutcome;
    private GameObject _activeMiniGame;

    private void Awake()
    {
        SelectMiniGame();
    }

    private void SelectMiniGame()
    {
        _activeMiniGame = Instantiate(_miniGames[_rOutcome = Random.Range(0, _miniGames.Count)]);
    }

    
    public void OnComplete()
    {
        //Save score
        SaveScore();

        //Load Main scene
        SceneSwitch.sceneSwitch.GoToScene(0);
    }

    public void SaveScore()
    {
        StaticManager.score = _scores[0];
        SaveData.saveData.GetVariables();
    }
}
