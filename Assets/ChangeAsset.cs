using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAsset : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] List<Sprite> sprites;

    private int index = 0;

    public void ChangeGameAsset()
    {
        if (index < sprites.Count - 1)
        {
            index++;
            spriteRenderer.sprite = sprites[index];
        }
    }

    public void ChangeGameAssetRandom()
    {
        index = Random.Range(0, sprites.Count - 1);
        spriteRenderer.sprite = sprites[index];
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
