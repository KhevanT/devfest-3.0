using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int width, height;
    public int tileLength;
    // public string levelString;
    [SerializeField] public char[,] level;

    // Start is called before the first frame update
    void Start()
    {
        level = new char[width, height];
        /*level = new char[,]{ {' ', ' ', ' ', ' ', ' '}, 
                    {' ', ' ', 'O', ' ', ' '}, 
                    {'O', ' ', ' ', ' ', ' '}, 
                    {' ', ' ', ' ', 'O', ' '},    
                    {'O', ' ', ' ', ' ', ' '} };*/
        CreateLevelInGame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool CanPlayerMoveLeft(int x, int y) {
        return (x > 0) && (!(char.IsUpper(level[y, x - 1])));
    }
    
    public bool CanPlayerMoveRight(int x, int y)
    {
        return (x < width - 1) && (!(char.IsUpper(level[y, x + 1])));
    }

    public bool CanPlayerMoveUp(int x, int y) {
        return (y < height - 1) && (!(char.IsUpper(level[y + 1, x])));
    }

    public bool CanPlayerMoveDown(int x, int y)
    {
        return (y > 0) && (!(char.IsUpper(level[y - 1, x])));
    }

    public char Get(int x, int y) {
        return level[x, y];
    }
    
    public void Set(int x, int y, char c)
    {
        level[x, y] = c;
    }

    public void pushLeft(int x, int y) {
        if (x > 0) {
            Set(x - 1, y, Get(x, y));
            Set(x, y, ' ');
        }
    }

    public void pushRight(int x, int y)
    {
        if (x < width - 1)
        {
            Set(x + 1, y, Get(x, y));
            Set(x, y, ' ');
        }
    }

    public void pushUp(int x, int y)
    {
        if (y < height - 1)
        {
            Set(x, y + 1, Get(x, y));
            Set(x, y, ' ');
        }
    }

    public void pushDown(int x, int y)
    {
        if (y > 0)
        {
            Set(x, y - 1, Get(x, y));
            Set(x, y, ' ');
        }
    }

    // need help with this method.
    void CreateLevelInGame() { 
        
    }

    /* char[,] levelFromString(string level) { 
        
    } */
}
