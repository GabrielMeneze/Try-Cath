using System;
using System.IO;

namespace Try_Cath
{
    class Program : Permissao
    {
        static void Main(string[] args)
        {
            Permissao permissao = new Permissao();
            permissao.Autorizar();
 
        }
    }
}
