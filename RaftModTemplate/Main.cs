using HarmonyLib;
using UnityEngine;
using System;
using Object = UnityEngine.Object;
using Debug = UnityEngine.Debug;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using UnityEngine.UI;
using HMLLibrary;
using System.Linq;
using Steamworks;
using System.IO;
using RaftModLoader;


namespace RaftModTemplate
{
    public class Main : Mod
    {
        public void Start()
        {
            Log("Mod has been loaded!");
        }

        public void OnModUnload()
        {
            Log("Mod has been unloaded!");
        }
    }
}