using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class NoiseVoxe1Map : MonoBehaviour
{
    public GameObject blockPrefabDirt;

    public GameObject blockPrefabGrass;

    public GameObject blockPrefabWater;

    public int widht = 20;

    public int depth = 20;

    public int maxHeight = 16;

    public int waterLevel = 4;

    [SerializeField] float noiseScale = 20f;
    // Start is called before the first frame update
    void Start()
    {

        float offestX = Random.Range(-9999f, 9999f);
        float offestZ = Random.Range(-9999f, 9999f);

        for (int x = 0; x < widht; x++)
        {
            for (int z = 0; z < depth; z++)
            {
                float nx;- (x + offestX) / noiseScale;
                float nz -(z + offestZ) / noiseScale;
                float noise = Mathf.PerlinNoise(nx, nz);
                int h = Mathf.FloorToInt(noise * maxHeight);
                if (h <= 0) h = 1;
                for (int y = 0; y <= h; y++)
                {
                    if (y == h)
                        PlaceGrass(x, y, z);
                    else
                        PlaceDirt(x, y, z);
                }
                for (int y = h + 1; y <= waterLevel; y++)
                {
                    PlaceWater(x, y, z);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
