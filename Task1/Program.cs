// 1. Пр-ма-опросник, в кот будет выводиться вопрос и 4 вар-та ответа. Польз-ль выбирает один из вар-тов. 
// Посчитать кол-во правильных ответов.

Console.Clear();

// Console.WriteLine("Who founded the great Mongol dinasty?");
// System.Console.WriteLine("Variant 1: Kirill and Mephody.");
// System.Console.WriteLine("Variant 2: Chingizkhan.");
// System.Console.WriteLine("Variant 3: Vasilisa the Beautiful.");
// System.Console.WriteLine("Variant 4: Peter the Great.");
// System.Console.WriteLine("Please, enter the number of your variant.");

string[,] questionaire =
{
{"1. Какие из перечисленных ниже программ являются антивирусными?", "MS Word", "Dr.Web", "Chrome", "PDFreader", "Dr.Web"},
{"2. Какого типа графики не существует?", "Растровая", "Векторная", "Облачная", "Трехмерная", "Облачная"},
{"3. Когда появился термин «информационные технологии» в современном значении?", "В 1893 году", "В 1990 году", "В 1958 году", "В 1902 году", "В 1958 году"},
{"4. В каком году компанией IBM был выпущен первый в истории жесткий диск?","В 1956 году", "В 1958 году", "В 1955 году", "В 1957 году", "В 1956 году"},
{"5. Какая поисковая система была самой популярной в 2011 году?", "Yahoo!", "Google", "Bing", "Yandex", "Google"},
{"6. Страна лидер по количеству суперкомпьютеров?", "Китай", "США", "Япония", "Россия", "Китай"},
{"7. Какого Интернет-браузера не существует?", "MS PowerPoint", "Opera", "Google Chrome", "Internet Explorer", "MS PowerPoint"}
};

int NumberOfRightAnswers(string[,] questionaire)
{
    int count = 0;
    string[] userAnswer = new string[questionaire.GetLength(0)];

    for (int i = 0; i < questionaire.GetLength(0); i++)
    {
        System.Console.WriteLine(questionaire[i, 0]);
        for (int j = 1; j < questionaire.GetLength(1) - 1; j++)
        {
            System.Console.WriteLine($"{j}) {questionaire[i, j]}");
        }

        userAnswer[i] = GetNumber("номер вашего ответа", questionaire, i);
        if (String.Equals(userAnswer[i], questionaire[i, questionaire.GetLength(1) - 1]))
            count++;

    }
    System.Console.WriteLine();
    System.Console.WriteLine("Ваши ответы: ");
    System.Console.WriteLine(String.Join(", ", userAnswer));
    System.Console.WriteLine();
    return count;
}


string GetNumber(string prompt, string[,] questionaire, int i)
{
    int answer;
    string answerStr;
    while (true)
    {
        System.Console.WriteLine($"Введите {prompt}: ");
        if (int.TryParse(Console.ReadLine(), out answer) && answer <= 4 && answer > 0)
        {
            answerStr = questionaire[i, answer];
            return answerStr;
        }
        else
            System.Console.WriteLine("Вы ввели неверный символ. ");
    }
}

System.Console.WriteLine($"Число правильных ответов: {NumberOfRightAnswers(questionaire)}.");




