using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;


public class ifelse : MonoBehaviour // 如果你發現 MonoBehaviour 這段文字是白色,那就代表剛剛的設定沒有開
{
    [Header("血量"), Range(0, 100)]
    public int HP = 0;

    [Header("補品")]
    public string prop = "紅水";

    public Slider _Slider;

    public Text result; // 這裡的result可以替換成其他你知道的單字 ,這裡輸入完之後, 會多出一個專門掛 text 的欄位

    public InputField _InputField;

    public Text water;


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
        _InputField = prop = "紅水" ? water.text + "恢復血量": prop = "藍水" ? water.text + "恢復魔力":

    }

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
