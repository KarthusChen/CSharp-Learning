using System.Text;

namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 设置控制台输出编码为 UTF-8
            Console.OutputEncoding = Encoding.UTF8;

            // 设置控制台输入编码为 UTF-8
            Console.InputEncoding = Encoding.UTF8;

            Question[] questions = new Question[]
            {

                new Question(
                "鼠鼠最爱吃的是：",
                new string[]{"奶酪","土豆","玉米","胡萝卜"},
                1
                ),
                new Question(
                "鼠鼠老了以后住哪里：",
                new string[]{"民宿","酒店","警校旁边的养老院","家里"},
                3
                ),
                new Question(
                "鼠鼠的结婚纪念日：",
                new string[]{"8.30","11.25","11.20","5.20"},
                2
                ),
                
                new Question(
                "鼠鼠遇到爱情的时间是：",
                new string[]{"8.30","11.25","11.20","5.20"},
                0
                ),

                new Question(
                "鼠鼠今天亲了我没有：",
                new string[]{"亲了，没亲快亲就现在"},
                0
                ),
                new Question(
                "鼠鼠还爱不爱我：",
                new string[]{"爱"},
                0
                ),

            };


            Quiz myQuiz =new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
