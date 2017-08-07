﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BundleStateItem : StateItem
{
#if UNITY_EDITOR
    public GameObject prefab;
#endif
    public string assetName;
    public string assetBundleName;
    public override string ID
    {
        get
        {
            if (!reset)
            {
                return string.Format("[{0}][{1}]", assetBundleName, assetName);
            }
            else
            {
                return string.Format("[{0}][{1}][{2}][{3}]", assetBundleName, assetName, JsonUtility.ToJson(position), JsonUtility.ToJson(rotation));

            }
        }
    }
}
