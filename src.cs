using System.Text;

namespace LongestCommonPrefixString
{

    class Solution
    {
        public string solve(List<string> A)
        {
            int N = A.Count();
            string com = A[0];
            for (int i = 1; i < N; i++)
            {
                com = commonprefix(com, A[i]);
            }
            return com;
        }

        public string commonprefix(string A, string B)
        {
            int i = 0;
            int count = 0;
            while (i < A.Length && i < B.Length)
            {
                if (A[i] == B[i])
                {
                    i++;
                    count++;
                }
                else
                {
                    break;
                }
            }
            string ans = subStr(A, 0, count-1);
            return ans;
        }

        public string subStr(string A, int start, int end = -1)
        {
            int N = A.Length;
            if (end < start)
            {
                return string.Empty;
            }
            if (end == -1)
            {
                end = N - 1;
            }
            if (start == -1)
            {
                start = 0;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = start; i <= end; i++)
            {
                sb.Append(A[i]);
            }
            return sb.ToString();
        }
    }

}
