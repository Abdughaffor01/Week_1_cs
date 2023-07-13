public class User
{

   public string Firstname;
   public string Lastname;
   public string Username;
   public string Password;
   public bool IsLoggedOn;
   public void Login(string username, string password)
   {
      if (Username == username && Password == password)
      {
         System.Console.WriteLine("Пользователь успешно зарегистрирован");
         IsLoggedOn = true;
      }
      else
      {
         System.Console.WriteLine("Ваш пароль или имя пользователя неверны");
      }
   }
   public void Logout()
   {
      IsLoggedOn = false;
   }
   public string GetFullInfo(){
       return ($"{Firstname} {Lastname} - {IsLoggedOn}");
   }

}