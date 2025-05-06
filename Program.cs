using System.Text; // Bitte nicht löschen!

namespace NoYelling;

public class Program {
    public static void Main(string[] args) {
    string a = Console.ReadLine();
    Console.WriteLine(NoYelling(a));
    }

    public static string NoYelling(string a){
        while (a[a.Length-2]=='!'||a[a.Length-2]=='?') {
            a = a.Substring(0, a.Length-1);
        }
        return a;
    }
}
