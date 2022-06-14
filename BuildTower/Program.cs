
Kata kata=new Kata();
List<string> sList = kata.wave("dg  k /dfgh");
foreach (var VARIABLE in sList)
{
    Console.WriteLine(VARIABLE);
}
public class Kata
{
	public List<string> wave(string str)
	{
		List<string> resultList=new List<string>();
   	for (int i = 0; i < str.Length; i++)
		{
			char[] ch = str.ToCharArray();
			ch[i]=Char.ToUpper(ch[i]);
			resultList.Add(new string(ch));
		}
		return resultList;
	}
}
