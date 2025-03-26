// See https://aka.ms/new-console-template for more information
using modul6_103022330080;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Danur 1");
        SayaTubeVideo video2 = new SayaTubeVideo("Danur 2");
        SayaTubeVideo video3 = new SayaTubeVideo("Pengabdi Setan 1");
        SayaTubeVideo video4 = new SayaTubeVideo("Pengabdi Setan 2");
        SayaTubeVideo video5 = new SayaTubeVideo("Pengabdi Setan 2");
        SayaTubeVideo video6 = new SayaTubeVideo("Gundala");
        SayaTubeVideo video7 = new SayaTubeVideo("Perayaan Mati Rasa");
        SayaTubeVideo video8 = new SayaTubeVideo("Home Sweet Loan");
        SayaTubeVideo video9 = new SayaTubeVideo("1 Kakak 7 Ponakan");
        SayaTubeVideo video10 = new SayaTubeVideo("Mufasa");

        SayaTubeUser user = new SayaTubeUser("Duhan");
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);

        user.PrintAllVideoPlaycount();
    }
}
