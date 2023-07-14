public class Student
{
   public string Name;
   public int Gradle;
   public int[] Everage;
   
   public int Sredbal()
   {
      int sum = 0;
      foreach (var e in Everage)
      {
         sum += e;
      }
      return (sum / Everage.Length); 
   }
   public string Gzarish()
   {
      int sum = 0;
      foreach (var e in Everage) sum += e;
      if ((sum / Everage.Length) > 85)
      {
         return "Молодец гапт надорм гзащти"; 
      }
      else if(sum / Everage.Length>70) return "Хай ак и мох мебахшемт сахт хон";
      else return "Балт камай брашка ай сар хон";
   }
}
