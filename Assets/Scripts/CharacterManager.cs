using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [HideInInspector] public AudioSource audioSource;
    [HideInInspector] public Actions action;
    //[HideInInspector] public Rigidbody rb;
    [HideInInspector] public Animator anim;
    [HideInInspector] public PlayableDirector cutscene_player;
    public TimelineAsset[] cutscene;
    public enum CutScene { scene_0, scene_1, scene_2, scene_3, scene_4, scene_5, scene_6, scene_7, scene_8, scene_9, scene_10, scene_11, scene_12, scene_13, scene_14, scene_15, startlevel, scene_16, scene_17, small_rock, tot_rock, bober_maxtal, uraa_grib_bober_level, scene_18, za_bes, net_bes, za_elkoy, net_elka, za_bereza, net_bereza, eshe_odin_grib, final_level, final_1, final_2, final_3, final_4, the_end, skolko_gribov, level_4 }
    public CutScene ActiveCutScene = CutScene.scene_0;
    public float cutscene_timer;
    public bool isPlayable;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        //rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        cutscene_player = GetComponent<PlayableDirector>();
        action = GetComponent<Actions>();
    }

    // Update is called once per frame
    void Update()
    {
        CutSceneTimer();
        MoveForward();
        Click();

        switch (ActiveCutScene)
        {
            case CutScene.scene_0:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Stop();
                    isPlayable = false;
                }
                break;
            case CutScene.scene_1:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[1]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    action.Unhide_Buttons();
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_2:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[2]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_3:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[3]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_4:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[4]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_5:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[5]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_6:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[6]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_7:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[7]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    action.GriAnimation();
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_8:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[8]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    action.Move_On();
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_9:
                action.Level_2();
                action.Move_Off();
                DefaulCutScene();
                break;
            case CutScene.scene_10:
                if (cutscene_timer == 0.0f)
                {
                    //action.GriAnimation();
                    cutscene_player.Play(cutscene[9]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    action.Unhide_Animals();
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_11:
                if (cutscene_timer == 0.0f)
                {
                    action.Hide_Animals();
                    cutscene_player.Play(cutscene[10]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    action.MostActivation();
                    action.RabbitActivation();
                    action.Move_On();
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_12:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[11]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_13:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[12]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_14:
                if (cutscene_timer == 0.0f)
                {
                    action.GribDestroy();
                    cutscene_player.Play(cutscene[13]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    action.Move_On();
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_15:
                action.Level_3();
                action.Move_Off();
                DefaulCutScene();
                break;
            case CutScene.startlevel:
                action.StartLevel();
                break;
            case CutScene.scene_16:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[14]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    //DefaulCutScene();
                    Active_17();
                }
                break;
            case CutScene.scene_17:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[15]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    //DefaulCutScene();
                }
                break;
            case CutScene.small_rock:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[16]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    //DefaulCutScene();
                }
                break;
            case CutScene.tot_rock:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[17]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {

                }
                break;
            case CutScene.bober_maxtal:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[18]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {

                }
                break;
            case CutScene.uraa_grib_bober_level:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[19]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    action.Move_On();
                    DefaulCutScene();
                }
                break;
            case CutScene.scene_18:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[20]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.za_bes:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[21]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.net_bes:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[22]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.za_elkoy:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[23]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.net_elka:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[24]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.za_bereza:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[25]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.net_bereza:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[26]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.eshe_odin_grib:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[27]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    action.Move_On();
                    DefaulCutScene();
                }
                break;
            case CutScene.final_level:
                action.Final_Level();
                break;
            case CutScene.final_1:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[28]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    //  Final_2();
                }
                break;
            case CutScene.final_2:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[29]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    Final_3();
                }
                break;
            case CutScene.final_3:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[30]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.final_4:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[31]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.the_end:
                action.TheEnd();
                break;
            case CutScene.skolko_gribov:
                if (cutscene_timer == 0.0f)
                {
                    cutscene_player.Play(cutscene[29]);
                    cutscene_timer = ((float)cutscene_player.playableAsset.duration);
                    isPlayable = true;
                }
                else if (cutscene_timer <= 0.5f && cutscene_timer >= 0.4f)
                {
                    DefaulCutScene();
                }
                break;
            case CutScene.level_4:
                action.Level_4();
                break;
        }
    }

    public void CutSceneTimer()
    {
        if (cutscene_timer <= 0.0f)
        {
            cutscene_timer = 0.0f;
        }
        else if (cutscene_timer > 0.0f)
        {
            cutscene_timer = cutscene_timer - Time.deltaTime;
        }
    }

    public void DefaulCutScene()
    {
        ActiveCutScene = CutScene.scene_0;
    }

    public void MoveForward()
    {
        if (action.isMove && cutscene_timer == 0.0f)
        {
            this.transform.Translate(Vector3.right * 10f * Time.deltaTime);
            anim.SetBool("Move", true);
        }
        else
        {
            anim.SetBool("Move", false);
        }
    }
    public void Click()
    {
        if (Input.GetMouseButtonDown(0) && !isPlayable)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider.gameObject.GetComponent<ItemData>())
            {
                ItemData i = hit.collider.gameObject.GetComponent<ItemData>();
                audioSource.PlayOneShot(i.item.item_sound);
                if (i.item.value == 1)
                {
                    ActiveCutScene = i.scene;
                    Destroy(hit.collider.gameObject);
                }
                if (i.item.value == 5)
                {
                    ActiveCutScene = CutScene.eshe_odin_grib;
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    public void Final_2()
    {
        ActiveCutScene = CutScene.final_2;
    }
    public void Final_3()
    {
        ActiveCutScene = CutScene.final_3;
    }
    public void isRabbit()
    {
        ActiveCutScene = CutScene.scene_11;
    }
    public void isMedved()
    {
        ActiveCutScene = CutScene.scene_12;
    }
    public void isBelka()
    {
        ActiveCutScene = CutScene.scene_13;
    }
    public void Active_17()
    {
        ActiveCutScene = CutScene.scene_17;
    }
    public void Zero_State()
    {
        ActiveCutScene = CutScene.scene_0;
    }
    public void Bober_Maxtal()
    {
        ActiveCutScene = CutScene.bober_maxtal;
    }
}
