using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{

    [SerializeField] Canvas gameOverCanvas;

    private void Start()
    {
        gameOverCanvas.enabled = false; //When the game starts, the gameOverCanvas cannot appear on the screen
    }

    public void  HandleDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0; 
        //注意这里分了两步：解锁鼠标、显示鼠标Unlock the cursor and make it visible so you can see the cursor
        Cursor.lockState = CursorLockMode.None; 
        Cursor.visible = true;  
    
    }


}
