using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class TerrainData : UpdatableData
{
    public bool useFalloff;
    public int mapChunkSize = 150;
    public float meshHeightMultiplier;
    public AnimationCurve meshHeightCurve;

}
