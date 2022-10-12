var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => AddTwoIntegers(2, 5));

// map a new get route to /add
app.MapGet("/add", () => AddTwoIntegers(9, 8));

// parameter routing
app.MapGet("/add/{input1}/{input2}", (int input1, int input2) => AddTwoIntegers(input1, input2));

app.MapGet("/sub/{num1}/{num2}", (int num1, int num2) => SubtractTwoNumbers(num1, num2));
// 글자수 세는거 counting letters
app.MapGet("/count/{word1}/{word2}", (String word1, String word2) => CountCharacters(word1, word2));
//단어 안에 있는 알파벳 세는거 
app.MapGet("/countletter/{special}/{word3}", (String special, String word3) => Countletter(special, word3));
app.Run();

// function to add two integers together
int AddTwoIntegers(int num1, int num2) {
    int ans = num1 +num2;
    return ans;
}
int SubtractTwoNumbers(int num1, int num2) {
    return num1 - num2;
}

int CountCharacters(String any1, String any2) {
    return any1.Length + any2.Length;
}
    


int Countletter(String any3, String any4) {
    return ;
}






// 다시 저장
