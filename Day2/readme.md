# __2일차! (24.06.26(수))__

- msdn c# : [Link][a]

[a]: https://learn.microsoft.com/ko-kr/dotnet/csharp/ 
틈틈이 읽어보자. 현장가면 로우 기술이 필요할지도

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


