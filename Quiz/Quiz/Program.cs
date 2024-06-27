string question1 = "What is the capital of Germany?";
string answer1 = "berlin";

string question2 = "What is 2+2?";
string answer2 = "4";

string question3 = "What color do you get by mixing blue and yellow";
string answer3 = "green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1= Console.ReadLine();
if (userAnswer1.Trim().ToLower() == answer1.ToLower())
    {
    Console.WriteLine("Correct!");
    score ++ ; 
    }
else
{
    Console.WriteLine("Wrong, the answer is " + answer1);
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2.Trim().ToLower() == answer2.ToLower())
{
    Console.WriteLine("Correct!");
    score ++;
}
else
{
    Console.WriteLine("Wrong, the answer is " + answer2);
}

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct!");
    score ++;
}
else
{
    Console.WriteLine("Wrong, the answer is " + answer3);
}

Console.WriteLine("Quiz Completed, your final score is:{0}/3",score);
if (score == 3)
{
    Console.WriteLine("You've made all the questions right!");
}


Console.ReadKey();
