using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {        
        "Think about your core values, how do they influence your decisions and actions?",
        "Think of your greatest strengths, how can you leverage them to achieve your goals?",
        "Think about what some of your weaknesses are, how can you work on improving them?",
        "Think of an experience where you demonstrated genuine selflessness.",
        "Reflect on a recent success. What factors contributed to it, and what can you learn from the experience?",
        "Reflect on a recent failure or setback. What lessons can you take away from it, and how can you grow from the experience?", 
        "Think of a moment where you went out of your way to make someone's day better.",
        "Think of how you handle stress and adversity. What coping mechanisms do you use, and are there healthier alternatives you can explore?",
        "Reflect on your relationships with others. Are there any patterns or behaviors you need to address to improve these relationships?",
        "Reflect on your goals, both short-term and long-term. Are they still aligned with your values and aspirations, or do they need adjustment?",
        "Reflect on how you handle criticism or feedback, are you open to constructive criticism, and how do you incorporate it in your personal growth",
    };
    private List<string> _questions = new List<string> {
        "What broader applications or lessons can you derive from this self-reflection?",
        "What self-discoveries did you make?",
        "How can you integrate the insights gained from this experience into future endeavors?",
    };
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on past experiences as well as personal ideals. This will help you to learn more about yourself and will allow you to gain a better understanding of how you tend to function.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public string GenerateQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }
    public void PromptReflecting()
    {   
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("Once you are ready, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            string question = GenerateQuestion();
            Console.Write(question + " ");
            GenerateSpinner(15);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}