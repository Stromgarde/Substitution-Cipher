using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Substitution Cipher
            char[] plain = new char[]  { 'E', 'A', 'T', 'O', 'I', 'R', 'S', 'N', 'H', 'D', 'L', 'U', 'C', 'M', 'W', 'F', 'Y', 'G', 'P', 'B', 'V', 'K', 'X', 'J', 'Q', 'Z' };
            char[] cipher = new char[] { 'I', 'E', 'X', 'W', 'M', 'V', 'S', 'R', 'L', 'P', 'G', 'H', 'Y', 'T', 'Q', 'C', 'K', 'J', 'Z', 'F', 'A', 'O', 'U', 'B', 'U', 'N' };

            string toBeDeciphered = "LIVITCSWPIYVEWHEVSRIQMXLEYVEOIEWHRXEXIPFEMVEWHKVSTYLXZIXLIKIIXPIJVSZEYPERRGERIMWQLMGLMXQERIWGPSRIHMXQEREKIETXMJTPRGEVEKEITREWHEXXLEXXMZITWAWSQWXSWEXTVEPMRXRSJGSTVRIEYVIEXCVMUIMWERGMIWXMJMGCSMWXSJOMIQXLIVIQIVIXQSVSTWHKPEGARCSXRWIEVSWIIBXVIZMXFSJXLIKEGAEWHEPSWYSWIWIEVXLISXLIVXLIRGEPIRQIVIIBGIIHMWYPFLEVHEWHYPSRRFQMXLEPPXLIECCIEVEWGISJKTVWMRLIHYSPHXLIQIMYLXSJXLIMWRIGXQEROIVFVIZEVAEKPIEWHXEAMWYEPPXLMWYRMWXSGSWRMHIVEXMSWMGSTPHLEVHPFKPEZINTCMXIVJSVLMRSCMWMSWVIRCIGXMWYMX";
            string output = "";

            for (int k = 0; k < toBeDeciphered.Length; k++)
            { 
                for (int j = 0; j < cipher.Length; j++)
                {
                    if (toBeDeciphered[k] == cipher[j])
                    {
                        output += plain[j];
                        break;
                    }
                }
            }
            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
