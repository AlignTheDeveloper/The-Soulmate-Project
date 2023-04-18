using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomChanger : MonoBehaviour
{
    private Com.LuisPedroFonseca.ProCamera2D.ProCamera2DRooms proCam;

    public void NextRoom()
    {
        proCam.EnterRoom("");
    }

    public void LastRoom()
    {
        proCam.EnterRoom("");
    }
}
