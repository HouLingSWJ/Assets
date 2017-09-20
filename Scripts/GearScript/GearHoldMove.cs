﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//占领移动机关 ： 进入时触发移动 ，退出时还原移动
public class GearHoldMove : GearMoveBase
{


    public override void TriggerEnter(Collider other)
    {
        base.TriggerEnter(other);
        ChildMove();
    }

    public override void TriggerExit(Collider other)
    {
        base.TriggerExit(other);
        ChildRehome();
    }

   


}
