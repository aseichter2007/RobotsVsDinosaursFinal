using System;
using System.Collections.Generic;
using System.Text;

namespace robots_vs_dinosaurs
{
    class asciiart
    {
        public asciiart()
        {
                 
        }
        public void PrintAsciiArt(string type)
        {
            if (type == "D")
            {
                Console.WriteLine("               ,  ;:._.-`''.");
                Console.WriteLine("             ;.;'.;`      _ `.");
                Console.WriteLine("              ',;`       ( ) ,`-.  ");
                Console.WriteLine("           `:.`,         (_/ ;)  `-.");
                Console.WriteLine("            ';:              / `.   `-._");
                Console.WriteLine("          `;.;'              `-,/ .     `-.");
                Console.WriteLine("          ';;'              _    `^`       `.");
                Console.WriteLine("         ';;            ,'-' `--._          ;");
                Console.WriteLine("':      `;;        ,;     `.    ':`,,.__,,_ /");
                Console.WriteLine(" `;`:;`;:`       ,;  '.    ;,      ';';':';;`");
                Console.WriteLine("              .,; '    '-._ `':.;    ");
                Console.WriteLine("            .:; `          '._ `';;,");
                Console.WriteLine("          ;:` `    :'`'       ',__.)");
                Console.WriteLine("        `;:;:.,...;'`'");
                Console.WriteLine("';. '`'::'`''.'`'");
                Console.WriteLine("    ,''''`';;:,..::;`'`'");
                Console.WriteLine(", .;`      `'::''`");
                Console.WriteLine(",`;`.");
            }
            else if (type == "R")
            {

                Console.WriteLine("    /_/");
                Console.WriteLine("   (_**)");
                Console.WriteLine("  __) #_");
                Console.WriteLine(" ( )...()");
                Console.WriteLine(" || | |I|");
                Console.WriteLine(" || | |()__/");
                Console.WriteLine(" /)(___)");
                Console.WriteLine("_-'''''''' )");
                Console.WriteLine("-,,,,,,,,-',");

            }
           

        }
    }
}
