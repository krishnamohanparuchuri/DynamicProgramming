public class Solution {
	public string LongestCommonPrefix(string[] strs) {
		string output = "";
	for (int i = 1; i <= strs[0].Length; i++)
	{
		string j = strs[0].Substring(0, i);
		bool result = strs.All(x => x.StartsWith(j));
		if (result)
		{
			output = j;
			continue;
		}
		else break;
	}
	return output;
        
	}
}