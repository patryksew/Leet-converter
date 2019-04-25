using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_converter {
    class Program { 
        static void Main(string[] args) {
             string word = "";
             int[] characters = new int[1];
             int i = 0, charNow;

             Console.Write("Enter CAPITAL letters to convert): \n");
             while (true) {
                 Array.Resize<int>(ref characters, i + 1);
                 charNow = Console.Read();
                 if (charNow != 13)
                     characters[i++] = charNow;
                 else
                     break;
             }

            for (int f = 0; f < i; f++) {
                string ch;

                switch (characters[f]) {
                    case 32:
                    ch = " ";
                    break;
                    case 65:
                    ch = "@";
                    break;
                    case 66:
                    ch = "8";
                    break;
                    case 67:
                    ch = "(";
                    break;
                    case 68:
                    ch = ")";
                    break;
                    case 69:
                    ch = "3";
                    break;
                    case 70:
                    ch = "|=";
                    break;
                    case 71:
                    ch = "6";
                    break;
                    case 72:
                    ch = "]-[";
                    break;
                    case 73:
                    ch = "1";
                    break;
                    case 74:
                    ch = "_/";
                    break;
                    case 75:
                    ch = "|<";
                    break;
                    case 76:
                    ch = "£";
                    break;
                    case 77:
                    ch = "|V|";
                    break;
                    case 78:
                    ch = "|\\|";
                    break;
                    case 79:
                    ch = "0";
                    break;
                    case 80:
                    ch = "|*";
                    break;
                    case 81:
                    ch = "0,";
                    break;
                    case 82:
                    ch = "|?";
                    break;
                    case 83:
                    ch = "$";
                    break;
                    case 84:
                    ch = "7";
                    break;
                    case 85:
                    ch = "|_|";
                    break;
                    case 86:
                    ch = "\\/";
                    break;
                    case 87:
                    ch = "VV";
                    break;
                    case 88:
                    ch = "><";
                    break;
                    case 89:
                    ch = "Ч";
                    break;
                    case 90:
                    ch = "2";
                    break;
                    default:
                    ch = "";
                    break;
                }

                word += ch;
            }
            Console.WriteLine(word);
            
            Console.ReadKey();
        }
    }
}
