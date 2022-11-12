﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillAmounts : MonoBehaviour
{
    public Image img_Skill;
    //bool isIng;//하는중이면

    void Update()
    {
        //스킬버튼누르기
        //T버튼 눌렸고&& 스킬 쿨타임도 돌아온 상태일때만
        if (Input.GetKeyDown(KeyCode.T)&& img_Skill.fillAmount==1.0f)
        {
         
            //인자: 쿨타임 초
            StartCoroutine(CoolTime(13f));
        }    
    }

    IEnumerator CoolTime(float cool)
    {
        print("쿨타임 코루틴 실행");

        while (cool >1.0f)
        {
            //이거하는동안 클릭 못하게
            
            cool -= Time.deltaTime;
            img_Skill.fillAmount = (1.0f / cool);
            yield return new WaitForFixedUpdate();
        }

        print("쿨타임 코루틴 완료");
    }
}
