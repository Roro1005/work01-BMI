double weight = 0;
bool parseSuccess = false;
Console.WriteLine("体重を入力してください(kg)");
while (!parseSuccess)
{
    string userWeight = Console.ReadLine();

    parseSuccess = double.TryParse(userWeight, out weight);
    if (!parseSuccess)
    {
        Console.WriteLine("数値を入力してください。");
    }
}
Console.WriteLine("体重は" + weight.ToString("F2") + "です。");

Console.WriteLine("身長を入力してください(m)");
double height = 0;
parseSuccess = false;
while (!parseSuccess)
{
    string userHeight = Console.ReadLine();
    parseSuccess = double.TryParse(userHeight, out height);
    if (!parseSuccess)
    {
        Console.WriteLine("数値を入力してください。");
    }
}
Console.WriteLine("身長は" + height.ToString("F2") + "です。");

double BMI = weight / (height * height);
if (BMI < 18.5)
{
    Console.WriteLine("BMIは" + BMI.ToString("F2") + "です。");
    Console.WriteLine("痩せ気味なので気を付けましょう。");
}
else if (BMI >= 18.5 && BMI < 25)
{
    Console.WriteLine("BMIは" + BMI.ToString("F2") + "です。");
    Console.WriteLine("通常体重ですね！そのままキープしましょう！");
}
else if (BMI >= 25 && BMI < 30)
{
    Console.WriteLine("BMIは" + BMI.ToString("F2") + "です。");
    Console.WriteLine("肥満気味なので気を付けましょう。");
}
else if (BMI >= 30 && BMI < 35)
{
    Console.WriteLine("BMIは" + BMI.ToString("F2") + "です。");
    Console.WriteLine("肥満なので改善しましょう。");
}
else if (BMI >= 35 && BMI < 40)
{
    Console.WriteLine("BMIは" + BMI.ToString("F2") + "です。");
    Console.WriteLine("肥満が進んでいます。今すぐ対策してください。");
}
else
{
    Console.WriteLine("BMIは" + BMI.ToString("F2") + "です。");
    Console.WriteLine("危険です！すぐに病院で診てもらってください！");
}
