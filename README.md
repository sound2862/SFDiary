- 책 추천
>- 클린코드
>https://www.yes24.com/Product/Goods/11681152   
>아키텍처의 가시화를 위한 책, 유지보수 관련

>- 실용주의 프로그래머
>https://www.yes24.com/Product/Goods/107077663  
>             "

>- 객체지향의 사실과 오해 
>https://www.yes24.com/Product/Goods/11681152  
>한국인 개발자의 입장에서 위의 내용을 서술.
-------------------
- 여러여러 기억할점

  - 기초
  자료구조, 알고리즘 중요  
  -그리드, 백트래킹, 다이나믹, 순열, 조합, 트리, 그래프, 다익스트라...
시간복잡도..ㅠㅠㅠ 
C#으로 공부하자

  - 중급, 고급  
객체지향, 애자일 (켄트벡, 마틴파울러, 로버트C마틴...)

  - 프로그램코드란? : 동작하게 명세하는 상세적인 명세
확실하게 자료구조와, 목적을 이해하고 코딩을 하자.

----------------------------------------------------------

>__필기__

- 비주얼 스튜디오 초기설정에 관한 정보
  - 닷넷 프레임워크는 윈도우에서만 쓸수있다. (24년 기준 현재는 닷넷 코어 이용(다양한 플랫폼 지원)
  - C:\Users\Admin\source\repos 내 프로젝트 디렉토리 링크 기억하기.
  - 레포지토리 만들때 체크 하면 main생성.(디폴트)  
체크 안하면 자바스크립트처럼 생성.

■ C#의 클래스 형식  
![image](https://github.com/sound2862/SFDiary/assets/62818790/3d4ab2ac-a915-45ab-9c1f-cc5a473b661c)

■ 매개변수!  
![image](https://github.com/sound2862/SFDiary/assets/62818790/0b6c28bf-69c0-4f32-8ec4-a3bc97d129cb)

■ 스태틱이란..?  
코딩은 상세언어. 적은대로 나온다.  
->콘솔에.적어라.("헬로월드")를.;끝  
![image](https://github.com/sound2862/SFDiary/assets/62818790/b03d6324-d42c-4353-85e3-df00c56a765b)

- 요것도 두줄  
![image](https://github.com/sound2862/SFDiary/assets/62818790/001dc3b0-0a13-4ca8-acbb-54a952c8c307)

- 요것도 또한 두줄  
![image](https://github.com/sound2862/SFDiary/assets/62818790/90d6c52d-0b7b-4208-9ec1-17acf5771c74)

- 또한...  
```
static void Main(string[] args)
{
    string name = "장창훈";
    Console.WriteLine("안녕하세요");
    Console.WriteLine($"저는 {name} 입니다.");
}
```

>퀴즈!  
조건)변수를 두개 사용하라.  
string greet;  
string name  

```
반갑습니다.
저는 장창훈입니다.
```
```
static void Main(string[] args)
{
    string greet = "반갑습니다.";
    string name = "장창훈";
    Console.WriteLine($"{greet}");
    Console.WriteLine($"저는 {name} 입니다.");
}
```

- 이런방식도 있다.
```
static void Main(string[] args)
{
    string greet = "반갑습니다";
    string greet2 = "안녕하세요";
    string name = "장창훈";
    int age = 40;
    Console.WriteLine("{0} {1}",greet,greet2);
    Console.WriteLine($"저는 {name} {age}살 입니다.");
}
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/925522c9-cc9c-48ff-a1b1-af2432e4255a)
