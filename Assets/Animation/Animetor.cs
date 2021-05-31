using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*アニメーション設定
 * Animetor Controller:アニメーション全体を管理
 * Animetor Clip:個々のモーション管理
 */

public class Animetor : MonoBehaviour
{
    //空のコンポーネントをせいせい
    Animator animator;

    void Start()
    {
        //自身についているanimatorを取得する
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //スペースボタンが押されたら 攻撃
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }
        //m が押されたら　走る
        if (Input.GetKeyDown(KeyCode.M))
        {
            animator.SetFloat("Run",1.1f);
        }
        //n が押されたら　止まる
        if (Input.GetKeyDown(KeyCode.N))
        {
            animator.SetFloat("Run", 0);
        }
        //SetBool SetInt がある
    }

    //アニメーション追加eventに割り当て
    public void HitLog()
    {
        Debug.Log("ぶつかったで");
    }
}

/*モデルを読み込んだのちにGUI側の設定
 * storからダウンロードしてPackageManagerからインポート
 * インポートしたファイルの中の
 * PrefabファイルのhogehogePloyartファイルを追加したいsceneのヒエラルキーにドラッグ
 * ヒエラルキーに入れたモデルを右クリックでPrefab内のUnpack Completelyをクリック
 * その後ローテーションなどの変更を行う
 */

/*Animetor Controller
 * inspectorのAnimatorのControllerをクリックするとControllerが出てくる
 * 中のnode（らべる見たいなやつ）がAnimation Clipでそれを矢印で繋いだ物がController
 * 
 * Clip遷移方法（矢印をつける）
 * Clipを右クリックしてmake transtionで新たな矢印を生成
 * (commond＋deleteで矢印消せる)(option+クリックで視点移動)
 * 繊維の条件を作る（パラメーター）
 * controller画面のParametersタグ内の＋ボタンからtriggerを追加する
 * 生成されたパラメーターに名前をつけ実行させたい矢印をクリックしインスペクターのCondetions
 * LIst is Emptyに追加する（追加するだけでもanimetionする（条件なくても））
 * insupectorのHas Exit Timeはアニメーションの時間で強制的に切り替わるか
 * アニメーションが終わったタイミングなどで切り替わるかを設定できる
 * Has Exit Time切るとパラメーターが呼ばれた瞬間すぐ実行される
 * 
 */

/*Animator割当、設定
 * 追加ファイルAnimetor Controllerを追加
 * アニメーションを加えたいモデルのインスペクターのアニメーターのControllerに
 * 追加したAnimetor Controllerを割り当てる
 * ダウンロードしてきた3DモデルのファイルのAnimationsのなかにClipが入っているので
 * 好きな物をチョイスしてドラッグ
 */

/*各ノードにさらにアニネーションを加える
 * GUI側のAnimetorのノードを選択し　AddBehaviourをクリックで新しいファイルを生成
 * Asssets配下に自動で生成されてるのでディレクトリー移動させる
 * 今回は DogAttackBehaviourで生成させてる
 */


/*アニメーション内部確認
 * 対象モデルクリックしヘッダーのwindowのなかのanimation選択で見れる
 * 左画面Previewの下のIdleをクリックするとanimetorNode一覧が出てくる
 * 好きなノードを選択
 * node選択した隣の3つ目をクリックするとaddEventできる(今回はAttack　eventに定義)
 * 追加したeventにコードを割り当てることができる
 * 関数を定義(今回はHitLog()を定義)したら、GUI側のeventのみたいなのをクリックすると
 * インスペクター内のfunctionの項目に先ほど生成した関数が表示できるようになりる
 */