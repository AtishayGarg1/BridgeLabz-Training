using System.Text;

class LexicalTwist
{
    static void Main(string[] args)
    {
        LexicalTwist lt = new();
        lt.Lexical();
    }

    public void Lexical()
    {
        System.Console.WriteLine("Enter First Word");
        string w1 = Console.ReadLine();
        if(w1.Contains(' '))
        {
            System.Console.WriteLine(w1 + " is an invalid word");
            return;
        }
        System.Console.WriteLine("Enter Second Word");
        string w2 = Console.ReadLine();
        if(w2.Contains(' '))
        {
            System.Console.WriteLine(w2 + " is an invalid word");
            return;
        }
        if(IsReversed(w1, w2))
        {
            w1 = Reverse(w1);
            w1 = Lower(w1);
            StringBuilder sb = new StringBuilder(w1);
            for(int i = 0; i < sb.Length; i++)
            {
                if(sb[i] == 'a' || sb[i] == 'e' || sb[i] == 'i' || sb[i] == 'o' || sb[i] == 'u')
                {
                    sb[i] = '@';
                }
            }
            System.Console.WriteLine(sb.ToString());
        }
        else
        {
            StringBuilder sb = new StringBuilder(w1);
            sb.Append(w2);
            w1 = Upper(sb.ToString());
            int vow = 0;
            int con = 0;
            sb = new StringBuilder(w1);
            for(int i = 0; i < sb.Length; i++)
            {
                if(sb[i] == 'A' || sb[i] == 'E' || sb[i] == 'I' || sb[i] == 'O' || sb[i] == 'U')
                {
                    vow++;
                }
                else
                {
                    con++;
                }
            }
            StringBuilder sb2 = new StringBuilder();
            if(vow > con)
            {
                for(int i = 0; i < sb.Length; i++)
                {
                    if(sb[i] == 'A' || sb[i] == 'E' || sb[i] == 'I' || sb[i] == 'O' || sb[i] == 'U')
                    {
                        if(sb2.Length == 0)
                        {
                            sb2.Append(sb[i]);
                        }
                        else if(sb[i] != sb2[0])
                        {
                            sb2.Append(sb[i]);
                            break;
                        }
                    }
                }
                System.Console.WriteLine(sb2.ToString());
            }
            else if(con > vow)
            {
                for(int i = 0; i < sb.Length; i++)
                {
                    if(sb[i] != 'A' && sb[i] != 'E' && sb[i] != 'I' && sb[i] != 'O' && sb[i] != 'U')
                    {
                        if(sb2.Length == 0)
                        {
                            sb2.Append(sb[i]);
                        }
                        else if(sb[i] != sb2[0])
                        {
                            sb2.Append(sb[i]);
                            break;
                        }
                    }
                }
                System.Console.WriteLine(sb2.ToString());
            }
            else
            {
                System.Console.WriteLine("Vowels and consonants are equal");
            }
        }
    }

    public string Upper(string s)
    {
        StringBuilder sb = new StringBuilder(s);
        for(int i = 0; i < sb.Length; i++)
        {
            if(sb[i] <= 'z' && sb[i] >= 'a')
            {
                sb[i] = (char)(sb[i] - 32);
            }
        }
        return sb.ToString();
    }

    public string Lower(string s)
    {
        StringBuilder sb = new StringBuilder(s);
        for(int i = 0; i < sb.Length; i++)
        {
            if(sb[i] <= 'Z' && sb[i] >= 'A')
            {
                sb[i] = (char)(sb[i] + 32);
            }
        }
        return sb.ToString();
    }

    public bool IsReversed(string s1, string s2)
    {
        StringBuilder sb = new StringBuilder(Reverse(s2));
        return sb.ToString().Equals(s1);
    }

    public string Reverse(string s)
    {
        StringBuilder sb = new StringBuilder(s);
        int l = 0;
        int r = sb.Length - 1;
        while(l < r)
        {
            char temp = sb[l];
            sb[l] = sb[r];
            sb[r] = temp;
            l++;
            r--;
        }
        return sb.ToString();
    }

}