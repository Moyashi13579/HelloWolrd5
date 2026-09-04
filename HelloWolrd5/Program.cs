Console.Write("あなたの国語の点数を入力してください：");
string? input = Console.ReadLine();

if (!int.TryParse(input, out int JapaneseScore))
{
    Console.WriteLine("数字を入力してください");
}
else if (JapaneseScore < 0 || JapaneseScore > 100)
{
    Console.WriteLine("0～100の範囲で入力してください");
}
else if (JapaneseScore >= 80)
{
    Console.WriteLine("貴殿は優秀でございます");
}
else if (JapaneseScore >= 60)
{
    Console.WriteLine("いいんじゃない？");
}
else
{
    Console.WriteLine("NT");
}

