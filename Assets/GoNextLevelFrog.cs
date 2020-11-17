﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextLevelFrog : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== triggeringTag)
            SceneManager.LoadScene(sceneName);    // Input can either be a serial number or a name; here we use name.
    }
}
