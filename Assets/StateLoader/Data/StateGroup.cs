﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
namespace StateLoader
{
    public abstract class StateGroup
    {
        public string stateName;
        public bool catchItems;
        public string[] subStateNames;
    }

    [System.Serializable]
    public class PrefabGroup : StateGroup
    {
        public List<PrefabStateItem> itemList = new List<PrefabStateItem>();
    }

    [System.Serializable]
    public class BundleGroup : StateGroup
    {
        public List<BundleStateItem> itemList = new List<BundleStateItem>();
    }
}