namespace _014_loop
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // (1) x에서 y까지의 합, 홀수의 합, 역수의 합
      Console.Write("x를 입력하세요 : ");
      int x = int.Parse(Console.ReadLine());
      Console.Write("y를 입력하세요 : ");
      int y = int.Parse(Console.ReadLine());

      int sum = 0;  // 합
      int oddSum = 0; // 홀수의 합
      double rSum = 0;  // 역수의 합
      for(int i=x; i<=y; i++)
      {
        sum += i;
        rSum += 1.0 / i;
        if(i%2 == 1) 
          oddSum += i;
      }
      Console.WriteLine("합 = {0}, 홀수의 합 = {1}, 역수의 합 = {2}",
        sum, oddSum, rSum);

      // (2) 구구단(b x a)
      for (int a = 1; a <= 9; a++) // 바깥쪽 루프
      { 
        for (int b = 2; b <= 9; b++)
          Console.Write("{0}x{1}={2}\t", b, a, a * a);
        Console.WriteLine();
      }

      // (3) x의 y승
      Console.Write("밑수를 입력하세요 : ");
      int baseV = int.Parse(Console.ReadLine());
      Console.Write("지수를 입력하세요 : ");
      int expV = int.Parse(Console.ReadLine());
      int exp = 1;
      for (int i = 1; i <= expV; i++)
        exp *= baseV;
      Console.WriteLine("{0}^{1}={2}", baseV, expV, exp);

      // (4) n!
      Console.Write("n을 입력하세요 : ");
      int n = int.Parse(Console.ReadLine());
      int fact = 1;

      for (int i = 1; i <= n; i++)
        fact *= i;
      
      Console.WriteLine("{0}! = {1}", n, fact);


      // foreach 쓸 때 주의할 점
      int[] arr = { 10, 20, 30, 40, 50 };
      for(int i=0; i<5; i++)
        Console.WriteLine(arr[i]);

      foreach(var i in arr)
        Console.WriteLine(i); // arr[i] 가 아님



    }
  }
}