namespace CSharpProject02;

/* 
# 클래스
    - 변수
    - 메소드(함수)
    - 그룹

# 클래스의 구성 요소
    - 프로퍼티(속성) : 외부에서 접근가능한 변수
    - 필드(멤버변수) : 내부에서 사용하는 변수
    - 메소드(Method) : 함수(로직의 집합)
    - 이벤트(Event) 


# 접근제한자
    - public  : 외부에서 접근가능
    - private : 외부에서 접근불가


# Camel Case (단봉 낙타형)
    - 변수
    - userName

# Pascal Case 
    - 클래스
    - 메소드
    - 프로퍼티
    - Enemy, Main
    - PlayerHp

*/
public class Enemy
{
    // 멤버변수 (기본적으로 외부 접근 금지)
    //private string name;
    private int hp = 100;
    //private float speed = 10.0f;

    // 프로퍼티(Property) - 외부에 노출시킬 속성
    public string Name { get; set; }
    // Auto Property
    public float Speed { get; set; }

    public int Hp
    {
        get { return this.hp; }
        set
        {
            this.hp = value;
            if (hp <= 0)
            {
                // 몬스터가 사망하는 로직 처리
                Console.WriteLine($"{Name} is dead!!!");
            }
        }
    }

    private void EnemyDie()
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        // 1. 일반적인 클래스 생성및 할당
        Enemy orc = new Enemy();
        orc.Name = "Orc";
        orc.Hp = 0;

        // 2.
        Enemy goblin = new Enemy()
        {
            Name = "Goblin",
            Hp = 200,
            Speed = 100
        };

        Console.WriteLine($"Enemy's name is {orc.Name}");
    }
}
