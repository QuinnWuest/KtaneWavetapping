using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

using Random = UnityEngine.Random;
using Math = UnityEngine.Mathf;

public class scr_wavetapping : MonoBehaviour {
    public KMAudio BombAudio;
    public KMBombInfo BombInfo;
    public KMBombModule BombModule;
    public KMSelectable[] ModuleButtons;
    public KMSelectable ModuleSelect;

    bool moduleSolved;

    static int moduleIdCounter = 1;
    int moduleId;

    void Start() {
        moduleId = moduleIdCounter++;
    }
}