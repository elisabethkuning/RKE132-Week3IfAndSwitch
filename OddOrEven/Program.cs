

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int result = userNum % 2;

//Console.WriteLine(result); //kui number on paaris, siis tulemus on 0, kui paaritu, siis ei ole 0

if(result != 0) // != - ei ole võrdne
{
    Console.WriteLine("User number is odd.");
}
else
{
    Console.WriteLine("User number is even.");
}
