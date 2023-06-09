namespace Algorithms_12Module{
    internal class Program{
        class User{
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
        }
        static void Main(string[] args){

            User user = new User();

            Console.WriteLine("Введите имя");
            user.Name = Console.ReadLine();
            Console.WriteLine("Введите логин");
            user.Login = Console.ReadLine();
            Console.WriteLine("Является ли аккаунт премиальным? True/False");
            user.IsPremium = bool.Parse(Console.ReadLine());

            if (!user.IsPremium){ShowAds();}
            Console.WriteLine("Привет, " + user.Name);
        }
        static void ShowAds(){

            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }       
    }
}