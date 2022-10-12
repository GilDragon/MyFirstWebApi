var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => AddTwoIntegers(2, 5));

// map a new get route to /add
app.MapGet("/add", () => AddTwoIntegers(9, 8));

// parameter routing
app.MapGet("/add/{input1}/{input2}", (int input1, int input2) => AddTwoIntegers(input1, input2));

app.MapGet("/sub/{num1}/{num2}", (int num1, int num2) => SubtractTwoNumbers(num1, num2));
//내가 한번 만들 으보까?
app.Run();

// function to add two integers together
int AddTwoIntegers(int num1, int num2) {
    int ans = num1 +num2;
    return ans;
}
int SubtractTwoNumbers(int num1, int num2) {
    return num1 - num2;
}