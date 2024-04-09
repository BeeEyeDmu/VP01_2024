namespace _013_array
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // 정수배열 {1,2,3} 만들기
      int[] a = { 1, 2, 3 }; // 만들면서 초기화시킴
      int[] b = new int[3] { 1, 2, 3 }; // 3개짜리 정수배열을 만들고나서 초기화
      int[] c = new int[] { 1, 2, 3 };
      int[] d = new int[3];
      d[0] = 1;
      d[1] = 2;
      d[2] = 3;

      Console.Write("a[] : ");
      foreach (int i in a)
      {
        Console.Write(i + " ");
      }
      Console.WriteLine();

      Console.Write("b[] : ");
      foreach (int i in b)
      {
        Console.Write(i + " ");
      }
      Console.WriteLine();

      Console.Write("c[] : ");
      foreach (int i in c)
      {
        Console.Write(i + " ");
      }
      Console.WriteLine();

      Console.Write("d[] : ");
      foreach (int i in d)
      {
        Console.Write(i + " ");
      }
      Console.WriteLine();

      string[] s = { "abc", "bcd", "cde" };
      Console.Write("s[] : ");
      foreach (string i in s)
      {
        Console.Write(i + " ");
      }
      Console.WriteLine();

      // List<T>, 교과서 103장
      List<int> la = new List<int>();
      la.Add(10);
      la.Add(20);
      la.Add(3);

      la.Sort();  // 리스트 정렬

      Console.Write("List<int> la : ");
      foreach (int i in la)
      {
        Console.Write(i + " ");        
      }
      Console.WriteLine();
    }
  }
}