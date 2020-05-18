using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;


public class ifelse : MonoBehaviour // 如果你發現 MonoBehaviour 這段文字是白色,那就代表剛剛的設定沒有開
{
    [Header("血量"), Range(0, 100)]
    private int HP;
    [Header("地板")]
    public GameObject cube;
     //public int HP {>= get; set; }
     // 現在可以看到 HPP 的H 下方 有3個灰點
     // 滑鼠移到那邊,按下滑鼠右鍵
     // 會出現快速動作與重構,也就是最上面第一個選項
     // 點選第二個選項,使用封裝欄位,並使用屬性
     //

    //可以看一下其他腳本嗎?忘了
    //咦，怎麼改成hp就不會看到3個點?
    //這樣好像底下的HP就要改掉是嗎?


    [Header("補品")]
    public string prop = "紅水";

    public Slider _Slider;

    public Text result; // 這裡的result可以替換成其他你知道的單字 ,這裡輸入完之後, 會多出一個專門掛 text 的欄位

    public InputField _InputField;

    public Text water;

    private int a;
    private int b; 
   
    
    public int HP1 { get => HP; set => HP = value; }
    private void CreateFloor(int length)
    {
        for(int a = 0; a <= length; a++)
        {
            for (int b = 0; b < a; b++) 
            {
                Instantiate(cube, new Vector3(a, b, 0), Quaternion.Euler(270, 0, 0));
            }
        }
    }

    private void Awake()
    {
        CreateFloor(10);
    }
    public void Update()
    {
        HP = (int)_Slider.value; // 是不清楚這段文字的意思嗎?


        if (HP >= 70)
        {

            result.text = "安全"; // 把text 拖拉到 text 的欄位後, text 會根據 if 判斷式 偵測的情況, 來決定要用哪一個部分 輸出訊息 
        }
        else if (HP >= 30)
        {
            result.text= "警告";
        }
        else
        {
            result.text = "危險";
        }
        //三元運算子語法 - 布林運算式 ? 運算式 A : 運算式 B
        water.text = prop == "紅水" ?  "恢復血量" : prop == "藍水" ?   "恢復魔力" :   "";
        // water.text = prop == "紅水" ? "恢復血量" : prop == "藍水" ?"恢復魔力" : "" ;

        //drinkthing.text = propDrink == "紅水" ? "恢復血量" : propDrink == "藍水" ? "恢復魔力" : "";
        // 上面這段有些問題, 可能明天在跟你說
        // 好哦，那最後看完第一段的問題就好，我發現第一段的功課好像得寫封裝，但我寫成public
        // 這樣就可以了~
        // 我會把程式碼刪除,
        // 請你試試看~
    }

    public void input1( string something ) //按鈕輸入功能
    {
        prop = something;
    } //按鈕輸入功能 結束

 
    // 上面是自己自定義一個功能
    // 然後 因為 public 代表的是 此功能可以被其他程式碼區塊使用
    // 因此之後可以在這個腳本的update裡,或是在其他C# 腳本語言裡呼叫使用
    // 或是新增到按鈕功能裡面
    // 打成 private 就不能在其他地方被使用了


    //inputfield 裡面附的text，是可以直接用來輸出恢復血量用的嗎? 我剛剛突然看到展開inputfield有一個text，但我是把上面slider那的text複製下來再丟到canves上
    // 它本來是用來設定 提示用的文字:
    // 像是 : 銀行 提款機畫面的 請輸入 6位數 密碼
    // 確認完後請按 確認鍵
    // ...等文字
    // 阿,抱歉,我沒講清楚
    // 大概是這樣子
    //


    //懂了，他是用來覆蓋在輸入框上顯示提示的，那我剛剛其實反而弄錯了
    //改回這樣就對了吧


    //謝謝你
    // 請問現在哪裡有問題呢?
    //這一行我跳到unity看顯示錯誤，但腳本這邊又顯示沒問題
    // 剛剛你的unity裡面 project 的設定,
    // 有一個跑掉了

    //難怪我發現有時候我明明寫錯，但他不會跳錯誤，然後我到學校打開，就錯一堆@@
    // 那我稍微停在那個畫面, 你可以做筆記
    //那個是每開一次新專案都需要改一次嗎?


    // 照理來說只需要改一次就好

    // 再來好像突然就卡住不知怎麼做

    // 就是 我們透過寫程式, 新增了一個叫做slider的欄位,
    // 現在要把 程式作用的目標slider 拖拉進來這個欄位裡

    // 我還以為那邊要丟text@@

    //text 是要用來顯示輸出訊息用的~

    //要再新增一個result.Text嗎

    // 是的  你也可以取名叫做 hint ...等名字
    // hint.text 或是 abcde.text 讓自己知道說: 這是什麼東西的輸出用訊息

    // 如果改成用講的，你是不是會比較輕鬆一點?想說不要給你打那麼多字


    // Z我其實還好 ,因為打在這裡, 就有個筆記可以參考

    // 恩恩，好像是，但我怕我問問題，你都得打字回，會比較麻煩你，如果沒關係的話就繼續

    // 那就繼續吧~

    // 那天過來看你的程式碼有看到hint.text，這只是隨便命名的嗎?

    //恩恩, 同時也讓自己知道這是用來做什麼的
    // 像是 我自己是把 hint 分給第一個 HP血條 的作業使用
    // result 是給第二個 喝藥水的作業使用
    //  依據情況決定名稱,這樣比較方便找對應的程式碼 去做修改

    // 我問一個笨問題，result這個單字在c語言沒有任何意義，也是一個詞嗎?

    //它是使用者自己定義的字,在unity裡面沒有特別的意思

    // 現在才知道@@我以為是回傳的意思

    //那怎麼把text跟slider輸出寫在一起?

    //恩恩，所以基本上，我就不用在if裡面寫print了對吧，print只是輸出到console而已

    // 是的

    // 經你解釋過後看起來很簡單，怎麼自己要寫的時候都覺得很複雜@@

    // 多寫一點就會習慣了,希望剛剛的圖解不會畫太醜

    //淺顯易懂，看完就比較不會打結了@@

    //這邊第一個功課這樣就算完成了嗎?

    //是的

    // 抱歉,我剛剛的圖有個地方寫錯了

    // [Header("道具")]
    //public string prop = "紅水"; 忘光光@@






}
