using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgegapConfig
{
    public int MaxDuration { get; set; }
    public int TimeToDeploy { get; set; }
    public List<EnvsData> Envs { get; set; }
}

public class EnvsData
{
    public string Key { get; set; }

    public string Value { get; set; }

    public bool IsSecret { get; set; } = true;
}