using UnityEngine;

public class MonsterController : MonoBehaviour
{
    //몬스터의 hp는 여기서 관리.
    // 어떤 카드가 골라지고, Player가 그 카드를 선택한 후
    //몬스터를 클릭했을 때의 일을 여기에 구현하겠음.

    public float hp;
    public float maxhp;

    private GameManager gameManager;

    //스폰 수 관리
    public static int MonsterCount;//나중에 프리팹 만들 때, MonsterCount ++ 넣어주기.


    void Start()
    {
        //오류 점검용
        if(gameManager == null)
        {
            //카드 불러오기 전, GameManager 불러오기
            gameManager = FindObjectOfType<GameManager>();
        }

        
    }

    void Update()
    {
        
    }

    //PlayerController - 카드 선택 후 몬스터(버튼) 클릭 -> CardFunction() 실행.
    public void CardFunction()
    {
        if(gameManager != null)
        {
            //Card 이름은 GameManager 에서 쓰는 이름으로 바꾸기.
            var Card = gameManager.currentCard;
            //무슨 카드인지 확인용
            Debug.Log("현재 사용된 카드 : " + Card.name);
        }

        //Player가 선택한 몬스터 이름 & 카드 이름으로, 행동.

        if (Card.name = "공격")
        {
            
        }


    }

    public void Dealer()
    {

    }

    public void Tanker()
    {

    }

    public void Boss()
    {

    }
}
