using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-1)]
public class GameSceneScript : MonoBehaviour
{
    void Start()
    {
        GameSceneOpen();
    }

    void GameSceneOpen()
    {
        UIManager.Instance.ShowUI(UITypeClass.EnumUIType.Game);
    }
}
