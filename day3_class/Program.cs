Person per = new Person()
{
   FirstName = "Abdughaffor",
   LastName = "Rahimov",
   age = 32,
   address = "Hksafkald_34"
};
Console.WriteLine(per.FulName());
Console.WriteLine(per.Birthday());
System.Console.WriteLine();

Rectange rec = new Rectange();
rec.Width = 34;
rec.Height = 34;
rec.GetArea();
rec.GetPerimeter();
Console.WriteLine();
Console.Write("Виведите ширина :");
rec.Width = Convert.ToInt32(Console.ReadLine());
Console.Write("Виведите длина :");
rec.Height = Convert.ToInt32(Console.ReadLine()); ;
rec.GetArea();
rec.GetPerimeter();
System.Console.WriteLine();

Student s1 = new Student();
s1.Name = "Ali";
s1.Gradle = 3;
s1.Everage = new int[4] { 20, 40, 90, 40 };
System.Console.WriteLine();

Student s2 = new Student();
s2.Name = "Ghaffor";
s2.Gradle = 6;
s2.Everage = new int[4] { 70, 80, 90, 80 };
System.Console.WriteLine();

Student s3 = new Student();
s3.Name = "Idibek";
s3.Gradle = 10;
s3.Everage = new int[4] { 90, 90, 90, 90 };
System.Console.WriteLine();


string[,] students ={
{s1.Name,Convert.ToString(s1.Gradle),Convert.ToString(s1.Sredbal()),s1.Gzarish()},
{s2.Name,Convert.ToString(s2.Gradle),Convert.ToString(s2.Sredbal()),s2.Gzarish()},
{s3.Name,Convert.ToString(s3.Gradle),Convert.ToString(s3.Sredbal()),s3.Gzarish()}
};

foreach (var item in students)
{
   System.Console.WriteLine(item);
}