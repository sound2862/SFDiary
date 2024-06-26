# __2일차! (24.06.26(수))__

- msdn c# : [Link][a]

[a]: https://learn.microsoft.com/ko-kr/dotnet/csharp/ 
틈틈이 읽어보자. 현장가면 로우 기술이 필요할지도

- 교수님이 추천하는 코딩연습장 사이트 : [그누보드][a]

[a]: http://www.verthasys.co.kr/coding/bbs/board.php?bo_table=db&page=3&device=pc  
여기서 문제도 내고,, 연습도 하고 할꺼니까 애용하자!

>__용어 및 상식__

- 닷넷 코어가 여러 플랫폼 지원하는거.. .어제 알려줬는데 까먹음 잊지말자
- ASP --> ASP.NET Core 라고 부른적이 있다.  //다른거랑 헷갈리지말자ㅇㅇ 닷넷코어 아니다 이거    
닷넷 코어(C#.NET Core)랑 헷갈리지말자!  //많은 플랫폼 지원  
닷넷 프레임워크([Windows].Net Framework  //윈도우 전용

- [PC, Cloud} C# Framework -> namespace의 집합/package의 집함 -> class들의 집합 -> 표현하고 싶은 객체(Coding)
- [J2SE] JDK (Java Framework) -> 컴퓨터로 할수있는 모든것을 표현
- [J2EE]

- [Android] Mobile 'Device' Framework : 폰에 국한되는게 아니라 움직이는 기계에 해당됨 ㅇㅇ (전기차 같은것도)   

- abstract = 추상화한다. 한글보단 영어로 이해하자.  
중요한걸 대강 추려서 그려내는 일이다!
------------------
>__필기__
```
Console.WriteLine("Hello, World!");     //객체.함수 형식, 콘솔이라는 기본적인 객체를 이용함!
```
```
public static void WriteLine(string? value)   // 공개되고, 메모리에 할당되고, 반환값없고, 이름(매개변수는 string)
```
- 리턴타입
용어에 익숙해지자ㅇㅇ ?string 저게 반환해주는 타입이다.
![image](https://github.com/sound2862/SFDiary/assets/62818790/0f5cf5d6-eb3e-42f6-abc9-559a320d3c98)  
`타입 안맞으면 이렇게됨`  
![image](https://github.com/sound2862/SFDiary/assets/62818790/e7425725-f388-402f-bbac-32080bfac795)

```
static void Main(string[] args)
{
    string greet;       //변수 선언
    greet = Console.ReadLine();     //값 할당, 초기화

    Console.WriteLine(greet);       //출력
}
```
- 새파란 친구는 변수로 쓸수없다. string class; 이런거 안댐
![image](https://github.com/sound2862/SFDiary/assets/62818790/4e25eff1-bdcb-48ea-9fc4-508a66a53063)

- _폭발적인 성장을 위해서는 코딩도 좋지만, 기본지식(운영체제, 역사) 요런걸 이해해두는게 장기적으로 좋다!_

>퀴즈
```
static void Main(string[] args)
{
    //두 정수 v1, v2를 입력받아 그 합을 출력하라.

    Console.WriteLine("정수를 입력하세요");
    int a = int32.Parse(Console.ReadLine());
    Console.WriteLine("정수를 입력하세요");
    int b = int32.Parse(Console.ReadLine());

    int r = a + b;

    Console.WriteLine(r);
}
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/7a94db3f-834e-4eff-a3b1-6964c74f7dd3)

>퀴즈2
```
static void Main(string[] args)
{
    int v1 = Int32.Parse(Console.ReadLine());
    int v2 = Int32.Parse(Console.ReadLine());

    Console.WriteLine($"{v1}{v2}");     //100, 200
    //코딩으로 순서 바꿔보기!
    //
    //
    Console.WriteLine($"{v1}{v2}");     //200, 100
}
```
- 내 답안지
```
static void Main(string[] args)
{
    int v1 = Int32.Parse(Console.ReadLine());
    int v2 = Int32.Parse(Console.ReadLine());

    Console.WriteLine($"{v1} {v2}");     //100, 200

    int temp1 = v1;
    int temp2 = v2;

    v1 = temp2;
    v2 = temp1;

    Console.WriteLine($"{v1} {v2}");     //200, 100
}
```
- 교수님은 이렇게, 나중에 배울 홉 정렬 요런것까지 생각해서!
```
int temp = v1;
v1 = v2;
v2 = temp;
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/987e97d8-c42a-4333-a4e9-0f744598ab28)

>__필기 이어서~__
- 요렇게 길이도 뽑을수있다.
```
string firstFriend ="1번";
string secondFriend ="2번";

Console.WriteLine($"나의 친구는 {firstFriend.Length}과 {secondFriend.Length}");
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/d98937b4-5068-4377-b125-2ca812d3965e)

- trim 하기!
```
string greeting = "   안녕   ";
Console.WriteLine(greeting);

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine(trimmedGreeting);

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine(trimmedGreeting);

trimmedGreeting = greeting.Trim();
Console.WriteLine(trimmedGreeting);
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/a6f667fd-d697-4b48-ae17-3cb4a0b8a84a)
`문자열 객체에 Trim이 들어있다! C#에는 꼭 들어있으니 잘 써먹자`

- 대문자 소문자 변환하기.
```
string greeting = "Good Morning";

Console.WriteLine(greeting);
Console.WriteLine(greeting.ToUpper());
Console.WriteLine(greeting.ToLower());
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/0d4d175e-8d26-4c8e-8b0f-c327968fe59f)
`요것또한 객체에 들어있다 다른것도 많으니 찾아서 알아서 잘 쓰자`

- 캐스팅
```
int a = 18;
int b = 7;
double c = (double)a / b;

Console.WriteLine(c);
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/4f7cce64-d446-48f3-b1a4-d6f59905965f)
`타입 바꾸기~`

>퀴즈3
```
static void Main(string[] args)
{
    //화씨 온도 = 9 / 5 * 섭씨온도 + 32
    //입력은 1~100사이의 자연수
    //출력은 소수점 둘째자리까지

    int C;
    double F;

    C = int.Parse(Console.ReadLine());

    if (C < 1 | C > 100)
    {
        Console.WriteLine("1부터 100까지의 정수중에 적어주세요.");
        return;
    }

    F = (C*9.0/5.0) + 32;

    Console.WriteLine(F.ToString("0.##"));
}
```  
`1~100사이의 자연수는 if절과 이중조건으로 넣었고, ToString()으로 자릿수 정해줬다.`
```
Console.WriteLine($"{F:F2}");
```
`C#의 경우 이런방법도 있다`

- 비트와 부호화에 대한 설명. 그리고 시장과 업무에 대해.
    - 현재 시장에서 구할수있는 젤 싼게 16비트짜리(2^16)
      4비트 8비트 요런거 만드는것보다 그냥 공간이 남더라도 싼거 사서 만드는게 낫다.
    - 중요한건.. 가치를 제공하는것. 리모컨 만들고 가격 더받고 요런식. 요런걸 노려보자

#이모저모
-
퀴즈2에서, 풀다가 '음... 임시공간 필요하니까... 영어로 temporary.. 니까 temp1,2로 써야징! 했는데 정답도 그거였구 단어 맞춰버렸구 너무재밌다  
퀴즈3 조금 헷갈려서 0.00으로 잡았었는데, 고민좀 하다가 0.##이 기억나서 넣었더니 원하는대로 나왔다ㅇㅇ 굿  
현재시간 13:08 졸릴까봐 커피도 마셨는데 매우 졸립다.... 이따 한잔 더마시든가 해야지
