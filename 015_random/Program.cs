namespace _015_random
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Random 클래스의 객체 r을 만든다
      Random r = new Random();
      for(int i=0; i<10; i++)
        Console.WriteLine(r.NextDouble());

      // 20개의 랜덤 숫자를 배열에 저장하고
      // 최대, 최소, 평균을 계산
      int[] a = new int[20];
      for (int i = 0; i < 20; i++)
        a[i] = r.Next(1000);
      for (int i = 0; i < 10; i++)
        Console.Write(a[i] + " ");
      Console.WriteLine();

      int min = a[0];
      int max = a[0];
      int sum = 0;

      for (int i = 1; i < 20; i++)
      {
        sum += a[i];
        if (min > a[i]) { min = a[i]; }
        if (max < a[i]) { max = a[i]; }
      }
      Console.WriteLine("min = {0}, max = {1}, avg = {2:F2}", min, max,
        sum / 20.0);
    }
  }
}