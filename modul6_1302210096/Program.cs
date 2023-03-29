// See https://aka.ms/new-console-template for more information

using modul6_1302210096;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film something oleh Arzaq");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film John Wick 4 oleh Arzaq");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film John Wick 3 oleh Arzaq");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film John Wick 2 oleh Arzaq");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film John Wick 1 oleh Arzaq");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film e oleh Arzaq");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film f oleh Arzaq");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film g oleh Arzaq");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film h oleh Arzaq");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film i oleh Arzaq");
        video1.IncreasePlayCount(2);
        video2.IncreasePlayCount(1);
        video3.IncreasePlayCount(1);
        video4.IncreasePlayCount(1);
        video5.IncreasePlayCount(1);
        video6.IncreasePlayCount(1);
        video7.IncreasePlayCount(1);
        video8.IncreasePlayCount(1);
        video9.IncreasePlayCount(1);
        video10.IncreasePlayCount(1);
        video1.PrintVideoDetails();
        Console.WriteLine("");
        SayaTubeUser user = new SayaTubeUser("Arzaq");
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);

        user.PrintAllVideoPlayCount();

        Console.WriteLine("Total video playcount: " + user.GetTotalVideoPlayCount());




        
        
    }
}
