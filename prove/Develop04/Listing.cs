using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate, why?",
        "Where do your personal strengths lie?",
        "Where have you seen the hand of the Lord this week?",
        "What attributes do you admire in your spouse or friends?",
        "What gave you a genuine smile this week?",
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on your life, and through listing you can recognize all you have going for you.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public void PromptListing()
    {   
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        GenerateCountdownTimer(5);
        Console.WriteLine();
                
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
    }
}