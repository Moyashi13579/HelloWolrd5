Console.Write("あなたの国語の点数を入力してください：");
int japaneseScore = Convert.ToInt32(Console.ReadLine());

if (japaneseScore >= 80)
{
    Console.WriteLine("あなたは優秀です");
}
else if (japaneseScore >= 60)
{
    Console.WriteLine("まあまあまあ、いいんじゃない？");
}
else
{
    Console.WriteLine("もっと頑張りましょう");
}